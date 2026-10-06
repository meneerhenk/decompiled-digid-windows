using System.Net.Http;
using System.Threading.Tasks;
using DigiD.Common.Http;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Models.Responses;
using DigiD.Common.SessionModels;
using Microsoft.Extensions.Logging;

namespace DigiD.Common.Api;

public class EIDApi : BaseApiService, IEIDApi
{
	public EIDApi(ILogger<EIDApi> logger, IGeneralPreferences preferences, IHttpClientFactory factory)
		: base(logger, preferences, factory)
	{
	}

	public async Task<WidSessionResponse> InitSessionEID(WidSessionRequest requestData)
	{
		return await PostAsync<WidSessionResponse>("apps/wid/new", requestData);
	}

	public async Task<ConfirmResponse> Confirm(BaseEIDRequest requestData)
	{
		return await PostAsync<ConfirmResponse>("apps/wid/confirm", requestData);
	}

	public async Task<ApiResult> CancelAuthenticate()
	{
		if (string.IsNullOrEmpty(HttpSession.AppSessionId))
		{
			return ApiResult.Ok;
		}
		if (!string.IsNullOrEmpty(HttpSession.HostName))
		{
			return (await PostAsync<BaseResponse>("apps/wid/cancel_authentication", new BaseEIDRequest())).ApiResult;
		}
		return ApiResult.Aborted;
	}

	public async Task<ApiResult> AbortAuthentication(AbortAuthenticationRequest requestData)
	{
		if (string.IsNullOrEmpty(HttpSession.AppSessionId))
		{
			return ApiResult.Ok;
		}
		if (!string.IsNullOrEmpty(HttpSession.HostName))
		{
			return (await PostAsync<BaseResponse>("apps/wid/abort_authentication", requestData)).ApiResult;
		}
		return ApiResult.Aborted;
	}

	public async Task<WidPollResponse> Poll()
	{
		return await PostAsync<WidPollResponse>("apps/wid/poll", new BaseEIDRequest());
	}
}
