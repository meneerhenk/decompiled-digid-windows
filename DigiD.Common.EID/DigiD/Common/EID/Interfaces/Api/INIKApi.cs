using System.Threading.Tasks;
using DigiD.Common.EID.Models.Network.Requests;
using DigiD.Common.EID.Models.Network.Responses;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.EID.Interfaces.Api;

public interface INIKApi
{
	Task<PcaCommandsResponse> PreparePCA(EIDBaseRequest request);

	Task<BaseResponse> StartSession(EIDBaseRequest request);

	Task<BaseResponse> Randomize(EIDBaseRequest request);

	Task<TerminalAuthenticationCommandResponses> PrepareEAC(EIDBaseRequest request);
}
