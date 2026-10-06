using System;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.CardSteps.FileOperations;
using DigiD.Common.EID.Interfaces;

namespace DigiD.Common.EID.CardSteps.CAv2;

public class ChipAuthenticationNik : BaseSecureCardOperation, IStep
{
	internal ChipAuthenticationNik(ISecureCardOperation operation)
		: base((Gap)operation)
	{
	}

	internal override async Task Init()
	{
		await base.Init();
		base.Steps.Add(new StepReadDG14(this));
		base.Steps.Add(new StepReadEFSOD(this));
		base.Steps.Add(new StepReadEFCVCA(this));
		base.Steps.Add(new StepSendFilesToServer(this));
		base.Steps.Add(new StepMseSetAT(this));
		base.Steps.Add(new StepGeneralAuthenticate(this));
	}

	public override void StepCompleted(IStep stepNumber)
	{
		ArgumentNullException.ThrowIfNull(base.GAP, "GAP");
		base.GAP.StepCompleted(stepNumber);
	}
}
