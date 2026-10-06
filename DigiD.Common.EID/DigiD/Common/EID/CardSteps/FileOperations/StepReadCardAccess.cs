using System;
using System.Threading.Tasks;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.Models.CardFiles;
using DigiD.Common.EID.SessionModels;

namespace DigiD.Common.EID.CardSteps.FileOperations;

public class StepReadCardAccess : IStep
{
	public async Task<bool> Execute()
	{
		EFCardAccess file = await SelectAndReadFile.Execute<EFCardAccess>(CardFile.EFCardAccess);
		if (file == null)
		{
			return false;
		}
		ArgumentNullException.ThrowIfNull(EIDSession.Card, "EIDSession.Card");
		EIDSession.Card.EF_CardAccess = file;
		return true;
	}
}
