using System.Threading.Tasks;
using DigiD.Common.EID.Enums;
using DigiD.Common.EID.Interfaces;

namespace DigiD.Common.EID.CardSteps.PACE;

public class StepResetPace(PasswordType passwordType, PaceOperation pace) : IStep
{
	public Task<bool> Execute()
	{
		pace.PasswordType = passwordType;
		return Task.FromResult(result: true);
	}
}
