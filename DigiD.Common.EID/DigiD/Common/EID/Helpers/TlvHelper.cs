using System;
using BerTlv;

namespace DigiD.Common.EID.Helpers;

public static class TlvHelper
{
	public static Tlv? FindTag(this Tlv tlv, params string[] tags)
	{
		if (((ReadOnlySpan<string>)tags).Contains(tlv.HexTag))
		{
			return tlv;
		}
		if (tlv.Children.Count > 0)
		{
			foreach (Tlv child in tlv.Children)
			{
				Tlv tlv2 = child.FindTag(tags);
				if (tlv2 != null)
				{
					return tlv2;
				}
			}
		}
		return null;
	}
}
