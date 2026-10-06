using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.CardSteps.FileOperations;
using DigiD.Common.EID.Interfaces;

namespace DigiD.Common.EID.CardSteps.CAv1;

internal class ChipAuthentication : BaseSecureCardOperation, IStep
{
	internal ChipAuthentication(ISecureCardOperation operation)
		: base((Gap)operation)
	{
	}

	internal override async Task Init()
	{
		await base.Init();
		base.Steps.Add(new StepReadEFSOD(this));
		base.Steps.Add(new StepReadDG14(this));
		base.Steps.Add(new StepVerifyAuthenticity(this));
		base.Steps.Add(new StepSetAT(this));
		base.Steps.Add(new StepGeneralAuthenticate(this));
	}
}
