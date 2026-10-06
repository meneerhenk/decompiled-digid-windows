using System;
using System.Threading.Tasks;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Models.Helpers;
using DigiD.Common.NFC.Enums;
using DigiD.Common.NFC.Helpers;

namespace DigiD.Common.EID.CardSteps.PACE;

internal class StepValidateOperation(Gap gap) : IStep
{
	public Task<bool> Execute()
	{
		ArgumentNullException.ThrowIfNull(gap.Pace?.KEnc, "gap.Pace?.KEnc");
		ArgumentNullException.ThrowIfNull(gap.Pace?.KMac, "gap.Pace?.KMac");
		ArgumentNullException.ThrowIfNull(EIDSession.Card, "EIDSession.Card");
		if (gap.Pace.IsSuccess)
		{
			Debugger.WriteLine("PACE was successful");
			gap.SMContext = new SMContext();
			gap.SMContext.Init(gap.Pace.KEnc, gap.Pace.KMac);
			return Task.FromResult(result: true);
		}
		if (EIDSession.Card.DocumentType != DocumentType.IDCard && gap.ChangePinRequired)
		{
			Debugger.WriteLine("PACE partial complete, need change Transport PIN");
			return Task.FromResult(result: true);
		}
		Debugger.WriteLine("Terminal token: " + gap.Pace.TerminalAuthToken.ToHexString());
		Debugger.WriteLine("Card token: " + gap.Pace.CardAuthToken.ToHexString());
		Debugger.WriteLine("PACE failed");
		return Task.FromResult(result: false);
	}
}
