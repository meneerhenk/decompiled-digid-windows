using System;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.Models.CardFiles;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Models.Helpers;
using DigiD.Common.NFC.Enums;

namespace DigiD.Common.EID.CardSteps.FileOperations;

internal class StepReadDG14 : BaseSecureStep, IStep
{
	public StepReadDG14(ISecureCardOperation operation)
		: base(operation)
	{
	}

	public async Task<bool> Execute()
	{
		ISecureCardOperation operation = base.Operation;
		Gap gap = ((!(operation is Gap op)) ? base.Operation.GAP : op);
		ArgumentNullException.ThrowIfNull(EIDSession.Card, "EIDSession.Card");
		if (EIDSession.Card.DataGroups.ContainsKey(14))
		{
			return true;
		}
		CardFile f = new CardFile(P1.CHILD_EF, ((EIDSession.Card.DocumentType == DocumentType.DrivingLicense) ? "00-0E" : "01-0E").ToBytes());
		DG14 file = await SelectAndReadFile.Execute<DG14>(f, gap.SMContext);
		if (file == null)
		{
			return false;
		}
		EIDSession.Card.DataGroups.Add(14, file);
		return true;
	}
}
