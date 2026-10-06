using System.Threading.Tasks;
using DigiD.Common.Http.Demo;
using DigiD.Common.Http.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Config;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Models.Responses;
using DigiD.Common.SessionModels;
using Microsoft.Extensions.Logging;

namespace DigiD.Common.Api.Demo;

public class GeneralApi : BaseApiService, IGeneralApi
{
	public GeneralApi(ILogger<GeneralApi> logger)
		: base(logger)
	{
	}

	public async Task<BaseResponse> Cancel(bool cancelledByUser = false, bool timeout = false)
	{
		if (HttpSession.AppSessionId != null)
		{
			DemoHelper.Sessions.Remove(HttpSession.AppSessionId);
		}
		await Task.Delay(100);
		return SendAsync("apps/cancel_authentication?usercancel=" + (cancelledByUser ? "1" : "0") + "&timeout=" + (timeout ? "1" : "0"), new BaseMyDigiDRequest(), new BaseResponse
		{
			ApiResult = ApiResult.Ok
		});
	}

	public async Task<ConfigResponse> GetConfig()
	{
		await Task.Delay(100);
		return SendAsync("apps/config", null, new ConfigResponse
		{
			ApiResult = ApiResult.Ok,
			MaxPinChangePerDay = 3,
			RDAEnabled = true,
			LetterRequestDelay = 3,
			EHAEnabled = DemoConfig.IsEHAEnabled
		});
	}

	public Task<BaseResponse> DoHealthCheck()
	{
		BaseResponse baseResponse = new BaseResponse
		{
			ApiResult = ApiResult.Nok
		};
		if (DemoConfig.TrafficMeteringEnabled)
		{
			baseResponse.ApiResult = ApiResult.TrafficMetered;
			DemoConfig.TrafficMeteringEnabled = false;
		}
		else if (DemoConfig.MaintenanceEnabled)
		{
			baseResponse.ApiResult = ApiResult.Maintenance;
			DemoConfig.MaintenanceEnabled = false;
		}
		else if (!DemoConfig.IsHealthCheckSuccess)
		{
			baseResponse.ApiResult = ApiResult.HostNotReachable;
			DemoConfig.IsHealthCheckSuccess = true;
		}
		else
		{
			baseResponse.ApiResult = ApiResult.Ok;
		}
		return Task.FromResult(baseResponse);
	}
}
