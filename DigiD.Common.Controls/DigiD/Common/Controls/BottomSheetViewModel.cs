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
using Microsoft.Maui.Controls;
using Plugin.Maui.BottomSheet.Navigation;
using WinRT;
using WinRT.DigiD_Common_ControlsVtableClasses;

namespace DigiD.Common.Controls;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Common_Controls_HyperlinkLabelWinRTTypeDetails))]
public class BottomSheetViewModel(IBottomSheetNavigationService bottomSheetNavigationService) : CommonBaseViewModel()
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CTitle_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CMessage_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CActionText_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool? _003CIsActionButton_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? closeCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? actionButtonClickedCommand;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? Title
	{
		get
		{
			return _003CTitle_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CTitle_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.Title);
				_003CTitle_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.Title);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? Message
	{
		get
		{
			return _003CMessage_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CMessage_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.Message);
				_003CMessage_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.Message);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? ActionText
	{
		get
		{
			return _003CActionText_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CActionText_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.ActionText);
				_003CActionText_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.ActionText);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool? IsActionButton
	{
		get
		{
			return _003CIsActionButton_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool?>.Default.Equals(_003CIsActionButton_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsActionButton);
				_003CIsActionButton_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsActionButton);
			}
		}
	}

	public bool IsInA11YMode => base.A11YService.IsInVoiceOverMode;

	public Func<Task>? Action { get; set; }

	public bool FirstCloseThenExecuteAction { get; set; }

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand CloseCommand => closeCommand ?? (closeCommand = new AsyncRelayCommand(CloseAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand ActionButtonClickedCommand => actionButtonClickedCommand ?? (actionButtonClickedCommand = new AsyncRelayCommand(ActionButtonClickedAsync));

	[RelayCommand]
	private async Task CloseAsync()
	{
		await bottomSheetNavigationService.ClearBottomSheetStackAsync();
	}

	[RelayCommand]
	private async Task ActionButtonClickedAsync()
	{
		ArgumentNullException.ThrowIfNull(Action, "Action");
		if (FirstCloseThenExecuteAction)
		{
			await CloseAsync();
			await Action();
		}
		else
		{
			await Action();
			await CloseAsync();
		}
	}

	public void Opened(ImageButton? closeButton)
	{
		base.MatomoService.TrackScreen(base.PageId);
		if (base.A11YService.IsInVoiceOverMode && OperatingSystem.IsAndroid())
		{
			base.A11YService.NotifyForNewPage();
		}
		else
		{
			closeButton?.Focus();
		}
	}
}
