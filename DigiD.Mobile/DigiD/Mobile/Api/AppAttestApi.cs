using System.Net.Http;
using System.Threading.Tasks;
using DigiD.Common.Http;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using Microsoft.Extensions.Logging;

namespace DigiD.Mobile.Api;

internal class AppAttestApi : BaseApiService, IAppAttestApi
{
	public AppAttestApi(ILogger<BaseApiService> logger, IGeneralPreferences preferences, IHttpClientFactory factory)
		: base(logger, preferences, factory)
	{
	}

	public async Task<KeyAttestChallengeResponse> Challenge()
	{
		return await PostAsync<KeyAttestChallengeResponse>("apps/wid/challenge", new BaseAuthSessionRequest());
	}

	public async Task<KeyAttestUpgradeResponse> Upgrade(KeyAttestUpgradeRequest model)
	{
		return await PostAsync<KeyAttestUpgradeResponse>("apps/wid/upgrade", model);
	}
}
