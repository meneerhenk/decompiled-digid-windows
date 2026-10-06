using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Enums;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.SessionModels;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Pages;
using Microsoft.Maui.ApplicationModel;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG039ViewModel : CommonBaseViewModel
{
	private readonly IQRCodeScannerService qRCodeScannerService;

	private readonly IIncomingDataService dataService;

	private readonly IAlertService alertService;

	private readonly IDeviceService deviceService;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CCode_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CAccessibilityCode_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? openMoreInfoCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? openQrCodeScannerCommand;

	[ObservableProperty]
	[NotifyPropertyChangedFor("IsCodeValid")]
	[NotifyPropertyChangedFor("AccessibilityCode")]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? Code
	{
		get
		{
			return _003CCode_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CCode_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.Code);
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsCodeValid);
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.AccessibilityCode);
				_003CCode_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.Code);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsCodeValid);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.AccessibilityCode);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? AccessibilityCode
	{
		get
		{
			return _003CAccessibilityCode_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CAccessibilityCode_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.AccessibilityCode);
				_003CAccessibilityCode_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.AccessibilityCode);
			}
		}
	}

	public bool IsCodeValid
	{
		get
		{
			string code = Code;
			return code != null && code.Length == 4;
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand OpenMoreInfoCommand => openMoreInfoCommand ?? (openMoreInfoCommand = new AsyncRelayCommand(OpenMoreInfoAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand OpenQrCodeScannerCommand => openQrCodeScannerCommand ?? (openQrCodeScannerCommand = new AsyncRelayCommand(OpenQrCodeScannerAsync));

	public DG039ViewModel(IQRCodeScannerService qRCodeScannerService, IIncomingDataService dataService, IAlertService alertService, IDeviceService deviceService)
	{
		this.qRCodeScannerService = qRCodeScannerService;
		this.dataService = dataService;
		this.alertService = alertService;
		this.deviceService = deviceService;
		GenerateCode();
	}

	private void GenerateCode()
	{
		char[] array = (from s in Enumerable.Repeat("BCDFGHJLMNPQRSTVWXZ", 4)
			select s[RandomNumberGenerator.GetInt32(0, s.Length - 1)]).ToArray();
		Code = new string(array);
		AccessibilityCode = $"{array[0]} {array[1]} {array[2]} {array[3]}";
	}

	[RelayCommand]
	private async Task OpenMoreInfoAsync()
	{
		await base.NavigationService.PushModalAsync<HLP007>();
	}

	[RelayCommand]
	private async Task OpenQrCodeScannerAsync()
	{
		bool flag = (uint)(await Permissions.CheckStatusAsync<Permissions.Camera>()) <= 2u;
		if (!flag || await Permissions.RequestAsync<Permissions.Camera>() == PermissionStatus.Granted)
		{
			await StartScanner();
			return;
		}
		bool? alertResult = await alertService.DisplayAlert(AlertMessageType.FM101);
		if (alertResult.HasValue && alertResult.Value)
		{
			deviceService.OpenSettings();
		}
	}

	private async Task ProcessUri(Uri uri)
	{
		HttpSession.SetAuthenticationType(AuthenticationType.None);
		HttpSession.Browser = DigiD.Common.Enums.Browser.Unknown;
		await dataService.ScanCompletedAsync(uri, Code);
	}

	private async Task StartScanner()
	{
		Uri uri = await qRCodeScannerService.StartScanner();
		if (uri != null)
		{
			await ProcessUri(uri);
		}
	}
}
