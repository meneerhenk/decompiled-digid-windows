using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.Cards;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.Models.CardFiles;
using DigiD.Common.EID.SessionModels;

namespace DigiD.Common.EID.CardSteps.FileOperations;

internal class StepReadEFCardSecurity : BaseSecureStep, IStep
{
	public StepReadEFCardSecurity(ISecureCardOperation operation)
		: base(operation)
	{
	}

	public async Task<bool> Execute()
	{
		EFCardSecurity file = await SelectAndReadFile.Execute<EFCardSecurity>(CardFile.EFCardSecurity, base.Operation.GAP.SMContext);
		if (file == null)
		{
			return false;
		}
		Card card = EIDSession.Card;
		if (card is DrivingLicense card2)
		{
			card2.CardSecurity = file;
		}
		return true;
	}
}
