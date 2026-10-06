using System.Threading.Tasks;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;

namespace DigiD.Common.Interfaces;

public interface IEIDApi
{
	Task<ConfirmResponse> Confirm(BaseEIDRequest requestData);

	Task<WidSessionResponse> InitSessionEID(WidSessionRequest requestData);

	Task<ApiResult> CancelAuthenticate();

	Task<ApiResult> AbortAuthentication(AbortAuthenticationRequest requestData);

	Task<WidPollResponse> Poll();
}
