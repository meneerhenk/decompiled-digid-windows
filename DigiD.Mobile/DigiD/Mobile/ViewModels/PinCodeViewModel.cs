using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Enums;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Helpers;
using DigiD.Common.Models.Messages;
using DigiD.Common.Models.Requests;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Models.Responses;
using DigiD.Common.NFC.Enums;
using DigiD.Common.Preferences;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using DigiD.Common.ViewModels;
using DigiD.Mobile.Helpers;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Models;
using DigiD.Mobile.Pages;
using LocalizationResourceManager.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class PinCodeViewModel : BasePinCodeViewModel
{
	private readonly IMobileSettings mobileSettings;

	private readonly IAlertService alertService;

	private readonly IEIDApi eIdApi;

	private readonly ISessionService sessionService;

	private readonly IChangePinApi changePinApi;

	private readonly IAuthenticationApi authenticationApi;

	private readonly IAuthenticationService authenticationService;

	private readonly IAppService appService;

	private readonly IActivationService activationService;

	private readonly IPopupService popupService;

	private readonly IBiometricService biometricService;

	private readonly IDeviceLockService deviceLockService;

	private readonly AppConfig appConfig;

	private readonly IDeviceService deviceService;

	private readonly ILogger<PinCodeViewModel> logger;

	private readonly IConnectionService connectionService;

	private readonly IKeyboardService keyboardService;

	private byte[]? _iv;

	private bool _isBiometricAuthentication;

	private Func<Task>? _cancelAction;

	private DateTime? _biometricDate;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsAppAuthentication_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsCardAuthentication_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsHeaderVisible_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CPinCodeForgottenVisible_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ImageSource? _003CImageSource_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private LocalizedString? _003CForgotPasswordText_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsBiometricsEnrolled_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<bool>? startBiometricsAuthenticationCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? pinCodeForgottenCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private RelayCommand<bool>? resetPinCodeCommand;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsAppAuthentication
	{
		get
		{
			return _003CIsAppAuthentication_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsAppAuthentication_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsAppAuthentication);
				_003CIsAppAuthentication_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsAppAuthentication);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsCardAuthentication
	{
		get
		{
			return _003CIsCardAuthentication_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsCardAuthentication_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsCardAuthentication);
				_003CIsCardAuthentication_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsCardAuthentication);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsHeaderVisible
	{
		get
		{
			return _003CIsHeaderVisible_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsHeaderVisible_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsHeaderVisible);
				_003CIsHeaderVisible_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsHeaderVisible);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool PinCodeForgottenVisible
	{
		get
		{
			return _003CPinCodeForgottenVisible_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CPinCodeForgottenVisible_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.PinCodeForgottenVisible);
				_003CPinCodeForgottenVisible_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.PinCodeForgottenVisible);
			}
		}
	}

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

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public LocalizedString? ForgotPasswordText
	{
		get
		{
			return _003CForgotPasswordText_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<LocalizedString>.Default.Equals(_003CForgotPasswordText_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.ForgotPasswordText);
				_003CForgotPasswordText_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.ForgotPasswordText);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsBiometricsEnrolled
	{
		get
		{
			return _003CIsBiometricsEnrolled_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsBiometricsEnrolled_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsBiometricsEnrolled);
				_003CIsBiometricsEnrolled_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsBiometricsEnrolled);
			}
		}
	}

	public Func<Task>? NextAction { get; set; }

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand<bool> StartBiometricsAuthenticationCommand => startBiometricsAuthenticationCommand ?? (startBiometricsAuthenticationCommand = new AsyncRelayCommand<bool>(StartBiometricsAuthenticationAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand PinCodeForgottenCommand => pinCodeForgottenCommand ?? (pinCodeForgottenCommand = new AsyncRelayCommand(PinCodeForgottenAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand<bool> ResetPinCodeCommand => resetPinCodeCommand ?? (resetPinCodeCommand = new RelayCommand<bool>(ResetPinCode));

	public PinCodeViewModel(IMobileSettings mobileSettings, IAlertService alertService, IEIDApi eIdApi, ISessionService sessionService, IChangePinApi changePinApi, IAuthenticationApi authenticationApi, IAuthenticationService authenticationService, IAppService appService, IActivationService activationService, IPopupService popupService, IBiometricService biometricService, IDeviceLockService deviceLockService, AppConfig appConfig, IDeviceService deviceService, ILogger<PinCodeViewModel> logger, IConnectionService connectionService, IKeyboardService keyboardService)
	{
		this.mobileSettings = mobileSettings;
		this.alertService = alertService;
		this.eIdApi = eIdApi;
		this.sessionService = sessionService;
		this.changePinApi = changePinApi;
		this.authenticationApi = authenticationApi;
		this.authenticationService = authenticationService;
		this.appService = appService;
		this.activationService = activationService;
		this.popupService = popupService;
		this.biometricService = biometricService;
		this.deviceLockService = deviceLockService;
		this.appConfig = appConfig;
		this.deviceService = deviceService;
		this.logger = logger;
		this.connectionService = connectionService;
		this.keyboardService = keyboardService;
		this.keyboardService.NumberPressed += KeyboardServiceOnNumberPressed;
	}

	public new void Initialize(PinCodeModel model)
	{
		base.Pin1 = new SecureString();
		base.Pin2 = null;
		base.PinLocked = false;
		base.HelpTextVisible = false;
		base.Initialize(model);
		PinCodeModel model2 = base.Model;
		IsHeaderVisible = model2 != null && !model2.IsAppAuthentication;
		IsAppAuthentication = base.Model.IsAppAuthentication;
		base.HasBackButton = EIDSession.Card == null && HttpSession.ActivationSessionData == null && !IsAppAuthentication;
		PinCodeForgottenVisible = EIDSession.Card == null && base.Model.EntryType == PinEntryType.Authentication;
		if (!base.Model.IsAppAuthentication)
		{
			base.CloseButtonVisible = true;
		}
		else
		{
			base.IsMenuImageVisible = true;
		}
		if (PinCodeForgottenVisible)
		{
			ForgotPasswordText = new LocalizedString(() => base.ResourceManager["DG030_Helplink"]);
		}
		if (model.MessageText != null)
		{
			base.MessageText = model.MessageText;
		}
		if (model.HasBackButton.HasValue)
		{
			base.HasBackButton = model.HasBackButton.Value;
		}
		if (model.NextAction != null)
		{
			NextAction = model.NextAction;
		}
		if (model.CancelAction != null)
		{
			_cancelAction = model.CancelAction;
		}
		SetImageSource();
	}

	private void KeyboardServiceOnNumberPressed(object? sender, int e)
	{
		if (Application.Current.Windows[0].Page is NavigationPage navigationPage && navigationPage.CurrentPage.BindingContext == this && base.NumberEnteredCommand.CanExecute(e))
		{
			base.NumberEnteredCommand.Execute(e);
		}
	}

	protected override async Task OnAppearing()
	{
		await base.OnAppearing();
		PinCodeViewModel pinCodeViewModel = this;
		int isBiometricsEnrolled;
		if (Preferences.BiometricsState != BiometricsState.NotEnrolled && Preferences.BiometricsState != BiometricsState.NotUsed && Preferences.BiometricsState != BiometricsState.PendingEnabled && Preferences.BiometricsState != BiometricsState.PendingDisabled && biometricService.AuthenticationStatus == BiometricHwStatus.Success)
		{
			PinCodeModel model = base.Model;
			if (model != null && model.BiometricEnabled)
			{
				isBiometricsEnrolled = ((!IsCardAuthentication) ? 1 : 0);
				goto IL_00ed;
			}
		}
		isBiometricsEnrolled = 0;
		goto IL_00ed;
		IL_00ed:
		pinCodeViewModel.IsBiometricsEnrolled = (byte)isBiometricsEnrolled != 0;
		if (!IsInitialized)
		{
			IsInitialized = await App.Initialize();
			if (IsInitialized && base.Model.StartBiometrics)
			{
				await StartBiometricsAuthenticationCommand.ExecuteAsync(parameter: true);
				base.Model.StartBiometrics = false;
			}
			AppSession.IsAppVisible = true;
		}
	}

	[RelayCommand]
	private async Task StartBiometricsAuthenticationAsync(bool autoStart = false)
	{
		WeakReferenceMessenger.Default.Unregister<CancelBiometricsAuthenticationMessage>(this);
		BiometricHwStatus currentState = biometricService.AuthenticationStatus;
		if (currentState == BiometricHwStatus.NoHardware || BiometricAuthenticationActive)
		{
			return;
		}
		_isBiometricAuthentication = false;
		if (Preferences.BiometricsState == BiometricsState.NotEnrolled || Preferences.BiometricsState == BiometricsState.NotUsed || (currentState != BiometricHwStatus.Success && autoStart))
		{
			if (logger.IsEnabled(LogLevel.Information))
			{
				logger.LogInformation("Biometrics Authentication: {status}", "Aborted");
			}
			return;
		}
		CancellationTokenSource cts = new CancellationTokenSource();
		WeakReferenceMessenger.Default.Register<CancelBiometricsAuthenticationMessage>(this, delegate
		{
			if (logger.IsEnabled(LogLevel.Information))
			{
				logger.LogInformation("Biometrics Authentication: {status}", "Cancelled");
			}
			cts?.Cancel();
		});
		int num;
		if (_biometricDate.HasValue)
		{
			DateTime now = DateTime.Now;
			DateTime? biometricDate = _biometricDate;
			num = ((now - biometricDate < TimeSpan.FromSeconds(5L)) ? 1 : 0);
		}
		else
		{
			num = 0;
		}
		if (num != 0)
		{
			return;
		}
		BiometricsAuthenticationRequest request = new BiometricsAuthenticationRequest(DigiDAppResources.BiometricsPromptTitle, CommonResources.Alg_Cancel)
		{
			Subtitle = string.Format(DigiDAppResources.BiometricsSubtitle, AppSession.BiometricType.TranslateType()),
			IsEnrollment = false
		};
		cts.CancelAfter(TimeSpan.FromSeconds(appConfig.BiometricsTimeout));
		if (logger.IsEnabled(LogLevel.Information))
		{
			logger.LogInformation("Biometrics Authentication: {status}", "Started");
		}
		BiometricAuthenticationActive = true;
		BiometricsAuthenticationResponse result = await biometricService.AuthenticateAsync(request, cts.Token);
		WeakReferenceMessenger.Default.Unregister<CancelBiometricsAuthenticationMessage>(this);
		cts.Dispose();
		cts = null;
		if (logger.IsEnabled(LogLevel.Information))
		{
			logger.LogInformation("Biometrics Authentication: {status}", "Completed");
		}
		switch (result.Status)
		{
		case BiometricResponseStatus.Cancelled:
			if (!autoStart)
			{
				mobileSettings.BiometricsCancelCounter++;
				if (mobileSettings.BiometricsCancelCounter == 5)
				{
					ShowBiometricsDisabledSheet(addDelay: false);
				}
				base.MatomoService.TrackAction("Biometrics", "Inloggen " + AppSession.BiometricType.Translate(), "Geannuleerd");
			}
			break;
		case BiometricResponseStatus.Success:
		{
			_biometricDate = DateTime.Now;
			if (HttpSession.WidSessionResponse != null)
			{
				return;
			}
			base.MatomoService.TrackAction("Biometrics", "Inloggen " + AppSession.BiometricType.Translate(), "Gelukt");
			deviceLockService.Update();
			ArgumentNullException.ThrowIfNull(result.Result, "result.Result");
			string plainPin = Encoding.UTF8.GetString(result.Result);
			base.Pin1 = new SecureString();
			_isBiometricAuthentication = true;
			WeakReferenceMessenger.Default.Send(new SemanticFeedbackMessage(HasSemanticFeedback: false));
			while (!IsInitialized)
			{
				await Task.Delay(10);
			}
			string text = plainPin;
			for (int num2 = 0; num2 < text.Length; num2++)
			{
				await NumberEnteredAsync(int.Parse(text[num2].ToString()), vibrate: false);
				await Task.Delay(50, CancellationToken.None);
			}
			WeakReferenceMessenger.Default.Send(new SemanticFeedbackMessage());
			break;
		}
		case BiometricResponseStatus.Failure:
		case BiometricResponseStatus.LockedOut:
			ShowBiometricsDisabledSheet(addDelay: true);
			break;
		case BiometricResponseStatus.Invalid:
			base.MatomoService.TrackAction("Biometrics", "Inloggen " + AppSession.BiometricType.Translate(), result.Status.ToString());
			if (result.Status == BiometricResponseStatus.Invalid)
			{
				Preferences.BiometricsState = BiometricsState.Invalid;
			}
			if (!autoStart)
			{
				string translation = AppSession.BiometricType.Translate();
				await popupService.OpenBottomSheet("TBD", string.Format(DigiDAppResources.BiometricsInvalidTitle, translation.FirstCharSubstring()), string.Format(DigiDAppResources.BiometricsInvalidMessage, translation));
			}
			break;
		case BiometricResponseStatus.PermissionNotGiven:
			await popupService.OpenBottomSheet("TBD", DigiDAppResources.BiometricsPermissionNotGivenTitle, DigiDAppResources.BiometricsPermissionNotGivenMessage, DigiDAppResources.BiometricsPermissionNotGivenButton, delegate
			{
				deviceService.OpenSettings();
				return Task.CompletedTask;
			});
			break;
		}
		BiometricAuthenticationActive = false;
	}

	private void ShowBiometricsDisabledSheet(bool addDelay)
	{
		Task.Run(async delegate
		{
			if (addDelay)
			{
				await Task.Delay(TimeSpan.FromMilliseconds(1000L));
				if (!AppSession.IsAppVisible)
				{
					return;
				}
			}
			Preferences.BiometricsState = BiometricsState.NotEnrolled;
			IsBiometricsEnrolled = false;
			string translation = AppSession.BiometricType.Translate();
			await MainThread.InvokeOnMainThreadAsync(async delegate
			{
				await popupService.OpenBottomSheet("TBD", string.Format(DigiDAppResources.BiometricsDisableTitle, translation.FirstCharSubstring()), string.Format(DigiDAppResources.BiometricsDisableMessage, translation));
			});
		});
	}

	[RelayCommand]
	private async Task PinCodeForgottenAsync()
	{
		await base.NavigationService.NavigateAsync<HLP005>();
	}

	protected override Task ShowMenuClicked()
	{
		return base.NavigationService.NavigateAsync<DG044, DG044ViewModel>(async delegate(DG044ViewModel vm)
		{
			await vm.Initialize();
		});
	}

	protected override async Task CloseButtonClicked()
	{
		if (!base.CanExecute)
		{
			return;
		}
		base.CanExecute = false;
		bool flag = base.Model.EIDSessionResponse == null;
		bool flag2 = flag;
		if (flag2)
		{
			PinEntryType entryType = base.Model.EntryType;
			bool flag3 = ((entryType == PinEntryType.ChangePIN_PIN || entryType == PinEntryType.ResumePIN_CAN) ? true : false);
			flag2 = flag3;
		}
		if (flag2)
		{
			EIDSession.Card = null;
			await base.NavigationService.PopCurrentModalPage();
			await base.NavigationService.PopToRootAsync();
			return;
		}
		if (_cancelAction != null)
		{
			await _cancelAction();
			return;
		}
		bool? result = ((mobileSettings.ActivationStatus == ActivationStatus.Activated) ? (await popupService.DisplayAlert(CommonResources.x_LoginCancelConfirmHeader, CommonResources.x_LoginCancelConfirmMessage, CommonResources.Alg_Yes, CommonResources.Alg_No)) : (await popupService.DisplayAlert(CommonResources.x_ActivationAnnulerenAlertHeader, CommonResources.x_ActivationAnnulerenAlertMessage, CommonResources.Alg_Yes, CommonResources.Alg_No)));
		await base.NavigationService.PopAsync(animate: false);
		if (result.HasValue && result.Value)
		{
			if (base.Model.EIDSessionResponse == null)
			{
				await sessionService.CancelSession(byUser: true, async delegate
				{
					PinEntryType entryType2 = base.Model.EntryType;
					PinEntryType pinEntryType = entryType2;
					PinEntryType pinEntryType2 = pinEntryType;
					if (pinEntryType2 != PinEntryType.Enrollment)
					{
						if (pinEntryType2 != PinEntryType.Authentication)
						{
							await base.NavigationService.PopToRootAsync();
							return;
						}
						if (mobileSettings.ActivationStatus == ActivationStatus.Activated)
						{
							await base.ToastService.ShowWarning(CommonResources.Alg_LoginCancelledMessage, null, popToRoot: false);
							return;
						}
					}
					AppSession.ResetActivationState();
					await base.NavigationService.PopToRootAsync();
				});
			}
			else
			{
				await eIdApi.CancelAuthenticate();
				await base.ToastService.ShowWarning(string.Format(CommonResources.x_WIDCancelledMessage, EIDSession.Card?.DocumentType.Translate().ToLower()), null, popToRoot: false);
				EIDSession.Card = null;
				await base.NavigationService.PopToRootAsync();
			}
		}
		base.CanExecute = true;
	}

	protected override async Task PinCompleteAction()
	{
		await ValidatePinCode();
	}

	protected override async Task ChangePinAction()
	{
		base.DialogService.Show();
		ArgumentNullException.ThrowIfNull(_iv, "_iv");
		ArgumentNullException.ThrowIfNull(base.Pin2, "Pin2");
		HttpSession.AppSessionId = (await changePinApi.InitSession()).AppSessionId;
		string mask = PinCodeHelper.GenerateMaskCode();
		string maskedPin = PinCodeHelper.MaskPin(base.Pin2, mask);
		string encryptedPin = EncryptionHelper.Encrypt(key: mobileSettings.SymmetricKey.ToBytes(), data: maskedPin, iv: _iv);
		BaseResponse changePinResult = await changePinApi.ChangePin(encryptedPin);
		switch (changePinResult.ApiResult)
		{
		case ApiResult.Ok:
			mobileSettings.MaskCode = mask;
			if (DemoSettings.IsDemoModeEnabled)
			{
				DemoSettings.DemoPin = maskedPin;
			}
			await base.ToastService.ShowSuccess(CommonResources.FM071_Body, null, popToRoot: false, ToastPriority.High);
			if (biometricService.AuthenticationStatus == BiometricHwStatus.Success && Preferences.BiometricsState == BiometricsState.Enrolled)
			{
				if (!(await EnrollBiometrics(base.Pin2, withPage: false)))
				{
					Preferences.BiometricsState = BiometricsState.NotUsed;
					biometricService.Reset();
					string translate = AppSession.BiometricType.Translate();
					await base.ToastService.ShowWarning(string.Format(DigiDAppResources.BiometricsTurnedOff, translate), null, popToRoot: false, ToastPriority.High);
				}
			}
			else
			{
				Preferences.BiometricsState = BiometricsState.NotUsed;
				biometricService.Reset();
				await base.NavigationService.PopCurrentModalPage();
			}
			break;
		case ApiResult.Nok:
			switch (changePinResult.ErrorMessage)
			{
			case "no_app_found":
			case "wrong_session":
			case "failed_decoding_pin":
				await base.ToastService.ShowWarning(CommonResources.x_ChangePinFailedMessage);
				break;
			case "too_many_changes_today":
				await alertService.DisplayAlert(AlertMessageType.FM075);
				break;
			default:
				await base.ToastService.ShowError(CommonResources.Alg_UnknownErrorOccurred);
				break;
			}
			break;
		default:
			await base.ToastService.ShowError(CommonResources.Alg_UnknownErrorOccurred);
			break;
		}
		await base.NavigationService.PopToRootAsync();
		await base.DialogService.Hide();
	}

	protected override async Task GoToNfcScannerPage(NfcScannerModel model)
	{
		await base.NavigationService.PopCurrentModalPage();
		await base.NavigationService.NavigateAsync<DG051, DG051ViewModel>(delegate(DG051ViewModel vm)
		{
			vm.Initialize(model);
		});
	}

	private async Task<bool?> AuthenticateAsync(SecureString pin)
	{
		base.DialogService.Show();
		if (!IsInitialized)
		{
			IsInitialized = !(await connectionService.CheckNetworkConnection());
			if (!IsInitialized)
			{
				return null;
			}
		}
		StartSessionBaseResponse response = await authenticationApi.InitSessionAuthentication();
		if (response.ApiResult == ApiResult.TrafficMetered)
		{
			await alertService.DisplayAlert(AlertMessageType.FM100);
			await base.DialogService.Hide();
			return null;
		}
		if (response.ApiResult == ApiResult.Maintenance)
		{
			await alertService.DisplayAlert(AlertMessageType.FM104);
			await base.DialogService.Hide();
			return null;
		}
		if (response.ApiResult != ApiResult.Ok)
		{
			await base.DialogService.Hide();
			return false;
		}
		ChallengeResponse challengeResponse = await authenticationService.GetChallenge(response.AppSessionId);
		if (challengeResponse == null)
		{
			await base.DialogService.Hide();
			return false;
		}
		ValidatePinResponse result = await authenticationService.AuthenticateAsync(pin, challengeResponse, response.AppSessionId);
		HttpSession.IsDeceased = result.IsDeceased;
		if (base.Model.ChangeAppPin && !HttpSession.IsDeceased)
		{
			_iv = challengeResponse.IV;
		}
		await base.DialogService.Hide();
		switch (result.ApiResult)
		{
		case ApiResult.Ok:
			mobileSettings.LoginLevel = result.AuthenticationLevel;
			AppSession.AppAuthenticationType = (_isBiometricAuthentication ? AppAuthenticationType.Biometric : AppAuthenticationType.PinCode);
			HttpSession.AuthenticationSessionId = response.AppSessionId;
			HttpSession.SubExpiryDate = result.SubExpiryDate;
			mobileSettings.BiometricsCancelCounter = 0;
			if (HttpSession.WidSessionResponse != null)
			{
				return null;
			}
			if (NextAction != null)
			{
				BiometricHwStatus authenticationStatus = biometricService.AuthenticationStatus;
				BiometricsState biometricsState = Preferences.BiometricsState;
				bool flag = !HttpSession.IsDeceased;
				bool flag2 = flag;
				if (flag2)
				{
					BiometricHwStatus biometricHwStatus = authenticationStatus;
					bool flag3 = ((biometricHwStatus == BiometricHwStatus.Success || biometricHwStatus == BiometricHwStatus.LockedOut) ? true : false);
					flag2 = flag3;
				}
				if (flag2 && biometricsState != BiometricsState.Enrolled && biometricsState != BiometricsState.NotUsed && biometricsState != BiometricsState.PendingDisabled)
				{
					if (!(await EnrollBiometrics(pin, biometricsState != BiometricsState.PendingEnabled)))
					{
						SetInitialAuthenticationMessage();
						if (_cancelAction != null)
						{
							await _cancelAction();
							NextAction = null;
							return true;
						}
					}
				}
				else if (biometricsState == BiometricsState.PendingDisabled)
				{
					Preferences.BiometricsState = BiometricsState.NotUsed;
				}
				await NextAction();
				NextAction = null;
			}
			else if (HttpSession.IsDeceased || !base.Model.ChangeAppPin)
			{
				await sessionService.SetStartPage();
			}
			else
			{
				PinCodeForgottenVisible = false;
				IsHeaderVisible = true;
				base.Model.EntryType = PinEntryType.ChangePIN_PIN;
				base.Pin1 = new SecureString();
				base.PageId = "DG016C";
				SetLabels(CommonResources.Alg_ChoosePincode, new LocalizedString(() => base.ResourceManager["DG016C_Intro"]));
				base.HelpTextVisible = true;
			}
			return true;
		case ApiResult.Kill:
			await alertService.DisplayAlert(AlertMessageType.FM064);
			await appService.Deactivate(null);
			break;
		case ApiResult.Cancelled:
			await base.ToastService.ShowWarning(CommonResources.Alg_LoginCancelledMessage);
			break;
		case ApiResult.Disabled:
			await base.ToastService.ShowWarning(CommonResources.Alg_ActivationDisabledMessage);
			break;
		case ApiResult.Aborted:
			await base.ToastService.ShowWarning(CommonResources.Alg_LoginAbortedMessage);
			break;
		case ApiResult.Blocked:
			HandleBlocked();
			await alertService.DisplayAlert(AlertMessageType.FM043);
			break;
		case ApiResult.Nok:
			HandlePinError(result);
			break;
		case ApiResult.Unknown:
			await base.ToastService.ShowWarning(CommonResources.Alg_LoginUnknownMessage);
			break;
		case ApiResult.SessionNotFound:
			await base.ToastService.ShowError(CommonResources.x_SessionTimeoutMessage);
			break;
		case ApiResult.HostNotReachable:
			await alertService.DisplayAlert(AlertMessageType.FM005);
			break;
		case ApiResult.SSLPinningError:
			await base.ToastService.ShowWarning(CommonResources.SSLWarningMessage);
			break;
		case ApiResult.Failed:
			mobileSettings.Reset();
			await base.ToastService.ShowWarning(CommonResources.x_ReactivationNeededMessage, null, popToRoot: false);
			await base.NavigationService.PopToRootAsync();
			break;
		}
		return null;
	}

	private async Task<bool> EnrollBiometrics(SecureString pin, bool withPage)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		DG088ViewModel vm = base.ServiceProvider.GetRequiredService<DG088ViewModel>();
		vm.SetPin(pin);
		vm.Response = tcs;
		vm.DisplayToast = !base.Model.ChangeAppPin;
		if (!withPage || base.NavigationService.CurrentPage == null)
		{
			await vm.NextCommand.ExecuteAsync(null);
		}
		else
		{
			await base.NavigationService.CurrentPage.Navigation.PushModalAsync(new NavigationPage(new DG088(vm)));
		}
		return await tcs.Task;
	}

	private void HandleBlocked()
	{
		OnError();
		appService.Reset();
		base.NavigationService.SetRoot<DG001>();
	}

	private void HandlePinError(ValidatePinResponse result)
	{
		switch (result.RemainingAttempts)
		{
		case 1:
			SetLabels(CommonResources.x_WrongPinHeader, new LocalizedString(() => base.ResourceManager["FM042_Melding2"]), isError: true);
			base.MatomoService.TrackScreen("AP210");
			break;
		case -1:
			SetLabels(string.Empty, new LocalizedString(() => base.ResourceManager["Alg_CheckConnection"]), isError: true);
			break;
		default:
			SetLabels(CommonResources.x_WrongPinHeader, new LocalizedString(() => base.ResourceManager["x_WrongPinMessageTriesLeft", new object[1] { result.RemainingAttempts }]), isError: true);
			break;
		}
		base.MatomoService.TrackScreen("AP209");
		OnError();
	}

	private async Task PinsAreEqual()
	{
		ArgumentNullException.ThrowIfNull(base.Pin1, "Pin1");
		ArgumentNullException.ThrowIfNull(base.Model.IV, "Model.IV");
		await Task.Delay(100);
		if (await activationService.ActivateAsync(base.Pin1, base.Model.IV))
		{
			if (HttpSession.ActivationSessionData != null)
			{
				HttpSession.ActivationSessionData.Pin = base.Pin1;
			}
			if (mobileSettings.KeyAttestationResult == KeyAttestationResult.Success)
			{
				AppSession.SetNextState();
				await base.NavigationService.PopToRootAsync();
				return;
			}
			base.DialogService.Show();
			AppSession.SetNextState();
			AppSession.RDASkipped = true;
			await activationService.SkipRda();
			await base.DialogService.Hide();
		}
		else
		{
			base.Pin1 = new SecureString();
			base.Pin2 = new SecureString();
		}
	}

	private async Task ValidatePinCode()
	{
		ArgumentNullException.ThrowIfNull(base.Pin1, "Pin1");
		await base.DialogService.Hide();
		switch (base.Model.EntryType)
		{
		case PinEntryType.Enrollment:
			if (base.Pin2 != null)
			{
				if (base.Pin1.ToPlain() == base.Pin2.ToPlain())
				{
					await PinsAreEqual();
					break;
				}
				OnError();
				ResetPinCode();
			}
			break;
		case PinEntryType.Authentication:
			await Task.Delay(100);
			if (base.Model.EIDSessionResponse != null)
			{
				NfcScannerModel model = new NfcScannerModel(base.Model.EntryType)
				{
					Pin = base.Pin1,
					EIDSessionResponse = base.Model.EIDSessionResponse,
					NewPin = null,
					IsStatusChecked = base.Model.IsStatusChecked,
					IsActivation = base.Model.IsWIDActivation,
					NeedAppDeactivation = base.Model.NeedAppDeactivation
				};
				await GoToNfcScannerPage(model);
			}
			else
			{
				bool? isValid = await AuthenticateAsync(base.Pin1);
				if (isValid.HasValue && !isValid.Value)
				{
					HandlePinError(new ValidatePinResponse
					{
						RemainingAttempts = -1
					});
				}
				base.Pin1 = new SecureString();
			}
			break;
		}
	}

	[RelayCommand]
	private void ResetPinCode(bool reset = false)
	{
		if (reset)
		{
			SetLabels(CommonResources.Alg_ChoosePincode, new LocalizedString(() => base.ResourceManager["DG016_Intro"]), isError: true);
			base.Pin1 = new SecureString();
			base.Pin2 = null;
			base.PageId = "DG016A";
			base.PinLocked = false;
			base.IsError = false;
			base.HelpTextVisible = true;
			base.A11YService.Speak(base.MessageText.Localized, 1000);
			WeakEventManager.HandleEvent(this, EventArgs.Empty, "ChangeFocus");
		}
		else
		{
			SetLabels(CommonResources.Alg_ChoosePincode, new LocalizedString(() => base.ResourceManager["FM035_Melding"]), isError: true);
			base.Pin2 = new SecureString();
			base.PageId = "DG016D";
			base.PinLocked = true;
			base.HelpTextVisible = false;
			base.A11YService.Speak(base.MessageText.Localized, 1000);
		}
	}

	private void SetImageSource()
	{
		if (EIDSession.Card != null)
		{
			if (base.Model.HasPinChanged.HasValue && !base.Model.HasPinChanged.Value)
			{
				ImageSource = "afbeelding_pin_brief.png";
			}
			else
			{
				ImageSource = ((EIDSession.Card.DocumentType == DocumentType.IDCard) ? "afbeelding_pin_nik.png" : "afbeelding_pin_drivinglicence.png");
			}
		}
	}
}
