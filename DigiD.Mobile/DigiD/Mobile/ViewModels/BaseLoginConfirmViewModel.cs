using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Enums;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.NFC.Enums;
using DigiD.Common.Preferences;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Pages;
using LocalizationResourceManager.Maui;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices;

namespace DigiD.Mobile.ViewModels;

public abstract class BaseLoginConfirmViewModel : CommonBaseViewModel
{
	private readonly IAlertService alertService;

	private readonly IEIDApi eIDApi;

	private readonly IAuthenticationApi authenticationApi;

	private readonly IDialogService dialogService;

	private readonly IEmailService emailService;

	private readonly ISessionService sessionService;

	private readonly IApp2AppService app2AppService;

	private readonly IAuthenticationService authenticationService;

	private readonly IAppService appService;

	private readonly IRemoteNotificationService remoteNotificationService;

	private readonly IConfirmService confirmService;

	private readonly IGeneralApi generalApi;

	private readonly AlertMessageType alertMessageType;

	private readonly IMatomoService matomoService;

	private readonly IDeviceLockService deviceLockService;

	private readonly ISignerService signerService;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int _003CSecondsLeft_003Ek__BackingField = 30;

	private CancellationTokenSource? token;

	private PeriodicTimer? timer;

	private ConfirmResponse? confirmResponse;

	private readonly Task? timerTask;

	protected readonly IMobileSettings MobileSettings;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsTimerVisible_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int _003CSecondsUsed_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ImageSource? _003CImageSource_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? confirmCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? abortCommand;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsTimerVisible
	{
		get
		{
			return _003CIsTimerVisible_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsTimerVisible_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsTimerVisible);
				_003CIsTimerVisible_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsTimerVisible);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int SecondsUsed
	{
		get
		{
			return _003CSecondsUsed_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<int>.Default.Equals(_003CSecondsUsed_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.SecondsUsed);
				_003CSecondsUsed_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.SecondsUsed);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int SecondsLeft
	{
		get
		{
			return _003CSecondsLeft_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<int>.Default.Equals(_003CSecondsLeft_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.SecondsLeft);
				_003CSecondsLeft_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.SecondsLeft);
			}
		}
	}

	public bool LoginButtonEnabled => SecondsLeft > 0;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public ImageSource? ImageSource
	{
		get
		{
			return _003CImageSource_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<Microsoft.Maui.Controls.ImageSource>.Default.Equals(_003CImageSource_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.ImageSource);
				_003CImageSource_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.ImageSource);
			}
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand ConfirmCommand => confirmCommand ?? (confirmCommand = new AsyncRelayCommand(ConfirmAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand AbortCommand => abortCommand ?? (abortCommand = new AsyncRelayCommand(AbortAsync));

	protected BaseLoginConfirmViewModel(IAlertService alertService, IGeneralApi generalApi, IMobileSettings mobileSettings, IEIDApi eIdApi, IAuthenticationApi authenticationApi, IDialogService dialogService, IEmailService emailService, ISessionService sessionService, IApp2AppService app2AppService, IAuthenticationService authenticationService, IAppService appService, IRemoteNotificationService remoteNotificationService, IConfirmService confirmService, AlertMessageType alertMessageType, IMatomoService matomoService, IDeviceLockService deviceLockService, ISignerService signerService)
	{
		MobileSettings = mobileSettings;
		eIDApi = eIdApi;
		this.alertService = alertService;
		this.generalApi = generalApi;
		this.authenticationApi = authenticationApi;
		this.dialogService = dialogService;
		this.emailService = emailService;
		this.sessionService = sessionService;
		this.app2AppService = app2AppService;
		this.authenticationService = authenticationService;
		this.appService = appService;
		this.remoteNotificationService = remoteNotificationService;
		this.confirmService = confirmService;
		this.alertMessageType = alertMessageType;
		this.matomoService = matomoService;
		this.deviceLockService = deviceLockService;
		this.signerService = signerService;
		base.HasBackButton = false;
		base.CloseButtonVisible = true;
		if (HttpSession.WidSessionResponse == null)
		{
			timerTask = Task.Run((Func<Task?>)SetTimer);
		}
	}

	protected override Task EnterPressed()
	{
		return ConfirmAsync();
	}

	protected override Task CloseButtonClicked()
	{
		return AbortCommand.ExecuteAsync(null);
	}

	protected void SetActionText(string action)
	{
		switch (action)
		{
		case "upgrade_rda_widchecker":
			base.MessageText = DigiDAppResources.DG069_Info;
			base.HeaderText = DigiDAppResources.DG069_Titel;
			break;
		case "change_password":
			base.MessageText = DigiDAppResources.HLP12_StartWachtwoord;
			break;
		case "change_phone_number":
			base.MessageText = DigiDAppResources.HLP12_StartTelnummer;
			break;
		case "activate_sms_authenticator":
			base.MessageText = DigiDAppResources.HLP12_StartSMS;
			break;
		case "add_email":
			base.MessageText = DigiDAppResources.HLP12_StartEmailToev;
			break;
		case "change_email":
			base.MessageText = DigiDAppResources.HLP12_StartEmailWijzig;
			break;
		case "remove_email":
			base.MessageText = DigiDAppResources.HLP12_StartEmailVerw;
			break;
		case "cancel_account":
			base.MessageText = DigiDAppResources.HLP12_StartOpheffen;
			break;
		case "deactivate_app":
			ArgumentNullException.ThrowIfNull(HttpSession.WebSessionInfoResponse, "HttpSession.WebSessionInfoResponse");
			if (HttpSession.WebSessionInfoResponse.AppIdToDestroy != null && HttpSession.WebSessionInfoResponse.AppIdToDestroy == MobileSettings.AppId)
			{
				base.MessageText = DigiDAppResources.DG038_Message_DeactivateCurrentDevice;
			}
			else if (HttpSession.WebSessionInfoResponse.DeviceName != null)
			{
				if (HttpSession.WebSessionInfoResponse.LastSignInDate.HasValue)
				{
					base.MessageText = string.Format(DigiDAppResources.DG038_Message_DeactivateOtherDeviceWithTimeStamp, HttpSession.WebSessionInfoResponse.DeviceName, HttpSession.WebSessionInfoResponse.LastSignInDate.Value.LocalDateTime.ToString("dd MMMM yyyy"), HttpSession.WebSessionInfoResponse.LastSignInDate.Value.LocalDateTime.ToString("HH:mm"));
				}
				else
				{
					base.MessageText = string.Format(DigiDAppResources.DG038_Message_DeactivateOtherDeviceWithoutTimeStamp, HttpSession.WebSessionInfoResponse.DeviceName);
				}
			}
			else
			{
				base.MessageText = DigiDAppResources.HLP12_StartDeactiveren;
			}
			break;
		case "activate_with_app":
			base.MessageText = DigiDAppResources.HLP12_StartActiverenApp;
			break;
		case "revoke_driving_license":
			base.MessageText = string.Format(CultureInfo.InvariantCulture, CommonResources.x_WIDRetractConfirmMessage, DocumentType.DrivingLicense.Translate().ToLowerInvariant());
			break;
		case "revoke_identity_card":
			base.MessageText = string.Format(CultureInfo.InvariantCulture, CommonResources.x_WIDRetractConfirmMessage, DocumentType.IDCard.Translate().ToLowerInvariant());
			break;
		}
	}

	private async Task SetTimer()
	{
		if (token != null)
		{
			return;
		}
		token = new CancellationTokenSource();
		try
		{
			int delay = (DemoSettings.IsDemoModeEnabled ? 10 : 30);
			await Task.Delay(TimeSpan.FromSeconds(delay), token.Token);
		}
		catch (TaskCanceledException)
		{
			return;
		}
		IsTimerVisible = true;
		timer = new PeriodicTimer(TimeSpan.FromSeconds(DemoSettings.IsDemoModeEnabled ? 0.5 : 1.0));
		try
		{
			base.A11YService.Speak(string.Format(CommonResources.Alg_SecondsToConfirmStart, SecondsLeft), 1000);
			while (await timer.WaitForNextTickAsync(token.Token))
			{
				SecondsUsed++;
				SecondsLeft--;
				if (SecondsUsed % 10 == 0)
				{
					base.A11YService.Speak(string.Format(CommonResources.Alg_SecondsToConfirmUpdate, SecondsLeft));
				}
				if (SecondsLeft == 0)
				{
					timer.Dispose();
					token.Dispose();
					await MainThread.InvokeOnMainThreadAsync((Func<Task>)ShowTimerAlert);
				}
			}
		}
		catch (TaskCanceledException)
		{
		}
	}

	protected virtual Task Dismiss()
	{
		return Task.CompletedTask;
	}

	private async Task ShowTimerAlert()
	{
		await Dismiss();
		await generalApi.Cancel(cancelledByUser: false, timeout: true);
		await alertService.DisplayAlert(alertMessageType);
		await base.NavigationService.PopToRootAsync();
		timerTask?.Dispose();
	}

	protected virtual Task ContinueNfc(ConfirmResponse? response = null)
	{
		return Task.CompletedTask;
	}

	[RelayCommand]
	private async Task ConfirmAsync()
	{
		token?.Cancel(throwOnFirstException: false);
		dialogService.Show();
		ConfirmRequest confirmModel = new ConfirmRequest
		{
			AppId = MobileSettings.AppId
		};
		if (HttpSession.WebSessionInfoResponse?.HashedPIP != null)
		{
			if (AppSession.AppAuthenticationType == AppAuthenticationType.Biometric)
			{
				await base.DialogService.Hide();
				PinCodeModel model = new PinCodeModel(PinEntryType.Authentication)
				{
					MessageText = new LocalizedString(() => base.ResourceManager["DG035C_PinConfirmText"]),
					HasBackButton = false,
					BiometricEnabled = false,
					NextAction = async delegate
					{
						AppSession.AppAuthenticationType = AppAuthenticationType.PinCode;
						await base.NavigationService.PopCurrentModalPage();
						await ConfirmAsync();
					},
					CancelAction = async delegate
					{
						await base.NavigationService.PopCurrentModalPage();
						await AbortAsync();
					}
				};
				await base.NavigationService.PushModalAsync<PinCodePage, PinCodeViewModel>(delegate(PinCodeViewModel vm)
				{
					vm.Initialize(model);
				});
				return;
			}
			ConfirmRequest confirmRequest = confirmModel;
			confirmRequest.SignatureOfPIP = await signerService.SignData(HttpSession.WebSessionInfoResponse.HashedPIP);
		}
		if (HttpSession.WidSessionResponse != null)
		{
			confirmResponse = await eIDApi.Confirm(new BaseEIDRequest());
		}
		else
		{
			confirmResponse = await authenticationApi.Confirm(confirmModel);
		}
		ApiResult result = confirmResponse.ApiResult;
		await dialogService.Hide();
		await Task.Delay(100);
		ApiResult apiResult = result;
		ApiResult apiResult2 = apiResult;
		if (apiResult2 != ApiResult.Ok)
		{
			if (apiResult2 != ApiResult.Nok)
			{
				goto IL_0de5;
			}
			base.MatomoService.TrackAction("Dienst", "Inloggen", "Afgebroken");
			await base.ToastService.ShowWarning(CommonResources.Alg_LoginCancelledMessage);
			sessionService.ClearSession();
		}
		else if (HttpSession.WidSessionResponse != null)
		{
			await ContinueNfc(confirmResponse);
		}
		else
		{
			if (HttpSession.WebSessionInfoResponse == null)
			{
				goto IL_0de5;
			}
			bool deactivateApp = HttpSession.WebSessionInfoResponse.AppIdToDestroy == MobileSettings.AppId;
			if (deactivateApp || HttpSession.WebSessionInfoResponse.Action == "cancel_account")
			{
				if (HttpSession.IsWeb2AppSession)
				{
					await ContinueAuthenticationAsync(deactivate: true);
					return;
				}
				await appService.Deactivate(null);
				base.ToastService.Toasts.Clear();
				if (deactivateApp)
				{
					base.MatomoService.TrackAction("Mijn DigiD", "App deactiveren", "Succes");
					await base.ToastService.ShowSuccess(CommonResources.FM064_Body);
				}
				else
				{
					base.MatomoService.TrackAction("Mijn DigiD", "DigiD opheffen", "Succes");
					await base.ToastService.ShowSuccess(DigiDAppResources.HLP12_OpheffenSucces);
				}
				return;
			}
			if (HttpSession.WebSessionInfoResponse.Action == "upgrade_rda_widchecker")
			{
				await base.NavigationService.NavigateAsync<DG070>();
				return;
			}
			await confirmService.SetSuccessMessage(HttpSession.WebSessionInfoResponse);
			if (HttpSession.IsApp2AppSession)
			{
				if (!MobileSettings.NotificationPermissionSet.HasValue)
				{
					await remoteNotificationService.AskForPermission();
				}
				await ContinueAuthenticationAsync();
				return;
			}
			if (!HttpSession.IsDeceased && HttpSession.WebSessionInfoResponse.NewAuthenticationLevelStartDate.HasValue && MobileSettings.LoginLevel < HttpSession.WebSessionInfoResponse.NewAuthenticationLevel)
			{
				if (MobileSettings.KeyAttestationResult != KeyAttestationResult.Success)
				{
					matomoService.TrackAction("KA", "Upgrade not possible", HttpSession.WebSessionInfoResponse.WebService ?? "Onbekend");
				}
				if (AppSession.HasNfc && AppSession.IsKeyAttestationSupported)
				{
					await base.NavigationService.NavigateAsync<DG041, DG041ViewModel>(delegate(DG041ViewModel vm)
					{
						vm.Initialize(HttpSession.WebSessionInfoResponse.WebService, async delegate
						{
							await ContinueAuthenticationAsync();
						});
					});
				}
				else
				{
					await base.NavigationService.NavigateAsync<DG042, DG042ViewModel>(delegate(DG042ViewModel vm)
					{
						vm.Initialize(HttpSession.WebSessionInfoResponse.WebService);
					});
				}
				return;
			}
			await ContinueAuthenticationAsync();
		}
		goto IL_0ef3;
		IL_0de5:
		base.MatomoService.TrackAction("Dienst", "Inloggen", "Mislukt, timeout");
		await base.ToastService.ShowWarning(CommonResources.Alg_LoginUnknownMessage);
		sessionService.ClearSession();
		goto IL_0ef3;
		IL_0ef3:
		await base.DialogService.Hide();
		timerTask?.Dispose();
	}

	[RelayCommand]
	private async Task AbortAsync()
	{
		token?.Cancel(throwOnFirstException: false);
		if (HttpSession.WidSessionResponse != null)
		{
			base.MatomoService.TrackAction("Dienst", "Inloggen met Document", "Afgebroken");
			await eIDApi.CancelAuthenticate();
			HttpSession.WidSessionResponse = null;
			await base.ToastService.ShowWarning(string.Format(CommonResources.x_WIDCancelledMessage, (EIDSession.Card != null) ? EIDSession.Card.DocumentType.Translate().ToLower() : DocumentType.Generic.Translate().ToLower()));
		}
		else if (HttpSession.WebSessionInfoResponse is PendingSessionResponse)
		{
			base.MatomoService.TrackAction("Dienst", "Inloggen EHA", "Afgebroken");
			await base.ToastService.ShowWarning(CommonResources.Alg_LoginCancelledMessage);
		}
		else
		{
			if (HttpSession.IsApp2AppSession)
			{
				await app2AppService.ReturnToClientApp("cancelled_by_user");
			}
			bool lockDevice = HttpSession.IsApp2AppSession || HttpSession.IsWeb2AppSession;
			bool isWebService = HttpSession.WebSessionInfoResponse?.IsWebservice ?? true;
			await sessionService.CancelSession(byUser: true, async delegate
			{
				if (isWebService)
				{
					base.MatomoService.TrackAction("Dienst", "Inloggen", "Afgebroken");
					await base.ToastService.ShowWarning(CommonResources.Alg_LoginCancelledMessage);
				}
				else
				{
					base.MatomoService.TrackAction("Dienst", "Bevestigen", "Afgebroken");
					await base.ToastService.ShowWarning(CommonResources.Alg_ConfirmCancelled);
				}
				if (lockDevice)
				{
					deviceLockService.Lock(userAction: true, logoutSession: false);
					HttpSession.AuthenticationSessionId = null;
				}
			});
		}
		timerTask?.Dispose();
	}

	private async Task ContinueAuthenticationAsync(bool deactivate = false)
	{
		if (HttpSession.IsApp2AppSession)
		{
			matomoService.TrackAction("App2App", "Inloggen succes", base.NavigationService.CurrentPageId);
			base.A11YService.Speak(CommonResources.x_LoginSuccessMessage);
			await app2AppService.ReturnToClientApp();
			return;
		}
		if (DeviceInfo.Idiom == DeviceIdiom.Desktop)
		{
			await authenticationService.HandleWeb2AppSuccess();
			await DeActivateIfNecessary(deactivate);
			if (AppSession.IsAppActivatedFromBrowser)
			{
				Application.Current?.Quit();
				return;
			}
			await Finish();
		}
		if (HttpSession.IsWeb2AppSession)
		{
			base.A11YService.Speak(CommonResources.x_LoginSuccessMessage);
			await authenticationService.HandleWeb2AppSuccess();
			if (!(await DeActivateIfNecessary(deactivate)))
			{
				deviceLockService.Lock(userAction: true, logoutSession: false);
				sessionService.ClearSession();
			}
		}
		else if (HttpSession.WebSessionInfoResponse != null && HttpSession.WebSessionInfoResponse.IsWebservice)
		{
			await emailService.Manage(Finish, isAuthentication: true);
		}
		else
		{
			await Finish();
		}
	}

	private async Task<bool> DeActivateIfNecessary(bool deactivate)
	{
		if (deactivate)
		{
			string text = HttpSession.WebSessionInfoResponse?.Action;
			string text2 = text;
			string text3 = text2;
			if (text3 == "deactivate_app" || text3 == "cancel_account")
			{
				await appService.Deactivate(null);
				return true;
			}
		}
		return false;
	}

	private async Task Finish()
	{
		WebSessionInfoResponse? webSessionInfoResponse = HttpSession.WebSessionInfoResponse;
		if (webSessionInfoResponse != null && webSessionInfoResponse.AuthenticationLevel == LoginLevel.Substantieel && HttpSession.WebSessionInfoResponse.IsWebservice && HttpSession.WillIDCheckExpire)
		{
			DG037ViewModel.PerformIDCheckAfterLogin = true;
		}
		await base.NavigationService.PopToRootAsync();
		sessionService.ClearSession();
	}
}
