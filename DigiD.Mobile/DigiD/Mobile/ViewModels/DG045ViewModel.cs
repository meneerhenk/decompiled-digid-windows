using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using DigiD.Common.BaseClasses;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Messages;
using DigiD.Common.Models.ResponseModels;
using Microsoft.Maui.Devices;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG045ViewModel : CommonBaseViewModel
{
	private readonly IRemoteNotificationsApi notificationsApi;

	private readonly IPushNotificationService pushNotificationService;

	private readonly IDeviceService deviceService;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private List<MessageModel>? _003CMessages_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003COpenSettingsCommandVisible_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? openSettingsCommand;

	[ObservableProperty]
	[NotifyPropertyChangedFor("HasMessages")]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public List<MessageModel>? Messages
	{
		get
		{
			return _003CMessages_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<List<MessageModel>>.Default.Equals(_003CMessages_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.Messages);
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.HasMessages);
				_003CMessages_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.Messages);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.HasMessages);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool OpenSettingsCommandVisible
	{
		get
		{
			return _003COpenSettingsCommandVisible_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003COpenSettingsCommandVisible_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.OpenSettingsCommandVisible);
				_003COpenSettingsCommandVisible_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.OpenSettingsCommandVisible);
			}
		}
	}

	public bool HasMessages
	{
		get
		{
			List<MessageModel>? messages = Messages;
			return messages != null && messages.Count > 0;
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand OpenSettingsCommand => openSettingsCommand ?? (openSettingsCommand = new AsyncRelayCommand(OpenSettings));

	public DG045ViewModel(IRemoteNotificationsApi notificationsApi, IPushNotificationService pushNotificationService, IDeviceService deviceService)
	{
		base.PageId = "DG045";
		base.CloseButtonVisible = true;
		this.notificationsApi = notificationsApi;
		this.pushNotificationService = pushNotificationService;
		this.deviceService = deviceService;
	}

	public async Task Initialize()
	{
		base.DialogService.Show();
		Messages = (await notificationsApi.GetMessages()).Messages.OrderByDescending((MessageModel x) => x.DateTime).ToList();
		await base.DialogService.Hide();
	}

	protected override Task OnAppearing()
	{
		OpenSettingsCommandVisible = !pushNotificationService.NotificationsEnabled() && DeviceInfo.Idiom != DeviceIdiom.Desktop;
		return base.OnAppearing();
	}

	[RelayCommand]
	private async Task OpenSettings()
	{
		WeakReferenceMessenger.Default.Unregister<ActivityFinishedMessage>(this);
		if (!(await pushNotificationService.RequestPermissionAsync()))
		{
			WeakReferenceMessenger.Default.Register<ActivityFinishedMessage>(this, delegate
			{
				WeakReferenceMessenger.Default.Unregister<ActivityFinishedMessage>(this);
				OpenSettingsCommandVisible = !pushNotificationService.NotificationsEnabled();
			});
			deviceService.OpenSettings();
		}
	}
}
