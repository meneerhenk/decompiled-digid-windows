using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Models.SecurityInfoObjects;
using Org.BouncyCastle.Asn1;

namespace DigiD.Common.EID.Models.CardFiles;

public class DG14 : File
{
	public ChipAuthenticationPublicKeyInfo? ChipAuthenticationPublicKeyInfo { get; set; }

	public CAInfo? ChipAuthenticationInfo { get; set; }

	public DG14(byte[] data)
		: base(data, "EF_DG14")
	{
	}

	public override bool Parse()
	{
		using Asn1InputStream asn1InputStream = new Asn1InputStream(base.Bytes);
		if (asn1InputStream.ReadObject() is DerTaggedObject derTaggedObject && derTaggedObject.GetBaseObject() is Asn1Set set)
		{
			if (InfoFactory.Parse<CAInfo>(set) is CAInfo chipAuthenticationInfo)
			{
				ChipAuthenticationInfo = chipAuthenticationInfo;
			}
			if (InfoFactory.Parse<ChipAuthenticationPublicKeyInfo>(set) is ChipAuthenticationPublicKeyInfo chipAuthenticationPublicKeyInfo)
			{
				ChipAuthenticationPublicKeyInfo = chipAuthenticationPublicKeyInfo;
			}
			return true;
		}
		return false;
	}
}
