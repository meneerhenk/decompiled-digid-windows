using System.Threading.Tasks;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Interfaces;

public interface IAuthenticationApi
{
	Task<BaseResponse> SessionStatus();

	Task<StartSessionBaseResponse> InitSessionAuthentication();

	Task<ChallengeResponse> Challenge(ChallengeRequest requestData);

	Task<ValidatePinResponse> ValidatePin(ValidatePinRequest requestData);

	Task<ConfirmResponse> Confirm(ConfirmRequest requestData);

	Task<WebSessionInfoResponse> SessionInfo();

	Task<ApiResult> AbortAuthentication(string abortCode);

	Task<ApiResult> LogOutSession(bool userAction);

	Task<PendingSessionResponse> CheckPendingSession();
}
