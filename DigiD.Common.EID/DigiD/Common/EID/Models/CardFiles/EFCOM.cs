using System;
using System.Collections.Generic;
using System.Linq;
using BerTlv;
using DigiD.Common.EID.Helpers;

namespace DigiD.Common.EID.Models.CardFiles;

public class EFCOM : File
{
	public byte[] SupportedTags { get; private set; } = null;

	public EFCOM(byte[] data)
		: base(data, "EFCOM")
	{
	}

	public override bool Parse()
	{
		ICollection<Tlv> source = Tlv.ParseTlv(base.Bytes);
		SupportedTags = source.First().FindTag("5C")?.Value ?? Array.Empty<byte>();
		return true;
	}
}
