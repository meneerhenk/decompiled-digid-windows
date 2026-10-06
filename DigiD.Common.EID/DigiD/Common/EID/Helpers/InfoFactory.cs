using System;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.Models.SecurityInfoObjects;
using Org.BouncyCastle.Asn1;

namespace DigiD.Common.EID.Helpers;

internal static class InfoFactory
{
	private const string Protocols = "2";

	private const string SmartCard = "2";

	private const string Pace = "4";

	private const string CA = "3";

	private const string TA = "2";

	private const string PK = "1";

	private static DerObjectIdentifier Base_OID = new DerObjectIdentifier("0.4.0.127.0.7");

	private static DerObjectIdentifier Pace_OID = Base_OID.Branch("2").Branch("2").Branch("4");

	private static DerObjectIdentifier CA_OID = Base_OID.Branch("2").Branch("2").Branch("3");

	private static DerObjectIdentifier TA_OID = Base_OID.Branch("2").Branch("2").Branch("2");

	private static DerObjectIdentifier PK_OID = Base_OID.Branch("2").Branch("2").Branch("1");

	internal static IAsn1Info? Parse(DerSequence sequence)
	{
		Asn1Encodable asn1Encodable = sequence[0];
		if (!(asn1Encodable is DerObjectIdentifier))
		{
			throw new ArgumentException("First object should be of type OID", "sequence");
		}
		DerObjectIdentifier derObjectIdentifier = (DerObjectIdentifier)asn1Encodable;
		if (derObjectIdentifier.Id.IndexOf(Pace_OID.Id, StringComparison.Ordinal) == 0)
		{
			return new PaceInfo(sequence);
		}
		if (derObjectIdentifier.Id.IndexOf(CA_OID.Id, StringComparison.Ordinal) == 0)
		{
			if (derObjectIdentifier.ToString().Length == 23)
			{
				return new CAInfo(sequence);
			}
			return new CADomainParameterInfo(sequence);
		}
		if (derObjectIdentifier.Id.IndexOf(TA_OID.Id, StringComparison.Ordinal) == 0)
		{
			return new TAInfo(sequence);
		}
		if (derObjectIdentifier.Id.IndexOf(PK_OID.Id, StringComparison.Ordinal) == 0)
		{
			return new ChipAuthenticationPublicKeyInfo(sequence);
		}
		return null;
	}

	internal static IAsn1Info? Parse<T>(Asn1Set set) where T : IAsn1Info
	{
		foreach (DerSequence item in set)
		{
			IAsn1Info asn1Info = Parse(item);
			if (asn1Info is T)
			{
				return asn1Info;
			}
		}
		return null;
	}
}
