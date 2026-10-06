using System.Threading.Tasks;
using DigiD.Common.Http.Demo;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Config;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Models.Responses;
using DigiD.Common.Preferences;
using Microsoft.Extensions.Logging;

namespace DigiD.Mobile.Api.Demo;

public class AccountInformationApi : BaseApiService, IAccountInformationApi
{
	public AccountInformationApi(ILogger<AccountInformationApi> logger)
		: base(logger)
	{
	}

	public async Task<TwoFactorResponseModel> GetTwoFactorStatus()
	{
		await Task.Delay(20);
		TwoFactorResponseModel result = new TwoFactorResponseModel();
		if (DemoConfig.ActivationMethod == ActivationMethod.RequestNewDigidAccount)
		{
			result.ApiResult = ApiResult.Nok;
			result.ErrorMessage = "no_username_password";
		}
		else
		{
			result.ApiResult = ApiResult.Ok;
			result.Enabled = DemoSettings.TwoFactorEnabled ?? DemoConfig.TwoFactorEnabled;
		}
		return SendAsync("/apps/two_factor/get_two_factor", new BaseRequest(), result);
	}

	public async Task<AccountStatusResponse> GetAccountStatus()
	{
		await Task.Delay(20);
		return SendAsync(responseData: new AccountStatusResponse
		{
			ApiResult = ApiResult.Ok,
			UnreadMessagesCount = DemoConfig.UnreadMessagesCount
		}, url: "apps/account_status", requestData: new BaseRequest());
	}

	public async Task<ApiResult> SetTwoFactor(bool enabled)
	{
		await Task.Delay(20);
		DemoSettings.TwoFactorEnabled = enabled;
		return SendAsync("/apps/two_factor/change_two_factor", new { enabled }, new BaseResponse
		{
			ApiResult = ApiResult.Ok
		}).ApiResult;
	}
}
