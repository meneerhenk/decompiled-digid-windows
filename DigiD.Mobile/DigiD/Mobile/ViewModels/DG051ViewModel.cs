using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Pages.Pages;
using DigiD.Common.Pages.ViewModels;
using DigiD.Common.Preferences;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using DigiD.Common.ViewModels;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Pages;
using Microsoft.Maui.ApplicationModel;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG051ViewModel : EidViewModel
{
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? startScanCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand StartScanCommand => startScanCommand ?? (startScanCommand = new AsyncRelayCommand(StartScanAsync));

	public DG051ViewModel(IEIDOperationService eIDOperationService, IEIDApi eIDApi, IAlertService alertService, IAuthenticationService authenticationService, IConfirmService confirmService, IToastService toastService, IAppAttestApi attestApi, IAttestationService attestationService, IMobileSettings mobileSettings, IAppService appService, IDeviceLockService deviceLockService)
	{
		_003CauthenticationService_003EP = authenticationService;
		_003CattestApi_003EP = attestApi;
		_003CattestationService_003EP = attestationService;
		_003CmobileSettings_003EP = mobileSettings;
		_003CappService_003EP = appService;
		base._002Ector(eIDOperationService, eIDApi, alertService, confirmService, toastService, deviceLockService);
	}

	protected override Task DeactivateApp()
	{
		return MainThread.InvokeOnMainThreadAsync(async delegate
		{
			await _003CappService_003EP.Deactivate(null);
			AppSession.Reset();
			await base.ToastService.ShowSuccess(CommonResources.FM064_Body);
		});
	}

	protected override Task NavigateToOverview(PinCodeModel? pinCodeModel)
	{
		if (EIDSession.ActivationState == EIDActivationState.Randomize)
		{
			return base.NavigationService.NavigateAsync<DG087, DG087ViewModel>(delegate(DG087ViewModel vm)
			{
				vm.Initialize(base.Model, pinCodeModel);
			});
		}
		return base.NavigationService.NavigateAsync<DG085, DG085ViewModel>(delegate(DG085ViewModel vm)
		{
			vm.Initialize(base.Model, pinCodeModel);
		});
	}

	[RelayCommand]
	private async Task StartScanAsync()
	{
		await Start();
	}

	protected override async Task GoToPinCodePage(PinCodeModel model)
	{
		await base.DialogService.Hide();
		if (model != null && model.IsWIDActivation && !model.TriesLeft.HasValue)
		{
			EIDSession.ActivationState++;
			await NavigateToOverview(model);
		}
		await base.NavigationService.PushModalAsync<PinCodePage, PinCodeViewModel>(delegate(PinCodeViewModel vm)
		{
			vm.IsCardAuthentication = true;
			vm.Initialize(model);
		});
	}

	protected override Task PopToRoot()
	{
		EIDSession.Card = null;
		HttpSession.WidSessionResponse = null;
		return base.NavigationService.PopToRootAsync();
	}

	protected override async Task AttestApp()
	{
		if (_003CmobileSettings_003EP.LoginLevel >= LoginLevel.Hoog)
		{
			return;
		}
		KeyAttestChallengeResponse challengeResponse = await _003CattestApi_003EP.Challenge();
		if (challengeResponse.ApiResult != ApiResult.Ok)
		{
			return;
		}
		KeyAttestationRequestModel attestationData = await _003CattestationService_003EP.Attest(challengeResponse.Challenge.Hash());
		if (attestationData != null)
		{
			HttpSession.AppSessionId = challengeResponse.SessionId;
			KeyAttestUpgradeRequest model = new KeyAttestUpgradeRequest
			{
				AppId = _003CmobileSettings_003EP.AppId,
				KeyAttestationData = attestationData
			};
			KeyAttestUpgradeResponse upgradeResponse = await _003CattestApi_003EP.Upgrade(model);
			if (upgradeResponse.ApiResult == ApiResult.Ok)
			{
				_003CmobileSettings_003EP.LoginLevel = upgradeResponse.AuthenticationLevel;
				_003CmobileSettings_003EP.HighAttestationKeyId = attestationData.KeyID;
			}
			else
			{
				_003CmobileSettings_003EP.HighAttestationKeyId = null;
			}
		}
		else
		{
			_003CmobileSettings_003EP.HighAttestationKeyId = null;
		}
	}

	protected override Task CancelAction(bool retry)
	{
		return base.NavigationService.PushModalAsync<DG084, DG084ViewModel>(delegate(DG084ViewModel vm)
		{
			vm.Initialize(async delegate
			{
				await base.NavigationService.PopCurrentModalPage();
			});
		});
	}

	public override async Task RandomizationComplete()
	{
		if (HttpSession.IsWeb2AppSession && !DemoSettings.IsDemoModeEnabled)
		{
			ArgumentNullException.ThrowIfNull(base.Model.EIDSessionResponse, "Model.EIDSessionResponse");
			base.A11YService.Speak(CommonResources.x_LoginSuccessMessage);
			await _003CauthenticationService_003EP.ProcessWebAuthentication(base.Model.EIDSessionResponse.ReturnURL);
		}
	}

	protected override Task ActionCompleted(MessageType successMessageType)
	{
		return MainThread.InvokeOnMainThreadAsync(async delegate
		{
			switch (successMessageType)
			{
			case MessageType.ResumePincodeSuccess:
				await base.ToastService.ShowSuccess(CommonResources.x_WIDResumePINSuccessMessage);
				break;
			case MessageType.ChangePincodeSuccess:
				await AlertService.DisplayAlert(AlertMessageType.FM086);
				await PopToRoot();
				break;
			case MessageType.ActivationCompleted:
				await base.ToastService.ShowSuccess(string.Format(CommonResources.WIDActivationSuccessMessage, EidViewModel.DocumentName), null, popToRoot: false);
				EIDSession.ActivationState = EIDActivationState.Completed;
				await base.NavigationService.NavigateAsync<DG085, DG085ViewModel>(delegate(DG085ViewModel vm)
				{
					vm.Initialize(null, null);
				});
				break;
			case MessageType.ActivationFailed:
				await base.ToastService.ShowWarning(string.Format(CommonResources.x_WIDActivationFailedMessage, EidViewModel.DocumentName), null, popToRoot: false);
				await PopToRoot();
				break;
			case MessageType.LoginSuccess:
				break;
			}
		});
	}
}
