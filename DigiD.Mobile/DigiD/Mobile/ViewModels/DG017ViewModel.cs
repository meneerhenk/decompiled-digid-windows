using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Responses;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Pages;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG017ViewModel : BaseNfcCheckVIewModel
{
	private RdaSessionResponse? session;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? cancelScanCommand;

	public static bool IsSkipButtonVisible => HttpSession.ActivationSessionData != null;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand CancelScanCommand => cancelScanCommand ?? (cancelScanCommand = new AsyncRelayCommand(CancelScan));

	public DG017ViewModel(IActivationService activationService, INfcService nfcService, IEnrollmentApi enrollmentApi, IMobileSettings mobileSettings, IRdaService rdaService)
	{
		_003CactivationService_003EP = activationService;
		_003CenrollmentApi_003EP = enrollmentApi;
		_003CmobileSettings_003EP = mobileSettings;
		_003CrdaService_003EP = rdaService;
		base._002Ector(nfcService);
	}

	public void Initialize(RdaSessionResponse rdaSessionResponse)
	{
		session = rdaSessionResponse;
	}

	protected override async Task Next()
	{
		if (session == null)
		{
			base.DialogService.Show();
			await _003CrdaService_003EP.InitSession();
			session = await _003CrdaService_003EP.GetRdaSessionUrl();
			await base.DialogService.Hide();
			ApiResult apiResult = session.ApiResult;
			ApiResult apiResult2 = apiResult;
			if (apiResult2 == ApiResult.NoDocumentsFound)
			{
				await base.NavigationService.NavigateAsync<DG018>();
				return;
			}
		}
		await _003CrdaService_003EP.StartSession(session, RdaComplete, RdaRetry, IsSkipButtonVisible ? new Func<Task>(CancelScan) : null);
	}

	public async Task RdaRetry()
	{
		if (HttpSession.ActivationSessionData != null)
		{
			AppSession.RDASkipped = true;
			switch (HttpSession.ActivationSessionData.ActivationMethod)
			{
			case ActivationMethod.App:
				await _003CactivationService_003EP.SetPreferencesNotificationsAsync();
				break;
			case ActivationMethod.RequestNewDigidAccount:
				await _003CenrollmentApi_003EP.SkipRda();
				await _003CactivationService_003EP.SetPreferencesNotificationsAsync();
				break;
			default:
				base.DialogService.Show();
				await _003CactivationService_003EP.SkipRda();
				await base.DialogService.Hide();
				break;
			}
		}
		else
		{
			await base.ToastService.ShowError(CommonResources.Alg_UnknownErrorOccurred);
		}
	}

	private async Task RdaComplete(RdaResult result)
	{
		ActivationSessionData? activationSessionData = HttpSession.ActivationSessionData;
		if (activationSessionData != null && activationSessionData.ActivationMethod == ActivationMethod.RequestNewDigidAccount)
		{
			await _003CactivationService_003EP.HandlePendingCompletion();
			return;
		}
		switch (result)
		{
		case RdaResult.AuthenticationFailed:
			await base.NavigationService.NavigateAsync<DG025>();
			return;
		case RdaResult.Success:
			if ((await _003CenrollmentApi_003EP.VerifyRDAActivation()).ApiResult == ApiResult.Ok)
			{
				AppSession.SetNextState();
				if (HttpSession.ActivationSessionData == null)
				{
					HttpSession.ActivationSessionData = new ActivationSessionData();
				}
				HttpSession.ActivationSessionData.ActivationMethod = ActivationMethod.RDA;
				await base.NavigationService.PopToRootAsync();
			}
			else
			{
				_003CmobileSettings_003EP.Reset();
				await base.ToastService.ShowError(CommonResources.Alg_UnknownErrorOccurred);
			}
			return;
		}
		if (HttpSession.ActivationSessionData != null)
		{
			AppSession.RDASkipped = true;
			if (HttpSession.ActivationSessionData.ActivationMethod == ActivationMethod.App)
			{
				AppSession.SetNextState();
				await base.NavigationService.PopToRootAsync();
			}
			else
			{
				await _003CactivationService_003EP.SkipRda();
			}
		}
		else
		{
			await base.ToastService.ShowWarning(CommonResources.IDCheck_Cancelled_Message, null, popToRoot: false);
			await base.NavigationService.PopToRootAsync();
		}
	}

	[RelayCommand]
	private async Task CancelScan()
	{
		if (session == null)
		{
			await base.NavigationService.PopAsync();
		}
		else if (await _003CrdaService_003EP.RequestCancel())
		{
			AppSession.RDASkipped = true;
			bool flag;
			switch (HttpSession.ActivationSessionData?.ActivationMethod)
			{
			case ActivationMethod.App:
			case ActivationMethod.AccountAndApp:
			case ActivationMethod.RequestNewDigidAccount:
				flag = true;
				break;
			default:
				flag = false;
				break;
			}
			if (flag)
			{
				await _003CenrollmentApi_003EP.SkipRda();
				AppSession.SetNextState();
				await base.NavigationService.PopToRootAsync();
			}
			else
			{
				await _003CactivationService_003EP.SkipRda();
			}
		}
	}
}
