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
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.Responses;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using DigiD.Mobile.Helpers;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Pages;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG031ViewModel : CommonBaseViewModel
{
	private readonly IEnrollmentApi api;

	private readonly IMobileSettings mobileSettings;

	private readonly IConfigurationService configuration;

	private readonly IActivationService activationService;

	private readonly IAlertService alertService;

	private PeriodicTimer? timer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string _003CNewLetterText_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string _003CIntroText_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? enterLetterCodeCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? requestNewLetterCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private RelayCommand? hideToastCommand;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string NewLetterText
	{
		get
		{
			return _003CNewLetterText_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CNewLetterText_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.NewLetterText);
				_003CNewLetterText_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.NewLetterText);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string IntroText
	{
		get
		{
			return _003CIntroText_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CIntroText_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IntroText);
				_003CIntroText_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IntroText);
			}
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand EnterLetterCodeCommand => enterLetterCodeCommand ?? (enterLetterCodeCommand = new AsyncRelayCommand(EnterLetterCodeAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand RequestNewLetterCommand => requestNewLetterCommand ?? (requestNewLetterCommand = new AsyncRelayCommand(RequestNewLetterAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand HideToastCommand => hideToastCommand ?? (hideToastCommand = new RelayCommand(HideToast));

	public DG031ViewModel(IDeviceLockService deviceLockService, IEnrollmentApi api, IMobileSettings mobileSettings, IConfigurationService configuration, IActivationService activationService, IAlertService alertService)
	{
		this.api = api;
		this.mobileSettings = mobileSettings;
		this.configuration = configuration;
		this.activationService = activationService;
		this.alertService = alertService;
		base.HasBackButton = false;
		deviceLockService.Start();
		int letterRequestDelay = configuration.Configuration.LetterRequestDelay;
		NewLetterText = string.Format(DigiDAppResources.DG031_InfoNieuweBrief, letterRequestDelay);
		IntroText = string.Format(DigiDAppResources.DG031_Intro, letterRequestDelay);
	}

	protected override async Task OnAppearing()
	{
		await base.DialogService.Hide();
		await base.OnAppearing();
	}

	[RelayCommand]
	private Task EnterLetterCodeAsync()
	{
		return NextAsync(requestNewLetter: false);
	}

	[RelayCommand]
	private async Task RequestNewLetterAsync()
	{
		double days = (Preferences.LetterRequestDate.AddDays(configuration.Configuration.LetterRequestDelay).ToLocalTime() - DateTime.UtcNow).TotalDays;
		days = Math.Ceiling(days);
		if (days > 0.0)
		{
			base.MessageText = string.Format(DigiDAppResources.DG031_Toast, days);
			timer = new PeriodicTimer(TimeSpan.FromSeconds(10L));
			while (await timer.WaitForNextTickAsync())
			{
				timer.Dispose();
			}
			base.MessageText = null;
		}
		else if (!Preferences.LetterReRequestAllowed)
		{
			timer?.Dispose();
			await base.NavigationService.NavigateAsync<DG032>();
		}
		else if (await alertService.DisplayAlert(AlertMessageType.FM055) == true)
		{
			await NextAsync(requestNewLetter: true);
		}
	}

	[RelayCommand]
	private void HideToast()
	{
		base.MessageText = null;
		timer?.Dispose();
	}

	private async Task NextAsync(bool requestNewLetter)
	{
		InitSessionResponse response = await api.InitSessionActivationCode(new ActivationCodeSessionRequest
		{
			AppId = mobileSettings.AppId,
			RequestNewLetter = requestNewLetter
		});
		if (response.ApiResult != ApiResult.Ok)
		{
			return;
		}
		timer?.Dispose();
		HttpSession.AppSessionId = response.SessionId;
		if (!requestNewLetter)
		{
			await base.NavigationService.NavigateAsync<DG005>();
			return;
		}
		if ((await activationService.RequestLetter()).ApiResult == ApiResult.Ok)
		{
			Preferences.LetterReRequestAllowed = false;
		}
		await base.NavigationService.NavigateAsync<DG029>();
	}
}
