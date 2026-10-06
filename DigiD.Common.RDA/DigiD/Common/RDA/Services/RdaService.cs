using System;
using System.Threading.Tasks;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Responses;
using DigiD.Common.RDA.Pages;
using DigiD.Common.RDA.ViewModels;
using DigiD.Common.SessionModels;

namespace DigiD.Common.RDA.Services;

public class RdaService(IRdaApi api, IAlertService alertService, INavigationService navigationService) : IRdaService
{
	public async Task<InitSessionResponse> InitSession()
	{
		InitSessionResponse response = await api.InitSessionRDA();
		HttpSession.AppSessionId = response.SessionId;
		return response;
	}

	public async Task<bool> RequestCancel()
	{
		ActivationSessionData? activationSessionData = HttpSession.ActivationSessionData;
		if (activationSessionData != null && activationSessionData.ActivationMethod == ActivationMethod.Password && !(await alertService.DisplayAlert(AlertMessageType.FM099)).Value)
		{
			return false;
		}
		return true;
	}

	public async Task StartSession(RdaSessionResponse session, Func<RdaResult, Task> completeAction, Func<Task>? retryAction = null, Func<Task>? cancelAction = null)
	{
		await navigationService.NavigateAsync<DG078, DG078ViewModel>(delegate(DG078ViewModel vm)
		{
			vm.Initialize(session, completeAction, retryAction, cancelAction);
		});
	}

	public async Task<RdaSessionResponse> GetRdaSessionUrl()
	{
		ApiResult status = ApiResult.Pending;
		BaseResponse response = await api.Documents();
		if (response.ApiResult != ApiResult.Ok)
		{
			return new RdaSessionResponse
			{
				ApiResult = response.ApiResult
			};
		}
		while (status == ApiResult.Pending)
		{
			RdaSessionResponse result = await api.Poll();
			status = result.ApiResult;
			if (result.ApiResult == ApiResult.Ok)
			{
				return result;
			}
			if (status == ApiResult.Pending)
			{
				await Task.Delay(1000);
			}
		}
		return new RdaSessionResponse
		{
			ApiResult = status
		};
	}
}
