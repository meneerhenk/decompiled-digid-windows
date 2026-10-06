using System.Net.Http;
using System.Threading.Tasks;
using DigiD.Common.Http;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Models.Responses;
using DigiD.Common.SessionModels;
using Microsoft.Extensions.Logging;

namespace DigiD.Mobile.Api;

public class EnrollmentApi : BaseApiService, IEnrollmentApi
{
	public EnrollmentApi(ILogger<EnrollmentApi> logger, IGeneralPreferences preferences, IHttpClientFactory factory)
		: base(logger, preferences, factory)
	{
	}

	public async Task<BasicAuthenticationResponse> BasicAuthenticate(BasicAuthenticateRequest requestData)
	{
		return await PostAsync<BasicAuthenticationResponse>("apps/auth", requestData);
	}

	public async Task<SessionResponse> InitSession(BasicAuthenticationSessionRequest requestData)
	{
		return await PostAsync<SessionResponse>("apps/session", requestData);
	}

	public async Task<EnrollmentChallengeResponse> EnrollmentChallenge(EnrollmentChallengeRequest requestData)
	{
		return await PostAsync<EnrollmentChallengeResponse>("apps/challenge_activation", requestData);
	}

	public async Task<CompleteChallengeResponse> CompleteChallenge(CompleteChallengeRequest requestData)
	{
		return await PostAsync<CompleteChallengeResponse>("apps/challenge_response", requestData);
	}

	public async Task<CompleteActivationResponse> CompleteActivationAsync(PincodeRequest requestData)
	{
		return await PostAsync<CompleteActivationResponse>("apps/pincode", requestData);
	}

	public async Task<BaseResponse> InitSessionLetterActivation()
	{
		return await PostAsync<BaseResponse>("apps/letter", new BaseRequest());
	}

	public async Task<BaseResponse> InitSessionActivationRDA()
	{
		var data = new
		{
			app_session_id = HttpSession.AppSessionId,
			re_request = false
		};
		return await PostAsync<BaseResponse>("apps/rda_activation", data);
	}

	public async Task<BaseResponse> LetterActivationPolling()
	{
		return await PostAsync<BaseResponse>("apps/letter_poll", new BaseRequest());
	}

	public async Task<InitSessionResponse> InitSessionActivationCode(ActivationCodeSessionRequest requestData)
	{
		return await PostAsync<InitSessionResponse>("apps/activationcode_session", requestData);
	}

	public async Task<ActivationLetterResponse> CompleteLetterActivation(LetterActivationRequest requestData)
	{
		return await PostAsync<ActivationLetterResponse>("apps/activationcode", requestData);
	}

	public async Task<ResendSMSResponse> ResendSMS(bool spoken)
	{
		return await PostAsync<ResendSMSResponse>("apps/resend_sms", new ResendSmsRequest(spoken));
	}

	public async Task<RequestSmsResponse> SendSMS()
	{
		return await PostAsync<RequestSmsResponse>("apps/sms", new BaseRequest());
	}

	public async Task<BaseResponse> VerifyRDAActivation()
	{
		return await PostAsync<BaseResponse>("apps/rda_activation_verified", new BaseRequest());
	}

	public async Task<StartSessionResponse> InitSessionActivationByApp()
	{
		return await GetAsync<StartSessionResponse>("apps/activate/start");
	}

	public async Task<AuthenticationStatusResponse> ActivationByAppPolling()
	{
		return await PostAsync<AuthenticationStatusResponse>("apps/authentication_status", new BaseRequest());
	}

	public async Task<ActivationLetterResponse> ActivateAccountByApp(LetterActivationRequest requestData)
	{
		return await PostAsync<ActivationLetterResponse>("apps/activationcode_account", requestData);
	}

	public async Task<RequestAccountResponse> InitSessionAccountRequest(RequestAccountRequest requestData)
	{
		return await PostAsync<RequestAccountResponse>("apps/account_requests/start", requestData);
	}

	public async Task<BaseResponse> AccountRequestsCheckApp(BaseRequest requestData)
	{
		return await PostAsync<BaseResponse>("apps/account_requests/existing_application", requestData);
	}

	public async Task<BaseResponse> AccountRequestsReplaceApp(ReplaceExistingApplicationRequest requestData)
	{
		return await PostAsync<BaseResponse>("apps/account_requests/replace_application", requestData);
	}

	public async Task<BaseResponse> AccountRequestsCheckAccount(BaseRequest requestData)
	{
		return await PostAsync<BaseResponse>("apps/account_requests/existing_account", requestData);
	}

	public async Task<BaseResponse> AccountRequestsReplaceAccount(ReplaceExistingAccountRequest requestData)
	{
		return await PostAsync<BaseResponse>("apps/account_requests/replace_account", requestData);
	}

	public async Task<BaseResponse> AccountRequestsBrpPoll(BaseRequest requestData)
	{
		return await PostAsync<BaseResponse>("apps/account_requests/brp_poll", requestData);
	}

	public async Task<BaseResponse> SkipRda()
	{
		return await PostAsync<BaseResponse>("apps/skip_rda", new BaseRequest());
	}
}
