using Org.BouncyCastle.Asn1;

namespace DigiD.Common.EID.Interfaces;

internal interface IAsn1Info
{
	DerObjectIdentifier OID { get; }
}
