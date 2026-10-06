using System.Collections.Generic;
using System.Threading.Tasks;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.Models.CardFiles;
using DigiD.Common.Models.Helpers;
using DigiD.Common.NFC.Enums;
using Org.BouncyCastle.Crypto.Parameters;

namespace DigiD.Common.EID.Cards;

public class eNIK : Card
{
	internal List<string> TACommands { get; set; } = new List<string>();

	internal List<string> PCACommands { get; set; } = new List<string>();

	internal ECPublicKeyParameters? CardAuthenticationPublicKey { get; set; }

	internal EFCVCA? CVCA { get; set; }

	internal override async Task<bool> ReadFiles(SMContext? context)
	{
		base.EFCOM = await SelectAndReadFile.Execute<EFCOM>(new CardFile(P1.CHILD_EF, "01-1E".ToBytes()), context);
		if (base.EFCOM == null)
		{
			return false;
		}
		base.EF_SOd = await SelectAndReadFile.Execute<EF_SOd>(new CardFile(P1.CHILD_EF, "01-1D".ToBytes()), context);
		if (base.EF_SOd == null)
		{
			return false;
		}
		File file = await SelectAndReadFile.Execute<DG1>(new CardFile(P1.CHILD_EF, "01-01".ToBytes()), context);
		if (file == null)
		{
			return false;
		}
		base.DataGroups.Add(1, file);
		file = await SelectAndReadFile.Execute<DG15>(new CardFile(P1.CHILD_EF, "01-0F".ToBytes()), context);
		if (file == null)
		{
			return false;
		}
		base.DataGroups.Add(15, file);
		return true;
	}
}
