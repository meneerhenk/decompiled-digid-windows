using System;
using System.Threading;
using System.Threading.Tasks;
using DigiD.Common.BaseClasses;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Models;
using DigiD.Mobile.Pages;
using Microsoft.Maui.ApplicationModel;

namespace DigiD.Mobile.ViewModels;

public class DG008ViewModel : CommonBaseViewModel
{
	private readonly IEnrollmentApi enrollmentApi;

	private readonly IActivationService activationService;

	public DG008ViewModel(IEnrollmentApi enrollmentApi, IActivationService activationService)
	{
		base.PageId = "DG008";
		this.enrollmentApi = enrollmentApi;
		this.activationService = activationService;
		base.HasBackButton = false;
		Task.Run((Func<Task?>)StartTimer);
	}

	private async Task StartTimer()
	{
		AuthenticationStatusResponse statusResponse = await enrollmentApi.ActivationByAppPolling();
		PeriodicTimer timer = new PeriodicTimer(TimeSpan.FromSeconds(1L));
		while (true)
		{
			bool flag = await timer.WaitForNextTickAsync();
			if (flag)
			{
				ApiResult apiResult = statusResponse.ApiResult;
				bool flag2 = ((apiResult == ApiResult.Pending || apiResult == ApiResult.PendingConfirmed) ? true : false);
				flag = flag2;
			}
			if (!flag)
			{
				break;
			}
			statusResponse = await enrollmentApi.ActivationByAppPolling();
		}
		timer.Dispose();
		await MainThread.InvokeOnMainThreadAsync(async delegate
		{
			switch (statusResponse.ApiResult)
			{
			case ApiResult.Ok:
				await StartActivation();
				break;
			case ApiResult.Cancelled:
				await base.ToastService.ShowWarning(CommonResources.x_ActivationCancelledMessage);
				break;
			default:
				await base.ToastService.ShowWarning(CommonResources.x_ActivationFailedMessage);
				break;
			}
		});
	}

	private async Task StartActivation()
	{
		base.DialogService.Show();
		SessionResponse result = await activationService.InitSession();
		await base.DialogService.Hide();
		if (result.ApiResult == ApiResult.Ok)
		{
			ArgumentNullException.ThrowIfNull(result.AppId, "result.AppId");
			ActivationResult activationResult = await activationService.StartChallenge(result.AppId);
			if (activationResult.ApiResult == ApiResult.Ok)
			{
				HttpSession.ActivationSessionData.ActivationMethod = ActivationMethod.App;
				HttpSession.ActivationSessionData.IV = activationResult.IV;
				AppSession.SetNextState();
				await base.NavigationService.PopToRootAsync();
			}
			return;
		}
		string errorMessage = result.ErrorMessage;
		string text = errorMessage;
		if (!(text == "too_many_active"))
		{
			await base.ToastService.ShowWarning(CommonResources.x_ActivationFailedMessage);
			return;
		}
		await base.NavigationService.PushModalAsync<FM011, FM011ViewModel>(delegate(FM011ViewModel vm)
		{
			vm.Initialize(result, async delegate
			{
				HttpSession.RemoveOldApp = true;
				await StartActivation();
			});
		});
	}
}
