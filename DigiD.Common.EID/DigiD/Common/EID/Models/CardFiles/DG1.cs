using System.Collections.Generic;
using System.Linq;
using System.Text;
using BerTlv;
using DigiD.Common.EID.Helpers;

namespace DigiD.Common.EID.Models.CardFiles;

public class DG1 : File
{
	public string? MRZ { get; private set; }

	public DG1(byte[] data)
		: base(data, "DG1")
	{
	}

	public override bool Parse()
	{
		ICollection<Tlv> collection = Tlv.ParseTlv(base.Bytes);
		if (collection.Count == 1)
		{
			Tlv tlv = collection.First().FindTag("5F1F");
			Tlv tlv2 = collection.First().FindTag("5F02");
			if (tlv != null)
			{
				MRZ = Encoding.ASCII.GetString(tlv.Value);
			}
			else if (tlv2 != null)
			{
				MRZ = Encoding.ASCII.GetString(tlv2.Value);
			}
			return true;
		}
		return false;
	}
}
