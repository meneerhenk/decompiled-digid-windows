using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Models.SecurityInfoObjects;
using Org.BouncyCastle.Asn1;

namespace DigiD.Common.EID.Models.CardFiles;

public sealed class EFCardAccess : File
{
	public PaceInfo PaceInfo { get; private set; } = null;

	public CAInfo CAInfo { get; private set; } = null;

	public CADomainParameterInfo CADomainParameters { get; private set; } = null;

	public TAInfo TAInfo { get; private set; } = null;

	public EFCardAccess(byte[]? data)
		: base(data, "EF.EF_CardAccess")
	{
	}

	public override bool Parse()
	{
		if (base.Bytes == null)
		{
			return false;
		}
		foreach (Asn1Encodable item in (Asn1Set)Asn1Object.FromByteArray(base.Bytes))
		{
			DerSequence sequence = (DerSequence)item;
			IAsn1Info asn1Info = InfoFactory.Parse(sequence);
			IAsn1Info asn1Info2 = asn1Info;
			IAsn1Info asn1Info3 = asn1Info2;
			if (!(asn1Info3 is TAInfo tAInfo))
			{
				if (!(asn1Info3 is CAInfo cAInfo))
				{
					if (!(asn1Info3 is PaceInfo paceInfo))
					{
						if (asn1Info3 is CADomainParameterInfo cADomainParameters)
						{
							CADomainParameters = cADomainParameters;
						}
					}
					else
					{
						PaceInfo = paceInfo;
					}
				}
				else
				{
					CAInfo = cAInfo;
				}
			}
			else
			{
				TAInfo = tAInfo;
			}
		}
		return true;
	}
}
