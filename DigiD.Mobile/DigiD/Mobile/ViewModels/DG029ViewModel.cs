using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Interfaces;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Mobile.Interfaces;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG029ViewModel : CommonBaseViewModel
{
	private readonly IAuthenticationApi authenticationApi;

	private readonly IApp2AppService app2AppService;

	private readonly ILetterService letterService;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CReceiveReminder_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CButtonVisible_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string _003CIntroText_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string _003CReminderText_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? nextCommand;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool ReceiveReminder
	{
		get
		{
			return _003CReceiveReminder_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CReceiveReminder_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.ReceiveReminder);
				_003CReceiveReminder_003Ek__BackingField = value;
				OnReceiveReminderChanged(value);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.ReceiveReminder);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool ButtonVisible
	{
		get
		{
			return _003CButtonVisible_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CButtonVisible_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.ButtonVisible);
				_003CButtonVisible_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.ButtonVisible);
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

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string ReminderText
	{
		get
		{
			return _003CReminderText_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CReminderText_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.ReminderText);
				_003CReminderText_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.ReminderText);
			}
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand NextCommand => nextCommand ?? (nextCommand = new AsyncRelayCommand(NextAsync));

	public DG029ViewModel(IDeviceLockService deviceLockService, IAuthenticationApi authenticationApi, IApp2AppService app2AppService, ILetterService letterService, IConfigurationService configurationService)
	{
		this.authenticationApi = authenticationApi;
		this.app2AppService = app2AppService;
		this.letterService = letterService;
		ButtonVisible = HttpSession.IsApp2AppSession && HttpSession.TempSessionData != null;
		int letterRequestDelay = configurationService.Configuration.LetterRequestDelay;
		ReminderText = string.Format(DigiDAppResources.DG029_InfoHerinnering, letterRequestDelay + 1);
		IntroText = string.Format(DigiDAppResources.DG029_Intro, letterRequestDelay);
		base.HasBackButton = false;
		deviceLockService.Start();
	}

	[RelayCommand]
	private async Task NextAsync()
	{
		if (HttpSession.IsApp2AppSession && HttpSession.TempSessionData != null)
		{
			HttpSession.TempSessionData.SwitchSession();
			await authenticationApi.AbortAuthentication("app_is_pending");
			await app2AppService.ReturnToClientApp();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private async void OnReceiveReminderChanged(bool value)
	{
		if (value)
		{
			await letterService.Register();
		}
		else
		{
			letterService.Cancel();
		}
	}
}
