using System.Threading.Tasks;
using DigiD.Common.EID.CardSteps.CAv2;
using DigiD.Common.EID.CardSteps.TA;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.Models.CardFiles;
using DigiD.Common.Models.Helpers;
using DigiD.Common.NFC.Enums;

namespace DigiD.Common.EID.Cards;

public class DrivingLicense : Card
{
	internal Certificate? ATCertificate { get; set; }

	internal TerminalAuthenticationRdw? TA { get; set; }

	internal ChipAuthenticationRdw? CA { get; set; }

	internal EFCardSecurity? CardSecurity { get; set; }

	internal override async Task<bool> ReadFiles(SMContext? context)
	{
		base.EFCOM = await SelectAndReadFile.Execute<EFCOM>(new CardFile(P1.CHILD_EF, "00-1E".ToBytes()), context);
		if (base.EFCOM == null)
		{
			return false;
		}
		base.EF_SOd = await SelectAndReadFile.Execute<EF_SOd>(new CardFile(P1.CHILD_EF, "00-1D".ToBytes()), context);
		if (base.EF_SOd == null)
		{
			return false;
		}
		if (base.DataGroups.ContainsKey(14))
		{
			return true;
		}
		File file = await SelectAndReadFile.Execute<DG14>(new CardFile(P1.CHILD_EF, "00-0E".ToBytes()), context);
		if (file == null)
		{
			return false;
		}
		base.DataGroups.Add(14, file);
		file = await SelectAndReadFile.Execute<DG1>(new CardFile(P1.CHILD_EF, "00-01".ToBytes()), context);
		if (file == null)
		{
			return false;
		}
		base.DataGroups.Add(1, file);
		file = await SelectAndReadFile.Execute<DG5>(new CardFile(P1.CHILD_EF, "00-05".ToBytes()), context);
		if (file == null)
		{
			return false;
		}
		base.DataGroups.Add(5, file);
		file = await SelectAndReadFile.Execute<DG11>(new CardFile(P1.CHILD_EF, "00-0B".ToBytes()), context);
		if (file == null)
		{
			return false;
		}
		base.DataGroups.Add(11, file);
		file = await SelectAndReadFile.Execute<DG12>(new CardFile(P1.CHILD_EF, "00-0C".ToBytes()), context);
		if (file == null)
		{
			return false;
		}
		base.DataGroups.Add(12, file);
		file = await SelectAndReadFile.Execute<DG13>(new CardFile(P1.CHILD_EF, "00-0D".ToBytes()), context);
		if (file == null)
		{
			return false;
		}
		base.DataGroups.Add(13, file);
		return true;
	}
}
