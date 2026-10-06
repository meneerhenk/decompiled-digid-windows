using System.Threading.Tasks;
using DigiD.Common.Helpers;
using DigiD.Common.Http.Demo;
using DigiD.Common.Http.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Models.Responses;
using Microsoft.Extensions.Logging;

namespace DigiD.Mobile.Api.Demo;

public class ChangePinApi : BaseApiService, IChangePinApi
{
	public ChangePinApi(ILogger<ChangePinApi> logger)
		: base(logger)
	{
	}

	public async Task<StartSessionBaseResponse> InitSession()
	{
		await Task.Delay(0);
		return SendAsync("/apps/change_pin/request_session", new BaseRequest(), new StartSessionBaseResponse
		{
			ApiResult = ApiResult.Ok,
			AppSessionId = DemoHelper.NewSession("change_app_pin"),
			At = DateHelper.GetEpochSeconds()
		});
	}

	public async Task<BaseResponse> ChangePin(string encryptedPin)
	{
		await Task.Delay(0);
		return SendAsync("/apps/change_pin/request_pin_change", new ChangePinRequest(encryptedPin), new BaseResponse
		{
			ApiResult = ApiResult.Ok
		});
	}
}
