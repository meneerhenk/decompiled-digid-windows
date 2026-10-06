using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.Interfaces;

namespace DigiD.Common.EID.CardSteps.BAC;

public class StepActiveAuthentication : BaseSecureCardOperation, IStep
{
	public StepActiveAuthentication(Gap gap)
		: base(gap)
	{
	}
}
