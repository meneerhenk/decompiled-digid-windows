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
using DigiD.Common.Enums;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.Enums;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Mobile.Helpers;
using DigiD.Mobile.Pages;
using LocalizationResourceManager.Maui;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG089ViewModel : CommonBaseViewModel
{
	private readonly IBiometricService biometricService;

	private readonly IPopupService popupService;

	private readonly IDeviceService deviceService;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsEnabled_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<bool>? switchSettingCommand;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsEnabled
	{
		get
		{
			return _003CIsEnabled_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsEnabled_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsEnabled);
				_003CIsEnabled_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsEnabled);
			}
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand<bool> SwitchSettingCommand => switchSettingCommand ?? (switchSettingCommand = new AsyncRelayCommand<bool>(SwitchSettingAsync));

	public DG089ViewModel(IBiometricService biometricService, IPopupService popupService, IDeviceService deviceService)
	{
		this.biometricService = biometricService;
		this.popupService = popupService;
		this.deviceService = deviceService;
		string arg = AppSession.BiometricType.Translate();
		switch (AppSession.BiometricType)
		{
		case BiometricType.FingerPrint:
			base.HeaderText = DigiDAppResources.DG046_Fingerprint;
			base.MessageText = string.Format(DigiDAppResources.DG089_Message, arg, CommonResources.Alg_Fingerprint);
			break;
		case BiometricType.TouchID:
			base.HeaderText = DigiDAppResources.DG046_TouchID;
			base.MessageText = string.Format(DigiDAppResources.DG089_Message, arg, CommonResources.Alg_Fingerprint);
			break;
		case BiometricType.FaceID:
			base.HeaderText = DigiDAppResources.DG046_FaceID;
			base.MessageText = string.Format(DigiDAppResources.DG089_Message, arg, CommonResources.Alg_Face);
			break;
		}
		IsEnabled = Preferences.BiometricsState == BiometricsState.Enrolled;
		base.CloseButtonVisible = true;
	}

	[RelayCommand]
	private async Task SwitchSettingAsync(bool enabled)
	{
		if (enabled == IsEnabled)
		{
			return;
		}
		Preferences.BiometricsState = (enabled ? BiometricsState.PendingEnabled : BiometricsState.PendingDisabled);
		if (enabled)
		{
			if (biometricService.AuthenticationStatus == BiometricHwStatus.PermissionNotGiven)
			{
				await popupService.OpenBottomSheet("TBD", DigiDAppResources.BiometricsPermissionNotGivenTitle, DigiDAppResources.BiometricsPermissionNotGivenMessage, DigiDAppResources.BiometricsPermissionNotGivenButton, delegate
				{
					deviceService.OpenSettings();
					return Task.CompletedTask;
				});
				return;
			}
			PinCodeModel model = new PinCodeModel(PinEntryType.Authentication)
			{
				MessageText = new LocalizedString(() => base.ResourceManager["DG035C_PinConfirmText"]),
				HasBackButton = false,
				NextAction = async delegate
				{
					base.MatomoService.TrackAction("Biometrics", "Inschakelen " + AppSession.BiometricType.Translate(), "Succesvol");
					IsEnabled = enabled;
					await base.NavigationService.PopCurrentModalPage();
				},
				CancelAction = delegate
				{
					base.MatomoService.TrackAction("Biometrics", "Inschakelen " + AppSession.BiometricType.Translate(), "Geannuleerd");
					IsEnabled = false;
					Preferences.BiometricsState = ((!enabled) ? BiometricsState.Enrolled : BiometricsState.NotUsed);
					return base.NavigationService.PopCurrentModalPage();
				}
			};
			await base.NavigationService.PushModalAsync<PinCodePage, PinCodeViewModel>(delegate(PinCodeViewModel vm)
			{
				vm.Initialize(model);
			});
		}
		else
		{
			base.MatomoService.TrackAction("Biometrics", "Deactiveren " + AppSession.BiometricType.Translate(), "Succesvol");
			await ResetBiometrics();
			IsEnabled = false;
		}
	}

	private Task ResetBiometrics()
	{
		biometricService.Reset();
		Preferences.BiometricsState = BiometricsState.NotUsed;
		string arg = AppSession.BiometricType.Translate();
		return base.ToastService.ShowWarning(string.Format(DigiDAppResources.DG089_BiometricsDisabled, arg), null, popToRoot: false);
	}
}
