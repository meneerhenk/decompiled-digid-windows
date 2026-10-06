using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Enums;
using DigiD.Common.Models;
using DigiD.Common.Models.Messages;
using DigiD.Mobile.Pages;
using Microsoft.Maui.Devices;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG057ViewModel : CommonBaseViewModel
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string _003CSelectedTab_003Ek__BackingField = "App";

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private RelayCommand<string>? tabSelectedCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? nextCommand;

	[ObservableProperty]
	[NotifyPropertyChangedFor("TabAppButtonType", new string[] { "TabCardButtonType" })]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string SelectedTab
	{
		get
		{
			return _003CSelectedTab_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CSelectedTab_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.SelectedTab);
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.TabAppButtonType);
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.TabCardButtonType);
				_003CSelectedTab_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.SelectedTab);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.TabAppButtonType);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.TabCardButtonType);
			}
		}
	}

	public ButtonType TabAppButtonType => (SelectedTab == "App") ? ButtonType.TabActive : ButtonType.TabInActive;

	public ButtonType TabCardButtonType => (SelectedTab == "Card") ? ButtonType.TabActive : ButtonType.TabInActive;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand<string> TabSelectedCommand => tabSelectedCommand ?? (tabSelectedCommand = new RelayCommand<string>(TabSelected));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand NextCommand => nextCommand ?? (nextCommand = new AsyncRelayCommand(NextAsync));

	public DG057ViewModel()
	{
		base.CloseButtonVisible = true;
	}

	[RelayCommand]
	private void TabSelected(string name)
	{
		SelectedTab = name;
		if (DeviceInfo.Platform == DevicePlatform.iOS)
		{
			WeakReferenceMessenger.Default.Send(new ScrollViewSizeChangedMessage());
		}
	}

	[RelayCommand]
	private async Task NextAsync()
	{
		if (SelectedTab == "App")
		{
			await base.NavigationService.NavigateAsync<PinCodePage, PinCodeViewModel>(delegate(PinCodeViewModel vm)
			{
				vm.Initialize(new PinCodeModel(PinEntryType.Authentication)
				{
					ChangeAppPin = true,
					BiometricEnabled = false
				});
			});
		}
		else
		{
			NfcScannerModel model = new NfcScannerModel(PinEntryType.ChangePIN_PIN);
			await base.NavigationService.NavigateAsync<DG051, DG051ViewModel>(delegate(DG051ViewModel vm)
			{
				vm.Initialize(model);
			});
		}
	}
}
