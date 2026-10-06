using System;
using System.Linq;
using DigiD.Common.NFC.Helpers;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace DigiD.Common.EID.Helpers;

public static class AesHelper
{
	public static byte[] AESCBC(bool forEncryption, byte[] data, byte[] key, byte[]? iv = null)
	{
		IBufferedCipher cipher = CipherUtilities.GetCipher("AES/CBC/NoPadding");
		KeyParameter parameters = ParameterUtilities.CreateKeyParameter("AES", key);
		ParametersWithIV parameters2 = new ParametersWithIV(parameters, iv ?? new byte[16]);
		cipher.Init(forEncryption, parameters2);
		try
		{
			return cipher.DoFinal(data);
		}
		catch (Exception ex)
		{
			Debugger.DumpInfo(ex);
			throw;
		}
	}

	public static byte[] CalculateHash(byte[] data, string algorithm, int? length = null)
	{
		ArgumentNullException.ThrowIfNull(data, "data");
		IDigest digest = DigestUtilities.GetDigest(algorithm);
		digest.BlockUpdate(data, 0, data.Length);
		byte[] array = new byte[digest.GetDigestSize()];
		digest.DoFinal(array, 0);
		return length.HasValue ? array.Take(length.Value).ToArray() : array.ToArray();
	}

	public static byte[] PerformCBC8(byte[] data, byte[] key)
	{
		ArgumentNullException.ThrowIfNull(data, "data");
		CMac cMac = new CMac(new AesEngine(), 64);
		cMac.Init(new KeyParameter(key));
		byte[] array = new byte[8];
		cMac.BlockUpdate(data, 0, data.Length);
		cMac.DoFinal(array, 0);
		return array;
	}
}
