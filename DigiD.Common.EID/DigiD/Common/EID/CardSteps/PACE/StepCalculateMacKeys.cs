using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.SessionModels;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math.EC;

namespace DigiD.Common.EID.CardSteps.PACE;

internal class StepCalculateMacKeys : IStep
{
	private readonly Gap _gap;

	public StepCalculateMacKeys(Gap gap)
	{
		_gap = gap;
	}

	public Task<bool> Execute()
	{
		ArgumentNullException.ThrowIfNull(_gap.Pace?.CardAgreedPublicKey, "_gap.Pace?.CardAgreedPublicKey");
		ArgumentNullException.ThrowIfNull(_gap.Pace?.AgreementKeyPair, "_gap.Pace?.AgreementKeyPair");
		ArgumentNullException.ThrowIfNull(EIDSession.Card, "EIDSession.Card");
		ECPrivateKeyParameters privateKey = (ECPrivateKeyParameters)_gap.Pace.AgreementKeyPair.Private;
		ECPublicKeyParameters pk = (ECPublicKeyParameters)_gap.Pace.AgreementKeyPair.Public;
		ECPublicKeyParameters cardAgreedPublicKey = _gap.Pace.CardAgreedPublicKey;
		ECPoint eCPoint = SecurityHelper.GenerateSharedSecret(privateKey, cardAgreedPublicKey);
		byte[] encoded = eCPoint.AffineXCoord.GetEncoded();
		byte[] data = SecurityHelper.DecodeECPublicKeyX509(pk);
		byte[] data2 = SecurityHelper.DecodeECPublicKeyX509(cardAgreedPublicKey);
		byte[] encoded2 = new DataObject(134, data).GetEncoded();
		byte[] encoded3 = new DataObject(134, data2).GetEncoded();
		byte[] authTokenInputData = GetAuthTokenInputData(encoded2);
		byte[] authTokenInputData2 = GetAuthTokenInputData(encoded3);
		_gap.Pace.KEnc = SecurityHelper.CalculateKEnc(encoded, EIDSession.Card);
		_gap.Pace.KMac = SecurityHelper.CalculateKMac(encoded, EIDSession.Card);
		_gap.Pace.TerminalAuthToken = AesHelper.PerformCBC8(authTokenInputData, _gap.Pace.KMac);
		_gap.Pace.TerminalToken = AesHelper.PerformCBC8(authTokenInputData2, _gap.Pace.KMac);
		return Task.FromResult(result: true);
	}

	private static byte[] GetAuthTokenInputData(IEnumerable<byte> coordinatesEncrypted)
	{
		ArgumentNullException.ThrowIfNull(EIDSession.Card?.EF_CardAccess, "EIDSession.Card?.EF_CardAccess");
		byte[] data = EIDSession.Card.EF_CardAccess.PaceInfo.OID.GetEncoded().Concat(coordinatesEncrypted).ToArray();
		return new DataObject(32585, data).GetEncoded();
	}
}
