using System;
using System.Security;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.NFC.Models;

namespace DigiD.Common.EID.CardSteps.PinManagement;

internal class StepChangeReferenceData : BaseSecureStep, IStep
{
	public StepChangeReferenceData(ISecureCardOperation operation, SecureString newPin)
	{
		_003CnewPin_003EP = newPin;
		base._002Ector(operation);
	}

	public async Task<bool> Execute()
	{
		ArgumentNullException.ThrowIfNull(base.Operation.GAP?.SMContext, "Operation.GAP?.SMContext");
		CommandApdu command = CommandApduBuilder.GetChangeReferenceDataCommand(_003CnewPin_003EP, base.Operation.GAP.SMContext);
		return (await CommandApduBuilder.SendAPDU("Change Reference Data", command, base.Operation.GAP.SMContext)).SW == 36864;
	}
}
