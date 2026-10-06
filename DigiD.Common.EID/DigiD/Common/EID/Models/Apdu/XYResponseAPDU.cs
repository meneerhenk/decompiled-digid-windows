using System;
using System.IO;
using System.Linq;
using DigiD.Common.NFC.Models;
using Greensoft.TlvLib;

namespace DigiD.Common.EID.Models.Apdu;

public class XYResponseAPDU
{
	public byte[] PointX { get; private set; } = Array.Empty<byte>();

	public byte[] PointY { get; private set; } = Array.Empty<byte>();

	public XYResponseAPDU(ResponseApdu apdu)
	{
		ArgumentNullException.ThrowIfNull(apdu, "apdu");
		byte[] data = apdu.Data;
		using MemoryStream stream = new MemoryStream(data);
		TlvEncoding.ProcessTlvStream(stream, delegate(uint tag1, byte[] d1)
		{
			using MemoryStream stream2 = new MemoryStream(d1);
			TlvEncoding.ProcessTlvStream(stream2, delegate(uint num, byte[] source)
			{
				byte[] array = source.Skip(1).ToArray();
				PointX = array.Take(array.Length / 2).ToArray();
				PointY = array.Skip(array.Length / 2).ToArray();
			});
		});
	}
}
