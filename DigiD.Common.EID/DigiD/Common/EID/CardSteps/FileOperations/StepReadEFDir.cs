using System.Threading.Tasks;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.Models.CardFiles;
using DigiD.Common.EID.SessionModels;

namespace DigiD.Common.EID.CardSteps.FileOperations;

internal class StepReadEFDir : IStep
{
	public async Task<bool> Execute()
	{
		Card card = EIDSession.Card;
		card.EF_Dir = await SelectAndReadFile.Execute<EFDir>(CardFile.EFDir);
		return true;
	}
}
