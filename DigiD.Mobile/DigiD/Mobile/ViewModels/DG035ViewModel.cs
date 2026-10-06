using System;
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
using DigiD.Mobile.Interfaces;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG035ViewModel : CommonBaseViewModel
{
	private readonly IActivationService activationService;

	private readonly IRemoteNotificationService remoteNotificationService;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CNotificationsEnabled_003Ek__BackingField = true;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? nextCommand;

	public Func<Task>? NextAction { get; set; }

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool NotificationsEnabled
	{
		get
		{
			return _003CNotificationsEnabled_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CNotificationsEnabled_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.NotificationsEnabled);
				_003CNotificationsEnabled_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.NotificationsEnabled);
			}
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand NextCommand => nextCommand ?? (nextCommand = new AsyncRelayCommand(NextAsync, CanExecuteNext));

	public DG035ViewModel(IActivationService activationService, IRemoteNotificationService remoteNotificationService)
	{
		base.PageId = "DG035B";
		this.activationService = activationService;
		this.remoteNotificationService = remoteNotificationService;
	}

	private bool CanExecuteNext()
	{
		return base.CanExecute;
	}

	[RelayCommand(CanExecute = "CanExecuteNext")]
	private async Task NextAsync()
	{
		if (base.CanExecute)
		{
			base.CanExecute = false;
			NextCommand.NotifyCanExecuteChanged();
			await remoteNotificationService.RequestToken(NotificationsEnabled);
			if (NextAction == null)
			{
				await activationService.SetPreferencesEmailAsync();
			}
			else
			{
				await NextAction();
			}
			base.CanExecute = true;
		}
	}
}
