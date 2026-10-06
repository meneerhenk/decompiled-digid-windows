using System;
using System.Threading.Tasks;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.NFC.Models;

namespace DigiD.Common.EID.CardSteps.FileOperations;

internal class StepSelectPcaApplicationNik(Gap gap) : IStep
{
	public async Task<bool> Execute()
	{
		ArgumentNullException.ThrowIfNull(EIDSession.Card, "EIDSession.Card");
		CommandApdu command = CommandApduBuilder.GetSelectApplicationCommand(EIDSession.Card.PolymorphicAID, gap.SMContext);
		return (await CommandApduBuilder.SendAPDU("SelectApplication", command, gap.SMContext)).SW1 == 144;
	}
}
