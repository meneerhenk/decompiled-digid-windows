using System;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.Cards;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.Models.CardFiles;
using DigiD.Common.EID.SessionModels;

namespace DigiD.Common.EID.CardSteps.FileOperations;

internal class StepReadEFCVCA : BaseSecureStep, IStep
{
	internal StepReadEFCVCA(ISecureCardOperation operation)
		: base(operation)
	{
	}

	public async Task<bool> Execute()
	{
		ArgumentNullException.ThrowIfNull(EIDSession.Card, "EIDSession.Card");
		ArgumentNullException.ThrowIfNull(base.Operation.GAP, "Operation.GAP");
		EFCVCA file = await SelectAndReadFile.Execute<EFCVCA>(CardFile.EFCVCA, base.Operation.GAP.SMContext);
		if (file == null)
		{
			return false;
		}
		((eNIK)EIDSession.Card).CVCA = file;
		return true;
	}
}
