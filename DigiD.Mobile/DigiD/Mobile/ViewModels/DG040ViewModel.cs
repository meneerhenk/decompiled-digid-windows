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
using Microsoft.Maui.Devices;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG040ViewModel : CommonBaseViewModel
{
	private Func<Uri?, Task>? _resultAction;

	private bool isInvoked;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsDetecting_003Ek__BackingField = true;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<Uri>? scanCompleteCommand;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsDetecting
	{
		get
		{
			return _003CIsDetecting_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsDetecting_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsDetecting);
				_003CIsDetecting_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsDetecting);
			}
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand<Uri> ScanCompleteCommand => scanCompleteCommand ?? (scanCompleteCommand = new AsyncRelayCommand<Uri>(ScanCompleteAsync));

	public DG040ViewModel()
	{
		base.CloseButtonVisible = true;
		base.HasBackButton = false;
	}

	public void Initialize(Func<Uri?, Task> resultAction)
	{
		_resultAction = resultAction;
	}

	[RelayCommand]
	private async Task ScanCompleteAsync(Uri data)
	{
		IsDetecting = false;
		Vibration.Default.Vibrate(100.0);
		if (_resultAction != null && !isInvoked)
		{
			isInvoked = true;
			await _resultAction(data);
		}
	}

	protected override async Task CloseButtonClicked()
	{
		if (_resultAction != null && !isInvoked)
		{
			isInvoked = true;
			await _resultAction(null);
		}
	}
}
