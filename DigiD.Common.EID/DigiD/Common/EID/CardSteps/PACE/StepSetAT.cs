using System;
using System.Threading.Tasks;
using DigiD.Common.EID.Cards;
using DigiD.Common.EID.Enums;
using DigiD.Common.EID.Exceptions;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.NFC.Enums;
using DigiD.Common.NFC.Exceptions;
using DigiD.Common.NFC.Models;

namespace DigiD.Common.EID.CardSteps.PACE;

internal class StepSetAT(Gap gap) : IStep
{
	public async Task<bool> Execute()
	{
		ArgumentNullException.ThrowIfNull(EIDSession.Card?.EF_CardAccess, "EIDSession.Card?.EF_CardAccess");
		ArgumentNullException.ThrowIfNull(gap.Pace, "gap.Pace");
		CommandApdu command = CommandApduBuilder.GetMSESetATCommand(certificate: (EIDSession.Card.DocumentType == DocumentType.DrivingLicense) ? ((DrivingLicense)EIDSession.Card).ATCertificate : null, paceInfo: EIDSession.Card.EF_CardAccess.PaceInfo, passwordType: gap.Pace.PasswordType, context: gap.SMContext);
		ResponseApdu response = await CommandApduBuilder.SendAPDU("PACE Set AT", command, gap.SMContext);
		switch (response.SW1)
		{
		case 144:
			gap.AuthenticationResult = AuthenticationResult.Success;
			break;
		case 99:
			gap.PinTriesLeft = (byte)response.SW2 & 0xF;
			gap.AuthenticationResult = AuthenticationResult.Failed;
			break;
		}
		if (IsSuccessOrWarning() || (response.SW == 25537 && gap.SMContext != null))
		{
			return true;
		}
		if (response.SW == 25536)
		{
			gap.IsBlocked = true;
			throw new CardBlockedException();
		}
		if (response.SW == 25537)
		{
			gap.IsSuspended = true;
			throw new CardSuspendException();
		}
		throw new CardException("Unknown response from card Set AT Pace");
		bool IsSuccessOrWarning()
		{
			int result;
			if (response.SW1 != 144)
			{
				if (response != null && response.SW1 == 99)
				{
					int sW = response.SW2;
					if (sW >= 194)
					{
						result = ((sW <= 207) ? 1 : 0);
						goto IL_004f;
					}
				}
				result = 0;
			}
			else
			{
				result = 1;
			}
			goto IL_004f;
			IL_004f:
			return (byte)result != 0;
		}
	}
}
