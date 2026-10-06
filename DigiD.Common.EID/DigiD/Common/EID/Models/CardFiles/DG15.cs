using System.Collections.Generic;
using BerTlv;

namespace DigiD.Common.EID.Models.CardFiles;

public class DG15 : File
{
	public DG15(byte[] data)
		: base(data, "EF_DG15")
	{
	}

	public override bool Parse()
	{
		ICollection<Tlv> collection = Tlv.ParseTlv(base.Bytes);
		return collection.Count > 0;
	}
}
