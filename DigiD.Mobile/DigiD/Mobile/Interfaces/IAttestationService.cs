using System.Threading.Tasks;
using DigiD.Common.Models;
using DigiD.Common.Models.Responses;

namespace DigiD.Mobile.Interfaces;

public interface IAttestationService
{
	Task<KeyAttestationRequestModel?> Attest(byte[] challenge);

	Task<byte[]?> Sign(string challenge, string keyId);

	void DeleteKey(string keyId);

	byte[]? ExportPubicKey(string keyId);

	void ProcessResponse(BaseResponse response, KeyAttestationRequestModel keyAttestModel);
}
