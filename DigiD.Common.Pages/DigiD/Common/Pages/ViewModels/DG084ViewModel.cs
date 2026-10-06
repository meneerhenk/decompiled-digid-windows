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
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Nfc;
using LocalizationResourceManager.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices;
using WinRT;
using WinRT.DigiD_Common_PagesVtableClasses;

namespace DigiD.Common.Pages.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Common_Pages_Pages_DG084WinRTTypeDetails))]
public class DG084ViewModel : CommonBaseViewModel
{
	private Func<Task>? _skipAction;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ImageSource _003CTip1ImageSource_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private LocalizedString _003CTip1Text_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? tryAgainCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? skipCommand;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public ImageSource Tip1ImageSource
	{
		get
		{
			return _003CTip1ImageSource_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<ImageSource>.Default.Equals(_003CTip1ImageSource_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.Tip1ImageSource);
				_003CTip1ImageSource_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.Tip1ImageSource);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public LocalizedString Tip1Text
	{
		get
		{
			return _003CTip1Text_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<LocalizedString>.Default.Equals(_003CTip1Text_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.Tip1Text);
				_003CTip1Text_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.Tip1Text);
			}
		}
	}

	public IDeviceService DeviceService { get; }

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand TryAgainCommand => tryAgainCommand ?? (tryAgainCommand = new AsyncRelayCommand(TryAgain));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand SkipCommand => skipCommand ?? (skipCommand = new AsyncRelayCommand(Skip));

	public DG084ViewModel(INfcLocationService service, IDeviceService deviceService)
	{
		base.HasBackButton = false;
		base.CloseButtonVisible = true;
		DeviceService = deviceService;
		if (DeviceInfo.Platform == DevicePlatform.Android)
		{
			switch (service.Position)
			{
			case NfcPosition.Top:
				Tip1ImageSource = ImageSource.FromFile("digid_afbeelding_dg084_tip1_location_top");
				Tip1Text = new LocalizedString(() => base.ResourceManager["DG084_Tip1_Text_Top"]);
				break;
			case NfcPosition.Bottom:
				Tip1ImageSource = ImageSource.FromFile("digid_afbeelding_dg084_tip1_location_bottom");
				Tip1Text = new LocalizedString(() => base.ResourceManager["DG084_Tip1_Text_Bottom"]);
				break;
			case NfcPosition.Middle:
				Tip1ImageSource = ImageSource.FromFile("digid_afbeelding_dg084_tip1_location_middle");
				Tip1Text = new LocalizedString(() => base.ResourceManager["DG084_Tip1_Text_Middle"]);
				break;
			default:
				Tip1ImageSource = ImageSource.FromFile("digid_afbeelding_dg084_tip1_location_unknown");
				Tip1Text = new LocalizedString(() => base.ResourceManager["DG084_Tip1_Text_Unknown"]);
				break;
			}
		}
		else
		{
			Tip1ImageSource = ImageSource.FromFile("digid_afbeelding_dg084_tip1_ios");
			Tip1Text = new LocalizedString(() => base.ResourceManager["DG084_Tip1_Text_Top"]);
		}
	}

	public void Initialize(Func<Task>? skipAction)
	{
		_skipAction = skipAction;
	}

	protected override Task CloseButtonClicked()
	{
		return base.NavigationService.PopCurrentModalPage();
	}

	[RelayCommand]
	private Task TryAgain()
	{
		return base.NavigationService.PopCurrentModalPage();
	}

	[RelayCommand]
	private Task Skip()
	{
		ArgumentNullException.ThrowIfNull(_skipAction, "_skipAction");
		return _skipAction();
	}
}
