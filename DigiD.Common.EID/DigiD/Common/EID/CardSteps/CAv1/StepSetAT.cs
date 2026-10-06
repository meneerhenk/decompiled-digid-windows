using System;
using System.Linq;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Models.CardFiles;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.NFC.Models;

namespace DigiD.Common.EID.CardSteps.CAv1;

internal class StepSetAT : BaseSecureStep, IStep
{
	public StepSetAT(ISecureCardOperation operation)
		: base(operation)
	{
	}

	public async Task<bool> Execute()
	{
		ArgumentNullException.ThrowIfNull(EIDSession.Card, "EIDSession.Card");
		ArgumentNullException.ThrowIfNull(base.Operation.GAP?.SMContext, "Operation.GAP?.SMContext");
		File file = EIDSession.Card.DataGroups[14];
		DG14 dg14 = file as DG14;
		if (dg14 != null && dg14.ChipAuthenticationInfo != null)
		{
			byte[] oid = dg14.ChipAuthenticationInfo.OID.GetEncoded().Skip(2).ToArray();
			CommandApdu command = CommandApduBuilder.GetMSESetATCAv1Command(oid, base.Operation.GAP.SMContext);
			return (await CommandApduBuilder.SendAPDU("CAv1 Set AT", command, base.Operation.GAP.SMContext)).SW == 36864;
		}
		return false;
	}
}
