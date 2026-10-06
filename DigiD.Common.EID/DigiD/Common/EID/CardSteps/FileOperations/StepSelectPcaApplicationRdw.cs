using System;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.Exceptions;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.NFC.Models;

namespace DigiD.Common.EID.CardSteps.FileOperations;

internal class StepSelectPcaApplicationRdw : BaseSecureStep, IStep
{
	public StepSelectPcaApplicationRdw(ISecureCardOperation operation)
		: base(operation)
	{
	}

	public async Task<bool> Execute()
	{
		ISecureCardOperation operation = base.Operation;
		if (operation.GAP == null)
		{
			operation.GAP = (Gap)base.Operation;
		}
		ArgumentNullException.ThrowIfNull(EIDSession.Card, "EIDSession.Card");
		CommandApdu command = CommandApduBuilder.GetSelectApplicationCommand(EIDSession.Card.PolymorphicAID, base.Operation.GAP.SMContext);
		ResponseApdu response = await CommandApduBuilder.SendAPDU("SelectPCAApplication", command, base.Operation.GAP.SMContext);
		switch (response.SW1)
		{
		case 144:
			return true;
		case 105:
			return true;
		case 99:
			base.Operation.GAP.ChangePinRequired = true;
			base.Operation.GAP.PinTriesLeft = (byte)response.SW2 & 0xF;
			throw new TransportPinException();
		default:
			return false;
		}
	}
}
