using System.Threading.Tasks;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.NFC.Enums;
using DigiD.Common.NFC.Models;

namespace DigiD.Common.EID.CardSteps.FileOperations;

internal class StepSelectMF : IStep
{
	private Gap? _gap;

	private readonly ISecureCardOperation? _operation;

	public StepSelectMF(ISecureCardOperation operation)
	{
		_operation = operation;
	}

	public StepSelectMF(Gap gap)
	{
		_gap = gap;
	}

	public async Task<bool> Execute()
	{
		if (_gap == null)
		{
			_gap = _operation?.GAP;
		}
		CommandApdu command = CommandApduBuilder.GetMFSelectCommand(_gap?.SMContext, EIDSession.Card.DocumentType == DocumentType.IDCard);
		int sW = (await CommandApduBuilder.SendAPDU("Select MasterFile", command, _gap?.SMContext)).SW;
		return (sW == 27010 || sW == 36864) ? true : false;
	}
}
