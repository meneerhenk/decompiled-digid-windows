using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Enums;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Preferences;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using DigiD.Mobile.Helpers;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Pages;
using LocalizationResourceManager.Maui;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG037ViewModel : CommonBaseViewModel
{
	private readonly IDeviceLockService deviceLockService;

	private readonly IDemoService demoService;

	private readonly IAuthenticationApi authenticationApi;

	private readonly IConfigurationService configurationService;

	private readonly IMobileSettings mobileSettings;

	private readonly IPushNotificationService pushNotificationService;

	private readonly IRemoteNotificationService remoteNotificationService;

	private readonly IPopupService popupService;

	private readonly AppConfig config;

	private readonly IAppRating ratingService;

	private readonly IToastService toastService;

	private PeriodicTimer? _timer;

	private Task? ehaTask;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private LocalizedString _003CMoreExplanationText_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? demoBarPressedCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? logoPressedCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? openKoppelCodeCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? moreExplanationCommand;

	internal static bool PerformIDCheckAfterLogin { get; set; }

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public LocalizedString MoreExplanationText
	{
		get
		{
			return _003CMoreExplanationText_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<LocalizedString>.Default.Equals(_003CMoreExplanationText_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.MoreExplanationText);
				_003CMoreExplanationText_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.MoreExplanationText);
			}
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand DemoBarPressedCommand => demoBarPressedCommand ?? (demoBarPressedCommand = new AsyncRelayCommand(DemoBarPressedAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand LogoPressedCommand => logoPressedCommand ?? (logoPressedCommand = new AsyncRelayCommand(LogoPressedAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand OpenKoppelCodeCommand => openKoppelCodeCommand ?? (openKoppelCodeCommand = new AsyncRelayCommand(OpenKoppelCodeAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand MoreExplanationCommand => moreExplanationCommand ?? (moreExplanationCommand = new AsyncRelayCommand(MoreExplanationAsync));

	public DG037ViewModel(IDeviceLockService deviceLockService, IDemoService demoService, IAuthenticationApi authenticationApi, IConfigurationService configurationService, IMobileSettings mobileSettings, IPushNotificationService pushNotificationService, IRemoteNotificationService remoteNotificationService, IPopupService popupService, AppConfig config, IAppRating ratingService, IToastService toastService)
	{
		this.deviceLockService = deviceLockService;
		this.demoService = demoService;
		this.authenticationApi = authenticationApi;
		this.configurationService = configurationService;
		this.mobileSettings = mobileSettings;
		this.pushNotificationService = pushNotificationService;
		this.remoteNotificationService = remoteNotificationService;
		this.popupService = popupService;
		this.config = config;
		this.ratingService = ratingService;
		this.toastService = toastService;
		MoreExplanationText = new LocalizedString(() => base.ResourceManager["DG037_InloggenKnop"]);
		base.HasBackButton = false;
		base.IsMenuImageVisible = true;
		if (DemoSettings.IsDemoModeEnabled)
		{
			base.DemoBarPressed = DemoBarPressedCommand;
		}
	}

	[RelayCommand(AllowConcurrentExecutions = false)]
	private Task DemoBarPressedAsync()
	{
		return base.NavigationService.PushModalAsync<DM002>();
	}

	[RelayCommand]
	private Task LogoPressedAsync()
	{
		return demoService.SetMode();
	}

	protected override Task ShowMenuClicked()
	{
		return base.NavigationService.NavigateAsync<DG044, DG044ViewModel>(async delegate(DG044ViewModel vm)
		{
			await vm.Initialize();
		});
	}

	protected override async Task OnAppearing()
	{
		if (AppSession.IsAuthenticated && HttpSession.AuthenticationSessionId != null)
		{
			deviceLockService.Start();
			ehaTask = Task.Run((Func<Task?>)StartEHATimerAsync);
			if (pushNotificationService.NotificationsAvailable && !mobileSettings.NotificationPermissionSet.HasValue && mobileSettings.ActivationStatus == ActivationStatus.Activated)
			{
				await remoteNotificationService.AskForPermission();
			}
			if (!Preferences.IsRatingRequested && Preferences.NumberOfSuccessfulLogins >= config.RatingLimit)
			{
				bool? result = await popupService.DisplayAlert(CommonResources.FM107_Titel, null, CommonResources.FM107_ButtonYes, null, invertCallToAction: false, AlertMessageType.FM107, null, "digid_afbeelding_app_rating.png", showCloseIcon: true);
				Preferences.IsRatingRequested = true;
				if (result.HasValue && result.Value)
				{
					await ratingService.PerformInAppRateAsync();
				}
			}
		}
		if (AppSession.IsAuthenticated && PerformIDCheckAfterLogin)
		{
			PerformIDCheckAfterLogin = false;
			await toastService.ShowWarning(DigiDAppResources.MSG_001_Message, null, popToRoot: false);
		}
		await base.OnAppearing();
	}

	protected override Task OnDisappearing()
	{
		_timer?.Dispose();
		ehaTask?.Dispose();
		return base.OnDisappearing();
	}

	[RelayCommand]
	private async Task OpenKoppelCodeAsync()
	{
		await StartQRCodeScanner();
	}

	private async Task StartQRCodeScanner()
	{
		if (!(await CheckPendingSessionAsync()) && AppSession.IsAuthenticated && HttpSession.AuthenticationSessionId != null)
		{
			await base.NavigationService.NavigateAsync<DG039>();
		}
	}

	[RelayCommand]
	private async Task MoreExplanationAsync()
	{
		if (AppSession.IsAuthenticated && HttpSession.AuthenticationSessionId != null)
		{
			await base.NavigationService.PushModalAsync<HLP007>();
		}
	}

	private async Task StartEHATimerAsync()
	{
		if (!configurationService.Configuration.EHAEnabled || await CheckPendingSessionAsync())
		{
			return;
		}
		_timer = new PeriodicTimer(TimeSpan.FromSeconds(10L));
		while (await _timer.WaitForNextTickAsync() && AppSession.IsAppVisible)
		{
			if (!AppSession.IsAuthenticated)
			{
				_timer.Dispose();
				ehaTask?.Dispose();
				break;
			}
			if (await CheckPendingSessionAsync())
			{
				_timer.Dispose();
				ehaTask?.Dispose();
			}
		}
	}

	private async Task<bool> CheckPendingSessionAsync()
	{
		PendingSessionResponse sessionInfo = await authenticationApi.CheckPendingSession();
		if (sessionInfo.ApiResult != ApiResult.Ok)
		{
			return false;
		}
		if (sessionInfo.WebService?.StartsWith("Publieke dienst in", StringComparison.CurrentCultureIgnoreCase) ?? false)
		{
			return false;
		}
		HttpSession.AppSessionId = sessionInfo.SessionId;
		HttpSession.WebSessionInfoResponse = sessionInfo;
		if (mobileSettings.LoginLevel >= sessionInfo.AuthenticationLevel)
		{
			await base.NavigationService.NavigateAsync<DG038>();
		}
		else if (!HttpSession.IsDeceased)
		{
			if (!AppSession.HasNfc || !AppSession.IsKeyAttestationSupported)
			{
				await base.NavigationService.NavigateAsync<DG043>();
			}
			else
			{
				AppSession.Process = Process.UpgradeAndAuthenticate;
				await base.NavigationService.NavigateAsync<DG021>();
			}
		}
		return true;
	}
}
