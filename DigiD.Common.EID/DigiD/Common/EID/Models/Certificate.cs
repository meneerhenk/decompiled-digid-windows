using System.Linq;
using Org.BouncyCastle.Asn1;

namespace DigiD.Common.EID.Models;

public class Certificate
{
	public byte[] Body { get; private set; } = null;

	public byte[] Signature { get; private set; } = null;

	public byte[] CardAuthReference { get; private set; } = null;

	public byte[] PublicKeyOID { get; private set; } = null;

	public byte[] CardHolderReference { get; private set; } = null;

	public byte[] ChatOID { get; private set; } = null;

	public byte[] ChatDiscretionaryData { get; private set; } = null;

	public byte[] CertRelativeAuth { get; private set; } = null;

	public Certificate(byte[] certBytes)
	{
		using Asn1InputStream asn1InputStream = new Asn1InputStream(certBytes);
		DerSequence o = (DerSequence)asn1InputStream.ReadObject();
		Parse(o);
	}

	private void Parse(DerSequence o)
	{
		Asn1Sequence instance = Asn1Sequence.GetInstance(o);
		Body = instance[0].ToAsn1Object().GetEncoded();
		Signature = instance[1].ToAsn1Object().GetEncoded();
		Asn1Sequence instance2 = Asn1Sequence.GetInstance(((DerTaggedObject)instance[0]).GetBaseUniversal(declaredExplicit: false, 16));
		CardAuthReference = instance2[1].ToAsn1Object().GetEncoded().Skip(2)
			.ToArray();
		Asn1Sequence instance3 = Asn1Sequence.GetInstance(((DerTaggedObject)instance2[2]).GetBaseUniversal(declaredExplicit: false, 16));
		PublicKeyOID = instance3[0].ToAsn1Object().GetEncoded().Skip(2)
			.ToArray();
		CardHolderReference = instance2[3].ToAsn1Object().GetEncoded().Skip(3)
			.ToArray();
		instance3 = Asn1Sequence.GetInstance(((DerTaggedObject)instance2[4]).GetBaseUniversal(declaredExplicit: false, 16));
		ChatOID = instance3[0].ToAsn1Object().GetEncoded();
		ChatDiscretionaryData = instance3[1].ToAsn1Object().GetEncoded();
		CertRelativeAuth = instance2[7].ToAsn1Object().GetEncoded();
	}
}
