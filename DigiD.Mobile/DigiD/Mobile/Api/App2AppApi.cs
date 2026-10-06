using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using DigiD.Common.Http;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using Microsoft.Extensions.Logging;

namespace DigiD.Mobile.Api;

public class App2AppApi : BaseApiService, IApp2AppApi
{
	private readonly IGeneralPreferences preferences;

	public App2AppApi(ILogger<App2AppApi> logger, IGeneralPreferences preferences, IHttpClientFactory factory)
	{
		this.preferences = preferences;
		base._002Ector(logger, preferences, factory);
	}

	public async Task<InitApp2AppResponse> InitSessionApp2App(App2AppRequest requestData)
	{
		if (requestData.Destination.Contains("v4"))
		{
			List<KeyValuePair<string, string>> content = new List<KeyValuePair<string, string>>
			{
				new KeyValuePair<string, string>("SAMLRequest", requestData.SAMLRequest),
				new KeyValuePair<string, string>("Type", "app_to_app")
			};
			if (requestData.RelayState != null)
			{
				content.Add(new KeyValuePair<string, string>("RelayState", requestData.RelayState));
			}
			HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, new Uri(requestData.Destination))
			{
				Content = new FormUrlEncodedContent(content)
			};
			return await SendAsync<InitApp2AppResponse>(request);
		}
		return await PostAsync<InitApp2AppResponse>(new Uri(requestData.Destination), new StartApp2AppRequest
		{
			SAMLRequest = requestData.SAMLRequest,
			Signature = requestData.Signature,
			RelayState = requestData.RelayState,
			SigAlg = requestData.SigAlg,
			Type = "app_to_app"
		});
	}

	public async Task<SamlArtifactResponse> GetSamlArtifact(SamlArtifactRequest requestData)
	{
		string host = preferences.SelectedHost;
		Uri uri = new Uri("https://" + host + "/saml/idp/app_to_app_artifact");
		return await PostAsync<SamlArtifactResponse>(uri, requestData);
	}
}
