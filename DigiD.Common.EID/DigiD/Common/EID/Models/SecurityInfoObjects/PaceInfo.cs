using System;
using DigiD.Common.EID.Interfaces;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X9;

namespace DigiD.Common.EID.Models.SecurityInfoObjects;

public class PaceInfo : Asn1Encodable, IAsn1Info
{
	public DerInteger? Version { get; }

	public DerInteger? ParameterId { get; }

	public DerObjectIdentifier OID { get; set; }

	public X9ECParameters Algorithm => ECNamedCurveTable.GetByName(AlgorithmName);

	public string AlgorithmName => ParameterId?.Value.IntValue switch
	{
		8 => "secp192r1", 
		9 => "brainpoolP192r1", 
		10 => "secp224r1", 
		11 => "brainpoolP224r1", 
		12 => "prime256v1", 
		13 => "brainpoolP256r1", 
		14 => "brainpoolP320r1", 
		15 => "secp384r1", 
		16 => "brainpoolP384r1", 
		17 => "brainpoolP512r1", 
		_ => string.Empty, 
	};

	public PaceInfo(Asn1Sequence sequence)
	{
		ArgumentNullException.ThrowIfNull(sequence, "sequence");
		OID = (DerObjectIdentifier)sequence[0];
		Version = (DerInteger)sequence[1];
		if (sequence.Count > 2)
		{
			ParameterId = (DerInteger)sequence[2];
		}
	}

	public override string ToString()
	{
		return $"PaceInfo\r\nOID: {OID}\r\nVersion: {Version}\r\nParameterId:{ParameterId}\n";
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector asn1EncodableVector = new Asn1EncodableVector { OID, Version };
		if (ParameterId != null)
		{
			asn1EncodableVector.Add(ParameterId);
		}
		return new DerSequence(asn1EncodableVector);
	}
}
