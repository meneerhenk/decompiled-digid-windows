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

internal class StepReadEFSOD : BaseSecureStep, IStep
{
	internal StepReadEFSOD(ISecureCardOperation operation)
		: base(operation)
	{
	}

	public async Task<bool> Execute()
	{
		ISecureCardOperation operation = base.Operation;
		Gap gap = ((!(operation is Gap _gap)) ? base.Operation.GAP : _gap);
		ArgumentNullException.ThrowIfNull(EIDSession.Card, "EIDSession.Card");
		string fileId = ((EIDSession.Card.DocumentType == DocumentType.DrivingLicense) ? "00-1D" : "01-1D");
		EF_SOd file = await SelectAndReadFile.Execute<EF_SOd>(new CardFile(P1.CHILD_EF, fileId.ToBytes()), gap.SMContext);
		if (file == null)
		{
			return false;
		}
		EIDSession.Card.EF_SOd = file;
		return true;
	}
}
