using System;
using System.Threading.Tasks;
using DigiD.Common.EID.Interfaces.Api;
using DigiD.Common.EID.Models.Network.Requests;
using DigiD.Common.EID.Models.Network.Responses;
using DigiD.Common.Http.Demo;
using DigiD.Common.Models.Responses;
using Microsoft.Extensions.Logging;

namespace DigiD.Common.EID.Api.Demo;

public class NikApi : BaseApiService, INIKApi
{
	public NikApi(ILogger<BaseApiService> logger)
		: base(logger)
	{
	}

	public Task<PcaCommandsResponse> PreparePCA(EIDBaseRequest request)
	{
		throw new NotImplementedException();
	}

	public Task<BaseResponse> StartSession(EIDBaseRequest request)
	{
		throw new NotImplementedException();
	}

	public Task<BaseResponse> Randomize(EIDBaseRequest request)
	{
		throw new NotImplementedException();
	}

	public Task<TerminalAuthenticationCommandResponses> PrepareEAC(EIDBaseRequest request)
	{
		throw new NotImplementedException();
	}
}
