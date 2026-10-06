using System.Threading.Tasks;
using DigiD.Common.Http.Demo;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Config;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.ResponseModels;
using Microsoft.Extensions.Logging;

namespace DigiD.Common.Api.Demo;

public class VersionApi : BaseApiService, IVersionApi
{
	public VersionApi(ILogger<VersionApi> logger)
		: base(logger)
	{
	}

	public async Task<VersionCheckResponse> CheckVersion()
	{
		await Task.Delay(100);
		VersionCheckResponse response = new VersionCheckResponse
		{
			ApiResult = ApiResult.Ok,
			VersionAction = DemoConfig.VersionState
		};
		DemoConfig.VersionState = VersionState.Active;
		return SendAsync("apps/version", null, response);
	}
}
