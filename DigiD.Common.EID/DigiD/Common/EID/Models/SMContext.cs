using System;
using Org.BouncyCastle.Math;

namespace DigiD.Common.EID.Models;

public class SMContext(byte[]? kEnc = null, byte[]? kMac = null, byte[]? ssc = null)
{
	private byte[]? _ssc = ssc;

	internal bool IsBAC
	{
		get
		{
			byte[]? ssc = ssc;
			return ssc != null && ssc.Length == 8;
		}
	}

	internal byte[]? KEnc { get; private set; } = kEnc;

	internal byte[]? KMac { get; private set; } = kMac;

	internal byte[] IncrementSSC()
	{
		ArgumentNullException.ThrowIfNull(ssc, "_ssc");
		BigInteger value = new BigInteger("1");
		byte[] array = new BigInteger(ssc).Add(value).ToByteArray();
		Buffer.BlockCopy(array, 0, ssc, ssc.Length - array.Length, array.Length);
		return ssc;
	}

	internal void Init(byte[] kEnc, byte[] kMac)
	{
		KEnc = kEnc;
		KMac = kMac;
		ssc = new byte[16];
	}
}
