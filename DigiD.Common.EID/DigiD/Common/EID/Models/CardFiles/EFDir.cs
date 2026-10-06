using System.Collections.Generic;
using System.Linq;
using BerTlv;

namespace DigiD.Common.EID.Models.CardFiles;

public class EFDir : File
{
	public List<byte[]> Identifiers { get; } = new List<byte[]>();

	public EFDir(byte[] data)
		: base(data, "EF_Dir")
	{
	}

	public override bool Parse()
	{
		ICollection<Tlv> collection = Tlv.ParseTlv(base.Bytes);
		foreach (Tlv item in collection)
		{
			Identifiers.Add(item.Children.First().Value);
		}
		return true;
	}
}
