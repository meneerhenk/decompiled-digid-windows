using System;
using System.Net;
using System.Net.Http;
using System.Security;
using System.Threading.Tasks;
using DigiD.Common.Enums;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Helpers;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Preferences;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using DigiD.Mobile.Helpers;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Pages;
using DigiD.Mobile.ViewModels;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Devices;

namespace DigiD.Mobile.Services;

public class AuthenticationService(IMobileSettings mobileSettings, IAuthenticationApi authenticationService, IDeviceService deviceService, INavigationService navigationService, IGeneralPreferences generalPreferences, ISecurityService securityService, IMatomoService matomoService, IToastService toastService, IAppService appService, IAlertService alertService, IDeviceLockService deviceLockService, ISessionService sessionService, ISignerService signerService, IAttestationService attestationService) : IAuthenticationService
{
	public async Task<ValidatePinResponse> AuthenticateAsync(SecureString pin, ChallengeResponse response, string sessionId)
	{
		if (securityService.IsDebuggerAttached)
		{
			matomoService.TrackAction("debugger_attached", "flow-authentication", "user_app_id: " + mobileSettings.AppId + " - instance_id: " + generalPreferences.InstanceId);
			return new ValidatePinResponse
			{
				ApiResult = ApiResult.Unknown
			};
		}
		ArgumentNullException.ThrowIfNull(response.IV, "response.IV");
		ArgumentNullException.ThrowIfNull(response.Challenge, "response.Challenge");
		string maskCode = mobileSettings.MaskCode;
		string maskedPin = PinCodeHelper.MaskPin(pin, maskCode);
		try
		{
			byte[] signature = await signerService.SignData(response.Challenge);
			ValidatePinRequest requestData = new ValidatePinRequest(pin: EncryptionHelper.Encrypt(maskedPin, response.IV, mobileSettings.SymmetricKey.ToBytes()), sessionId: sessionId, appId: mobileSettings.AppId)
			{
				PublicKey = signerService.GetPublicKey(),
				Signature = signature
			};
			if (AppSession.IsKeyAttestationSupported && mobileSettings.KeyAttestationResult == KeyAttestationResult.NotPerformed)
			{
				ValidatePinRequest validatePinRequest = requestData;
				validatePinRequest.KeyAttestation = await attestationService.Attest(response.Challenge.Hash());
			}
			ValidatePinResponse responseData = await authenticationService.ValidatePin(requestData);
			if (requestData.KeyAttestation != null)
			{
				attestationService.ProcessResponse(responseData, requestData.KeyAttestation);
			}
			return responseData;
		}
		catch
		{
			return new ValidatePinResponse
			{
				ApiResult = ApiResult.Failed
			};
		}
	}

	public async Task ProcessWebAuthentication(string returnUrl)
	{
		if (DemoSettings.IsDemoModeEnabled)
		{
			return;
		}
		if (DeviceInfo.Platform == DevicePlatform.iOS)
		{
			switch (HttpSession.Browser)
			{
			case DigiD.Common.Enums.Browser.Chrome:
				returnUrl = "googlechromes://" + returnUrl.Replace("https://", "");
				break;
			case DigiD.Common.Enums.Browser.Firefox:
				returnUrl = "firefox://open-url?url=" + WebUtility.UrlEncode(returnUrl);
				break;
			case DigiD.Common.Enums.Browser.Edge:
				returnUrl = "microsoft-edge-https://" + returnUrl.Replace("https://", "");
				break;
			}
			await MainThread.InvokeOnMainThreadAsync(async delegate
			{
				await Launcher.OpenAsync(returnUrl);
			});
		}
		else if (DeviceInfo.Platform == DevicePlatform.WinUI || DeviceInfo.Platform == DevicePlatform.MacCatalyst)
		{
			await MainThread.InvokeOnMainThreadAsync(async delegate
			{
				await Launcher.OpenAsync(returnUrl);
			});
		}
		else if (DeviceInfo.Platform == DevicePlatform.Android && !string.IsNullOrEmpty(HttpSession.SourceApplication))
		{
			deviceService.OpenBrowser(HttpSession.SourceApplication, returnUrl);
		}
		else
		{
			await MainThread.InvokeOnMainThreadAsync(async delegate
			{
				await Launcher.OpenAsync(returnUrl);
			});
		}
	}

	public async Task<ChallengeResponse?> GetChallenge(string sessionId)
	{
		ChallengeResponse response = await authenticationService.Challenge(new ChallengeRequest(sessionId)
		{
			AppId = mobileSettings.AppId,
			InstanceId = generalPreferences.InstanceId
		});
		switch (response.ApiResult)
		{
		case ApiResult.Nok:
		{
			string errorMessage = response.ErrorMessage;
			string text = errorMessage;
			if (text == "aborted_contact_helpdesk")
			{
				await toastService.ShowWarning(CommonResources.x_FM_LoginHelpDesk);
				return null;
			}
			await toastService.ShowWarning(CommonResources.Alg_LoginUnknownMessage);
			return null;
		}
		case ApiResult.Kill:
			appService.Reset();
			await toastService.ShowError(CommonResources.FM064_Body);
			navigationService.SetRoot<DG001>();
			return null;
		case ApiResult.SSLPinningError:
			await toastService.ShowWarning(CommonResources.SSLWarningMessage);
			return null;
		case ApiResult.HostNotReachable:
			await alertService.DisplayAlert(AlertMessageType.FM005);
			return null;
		case ApiResult.Timeout:
			await toastService.ShowError(CommonResources.Alg_UnknownErrorOccurred);
			return null;
		case ApiResult.Unknown:
			await toastService.ShowWarning(CommonResources.Alg_LoginUnknownMessage);
			return null;
		case ApiResult.SessionNotFound:
			await toastService.ShowError(CommonResources.x_SessionTimeoutMessage);
			return null;
		default:
			if (response.IV == null)
			{
				await toastService.ShowWarning(CommonResources.Alg_LoginUnknownMessage);
				return null;
			}
			return response;
		}
	}

	private Task ProcessAction(WebSessionInfoResponse sessionInfo)
	{
		switch (sessionInfo.Action)
		{
		case "new_session":
		case "change_app_pin":
			return navigationService.NavigateAsync<PinCodePage, PinCodeViewModel>(delegate(PinCodeViewModel vm)
			{
				vm.Initialize(new PinCodeModel(PinEntryType.Authentication));
			});
		case "upgrade_rda_widchecker":
			if (mobileSettings.KeyAttestationResult == KeyAttestationResult.Failed)
			{
				HttpSession.WebSessionInfoResponse = sessionInfo;
				return sessionService.CancelSession(byUser: false, () => toastService.ShowError(CommonResources.FM105_Title));
			}
			return NavigateToConfirm();
		default:
			return NavigateToConfirm();
		}
		Task NavigateToConfirm()
		{
			HttpSession.WebSessionInfoResponse = sessionInfo;
			return navigationService.NavigateAsync<DG067A>();
		}
	}

	public async Task ContinueAuthenticationAsync()
	{
		WebSessionInfoResponse sessionInfo = await authenticationService.SessionInfo();
		if (sessionInfo.ApiResult != ApiResult.Ok)
		{
			string errorMessage = sessionInfo.ErrorMessage;
			string text = errorMessage;
			if (!(text == "aborted_contact_helpdesk"))
			{
				await toastService.ShowWarning(CommonResources.Alg_LoginUnknownMessage);
			}
			else
			{
				await toastService.ShowWarning(CommonResources.x_FM_LoginHelpDesk);
			}
			return;
		}
		string action = sessionInfo.Action;
		if ((action == "new_session" || action == "change_app_pin") ? true : false)
		{
			await navigationService.NavigateAsync<PinCodePage, PinCodeViewModel>(delegate(PinCodeViewModel vm)
			{
				vm.Initialize(new PinCodeModel(PinEntryType.Authentication, sessionInfo));
			});
		}
		else if (sessionInfo.IsConfirmAction)
		{
			await ProcessAction(sessionInfo);
		}
		else if (mobileSettings.LoginLevel < sessionInfo.AuthenticationLevel)
		{
			if (!HttpSession.IsDeceased && AppSession.HasNfc && AppSession.IsKeyAttestationSupported)
			{
				HttpSession.WebSessionInfoResponse = sessionInfo;
				AppSession.Process = Process.UpgradeAndAuthenticate;
				await navigationService.NavigateAsync<DG021>();
			}
			else
			{
				await navigationService.NavigateAsync<DG043>();
			}
		}
		else
		{
			HttpSession.WebSessionInfoResponse = sessionInfo;
			await navigationService.NavigateAsync<DG038>();
		}
	}

	public async Task HandleWeb2AppSuccess()
	{
		matomoService.TrackAction("Web2App", "Inloggen succes", navigationService.CurrentPageId);
		string url = ((HttpSession.WidSessionResponse != null) ? HttpSession.WidSessionResponse.ReturnURL : HttpSession.WebSessionInfoResponse.ReturnURL);
		if ((DeviceInfo.Platform == DevicePlatform.iOS || DeviceInfo.Platform == DevicePlatform.MacCatalyst) && (HttpSession.WebSessionInfoResponse?.IsConfirmAction ?? false))
		{
			url = url + "?app_action=" + HttpSession.WebSessionInfoResponse.Action;
		}
		if (HttpSession.WebSessionInfoResponse?.IsOidcSession ?? false)
		{
			deviceLockService.Lock(userAction: true, logoutSession: false);
			sessionService.ClearSession();
			using HttpClient httpClient = new HttpClient(new HttpClientHandler
			{
				AllowAutoRedirect = false
			});
			httpClient.Timeout = TimeSpan.FromSeconds(1000L);
			HttpResponseMessage response = await httpClient.GetAsync(url);
			if (response.StatusCode == HttpStatusCode.Found)
			{
				Uri redirectUrl = response.Headers.Location;
				if (redirectUrl != null)
				{
					await Launcher.OpenAsync(redirectUrl);
					return;
				}
			}
			await Launcher.OpenAsync(url);
		}
		else
		{
			await ProcessWebAuthentication(url);
		}
	}
}
