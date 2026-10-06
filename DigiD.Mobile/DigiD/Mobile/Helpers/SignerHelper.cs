using Org.BouncyCastle.Asn1.Sec;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Security;

namespace DigiD.Mobile.Helpers;

internal static class SignerHelper
{
	internal static bool VerifySignature(byte[] publicKey, byte[] challenge, byte[] signature)
	{
		X9ECParameters byName = SecNamedCurves.GetByName("secp256r1");
		ECPoint q = byName.Curve.DecodePoint(publicKey);
		ECPublicKeyParameters parameters = new ECPublicKeyParameters(q, new ECDomainParameters(byName.Curve, byName.G, byName.N, byName.H));
		ISigner signer = SignerUtilities.GetSigner("SHA256withECDSA");
		signer.Init(forSigning: false, parameters);
		signer.BlockUpdate(challenge, 0, challenge.Length);
		return signer.VerifySignature(signature);
	}
}
