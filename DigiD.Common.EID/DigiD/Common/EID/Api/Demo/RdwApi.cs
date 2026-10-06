using System;
using System.Threading.Tasks;
using DigiD.Common.EID.Interfaces.Api;
using DigiD.Common.EID.Models.Network.Requests;
using DigiD.Common.EID.Models.Network.Responses;
using DigiD.Common.Http.Demo;
using Microsoft.Extensions.Logging;

namespace DigiD.Common.EID.Api.Demo;

public class RdwApi : BaseApiService, IRDWApi
{
	public RdwApi(ILogger<BaseApiService> logger)
		: base(logger)
	{
	}

	public Task<AtCertificateResponse> GetCertificates(EIDBaseRequest request)
	{
		throw new NotImplementedException();
	}

	public Task<SetupSecureMessagingResponse> SetupSecureChannel(EIDBaseRequest request)
	{
		throw new NotImplementedException();
	}

	public Task<SendSecureCommandsResponse> SendCommands(EIDBaseRequest request)
	{
		throw new NotImplementedException();
	}

	public Task<PcaChallengeResponse> Challenge(EIDBaseRequest request)
	{
		throw new NotImplementedException();
	}

	public Task<PcaInfoServerResponse> SendPCAInfo(EIDBaseRequest request)
	{
		throw new NotImplementedException();
	}
}
