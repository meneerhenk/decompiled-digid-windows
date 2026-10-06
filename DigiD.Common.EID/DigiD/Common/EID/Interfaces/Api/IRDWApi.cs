using System.Threading.Tasks;
using DigiD.Common.EID.Models.Network.Requests;
using DigiD.Common.EID.Models.Network.Responses;

namespace DigiD.Common.EID.Interfaces.Api;

public interface IRDWApi
{
	Task<AtCertificateResponse> GetCertificates(EIDBaseRequest request);

	Task<SetupSecureMessagingResponse> SetupSecureChannel(EIDBaseRequest request);

	Task<SendSecureCommandsResponse> SendCommands(EIDBaseRequest request);

	Task<PcaChallengeResponse> Challenge(EIDBaseRequest request);

	Task<PcaInfoServerResponse> SendPCAInfo(EIDBaseRequest request);
}
