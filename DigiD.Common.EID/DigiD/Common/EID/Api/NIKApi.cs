using System;
using System.Net.Http;
using System.Threading.Tasks;
using DigiD.Common.EID.Interfaces.Api;
using DigiD.Common.EID.Models.Network.Requests;
using DigiD.Common.EID.Models.Network.Responses;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Http;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Responses;
using Microsoft.Extensions.Logging;

namespace DigiD.Common.EID.Api;

public class NIKApi : BaseApiService, INIKApi
{
	public NIKApi(ILogger<NIKApi> logger, IGeneralPreferences preferences, IHttpClientFactory factory)
		: base(logger, preferences, factory)
	{
	}

	public async Task<BaseResponse> StartSession(EIDBaseRequest request)
	{
		Uri uri = new Uri(EIDSession.Host + "/v1/nik/start");
		return await PostAsync<BaseResponse>(uri, request);
	}

	public async Task<PcaCommandsResponse> PreparePCA(EIDBaseRequest request)
	{
		Uri uri = new Uri(EIDSession.Host + "/v1/nik/preparepca");
		return await PostAsync<PcaCommandsResponse>(uri, request);
	}

	public async Task<BaseResponse> Randomize(EIDBaseRequest request)
	{
		Uri uri = new Uri(EIDSession.Host + "/v1/nik/polymorph/data");
		return await PostAsync<BaseResponse>(uri, request);
	}

	public async Task<TerminalAuthenticationCommandResponses> PrepareEAC(EIDBaseRequest request)
	{
		Uri uri = new Uri(EIDSession.Host + "/v1/nik/prepareeac");
		return await PostAsync<TerminalAuthenticationCommandResponses>(uri, request);
	}
}
