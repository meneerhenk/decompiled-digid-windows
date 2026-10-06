using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Enums;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Messages;
using DigiD.Common.Models.Responses;
using DigiD.Common.Preferences;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Models;
using DigiD.Mobile.Pages;
using LocalizationResourceManager.Maui;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG001ViewModel : CommonBaseViewModel
{
	private readonly IRdaService rdaService;

	private readonly IActivationService activationService;

	private readonly IAuthenticationService authenticationService;

	private readonly IToastService toastService;

	private readonly IAlertService alertService;

	private readonly ISessionService sessionService;

	private readonly IMobileSettings mobileSettings;

	private readonly IDemoService demoService;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private List<IStepModel> _003CSteps_003Ek__BackingField = new List<IStepModel>();

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ButtonType _003CButtonType_003Ek__BackingField = ButtonType.Primary;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private LocalizedString? _003CHeaderText_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private LocalizedString? _003CButtonText_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private LocalizedString? _003CMessageText_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? demoBarPressedCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? logoClickCommand;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public List<IStepModel> Steps
	{
		get
		{
			return _003CSteps_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<List<IStepModel>>.Default.Equals(_003CSteps_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.Steps);
				_003CSteps_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.Steps);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public ButtonType ButtonType
	{
		get
		{
			return _003CButtonType_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<ButtonType>.Default.Equals(_003CButtonType_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.ButtonType);
				_003CButtonType_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.ButtonType);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public new LocalizedString? HeaderText
	{
		get
		{
			return _003CHeaderText_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<LocalizedString>.Default.Equals(_003CHeaderText_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.HeaderText);
				_003CHeaderText_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.HeaderText);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public new LocalizedString? ButtonText
	{
		get
		{
			return _003CButtonText_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<LocalizedString>.Default.Equals(_003CButtonText_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.ButtonText);
				_003CButtonText_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.ButtonText);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public new LocalizedString? MessageText
	{
		get
		{
			return _003CMessageText_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<LocalizedString>.Default.Equals(_003CMessageText_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.MessageText);
				_003CMessageText_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.MessageText);
			}
		}
	}

	private bool IDCheckAllowed => AppSession.HasNfc && AppSession.IsKeyAttestationSupported && mobileSettings.KeyAttestationResult != KeyAttestationResult.Failed;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand DemoBarPressedCommand => demoBarPressedCommand ?? (demoBarPressedCommand = new AsyncRelayCommand(DemoBarPressedAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand LogoClickCommand => logoClickCommand ?? (logoClickCommand = new AsyncRelayCommand(LogoClickAsync));

	public DG001ViewModel(IRdaService rdaService, IActivationService activationService, IAuthenticationService authenticationService, IDemoService demoService, IToastService toastService, IAlertService alertService, ISessionService sessionService, IMobileSettings mobileSettings)
	{
		this.rdaService = rdaService;
		this.activationService = activationService;
		this.authenticationService = authenticationService;
		this.toastService = toastService;
		this.alertService = alertService;
		this.sessionService = sessionService;
		this.mobileSettings = mobileSettings;
		this.demoService = demoService;
		base.HasBackButton = false;
		base.IsHeaderLogoVisible = true;
		base.IsMenuImageVisible = true;
		if (DemoSettings.IsDemoModeEnabled)
		{
			base.DemoBarPressed = DemoBarPressedCommand;
		}
		WeakReferenceMessenger.Default.Register<AppStateChangedMessage>(this, delegate
		{
			SetData(fromEvent: true);
		});
		SetData(fromEvent: false);
	}

	protected override async Task OnAppearing()
	{
		await base.DialogService.Hide();
		await base.OnAppearing();
		if (!WeakReferenceMessenger.Default.IsRegistered<LanguageChangedMessage>(this))
		{
			WeakReferenceMessenger.Default.Register<LanguageChangedMessage>(this, delegate
			{
				SetData(fromEvent: true);
			});
		}
	}

	protected override async Task EnterPressed()
	{
		ICommand buttonCommand = base.ButtonCommand;
		if (buttonCommand is AsyncRelayCommand command)
		{
			await command.ExecuteAsync(null);
		}
	}

	protected override Task OnDisappearing()
	{
		toastService.Toasts.Clear();
		if (AppSession.ActivationState > AppActivationState.Completed)
		{
			WeakReferenceMessenger.Default.Unregister<LanguageChangedMessage>(this);
		}
		return base.OnDisappearing();
	}

	private void SetData(bool fromEvent)
	{
		SetSteps(fromEvent);
		switch (AppSession.ActivationState)
		{
		case AppActivationState.Login:
			SetLoginTexts();
			break;
		case AppActivationState.ChoosePin:
			SetChoosePinTexts();
			break;
		case AppActivationState.ScanId:
			SetScanIdTexts();
			break;
		case AppActivationState.Preferences:
			SetPreferencesTexts();
			break;
		case AppActivationState.Completed:
			SetCompletedTexts();
			break;
		case AppActivationState.WaitingForLetter:
			SetWaitingForLetterTexts();
			break;
		}
	}

	[RelayCommand(AllowConcurrentExecutions = false)]
	private Task DemoBarPressedAsync()
	{
		return base.NavigationService.PushModalAsync<DM002>();
	}

	[RelayCommand]
	private Task LogoClickAsync()
	{
		return demoService.SetMode();
	}

	private void SetSteps(bool fromEvent)
	{
		if (fromEvent)
		{
			Steps = new List<IStepModel>();
		}
		List<IStepModel> list = new List<IStepModel>
		{
			new StepModel("DG001_Stap1Titel", "DG001_Stap1")
			{
				Index = 1,
				State = AppActivationState.Login
			},
			new StepModel("DG001_Stap2Titel", "DG001_Stap2")
			{
				Index = 2,
				State = AppActivationState.ChoosePin
			}
		};
		if (IDCheckAllowed)
		{
			if (AppSession.ActivationState == AppActivationState.ScanId && mobileSettings.SubAttestationKeyId == null)
			{
				list.Add(new StepModel("DG001_Stap3Titel_KAFailed", "DG001_Stap3Message_KAFailed")
				{
					Index = 3,
					State = AppActivationState.ScanId
				});
			}
			else
			{
				list.Add(new StepModel("DG001_Stap3Titel", (!AppSession.RDASkipped) ? "DG001_Stap3" : "DG001_Stap3Overgeslagen")
				{
					Index = 3,
					State = AppActivationState.ScanId
				});
			}
		}
		list.Add(new StepModel("DG001_Stap4Titel", "DG001_Stap4")
		{
			Index = (IDCheckAllowed ? 4 : 3),
			State = AppActivationState.Preferences
		});
		Steps = list;
	}

	protected override Task ShowMenuClicked()
	{
		return base.NavigationService.NavigateAsync<DG044, DG044ViewModel>(async delegate(DG044ViewModel vm)
		{
			await vm.Initialize();
		});
	}

	private void SetTexts(string headerTextKey, string buttonTextKey, string messageTextKey, params object[] arguments)
	{
		HeaderText = new LocalizedString(() => base.ResourceManager[headerTextKey]);
		ButtonText = new LocalizedString(() => base.ResourceManager[buttonTextKey]);
		MessageText = new LocalizedString(() => base.ResourceManager[messageTextKey, arguments]);
	}

	private void SetLoginTexts()
	{
		base.PageId = (IDCheckAllowed ? "DG001A" : "DG001F");
		SetTexts("DG001_Titel", "Alg_Next", "DG001_Intro", IDCheckAllowed ? 4 : 3);
		ButtonType = ButtonType.Primary;
		base.ButtonCommand = new AsyncRelayCommand((Func<Task>)async delegate
		{
			base.DialogService.Show();
			if (await App.Initialize())
			{
				await base.NavigationService.NavigateAsync<DG003>();
			}
			await base.DialogService.Hide();
		});
	}

	private void SetChoosePinTexts()
	{
		base.PageId = (IDCheckAllowed ? "DG001B" : "DG001G");
		SetTexts("DG001_Titel", "Alg_Next", IDCheckAllowed ? "DG001B_Intro" : "DG001G_Intro");
		ButtonType = ButtonType.Primary;
		base.ButtonCommand = new AsyncRelayCommand(ChoosePinTaskAsync);
	}

	private void SetScanIdTexts()
	{
		base.PageId = "DG001C";
		SetTexts("DG001_Titel", "Alg_Next", "DG001C_Intro");
		ButtonType = ButtonType.Primary;
		base.ButtonCommand = new AsyncRelayCommand(StartIdScanTaskAsync);
	}

	private void SetPreferencesTexts()
	{
		base.PageId = (IDCheckAllowed ? "DG001D" : "DG001H");
		SetTexts("DG001_Titel", "Alg_Next", IDCheckAllowed ? "DG001D_Intro" : "DG001C_Intro");
		ButtonType = ButtonType.Primary;
		base.ButtonCommand = new AsyncRelayCommand(activationService.SetPreferencesNotificationsAsync);
	}

	private void SetCompletedTexts()
	{
		base.PageId = (IDCheckAllowed ? "DG001E" : "DG001I");
		WeakReferenceMessenger.Default.Unregister<AppStateChangedMessage>(this);
		bool directAuthenticate = HttpSession.TempSessionData != null && HttpSession.ActivationSessionData != null && (HttpSession.IsApp2AppSession || HttpSession.IsWeb2AppSession);
		SetTexts("DG001E_Titel", directAuthenticate ? "DG001E_KnopInloggen" : "DG001E_KnopKlaar", "DG001E_Intro");
		ButtonType = ButtonType.Green;
		base.ButtonCommand = new AsyncRelayCommand((Func<Task>)delegate
		{
			AppSession.RDASkipped = false;
			if (directAuthenticate && HttpSession.TempSessionData != null)
			{
				HttpSession.TempSessionData.SwitchSession();
				return authenticationService.ContinueAuthenticationAsync();
			}
			HttpSession.AuthenticationSessionId = null;
			HttpSession.AppSessionId = null;
			AppSession.ResetActivationState(mobileSettings.ActivationStatus);
			base.NavigationService.SetRoot<DG037>();
			return sessionService.StartSession(sessionService.SetStartPage, startBiometrics: true);
		});
	}

	private void SetWaitingForLetterTexts()
	{
		base.PageId = (IDCheckAllowed ? "DG001J" : "DG001K");
		HttpSession.AuthenticationSessionId = null;
		SetTexts("DG001_Titel", "Alg_Next", "DG001J_Intro");
		ButtonType = ButtonType.Primary;
		base.ButtonCommand = new AsyncRelayCommand((Func<Task>)async delegate
		{
			await base.NavigationService.NavigateAsync<DG029>();
		});
	}

	private async Task ChoosePinTaskAsync()
	{
		if (HttpSession.ActivationSessionData?.IV != null)
		{
			await base.NavigationService.NavigateAsync<PinCodePage, PinCodeViewModel>(delegate(PinCodeViewModel vm)
			{
				vm.Initialize(new PinCodeModel(PinEntryType.Enrollment)
				{
					IV = HttpSession.ActivationSessionData.IV
				});
			});
		}
		else if (HttpSession.AuthenticationResponse != null)
		{
			await activationService.StartActivationAsync(HttpSession.AuthenticationResponse);
		}
		else
		{
			await activationService.LoginAndRemoveAsync();
		}
	}

	private async Task StartIdScanTaskAsync()
	{
		if (mobileSettings.SubAttestationKeyId == null)
		{
			AppSession.RDASkipped = true;
			await activationService.SkipRda();
			return;
		}
		base.DialogService.Show();
		ActivationMethod? activationMethod = HttpSession.ActivationSessionData?.ActivationMethod;
		bool flag;
		if (activationMethod.HasValue)
		{
			ActivationMethod valueOrDefault = activationMethod.GetValueOrDefault();
			if ((uint)(valueOrDefault - 4) <= 1u)
			{
				flag = true;
				goto IL_0146;
			}
		}
		flag = false;
		goto IL_0146;
		IL_0146:
		if (flag)
		{
			await rdaService.InitSession();
		}
		RdaSessionResponse session = await rdaService.GetRdaSessionUrl();
		await base.DialogService.Hide();
		switch (session.ApiResult)
		{
		case ApiResult.Ok:
			await base.NavigationService.NavigateAsync<DG017, DG017ViewModel>(delegate(DG017ViewModel vm)
			{
				vm.Initialize(session);
			});
			break;
		case ApiResult.NoDocumentsFound:
			await base.NavigationService.NavigateAsync<DG018>();
			break;
		case ApiResult.Nok:
			await alertService.DisplayAlert(AlertMessageType.FM038);
			activationMethod = HttpSession.ActivationSessionData?.ActivationMethod;
			if (activationMethod.HasValue && activationMethod == ActivationMethod.App)
			{
				AppSession.RDASkipped = true;
				AppSession.SetNextState(AppActivationState.Preferences);
				SetData(fromEvent: false);
			}
			else
			{
				await activationService.SkipRda();
			}
			break;
		}
	}

	protected override Task HeaderLogoClicked()
	{
		return demoService.SetMode();
	}
}
