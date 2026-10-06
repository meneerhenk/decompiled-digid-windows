using System;
using System.Net.Http;
using System.Threading.Tasks;
using DigiD.Common.EID.Interfaces.Api;
using DigiD.Common.EID.Models.Network.Requests;
using DigiD.Common.EID.Models.Network.Responses;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Http;
using DigiD.Common.Interfaces;
using Microsoft.Extensions.Logging;

namespace DigiD.Common.EID.Api;

public class RDWApi : BaseApiService, IRDWApi
{
	public RDWApi(ILogger<RDWApi> logger, IGeneralPreferences preferences, IHttpClientFactory factory)
		: base(logger, preferences, factory)
	{
	}

	public async Task<AtCertificateResponse> GetCertificates(EIDBaseRequest request)
	{
		Uri uri = new Uri(EIDSession.Host + "/v1/getcertificate");
		return await PostAsync<AtCertificateResponse>(uri, request);
	}

	public async Task<SetupSecureMessagingResponse> SetupSecureChannel(EIDBaseRequest request)
	{
		Uri uri = new Uri(EIDSession.Host + "/v1/secapdu");
		return await PostAsync<SetupSecureMessagingResponse>(uri, request);
	}

	public async Task<SendSecureCommandsResponse> SendCommands(EIDBaseRequest request)
	{
		Uri uri = new Uri(EIDSession.Host + "/v1/polymorph/data");
		return await PostAsync<SendSecureCommandsResponse>(uri, request);
	}

	public async Task<PcaChallengeResponse> Challenge(EIDBaseRequest request)
	{
		Uri uri = new Uri(EIDSession.Host + "/v1/signature");
		return await PostAsync<PcaChallengeResponse>(uri, request);
	}

	public async Task<PcaInfoServerResponse> SendPCAInfo(EIDBaseRequest request)
	{
		Uri uri = new Uri(EIDSession.Host + "/v1/polymorph/info");
		return await PostAsync<PcaInfoServerResponse>(uri, request);
	}
}
