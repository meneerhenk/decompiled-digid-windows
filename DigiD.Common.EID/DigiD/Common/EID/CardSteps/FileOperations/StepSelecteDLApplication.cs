using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.NFC.Models;

namespace DigiD.Common.EID.CardSteps.FileOperations;

internal class StepSelecteDLApplication : BaseSecureStep, IStep
{
	internal StepSelecteDLApplication(ISecureCardOperation operation)
		: base(operation)
	{
	}

	public async Task<bool> Execute()
	{
		ISecureCardOperation operation = base.Operation;
		Gap gap = ((!(operation is Gap _gap)) ? base.Operation.GAP : _gap);
		CommandApdu command = CommandApduBuilder.GetSelectApplicationCommand(EIDSession.Card.CardAID, gap.SMContext);
		int sW = (await CommandApduBuilder.SendAPDU("SelecteDLApplication", command, gap.SMContext)).SW1;
		int num = sW;
		if (num == 144)
		{
			return true;
		}
		return false;
	}
}
