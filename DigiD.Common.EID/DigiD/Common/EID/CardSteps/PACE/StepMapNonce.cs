using System;
using System.Threading.Tasks;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Models.Apdu;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.NFC.Models;

namespace DigiD.Common.EID.CardSteps.PACE;

internal class StepMapNonce(Gap gap) : IStep
{
	public async Task<bool> Execute()
	{
		ArgumentNullException.ThrowIfNull(gap.Pace?.EphemeralKeyPair, "gap.Pace?.EphemeralKeyPair");
		ArgumentNullException.ThrowIfNull(EIDSession.Card?.EF_CardAccess, "EIDSession.Card?.EF_CardAccess");
		byte[] pk = SecurityHelper.DecodeECPublicKeyX509(gap.Pace.EphemeralKeyPair.Public);
		CommandApdu command = CommandApduBuilder.GetMapCommand(pk, gap.SMContext);
		ResponseApdu response = await CommandApduBuilder.SendAPDU("PACE MapNonce", command, gap.SMContext);
		if (response.SW == 36864)
		{
			XYResponseAPDU mapResponse = new XYResponseAPDU(response);
			gap.Pace.CardPublicKey = SecurityHelper.DecodeKey(mapResponse, EIDSession.Card.EF_CardAccess.PaceInfo.Algorithm);
			return true;
		}
		return false;
	}
}
