using System.Threading.Tasks;
using DigiD.Common.Enums;
using DigiD.Common.Http.Demo;
using DigiD.Common.Http.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.SessionModels;
using Microsoft.Extensions.Logging;

namespace DigiD.Common.Api.Demo;

public class EIDApi : BaseApiService, IEIDApi
{
	public EIDApi(ILogger<EIDApi> logger)
		: base(logger)
	{
	}

	public async Task<WidSessionResponse> InitSessionEID(WidSessionRequest requestData)
	{
		await Task.Delay(20);
		DemoSession session = DemoHelper.GetSession(requestData.AppSessionId);
		WidSessionResponse response = new WidSessionResponse
		{
			ApiResult = ApiResult.Ok
		};
		if (session != null && !string.IsNullOrEmpty(session.Action))
		{
			response.Action = session.Action;
			switch (session.Action)
			{
			case "activate_identity_card":
			case "activate_driving_licence":
				HttpSession.SetAuthenticationType(AuthenticationType.None);
				break;
			case "webservice":
				response.WebService = "DigiD Demo EID";
				break;
			}
		}
		return response;
	}

	public async Task<ConfirmResponse> Confirm(BaseEIDRequest requestData)
	{
		DemoSession session = DemoHelper.GetSession(requestData.AppSessionId);
		await Task.Delay(0);
		return new ConfirmResponse
		{
			ApiResult = ApiResult.Ok,
			NeedDeactivation = (session != null && session.Action == "deactivate_app")
		};
	}

	public async Task<ApiResult> CancelAuthenticate()
	{
		await Task.Delay(100);
		return ApiResult.Ok;
	}

	public async Task<ApiResult> AbortAuthentication(AbortAuthenticationRequest requestData)
	{
		await Task.Delay(100);
		return ApiResult.Ok;
	}

	public async Task<WidPollResponse> Poll()
	{
		await Task.Delay(500);
		return new WidPollResponse
		{
			ApiResult = ApiResult.Verified
		};
	}
}
