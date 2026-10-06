using System.Collections.Generic;
using System.Linq;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;

namespace DigiD.Common.EID.Models.CardFiles;

public class EF_SOd : File
{
	internal Dictionary<int, byte[]> Hashes = new Dictionary<int, byte[]>();

	internal SignedData SignedData { get; private set; } = null;

	public EF_SOd(byte[] data)
		: base(data, "EF.SOd")
	{
	}

	public override bool Parse()
	{
		using Asn1InputStream asn1InputStream = new Asn1InputStream(base.Bytes);
		if (asn1InputStream.ReadObject() is DerTaggedObject derTaggedObject && derTaggedObject.GetBaseObject() is DerSequence derSequence)
		{
			DerObjectIdentifier derObjectIdentifier = (DerObjectIdentifier)derSequence[0];
			if (derObjectIdentifier.Id != "1.2.840.113549.1.7.2")
			{
				return false;
			}
			DerSequence obj = (DerSequence)((DerTaggedObject)derSequence[1]).GetBaseObject();
			SignedData = Org.BouncyCastle.Asn1.Cms.SignedData.GetInstance(obj);
			DerTaggedObject derTaggedObject2 = (DerTaggedObject)derSequence[1];
			DerSequence derSequence2 = (DerSequence)derTaggedObject2.GetBaseObject();
			DerSequence derSequence3 = (DerSequence)derSequence2[2];
			DerTaggedObject derTaggedObject3 = (DerTaggedObject)derSequence3[1];
			DerOctetString derOctetString = (DerOctetString)derTaggedObject3.GetBaseObject();
			DerSequence derSequence4 = (DerSequence)Asn1Object.FromByteArray(derOctetString.GetOctets());
			DerSequence source = (DerSequence)derSequence4[2];
			foreach (DerSequence item in source.Cast<DerSequence>())
			{
				int intValue = ((DerInteger)item[0]).PositiveValue.IntValue;
				Hashes.Add(intValue, ((Asn1OctetString)item[1]).GetOctets());
			}
			return true;
		}
		return false;
	}
}
