using System.Net.Http;
using System.Threading.Tasks;
using DigiD.Common.Http;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Models.Responses;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DigiD.Mobile.Api;

public class AuthenticationApi : BaseApiService, IAuthenticationApi
{
	public AuthenticationApi(ILogger<AuthenticationApi> logger, IGeneralPreferences preferences, IHttpClientFactory factory)
		: base(logger, preferences, factory)
	{
	}

	public async Task<BaseResponse> SessionStatus()
	{
		if (string.IsNullOrEmpty(HttpSession.AuthenticationSessionId))
		{
			return new BaseResponse
			{
				ApiResult = ApiResult.SessionNotFound
			};
		}
		return await PostAsync<StartSessionBaseResponse>("apps/session_status", new BaseRequest());
	}

	public async Task<StartSessionBaseResponse> InitSessionAuthentication()
	{
		return await GetAsync<StartSessionBaseResponse>("apps/request_session");
	}

	public async Task<ChallengeResponse> Challenge(ChallengeRequest requestData)
	{
		return await PostAsync<ChallengeResponse>("apps/challenge_auth", requestData);
	}

	public async Task<ValidatePinResponse> ValidatePin(ValidatePinRequest requestData)
	{
		return await PostAsync<ValidatePinResponse>("apps/check_pincode", requestData);
	}

	public async Task<ConfirmResponse> Confirm(ConfirmRequest requestData)
	{
		return await PostAsync<ConfirmResponse>("apps/confirm", requestData);
	}

	public Task<WebSessionInfoResponse> SessionInfo()
	{
		return PostAsync<WebSessionInfoResponse>("apps/web_session_information", new WebSessionInfoRequest());
	}

	public async Task<ApiResult> AbortAuthentication(string abortCode)
	{
		return (await PostAsync<BaseResponse>("apps/abort_authentication", new AbortAuthenticationRequest(abortCode))).ApiResult;
	}

	public async Task<ApiResult> LogOutSession(bool userAction)
	{
		return (await PostAsync<BaseResponse>(data: new LogOutSessionRequest
		{
			InstanceId = AppSession.ServiceProvider.GetRequiredService<IGeneralPreferences>().InstanceId
		}, uri: "apps/logout_session?userAction=" + (userAction ? "1" : "0"))).ApiResult;
	}

	public async Task<PendingSessionResponse> CheckPendingSession()
	{
		return await PostAsync<PendingSessionResponse>("apps/check_pending_session", new PendingSessionRequest
		{
			AppId = AppSession.ServiceProvider.GetRequiredService<IMobileSettings>().AppId
		});
	}
}
