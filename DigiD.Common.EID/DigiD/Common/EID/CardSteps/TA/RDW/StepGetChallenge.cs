using System;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.NFC.Models;

namespace DigiD.Common.EID.CardSteps.TA.RDW;

internal class StepGetChallenge : BaseSecureStep, IStep
{
	public StepGetChallenge(ISecureCardOperation operation)
		: base(operation)
	{
	}

	public async Task<bool> Execute()
	{
		ArgumentNullException.ThrowIfNull(base.Operation.GAP?.SMContext, "Operation.GAP?.SMContext");
		CommandApdu command = CommandApduBuilder.GetChallengeCommand(base.Operation.GAP.SMContext);
		ResponseApdu response = await CommandApduBuilder.SendAPDU("TA GetChallenge", command, base.Operation.GAP.SMContext);
		if (response.SW == 36864)
		{
			((TerminalAuthenticationRdw)base.Operation).Ricc = response.Data;
			return true;
		}
		return false;
	}
}
