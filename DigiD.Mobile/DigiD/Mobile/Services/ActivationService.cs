using System;
using System.Globalization;
using System.Security;
using System.Text.Json;
using System.Threading.Tasks;
using DigiD.Common.Enums;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Helpers;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Models.Responses;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using DigiD.Mobile.Helpers;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Models;
using DigiD.Mobile.Pages;
using DigiD.Mobile.ViewModels;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices;

namespace DigiD.Mobile.Services;

public class ActivationService : IActivationService
{
	private readonly IEnrollmentApi enrollmentServices;

	private readonly IMobileSettings mobileSettings;

	private readonly INavigationService navigationService;

	private readonly IAccountInformationApi accountInformationServices;

	private readonly IPushNotificationService pushNotificationService;

	private readonly IGeneralPreferences generalPreferences;

	private readonly IDialogService dialogService;

	private readonly IConfigurationService configurationService;

	private readonly ISigningService signingService;

	private readonly ISessionService sessionService;

	private readonly IEmailService emailService;

	private readonly IAlertService alertService;

	private readonly IAppService appService;

	private readonly IToastService toastService;

	private readonly IMatomoService matomoService;

	private readonly IAttestationService keyAttestationService;

	private readonly IDeviceService deviceService;

	private readonly ISecurityService securityService;

	public ActivationService(ISecurityService securityService, IEnrollmentApi enrollmentServices, IMobileSettings mobileSettings, INavigationService navigationService, IAccountInformationApi accountInformationServices, IPushNotificationService pushNotificationService, IGeneralPreferences generalPreferences, IDialogService dialogService, IConfigurationService configurationService, ISigningService signingService, ISessionService sessionService, IEmailService emailService, IAlertService alertService, IAppService appService, IToastService toastService, IMatomoService matomoService, IAttestationService keyAttestationService, IDeviceService deviceService)
	{
		this.enrollmentServices = enrollmentServices;
		this.mobileSettings = mobileSettings;
		this.navigationService = navigationService;
		this.accountInformationServices = accountInformationServices;
		this.pushNotificationService = pushNotificationService;
		this.generalPreferences = generalPreferences;
		this.dialogService = dialogService;
		this.configurationService = configurationService;
		this.signingService = signingService;
		this.sessionService = sessionService;
		this.emailService = emailService;
		this.alertService = alertService;
		this.appService = appService;
		this.toastService = toastService;
		this.matomoService = matomoService;
		this.keyAttestationService = keyAttestationService;
		this.deviceService = deviceService;
		this.securityService = securityService;
	}

	public async Task<BasicAuthenticationResponse?> LoginAsync(string userName, string password, bool isIdCheckSkipped = false, bool useLetter = false)
	{
		BasicAuthenticateRequest requestData = new BasicAuthenticateRequest
		{
			Username = userName,
			Password = password,
			DeviceName = deviceService.DeviceName.ReplaceEmoticons(),
			InstanceId = ((IApp)Application.Current).GeneralPreferences.InstanceId,
			RemoveOldApp = HttpSession.RemoveOldApp,
			IsIdCheckSkipped = isIdCheckSkipped,
			UseLetter = useLetter
		};
		mobileSettings.KeyAttestationResult = KeyAttestationResult.NotPerformed;
		BasicAuthenticationResponse result = await enrollmentServices.BasicAuthenticate(requestData);
		if (result.ApiResult == ApiResult.Ok)
		{
			HttpSession.AppSessionId = result.SessionId;
		}
		else if (HttpSession.RemoveOldApp)
		{
			string errorMessage = result.ErrorMessage;
			string text = errorMessage;
			if (text == "account_blocked")
			{
				ArgumentNullException.ThrowIfNull(result.Payload, "result.Payload");
				AccountBlockedModel error = JsonSerializer.Deserialize<AccountBlockedModel>(result.Payload.ToString());
				await toastService.ShowWarning(string.Format(CultureInfo.InvariantCulture, CommonResources.x_SingleDeviceAccountBlocked, error.minutes));
			}
			else
			{
				await toastService.ShowWarning(CommonResources.x_ActivationFailedMessage);
			}
			return null;
		}
		if (HttpSession.ActivationSessionData == null && ((AppSession.HasNfc && AppSession.IsKeyAttestationSupported) || DeviceInfo.Idiom == DeviceIdiom.Desktop))
		{
			HttpSession.ActivationSessionData = new ActivationSessionData
			{
				ActivationMethod = result.ActivationMethod,
				UserName = userName,
				Password = password
			};
		}
		else
		{
			ActivationSessionData activationSessionData = HttpSession.ActivationSessionData;
			if (activationSessionData != null && activationSessionData.ActivationMethod == ActivationMethod.Unsupported)
			{
				HttpSession.ActivationSessionData.ActivationMethod = result.ActivationMethod;
			}
		}
		return result;
	}

	public async Task LoginAndRemoveAsync()
	{
		if (HttpSession.ActivationSessionData == null)
		{
			await toastService.ShowError(CommonResources.Alg_UnknownErrorOccurred);
			AppSession.Reset();
		}
		else
		{
			ArgumentNullException.ThrowIfNull(HttpSession.ActivationSessionData.UserName, "HttpSession.ActivationSessionData.UserName");
			ArgumentNullException.ThrowIfNull(HttpSession.ActivationSessionData.Password, "HttpSession.ActivationSessionData.Password");
			await StartActivationAsync(await LoginAsync(HttpSession.ActivationSessionData.UserName, HttpSession.ActivationSessionData.Password, !AppSession.HasNfc));
		}
	}

	public async Task StartActivationAsync(BasicAuthenticationResponse? result, bool useLetter = false)
	{
		bool firstTimeAuthenticate = true;
		if (result == null)
		{
			ArgumentNullException.ThrowIfNull(HttpSession.ActivationSessionData, "HttpSession.ActivationSessionData");
			if (HttpSession.ActivationSessionData.UserName == null || HttpSession.ActivationSessionData.Password == null)
			{
				await toastService.ShowError(CommonResources.Alg_UnknownErrorOccurred);
				AppSession.Reset();
				return;
			}
			result = await LoginAsync(HttpSession.ActivationSessionData.UserName, HttpSession.ActivationSessionData.Password, isIdCheckSkipped: true, useLetter);
			BasicAuthenticationResponse? basicAuthenticationResponse = result;
			if (basicAuthenticationResponse != null && basicAuthenticationResponse.ActivationMethod == ActivationMethod.SMS && HttpSession.ActivationSessionData.ActivationMethod == ActivationMethod.Password)
			{
				result.ActivationMethod = ActivationMethod.Password;
			}
			if (result != null && result.ApiResult == ApiResult.Nok)
			{
				await HandleRdaSkip(result);
				return;
			}
			if (DeviceInfo.Idiom != DeviceIdiom.Desktop)
			{
				firstTimeAuthenticate = false;
			}
		}
		else if (result.PendingActivation)
		{
			firstTimeAuthenticate = !AppSession.HasNfc;
			result.PendingActivation = false;
		}
		ArgumentNullException.ThrowIfNull(result, "result");
		HttpSession.AppSessionId = result.SessionId;
		switch (result.ActivationMethod)
		{
		case ActivationMethod.SMS:
		{
			if (firstTimeAuthenticate && AppSession.HasNfc && AppSession.IsKeyAttestationSupported)
			{
				await StartActivationWithRda();
				break;
			}
			AppSession.Process = Process.NotSet;
			if (HttpSession.ActivationSessionData == null)
			{
				HttpSession.ActivationSessionData = new ActivationSessionData();
			}
			HttpSession.ActivationSessionData.ActivationMethod = ActivationMethod.SMS;
			RequestSmsResponse response2 = await enrollmentServices.SendSMS();
			await navigationService.NavigateAsync<DG004, DG004ViewModel>(delegate(DG004ViewModel vm)
			{
				vm.Initialize(response2);
			});
			break;
		}
		case ActivationMethod.Password:
			if (firstTimeAuthenticate)
			{
				if (AppSession.HasNfc && AppSession.IsKeyAttestationSupported)
				{
					await StartActivationWithRda();
					break;
				}
				if (!AppSession.HasNfc || !AppSession.IsKeyAttestationSupported)
				{
					ActivationResult activationResult2 = await StartActivationByLetter();
					if (activationResult2.ApiResult != ApiResult.Ok)
					{
						break;
					}
					ArgumentNullException.ThrowIfNull(activationResult2.IV, "activationResult.IV");
					HttpSession.ActivationSessionData = new ActivationSessionData
					{
						ActivationMethod = ActivationMethod.Letter
					};
					if (DeviceInfo.Idiom == DeviceIdiom.Desktop && AppSession.ActivationState == AppActivationState.Login && AppSession.ActivationStatus == ActivationStatus.NotActivated)
					{
						HttpSession.ActivationSessionData.IV = activationResult2.IV;
						AppSession.SetNextState();
						await dialogService.Hide();
						await navigationService.PopToRootAsync();
					}
					else
					{
						await navigationService.NavigateAsync<PinCodePage, PinCodeViewModel>(delegate(PinCodeViewModel vm)
						{
							vm.Initialize(new PinCodeModel(PinEntryType.Enrollment)
							{
								IV = activationResult2.IV
							});
						});
					}
					break;
				}
			}
			if (result.PendingActivation)
			{
				HttpSession.AuthenticationResponse = result;
				await navigationService.NavigateAsync<FM051>();
			}
			else if (HttpSession.ActivationSessionData != null)
			{
				AppSession.Process = Process.NotSet;
				ActivationResult activationResult3 = await StartActivationByLetter();
				if (activationResult3.ApiResult == ApiResult.Ok)
				{
					ArgumentNullException.ThrowIfNull(HttpSession.ActivationSessionData, "HttpSession.ActivationSessionData");
					ArgumentNullException.ThrowIfNull(HttpSession.ActivationSessionData.Pin, "HttpSession.ActivationSessionData.Pin");
					ArgumentNullException.ThrowIfNull(activationResult3.IV, "activationResult.IV");
					HttpSession.ActivationSessionData.ActivationMethod = ActivationMethod.Letter;
					await ActivateAsync(HttpSession.ActivationSessionData.Pin, activationResult3.IV, alternative: true);
				}
			}
			else
			{
				HttpSession.ActivationSessionData = new ActivationSessionData
				{
					ActivationMethod = result.ActivationMethod
				};
				await navigationService.NavigateAsync<PinCodePage, PinCodeViewModel>(delegate(PinCodeViewModel vm)
				{
					vm.Initialize(new PinCodeModel(PinEntryType.Enrollment));
				});
			}
			break;
		case ActivationMethod.AccountAndApp:
		{
			HttpSession.ActivationSessionData = new ActivationSessionData
			{
				ActivationMethod = ActivationMethod.AccountAndApp
			};
			if (result.IsSmsCheckRequested)
			{
				RequestSmsResponse response = await enrollmentServices.SendSMS();
				await navigationService.NavigateAsync<DG004, DG004ViewModel>(delegate(DG004ViewModel vm)
				{
					vm.Initialize(response);
				});
				break;
			}
			ActivationResult activationResult = await StartActivationWithoutSms();
			if (activationResult.ApiResult == ApiResult.Ok)
			{
				HttpSession.ActivationSessionData.IV = activationResult.IV;
				await navigationService.NavigateAsync<DG005>();
			}
			break;
		}
		}
	}

	public async Task SetPreferencesEmailAsync()
	{
		await emailService.Manage(FinishActivation);
	}

	public async Task SetPreferencesNotificationsAsync()
	{
		TwoFactorResponseModel response = await accountInformationServices.GetTwoFactorStatus();
		if (HttpSession.ActivationSessionData != null && HttpSession.ActivationSessionData.ActivationMethod != ActivationMethod.RequestNewDigidAccount && HttpSession.ActivationSessionData.ActivationMethod != ActivationMethod.Letter && !pushNotificationService.NotificationsAvailable && response.Enabled)
		{
			await SetPreferencesEmailAsync();
			return;
		}
		if (DeviceInfo.Idiom == DeviceIdiom.Desktop)
		{
			await SetPreferencesEmailAsync();
			return;
		}
		await navigationService.NavigateAsync<DG035B, DG035ViewModel>(delegate(DG035ViewModel vm)
		{
			vm.HasBackButton = true;
		});
	}

	public async Task CompleteActivation()
	{
		if (HttpSession.ActivationSessionData != null)
		{
			matomoService.TrackAction("Activatie", HttpSession.ActivationSessionData.ActivationMethod.ToString(), navigationService.CurrentPageId);
		}
		if (mobileSettings.ActivationStatus == ActivationStatus.Pending)
		{
			AppSession.SetNextState(AppActivationState.WaitingForLetter);
		}
		else
		{
			AppSession.SetNextState();
		}
		await navigationService.PopToRootAsync();
	}

	public async Task FinishActivation()
	{
		await CompleteActivation();
	}

	public async Task<SessionResponse> InitSession(string? smsCode = null)
	{
		BasicAuthenticationSessionRequest requestData = new BasicAuthenticationSessionRequest
		{
			InstanceId = generalPreferences.InstanceId,
			SMSCode = smsCode,
			DeviceName = deviceService.DeviceName.ReplaceEmoticons(),
			RemoveOldApp = HttpSession.RemoveOldApp
		};
		return await enrollmentServices.InitSession(requestData);
	}

	public async Task<ActivationResult> StartActivationByLetter()
	{
		SessionResponse result = await InitSession();
		ActivationResult res = new ActivationResult();
		switch (result.ApiResult)
		{
		case ApiResult.Ok:
		{
			ActivationSessionData? activationSessionData = HttpSession.ActivationSessionData;
			res = ((activationSessionData == null || activationSessionData.ActivationMethod != ActivationMethod.RequestNewDigidAccount) ? (await RequestLetter(result)) : (await RequestNewAccount(result)));
			break;
		}
		case ApiResult.Nok:
			await toastService.ShowWarning(CommonResources.x_ActivationFailedMessage);
			break;
		case ApiResult.SessionNotFound:
			await toastService.ShowWarning(CommonResources.x_SessionTimeoutMessage);
			break;
		case ApiResult.Disabled:
			await toastService.ShowWarning(CommonResources.Alg_ActivationDisabledMessage);
			break;
		}
		return res;
	}

	public async Task<ActivationResult> StartActivationWithoutSms()
	{
		ActivationResult activationResult = new ActivationResult();
		SessionResponse result = await InitSession();
		activationResult.ApiResult = result.ApiResult;
		switch (result.ApiResult)
		{
		case ApiResult.Ok:
			ArgumentNullException.ThrowIfNull(result.AppId, "result.AppId");
			activationResult = await StartChallenge(result.AppId);
			break;
		case ApiResult.SessionNotFound:
			await toastService.ShowWarning(CommonResources.x_SessionTimeoutMessage);
			break;
		case ApiResult.Disabled:
			await toastService.ShowWarning(CommonResources.Alg_ActivationDisabledMessage);
			break;
		default:
			await toastService.ShowError(CommonResources.Alg_UnknownErrorOccurred);
			break;
		case ApiResult.HostNotReachable:
			break;
		}
		return activationResult;
	}

	public async Task<ActivationResult> RequestNewAccount(SessionResponse result)
	{
		ArgumentNullException.ThrowIfNull(result.AppId, "result.AppId");
		ActivationResult activationResult = await StartChallenge(result.AppId);
		switch (activationResult.ApiResult)
		{
		case ApiResult.Blocked:
			await alertService.DisplayAlert(AlertMessageType.FM024);
			break;
		case ApiResult.Aborted:
			await toastService.ShowWarning(CommonResources.x_AuthenticationAbortedMessage);
			break;
		case ApiResult.Cancelled:
			await toastService.ShowWarning(CommonResources.x_ActivationCancelledMessage);
			break;
		}
		return activationResult;
	}

	public async Task<ActivationResult> RequestLetter(SessionResponse? result = null)
	{
		ActivationResult activationResult = new ActivationResult();
		BaseResponse initResult = await enrollmentServices.InitSessionLetterActivation();
		switch (initResult.ApiResult)
		{
		case ApiResult.Ok:
		{
			BaseResponse pollResult = await enrollmentServices.LetterActivationPolling();
			while (pollResult.ApiResult == ApiResult.Pending)
			{
				pollResult = await enrollmentServices.LetterActivationPolling();
				await Task.Delay(1000);
			}
			switch (pollResult.ApiResult)
			{
			case ApiResult.Ok:
				if (result != null && result.AppId != null)
				{
					activationResult = await StartChallenge(result.AppId);
					break;
				}
				return new ActivationResult
				{
					ApiResult = ApiResult.Ok
				};
			case ApiResult.Nok:
				switch (pollResult.ErrorMessage)
				{
				case "gba_deceased":
					await alertService.DisplayAlert(AlertMessageType.FM025);
					break;
				case "gba_invalid":
					await alertService.DisplayAlert(AlertMessageType.FM026);
					break;
				case "gba_emigrated_RNI":
					await alertService.DisplayAlert(AlertMessageType.FM039);
					break;
				default:
					await alertService.DisplayAlert(AlertMessageType.FM023);
					break;
				}
				break;
			}
			break;
		}
		case ApiResult.Nok:
			switch (initResult.ErrorMessage)
			{
			case "too_soon":
			case "too_many_letter_requests":
				await alertService.DisplayAlert(AlertMessageType.FM036);
				break;
			case "too_fast":
			case "too_often":
			{
				string message = string.Format(arg0: ((DateTimeOffset)((dynamic)initResult.Payload).next_registration_date).ToString("dd-MM-yyyy"), provider: CultureInfo.InvariantCulture, format: CommonResources.FM037_Body);
				await toastService.ShowWarning(message);
				break;
			}
			case "no_bsn_on_account":
				await toastService.ShowWarning(CommonResources.x_SingleDeviceNoBSNOnAccount);
				break;
			}
			break;
		case ApiResult.Disabled:
			await toastService.ShowWarning(CommonResources.Alg_ActivationDisabledMessage);
			break;
		}
		return activationResult;
	}

	public Task SkipRda()
	{
		return StartActivationAsync(null);
	}

	private async Task HandleRdaSkip(BasicAuthenticationResponse? activationResult)
	{
		if (activationResult != null && activationResult.ErrorMessage == "two_factor_enabled")
		{
			await alertService.DisplayAlert(AlertMessageType.FM079);
			appService.Reset();
			navigationService.SetRoot<DG001>();
		}
	}

	public async Task<ActivationResult> StartChallenge(string appId)
	{
		ActivationResult res = new ActivationResult();
		if (signingService.GenerateKeyPair())
		{
			byte[] publicKey = signingService.ExportPublicKey();
			if (publicKey == null)
			{
				res.ApiResult = ApiResult.Error;
				await toastService.ShowWarning(CommonResources.x_ActivationFailedMessage);
				return res;
			}
			EnrollmentChallengeRequest enrollmentChallengeRequestData = new EnrollmentChallengeRequest
			{
				AppId = appId,
				PublicKey = publicKey
			};
			EnrollmentChallengeResponse response = await enrollmentServices.EnrollmentChallenge(enrollmentChallengeRequestData);
			res.ApiResult = response.ApiResult;
			if (response.ApiResult == ApiResult.Ok)
			{
				mobileSettings.AppId = appId;
				byte[] signature = signingService.Sign(response.Challenge);
				if (signature != null)
				{
					KeyAttestationRequestModel attestationData = null;
					if (AppSession.IsKeyAttestationSupported)
					{
						attestationData = await keyAttestationService.Attest(response.Challenge.Hash());
					}
					CompleteChallengeResponse challengeResult = await CompleteChallenge(signature, publicKey, signingService.HardwareSupport, attestationData);
					res.IV = challengeResult.IV;
					res.ApiResult = challengeResult.ApiResult;
				}
				else
				{
					res.ApiResult = ApiResult.Nok;
				}
			}
			switch (res.ApiResult)
			{
			case ApiResult.Unknown:
			case ApiResult.Nok:
				await toastService.ShowError(CommonResources.Alg_UnknownErrorOccurred);
				break;
			case ApiResult.HostNotReachable:
				await alertService.DisplayAlert(AlertMessageType.FM005);
				break;
			case ApiResult.SSLPinningError:
				await toastService.ShowWarning(CommonResources.SSLWarningMessage);
				break;
			case ApiResult.Disabled:
				await toastService.ShowWarning(CommonResources.Alg_ActivationDisabledMessage);
				break;
			}
			return res;
		}
		res.ApiResult = ApiResult.Error;
		await toastService.ShowWarning(CommonResources.x_ActivationFailedMessage);
		return res;
	}

	public async Task<CompleteChallengeResponse> CompleteChallenge(byte[] signature, byte[] publicKey, bool hardwareSupport, KeyAttestationRequestModel? keyAttestModel)
	{
		CompleteChallengeRequest requestData = new CompleteChallengeRequest
		{
			Signature = signature,
			PublicKey = publicKey,
			HardwareSupport = hardwareSupport,
			KeyAttestation = keyAttestModel
		};
		try
		{
			requestData.NFCSupport = AppSession.HasNfc;
		}
		catch (Exception)
		{
			requestData.NFCSupport = false;
		}
		CompleteChallengeResponse response = await enrollmentServices.CompleteChallenge(requestData);
		if (keyAttestModel != null)
		{
			keyAttestationService.ProcessResponse(response, keyAttestModel);
		}
		if (response.ApiResult == ApiResult.Ok)
		{
			mobileSettings.SymmetricKey = response.SymmetricKey.ToBase16();
		}
		return response;
	}

	public async Task StartActivationWithRda()
	{
		if (!configurationService.Configuration.RDAEnabled)
		{
			await toastService.ShowWarning(CommonResources.x_RDADisabledMessage);
			return;
		}
		dialogService.Show();
		BaseResponse initResult = await enrollmentServices.InitSessionActivationRDA();
		if (initResult.ApiResult == ApiResult.Ok)
		{
			SessionResponse result = await InitSession();
			await dialogService.Hide();
			switch (result.ApiResult)
			{
			case ApiResult.Ok:
			{
				ArgumentNullException.ThrowIfNull(result.AppId, "result.AppId");
				AppSession.Process = Process.AppActivateWithRDA;
				ActivationResult activationResult = await StartChallenge(result.AppId);
				if (activationResult.ApiResult == ApiResult.Ok)
				{
					ArgumentNullException.ThrowIfNull(activationResult.IV, "activationResult.IV");
					await navigationService.NavigateAsync<PinCodePage, PinCodeViewModel>(delegate(PinCodeViewModel vm)
					{
						vm.Initialize(new PinCodeModel(PinEntryType.Enrollment)
						{
							IV = activationResult.IV
						});
					});
				}
				break;
			}
			case ApiResult.Disabled:
				await toastService.ShowWarning(CommonResources.x_RDADisabledMessage);
				break;
			default:
				await toastService.ShowWarning(CommonResources.x_ActivationFailedMessage);
				break;
			}
		}
		else
		{
			await dialogService.Hide();
			if (initResult.ErrorMessage == "no_bsn_on_account")
			{
				await toastService.ShowWarning(CommonResources.x_SingleDeviceNoBSNOnAccount);
			}
			else
			{
				await toastService.ShowWarning(CommonResources.x_RDADisabledMessage);
			}
		}
	}

	public async Task<bool> ActivateAsync(SecureString pin, byte[] iv, bool alternative = false)
	{
		if (securityService.IsDebuggerAttached)
		{
			matomoService.TrackAction("debugger_attached", "flow-activation", "user_app_id: " + mobileSettings.AppId + " - instance_id: " + generalPreferences.InstanceId);
			await toastService.ShowWarning(CommonResources.x_ActivationFailedMessage);
		}
		dialogService.Show();
		string mask = PinCodeHelper.GenerateMaskCode();
		string maskedPin = PinCodeHelper.MaskPin(pin, mask);
		byte[] key = mobileSettings.SymmetricKey.ToBytes();
		PincodeRequest requestData = new PincodeRequest
		{
			AppId = mobileSettings.AppId,
			MaskedPincode = EncryptionHelper.Encrypt(maskedPin, iv, key),
			IV = iv
		};
		CompleteActivationResponse result = await enrollmentServices.CompleteActivationAsync(requestData);
		await dialogService.Hide();
		ApiResult apiResult = result.ApiResult;
		if ((apiResult == ApiResult.Ok || apiResult == ApiResult.Pending) ? true : false)
		{
			HttpSession.AuthenticationSessionId = HttpSession.AppSessionId;
			mobileSettings.MaskCode = mask;
		}
		switch (result.ApiResult)
		{
		case ApiResult.Ok:
			await HandleActivationCompletion(result);
			return false;
		case ApiResult.Pending:
			return await HandlePending(alternative);
		case ApiResult.Nok:
			await toastService.ShowWarning(CommonResources.x_ActivationFailedMessage);
			break;
		case ApiResult.Disabled:
			await toastService.ShowWarning(CommonResources.Alg_ActivationDisabledMessage);
			break;
		case ApiResult.HostNotReachable:
			await alertService.DisplayAlert(AlertMessageType.FM005);
			break;
		case ApiResult.SessionNotFound:
			await toastService.ShowError(CommonResources.x_SessionTimeoutMessage);
			break;
		case ApiResult.Unknown:
			await toastService.ShowWarning(CommonResources.Alg_LoginUnknownMessage);
			break;
		case ApiResult.SSLPinningError:
			await toastService.ShowWarning(CommonResources.SSLWarningMessage);
			break;
		default:
			await toastService.ShowWarning(CommonResources.x_ActivationFailedMessage);
			break;
		}
		sessionService.ClearSession();
		return false;
	}

	private async Task<bool> HandlePending(bool alternative)
	{
		ActivationSessionData? activationSessionData = HttpSession.ActivationSessionData;
		if (activationSessionData != null && activationSessionData.ActivationMethod == ActivationMethod.RequestNewDigidAccount && AppSession.HasNfc)
		{
			mobileSettings.ActivationStatus = ActivationStatus.Pending;
			Preferences.LetterRequestDate = DateTimeOffset.UtcNow;
			AppSession.IsAppActivated = true;
			AppSession.ActivationStatus = mobileSettings.ActivationStatus;
			return true;
		}
		if (!alternative && AppSession.HasNfc)
		{
			return true;
		}
		await HandlePendingCompletion();
		return false;
	}

	public async Task HandlePendingCompletion()
	{
		ActivationMethod method = HttpSession.ActivationSessionData.ActivationMethod;
		mobileSettings.ActivationStatus = ActivationStatus.Pending;
		AppSession.IsAppActivated = true;
		AppSession.ActivationStatus = mobileSettings.ActivationStatus;
		Preferences.LetterRequestDate = DateTimeOffset.UtcNow;
		if (method != ActivationMethod.RequestNewDigidAccount)
		{
			AppSession.SetNextState();
			await navigationService.PopToRootAsync();
		}
		else
		{
			await SetPreferencesEmailAsync();
		}
	}

	public async Task HandleActivationCompletion(CompleteActivationResponse result)
	{
		if ((HttpSession.IsApp2AppSession || HttpSession.IsWeb2AppSession) && HttpSession.AppSessionId != null && HttpSession.TempSessionData == null)
		{
			HttpSession.TempSessionData = new TempSessionData(HttpSession.AppSessionId);
		}
		mobileSettings.ActivationStatus = ActivationStatus.Activated;
		mobileSettings.LoginLevel = result.AuthenticationLevel;
		AppSession.IsAppActivated = true;
		AppSession.ActivationStatus = mobileSettings.ActivationStatus;
		if (mobileSettings.LoginLevel == LoginLevel.Substantieel)
		{
			AppSession.SetNextState(AppActivationState.Preferences);
		}
		else
		{
			AppSession.SetNextState();
		}
		await navigationService.PopToRootAsync();
	}
}
