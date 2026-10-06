using System.Threading.Tasks;
using DigiD.Common.EID.CardSteps.PACE;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.SessionModels;

namespace DigiD.Common.EID.CardSteps;

internal class StepGenerateKeyPair(ICardOperation operation) : IStep
{
	public Task<bool> Execute()
	{
		ICardOperation cardOperation = operation;
		ICardOperation cardOperation2 = cardOperation;
		if (cardOperation2 is PaceOperation paceOperation && EIDSession.Card?.EF_CardAccess?.PaceInfo != null)
		{
			paceOperation.EphemeralKeyPair = SecurityHelper.GenerateKeyPair(EIDSession.Card.EF_CardAccess.PaceInfo.Algorithm);
		}
		return Task.FromResult(result: true);
	}
}
