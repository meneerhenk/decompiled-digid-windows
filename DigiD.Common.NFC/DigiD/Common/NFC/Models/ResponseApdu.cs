using System;
using System.Globalization;

namespace DigiD.Common.NFC.Models;

public class ResponseApdu
{
	private readonly byte[] apdu;

	public virtual int Nr => apdu.Length - 2;

	public virtual byte[] Data
	{
		get
		{
			byte[] array = new byte[apdu.Length - 2];
			Array.Copy(apdu, 0, array, 0, array.Length);
			return array;
		}
	}

	public virtual int SW1 => apdu[apdu.Length - 2] & 0xFF;

	public virtual int SW2 => apdu[apdu.Length - 1] & 0xFF;

	public virtual int SW => (SW1 << 8) | SW2;

	public virtual byte[] Bytes => (byte[])apdu.Clone();

	public ResponseApdu(byte[] apdu)
	{
		if (apdu == null || apdu.Length < 2)
		{
			apdu = new byte[2] { 98, 0 };
		}
		apdu = (byte[])apdu.Clone();
		this.apdu = apdu;
	}

	public override string ToString()
	{
		return "ResponseApdu: " + apdu.Length + " bytes, SW=" + SW.ToString("x", CultureInfo.InvariantCulture);
	}
}
