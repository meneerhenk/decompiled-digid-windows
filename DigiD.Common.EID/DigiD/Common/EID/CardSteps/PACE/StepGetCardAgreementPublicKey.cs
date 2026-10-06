using System;
using System.Threading.Tasks;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Models.Apdu;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.NFC.Models;

namespace DigiD.Common.EID.CardSteps.PACE;

internal class StepGetCardAgreementPublicKey(Gap gap) : IStep
{
	public async Task<bool> Execute()
	{
		ArgumentNullException.ThrowIfNull(gap.Pace?.AgreementKeyPair, "gap.Pace?.AgreementKeyPair");
		byte[] pk = SecurityHelper.DecodeECPublicKeyX509(gap.Pace.AgreementKeyPair.Public);
		CommandApdu command = CommandApduBuilder.GetPairAgreementCommand(pk, gap.SMContext);
		ResponseApdu response = await CommandApduBuilder.SendAPDU("PACE GetCardAgreementPublicKey", command, gap.SMContext);
		if (response.SW == 36864)
		{
			ArgumentNullException.ThrowIfNull(EIDSession.Card?.EF_CardAccess, "EIDSession.Card?.EF_CardAccess");
			XYResponseAPDU agreementResp = new XYResponseAPDU(response);
			gap.Pace.CardAgreedPublicKey = SecurityHelper.DecodeKey(agreementResp, EIDSession.Card.EF_CardAccess.PaceInfo.Algorithm);
			return true;
		}
		return false;
	}
}
