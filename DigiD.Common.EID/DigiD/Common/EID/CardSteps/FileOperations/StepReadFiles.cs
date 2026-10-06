using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.SessionModels;

namespace DigiD.Common.EID.CardSteps.FileOperations;

internal class StepReadFiles : BaseSecureStep, IStep
{
	internal StepReadFiles(ISecureCardOperation operation)
		: base(operation)
	{
	}

	public async Task<bool> Execute()
	{
		ISecureCardOperation operation = base.Operation;
		Gap gap = ((!(operation is Gap operation2)) ? base.Operation.GAP : operation2);
		return await EIDSession.Card.ReadFiles(gap.SMContext);
	}
}
