using System.Net.Http;
using System.Threading.Tasks;
using DigiD.Common.Http;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Models.Responses;
using Microsoft.Extensions.Logging;

namespace DigiD.Mobile.Api;

public class ChangePinApi : BaseApiService, IChangePinApi
{
	public ChangePinApi(ILogger<ChangePinApi> logger, IGeneralPreferences preferences, IHttpClientFactory factory)
		: base(logger, preferences, factory)
	{
	}

	public async Task<StartSessionBaseResponse> InitSession()
	{
		return await PostAsync<StartSessionBaseResponse>("apps/change_pin/request_session", new BaseRequest());
	}

	public async Task<BaseResponse> ChangePin(string encryptedPin)
	{
		return await PostAsync<BaseResponse>("apps/change_pin/request_pin_change", new ChangePinRequest(encryptedPin));
	}
}
