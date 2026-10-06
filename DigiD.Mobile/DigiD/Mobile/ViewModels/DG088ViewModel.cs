using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.EID.Helpers;
using DigiD.Common.Enums;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Requests;
using DigiD.Common.Models.Responses;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using DigiD.Mobile.Helpers;
using Microsoft.Maui.Controls;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG088ViewModel : CommonBaseViewModel
{
	private readonly IBiometricService biometricService;

	private readonly AppConfig appConfig;

	private SecureString _pin = new SecureString();

	private bool resultSet;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ImageSource _003CImageSource_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? skipCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? nextCommand;

	public bool DisplayToast { get; set; } = true;

	public required TaskCompletionSource<bool> Response { get; set; }

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public ImageSource ImageSource
	{
		get
		{
			return _003CImageSource_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<Microsoft.Maui.Controls.ImageSource>.Default.Equals(_003CImageSource_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.ImageSource);
				_003CImageSource_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.ImageSource);
			}
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand SkipCommand => skipCommand ?? (skipCommand = new AsyncRelayCommand(SkipAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand NextCommand => nextCommand ?? (nextCommand = new AsyncRelayCommand(NextAsync));

	public DG088ViewModel(IBiometricService biometricService, AppConfig appConfig)
	{
		this.biometricService = biometricService;
		this.appConfig = appConfig;
		base.HasBackButton = false;
		string arg = AppSession.BiometricType.Translate();
		base.HeaderText = string.Format(DigiDAppResources.DG088_Title, arg);
		base.MessageText = string.Format(DigiDAppResources.DG088_Message, arg, AppSession.BiometricType.TranslateType());
		ImageSource = GetImageSource();
	}

	[RelayCommand]
	private Task SkipAsync()
	{
		base.MatomoService.TrackAction("Biometrics", "Enrollement " + AppSession.BiometricType.Translate(), "Overgeslagen");
		Preferences.BiometricsState = BiometricsState.NotUsed;
		return SetResult(success: false);
	}

	protected override Task EnterPressed()
	{
		return NextAsync();
	}

	[RelayCommand]
	private async Task NextAsync()
	{
		BiometricsAuthenticationRequest request = new BiometricsAuthenticationRequest(DigiDAppResources.BiometricsPromptTitle, CommonResources.Alg_Cancel)
		{
			Subtitle = string.Format(DigiDAppResources.BiometricsSubtitle, AppSession.BiometricType.TranslateType()),
			Secret = _pin.ToBytes(),
			IsEnrollment = true
		};
		CancellationTokenSource cts = new CancellationTokenSource();
		cts.CancelAfter(TimeSpan.FromSeconds(appConfig.BiometricsTimeout));
		BiometricsAuthenticationResponse result = await biometricService.AuthenticateAsync(request, cts.Token);
		cts.Dispose();
		if (result.Status != BiometricResponseStatus.Cancelled)
		{
			Preferences.BiometricsState = ((result.Status == BiometricResponseStatus.Success) ? BiometricsState.Enrolled : BiometricsState.NotUsed);
			if (Preferences.BiometricsState == BiometricsState.Enrolled && DisplayToast)
			{
				string translate = AppSession.BiometricType.Translate();
				await base.ToastService.ShowSuccess(string.Format(DigiDAppResources.DG089_BiometricsEnabled, translate), null, popToRoot: false);
			}
		}
		await SetResult(result.Status == BiometricResponseStatus.Success);
	}

	private async Task SetResult(bool success)
	{
		if (!resultSet)
		{
			resultSet = true;
			base.MatomoService.TrackAction("Biometrics", "Enrollement " + AppSession.BiometricType.Translate(), success ? "Succesvol" : "Mislukt");
			_pin = new SecureString();
			await base.NavigationService.PopCurrentModalPage();
			Response.SetResult(success);
		}
	}

	public void SetPin(SecureString pin)
	{
		_pin = new SecureString();
		string text = pin.ToPlain();
		foreach (char c in text)
		{
			_pin.AppendChar(c);
		}
	}

	private ImageSource GetImageSource()
	{
		return biometricService.BiometricType switch
		{
			BiometricType.FaceID => "digid_afbeelding_biometrics_faceid.png", 
			BiometricType.TouchID => "digid_afbeelding_biometrics_touchid.png", 
			BiometricType.FingerPrint => "digid_afbeelding_biometrics_fingerprint.png", 
			_ => string.Empty, 
		};
	}
}
