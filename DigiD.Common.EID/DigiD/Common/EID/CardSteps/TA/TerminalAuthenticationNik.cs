using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.CardSteps.TA.NIK;
using DigiD.Common.EID.Interfaces;

namespace DigiD.Common.EID.CardSteps.TA;

internal class TerminalAuthenticationNik : BaseSecureCardOperation, IStep
{
	internal TerminalAuthenticationNik(ISecureCardOperation operation)
		: base((Gap)operation)
	{
	}

	internal override async Task Init()
	{
		await base.Init();
		base.Steps.Add(new StepSendTACommands(this));
	}
}
