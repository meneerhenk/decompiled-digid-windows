using DigiD.Common.Models.Helpers;
using DigiD.Common.NFC.Enums;

namespace DigiD.Common.EID.Models;

public class CardFile
{
	public P1 Type { get; internal set; }

	internal byte[] Id { get; }

	public string Identifier => Id.ToHexString();

	public static CardFile EFDir => new CardFile(P1.CHILD_EF, "2F-00".ToBytes());

	public static CardFile EFCardAccess => new CardFile(P1.CHILD_EF, "01-1C".ToBytes());

	internal static CardFile EFCardSecurity => new CardFile(P1.CHILD_EF, "01-1D".ToBytes());

	internal static CardFile EFCVCA => new CardFile(P1.CHILD_EF, "01-1C".ToBytes());

	internal CardFile(P1 p1, byte[] fileId)
	{
		Type = p1;
		Id = fileId;
	}
}
