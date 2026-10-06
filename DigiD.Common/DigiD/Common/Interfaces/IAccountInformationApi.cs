using System.Threading.Tasks;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.ResponseModels;

namespace DigiD.Common.Interfaces;

public interface IAccountInformationApi
{
	Task<TwoFactorResponseModel> GetTwoFactorStatus();

	Task<AccountStatusResponse> GetAccountStatus();

	Task<ApiResult> SetTwoFactor(bool enabled);
}
