using System;
using DigiD.Common.EID.Interfaces;
using Org.BouncyCastle.Asn1;

namespace DigiD.Common.EID.Models.SecurityInfoObjects;

public class CAInfo : Asn1Encodable, IAsn1Info
{
	public DerObjectIdentifier OID { get; }

	public DerInteger Version { get; }

	public byte[]? KeyId { get; }

	public CAInfo(Asn1Sequence sequence)
	{
		ArgumentNullException.ThrowIfNull(sequence, "sequence");
		OID = (DerObjectIdentifier)sequence[0];
		Version = (DerInteger)sequence[1];
		KeyId = ((sequence.Count == 3) ? ((DerInteger)sequence[2]).PositiveValue.ToByteArray() : null);
	}

	public override string ToString()
	{
		return $"ChipAuthenticationInfo\r\nOID: {OID}\r\nVersion: {Version}\r\n";
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector elementVector = new Asn1EncodableVector { OID, Version };
		return new DerSequence(elementVector);
	}
}
