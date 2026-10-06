using System;
using System.Threading.Tasks;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.SessionModels;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;

namespace DigiD.Common.EID.CardSteps.PACE;

internal class StepGenerateAgreementKeyPair(Gap gap) : IStep
{
	public async Task<bool> Execute()
	{
		ArgumentNullException.ThrowIfNull(gap.Pace?.CardPublicKey, "gap.Pace?.CardPublicKey");
		ArgumentNullException.ThrowIfNull(gap.Pace?.EphemeralKeyPair, "gap.Pace?.EphemeralKeyPair");
		ArgumentNullException.ThrowIfNull(gap.Pace?.DecryptedNonce, "gap.Pace?.DecryptedNonce");
		ArgumentNullException.ThrowIfNull(EIDSession.Card?.EF_CardAccess, "EIDSession.Card?.EF_CardAccess");
		AsymmetricCipherKeyPair agreementPair = await SecurityHelper.GenerateKeyPairAgreement(gap.Pace.CardPublicKey, (ECPrivateKeyParameters)gap.Pace.EphemeralKeyPair.Private, gap.Pace.DecryptedNonce, EIDSession.Card.EF_CardAccess.PaceInfo.Algorithm);
		gap.Pace.AgreementKeyPair = agreementPair;
		return true;
	}
}
