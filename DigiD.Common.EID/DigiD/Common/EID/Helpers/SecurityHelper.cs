using System;
using System.Linq;
using System.Threading.Tasks;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.Models.Apdu;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;

namespace DigiD.Common.EID.Helpers;

public static class SecurityHelper
{
	public static AsymmetricCipherKeyPair GenerateKeyPair(X9ECParameters param, ECPoint? point = null)
	{
		ArgumentNullException.ThrowIfNull(param, "param");
		ECKeyPairGenerator eCKeyPairGenerator = new ECKeyPairGenerator();
		ECDomainParameters domainParameters = new ECDomainParameters(param.Curve, point ?? param.G, param.N, param.H, param.GetSeed());
		eCKeyPairGenerator.Init(new ECKeyGenerationParameters(domainParameters, new SecureRandom()));
		return eCKeyPairGenerator.GenerateKeyPair();
	}

	public static ECPoint GenerateSharedSecret(ECPrivateKeyParameters privateKey, ECPublicKeyParameters publicKey)
	{
		ArgumentNullException.ThrowIfNull(publicKey, "publicKey");
		ArgumentNullException.ThrowIfNull(privateKey, "privateKey");
		ECPoint eCPoint = publicKey.Q.Multiply(privateKey.D).Normalize();
		if (eCPoint.IsInfinity)
		{
			throw new ArgumentException("Infinity is not a valid agreement value for ECDH", "publicKey");
		}
		return eCPoint;
	}

	public static Task<AsymmetricCipherKeyPair> GenerateKeyPairAgreement(ECPublicKeyParameters publicKey, ECPrivateKeyParameters privateKey, byte[] nonce, X9ECParameters param)
	{
		ArgumentNullException.ThrowIfNull(param, "param");
		byte[] encoded = GenerateSharedSecret(privateKey, publicKey).GetEncoded(compressed: false);
		byte[] encoded2 = CalculateECDHGenericMapping(nonce, encoded, param);
		ECPoint point = param.Curve.DecodePoint(encoded2);
		return Task.FromResult(GenerateKeyPair(param, point));
	}

	private static byte[] CalculateECDHGenericMapping(byte[] nonce, byte[] sharedSecret, X9ECParameters param)
	{
		ECPoint eCPoint = param.Curve.CreatePoint(param.G.AffineXCoord.ToBigInteger(), param.G.AffineYCoord.ToBigInteger());
		BigInteger b = new BigInteger(1, nonce);
		ECPoint b2 = param.Curve.DecodePoint(sharedSecret);
		ECPoint eCPoint2 = eCPoint.Multiply(b).Add(b2);
		return eCPoint2.GetEncoded(compressed: false);
	}

	private static ECPublicKeyParameters CreateParameters(byte[] x, byte[] y, X9ECParameters param)
	{
		BigInteger x2 = new BigInteger(1, x);
		BigInteger y2 = new BigInteger(1, y);
		ECPoint q = param.Curve.CreatePoint(x2, y2);
		ECDomainParameters parameters = new ECDomainParameters(param.Curve, param.G, param.N, param.H);
		return new ECPublicKeyParameters(q, parameters);
	}

	public static ECPublicKeyParameters DecodeKey(XYResponseAPDU response, X9ECParameters param)
	{
		return CreateParameters(response.PointX, response.PointY, param);
	}

	public static ECPublicKeyParameters DecodeKey(byte[] encoded, X9ECParameters param)
	{
		byte[] x = encoded.Take(encoded.Length / 2).ToArray();
		byte[] y = encoded.Skip(encoded.Length / 2).ToArray();
		return CreateParameters(x, y, param);
	}

	internal static byte[] CalculateKEnc(byte[] secretX, Card card)
	{
		byte[] data = secretX.Concat(new byte[4] { 0, 0, 0, 1 }).ToArray();
		return AesHelper.CalculateHash(data, card.MessageDigestAlgorithm, card.KeyLength);
	}

	internal static byte[] CalculateKMac(byte[] secretX, Card card)
	{
		byte[] data = secretX.Concat(new byte[4] { 0, 0, 0, 2 }).ToArray();
		return AesHelper.CalculateHash(data, card.MessageDigestAlgorithm, card.KeyLength);
	}

	public static byte[] DecodeECPublicKeyX509(AsymmetricKeyParameter pk)
	{
		SubjectPublicKeyInfo subjectPublicKeyInfo = SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(pk);
		return subjectPublicKeyInfo.PublicKey.GetOctets();
	}

	internal static byte[] Sign(AsymmetricKeyParameter privateKey, byte[] message, string algoritm)
	{
		ISigner signer = SignerUtilities.GetSigner(algoritm);
		signer.Init(forSigning: true, privateKey);
		signer.BlockUpdate(message, 0, message.Length);
		return signer.GenerateSignature();
	}
}
