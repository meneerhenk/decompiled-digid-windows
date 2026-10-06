using System.Collections.Generic;
using System.Threading.Tasks;
using DigiD.Common.EID.Models.CardFiles;
using DigiD.Common.Models;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.Responses;
using DigiD.Common.SessionModels;

namespace DigiD.Common.Interfaces;

public interface IRdaApi
{
	void Initialize(RdaSession session);

	Task<InitSessionResponse> InitSessionRDA();

	Task<BaseResponse> Documents();

	Task<RdaSessionResponse> Poll();

	Task<ApiResult> Verified();

	Task<BaseResponse> Cancel();

	Task<RdaStartResponse> Start(string type, EFCardAccess? cardAccess);

	Task<SelectResponse> Challenge(string challenge);

	Task<CommandResponse> Authenticate(string? authenticate, string? challenge);

	Task<CommandResponse> SecureMessaging(List<string> responses);

	Task<PrepareResponseModel> Prepare(byte[] encryptedNonce);

	Task<MapResponseModel> Map(byte[] mappedNonce);

	Task<AgreeKeyResponseModel> KeyAgreement(byte[] keyAgree);

	Task<MutualAuthResponseModel> MutualAuthenticate(byte[]? authenticate, byte[]? encryptedNonce = null);
}
