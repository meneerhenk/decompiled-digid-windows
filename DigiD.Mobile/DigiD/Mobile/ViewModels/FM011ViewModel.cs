using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Helpers;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Resources;
using DigiD.Mobile.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.ApplicationModel;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class FM011ViewModel : CommonBaseViewModel
{
	private Func<Task>? _confirm;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CDeviceName_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int _003CMaxAmount_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? confirmCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? cancelCommand;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? DeviceName
	{
		get
		{
			return _003CDeviceName_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CDeviceName_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.DeviceName);
				_003CDeviceName_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.DeviceName);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int MaxAmount
	{
		get
		{
			return _003CMaxAmount_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<int>.Default.Equals(_003CMaxAmount_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.MaxAmount);
				_003CMaxAmount_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.MaxAmount);
			}
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand ConfirmCommand => confirmCommand ?? (confirmCommand = new AsyncRelayCommand(ConfirmAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand CancelCommand => cancelCommand ?? (cancelCommand = new AsyncRelayCommand(CancelAsync));

	public void Initialize(ActivationResponse model, Func<Task> confirm)
	{
		base.PageId = "FM011";
		_confirm = confirm;
		MaxAmount = model.MaxAmount;
		base.MessageText = string.Format(CultureInfo.InvariantCulture, CommonResources.FM011_Message, model.MaxAmount);
		DeviceName = model.DeviceName;
		base.HasBackButton = false;
	}

	[RelayCommand]
	private async Task ConfirmAsync()
	{
		await base.NavigationService.PopCurrentModalPage();
		if (_confirm != null)
		{
			await _confirm();
		}
	}

	[RelayCommand]
	private async Task CancelAsync()
	{
		await base.ServiceProvider.GetRequiredService<ISessionService>().CancelSession(byUser: true, async delegate
		{
			await base.NavigationService.PopCurrentModalPage();
			await Browser.OpenAsync("gTYB9n9QAVxxd2UAzyjF8K7Nqac7Ow==".DeObfuscate("6UJ1hgxqLnMcHg9u4Uysl8eph8lXFG4L/RoM8Ry1knA="));
		});
	}
}
