using System.Net.Http;
using System.Threading.Tasks;
using DigiD.Common.Http;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.ResponseModels;
using Microsoft.Extensions.Logging;

namespace DigiD.Common.Api;

public class VersionApi : BaseApiService, IVersionApi
{
	public VersionApi(ILogger<VersionApi> logger, IGeneralPreferences preferences, IHttpClientFactory factory)
		: base(logger, preferences, factory)
	{
	}

	public async Task<VersionCheckResponse> CheckVersion()
	{
		return await GetAsync<VersionCheckResponse>("apps/version");
	}
}
