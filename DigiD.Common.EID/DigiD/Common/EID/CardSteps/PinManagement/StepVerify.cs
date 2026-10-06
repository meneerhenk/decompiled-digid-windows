using System;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.Enums;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Models;
using DigiD.Common.NFC.Models;

namespace DigiD.Common.EID.CardSteps.PinManagement;

internal class StepVerify : BaseSecureStep, IStep
{
	public StepVerify(ISecureCardOperation operation, CardCredentials credentials, PasswordType passwordType)
	{
		_003Ccredentials_003EP = credentials;
		_003CpasswordType_003EP = passwordType;
		base._002Ector(operation);
	}

	public async Task<bool> Execute()
	{
		ArgumentNullException.ThrowIfNull(base.Operation.GAP?.SMContext, "Operation.GAP?.SMContext");
		CommandApdu command = CommandApduBuilder.GetVerifyCommand(_003Ccredentials_003EP.Password(_003CpasswordType_003EP), _003CpasswordType_003EP, base.Operation.GAP.SMContext);
		switch ((await CommandApduBuilder.SendAPDU("Verify", command, base.Operation.GAP.SMContext)).SW)
		{
		case 36864:
			return true;
		case 25536:
			base.Operation.GAP.IsBlocked = true;
			base.Operation.GAP.AuthenticationResult = AuthenticationResult.Failed;
			break;
		}
		return false;
	}
}
