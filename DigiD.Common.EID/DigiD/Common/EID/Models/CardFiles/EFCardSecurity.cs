using DigiD.Common.EID.Helpers;
using Org.BouncyCastle.Asn1;

namespace DigiD.Common.EID.Models.CardFiles;

public class EFCardSecurity : File
{
	public DerObjectIdentifier OID { get; private set; } = null;

	public byte[] KeyReference { get; private set; } = null;

	public ChipAuthenticationPublicKeyInfo ChipAuthenticationPublicKeyInfo { get; private set; } = null;

	public EFCardSecurity(byte[] data)
		: base(data, "EF.CardSecurity")
	{
	}

	public override bool Parse()
	{
		using Asn1InputStream asn1InputStream = new Asn1InputStream(base.Bytes);
		DerTaggedObject taggedObject = (DerTaggedObject)Asn1Sequence.GetInstance(asn1InputStream.ReadObject())[1];
		Asn1Sequence asn1Sequence = (Asn1Sequence)Asn1Sequence.GetInstance(taggedObject, declaredExplicit: false)[0];
		DerTaggedObject taggedObject2 = (DerTaggedObject)((Asn1Sequence)asn1Sequence[2])[1];
		byte[] octets = Asn1OctetString.GetInstance(taggedObject2, declaredExplicit: false).GetOctets();
		DerSequence sequence = (DerSequence)((DerSet)Asn1Object.FromByteArray(octets))[1];
		if (InfoFactory.Parse(sequence) is ChipAuthenticationPublicKeyInfo chipAuthenticationPublicKeyInfo)
		{
			ChipAuthenticationPublicKeyInfo = chipAuthenticationPublicKeyInfo;
			DerSequence derSequence = (DerSequence)((DerSet)Asn1Object.FromByteArray(octets))[2];
			OID = (DerObjectIdentifier)derSequence[0];
			KeyReference = ((DerInteger)derSequence[1]).PositiveValue.ToByteArray();
			return true;
		}
		return false;
	}
}
