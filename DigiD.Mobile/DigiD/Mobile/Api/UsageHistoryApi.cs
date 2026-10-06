using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using DigiD.Common.Http;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.Enums;
using Microsoft.Extensions.Logging;

namespace DigiD.Mobile.Api;

public class UsageHistoryApi : BaseApiService, IUsageHistoryApi
{
	private readonly IGeneralPreferences preferences;

	public UsageHistoryApi(ILogger<UsageHistoryApi> logger, IGeneralPreferences preferences, IHttpClientFactory factory)
	{
		this.preferences = preferences;
		base._002Ector(logger, preferences, factory);
	}

	public async Task<List<UsageHistoryModel>> GetUsageHistory(int pageIndex = 0)
	{
		UsageHistoryRequestModel model = new UsageHistoryRequestModel
		{
			Language = preferences.Language.ToUpper(),
			PageId = pageIndex
		};
		UsageHistoryResponseModel result = await PostAsync<UsageHistoryResponseModel>("apps/logs/get_logs", model);
		return (result.ApiResult == ApiResult.Ok) ? result.Items : new List<UsageHistoryModel>();
	}
}
