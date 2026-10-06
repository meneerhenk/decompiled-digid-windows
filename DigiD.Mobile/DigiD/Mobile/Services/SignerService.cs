using System.Threading.Tasks;
using DigiD.Common.Interfaces;
using DigiD.Common.Settings;
using DigiD.Mobile.Interfaces;

namespace DigiD.Mobile.Services;

internal class SignerService(IMobileSettings mobileSettings, IAttestationService attestationService, ISigningService signingService) : ISignerService
{
	public async Task<byte[]?> SignData(string challenge)
	{
		if (mobileSettings.HighAttestationKeyId != null)
		{
			return await attestationService.Sign(challenge, mobileSettings.HighAttestationKeyId);
		}
		if (mobileSettings.SubAttestationKeyId != null)
		{
			return await attestationService.Sign(challenge, mobileSettings.SubAttestationKeyId);
		}
		return signingService.Sign(challenge);
	}

	public byte[]? GetPublicKey()
	{
		if (mobileSettings.HighAttestationKeyId != null)
		{
			return attestationService.ExportPubicKey(mobileSettings.HighAttestationKeyId);
		}
		if (mobileSettings.SubAttestationKeyId != null)
		{
			return attestationService.ExportPubicKey(mobileSettings.SubAttestationKeyId);
		}
		return signingService.ExportPublicKey();
	}
}
