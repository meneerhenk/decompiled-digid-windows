using System.Threading.Tasks;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Interfaces;

public interface IEnrollmentApi
{
	Task<InitSessionResponse> InitSessionActivationCode(ActivationCodeSessionRequest requestData);

	Task<EnrollmentChallengeResponse> EnrollmentChallenge(EnrollmentChallengeRequest requestData);

	Task<CompleteChallengeResponse> CompleteChallenge(CompleteChallengeRequest requestData);

	Task<CompleteActivationResponse> CompleteActivationAsync(PincodeRequest requestData);

	Task<BasicAuthenticationResponse> BasicAuthenticate(BasicAuthenticateRequest requestData);

	Task<SessionResponse> InitSession(BasicAuthenticationSessionRequest requestData);

	Task<BaseResponse> InitSessionLetterActivation();

	Task<BaseResponse> LetterActivationPolling();

	Task<ActivationLetterResponse> CompleteLetterActivation(LetterActivationRequest requestData);

	Task<ResendSMSResponse> ResendSMS(bool spoken);

	Task<RequestSmsResponse> SendSMS();

	Task<BaseResponse> InitSessionActivationRDA();

	Task<BaseResponse> VerifyRDAActivation();

	Task<StartSessionResponse> InitSessionActivationByApp();

	Task<AuthenticationStatusResponse> ActivationByAppPolling();

	Task<ActivationLetterResponse> ActivateAccountByApp(LetterActivationRequest requestData);

	Task<RequestAccountResponse> InitSessionAccountRequest(RequestAccountRequest requestData);

	Task<BaseResponse> AccountRequestsCheckApp(BaseRequest requestData);

	Task<BaseResponse> AccountRequestsReplaceApp(ReplaceExistingApplicationRequest requestData);

	Task<BaseResponse> AccountRequestsBrpPoll(BaseRequest requestData);

	Task<BaseResponse> AccountRequestsCheckAccount(BaseRequest requestData);

	Task<BaseResponse> AccountRequestsReplaceAccount(ReplaceExistingAccountRequest requestData);

	Task<BaseResponse> SkipRda();
}
