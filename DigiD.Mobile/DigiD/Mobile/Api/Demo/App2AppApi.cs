using System.Threading.Tasks;
using DigiD.Common.Http.Demo;
using DigiD.Common.Http.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.SessionModels;
using Microsoft.Extensions.Logging;

namespace DigiD.Mobile.Api.Demo;

public class App2AppApi : BaseApiService, IApp2AppApi
{
	public App2AppApi(ILogger<AccountInformationApi> logger)
		: base(logger)
	{
	}

	public async Task<InitApp2AppResponse> InitSessionApp2App(App2AppRequest requestData)
	{
		await Task.Delay(0);
		InitApp2AppResponse result = new InitApp2AppResponse
		{
			ApiResult = ApiResult.Ok,
			WebSessionId = DemoHelper.NewSession("app2app"),
			ImagedDomain = requestData.ReturnUrl
		};
		result.Apps.Add(new DigiD.Common.Models.ResponseModels.App
		{
			Url = requestData.ReturnUrl,
			Name = "DigiD Demo App"
		});
		SendAsync(requestData.Destination, requestData, result);
		return result;
	}

	public async Task<SamlArtifactResponse> GetSamlArtifact(SamlArtifactRequest requestData)
	{
		await Task.Delay(0);
		SamlArtifactResponse result = new SamlArtifactResponse
		{
			ApiResult = ApiResult.Ok,
			SAMLart = "demo",
			RelayState = App2AppSession.RelayState
		};
		SendAsync("/saml/idp/app_to_app_artifact", requestData, result);
		return result;
	}
}
