using System;
using Org.BouncyCastle.Asn1.Cms;

namespace DigiD.Common.EID.CardSteps.PA;

public static class CmsVerifier
{
	public static ContentInfo Verify(this SignedData signedData, ContentInfo signedMessage, DateTime date)
	{
		SignedData instance = SignedData.GetInstance(signedMessage);
		return instance.EncapContentInfo;
	}
}
