using System;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.Models.CardFiles;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.NFC.Models;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;

namespace DigiD.Common.EID.CardSteps.CAv1;

internal class StepGeneralAuthenticate : BaseSecureStep, IStep
{
	public StepGeneralAuthenticate(ISecureCardOperation operation)
		: base(operation)
	{
	}

	public async Task<bool> Execute()
	{
		byte[] pk = Array.Empty<byte>();
		ArgumentNullException.ThrowIfNull(EIDSession.Card, "EIDSession.Card");
		ArgumentNullException.ThrowIfNull(base.Operation.GAP?.SMContext, "Operation.GAP?.SMContext");
		CommandApdu command = CommandApduBuilder.GetGeneralAuthenticateCAv1(pk, base.Operation.GAP.SMContext);
		ECPrivateKeyParameters skPCD = default(ECPrivateKeyParameters);
		DG14 dg14 = default(DG14);
		int num;
		if ((await CommandApduBuilder.SendAPDU("CAv1 General Authenticate", command, base.Operation.GAP.SMContext)).SW == 36864)
		{
			AsymmetricKeyParameter asymmetricKeyParameter = base.Operation.GAP.Pace?.EphemeralKeyPair?.Private;
			skPCD = asymmetricKeyParameter as ECPrivateKeyParameters;
			if (skPCD != null)
			{
				File file = EIDSession.Card.DataGroups[14];
				dg14 = file as DG14;
				num = ((dg14 != null && dg14.ChipAuthenticationPublicKeyInfo != null) ? 1 : 0);
				goto IL_01a5;
			}
		}
		num = 0;
		goto IL_01a5;
		IL_01a5:
		if (num != 0)
		{
			ECPublicKeyParameters pkPICC = SecurityHelper.DecodeKey(dg14.ChipAuthenticationPublicKeyInfo.Pk, ChipAuthenticationPublicKeyInfo.Algorithm);
			byte[] sharedSecretX = SecurityHelper.GenerateSharedSecret(skPCD, pkPICC).AffineXCoord.GetEncoded();
			byte[] kEnc = SecurityHelper.CalculateKEnc(sharedSecretX, EIDSession.Card);
			byte[] kMac = SecurityHelper.CalculateKMac(sharedSecretX, EIDSession.Card);
			base.Operation.GAP.SMContext.Init(kEnc, kMac);
			return true;
		}
		return false;
	}
}
