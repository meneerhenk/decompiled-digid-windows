using System.Net.Http;
using System.Threading.Tasks;
using DigiD.Common.Http;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Models.Responses;
using Microsoft.Extensions.Logging;

namespace DigiD.Mobile.Api;

public class AccountInformationApi : BaseApiService, IAccountInformationApi
{
	public AccountInformationApi(ILogger<AccountInformationApi> logger, IGeneralPreferences preferences, IHttpClientFactory factory)
		: base(logger, preferences, factory)
	{
	}

	public async Task<TwoFactorResponseModel> GetTwoFactorStatus()
	{
		return await PostAsync<TwoFactorResponseModel>("apps/two_factor/get_two_factor", new BaseMyDigiDRequest());
	}

	public async Task<AccountStatusResponse> GetAccountStatus()
	{
		return await PostAsync<AccountStatusResponse>("apps/account_status", new BaseMyDigiDRequest());
	}

	public async Task<ApiResult> SetTwoFactor(bool enabled)
	{
		return (await PostAsync<BaseResponse>("apps/two_factor/change_two_factor", new SetTwoFactorRequestModel(enabled))).ApiResult;
	}
}
