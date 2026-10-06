using System;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.CardSteps;
using DigiD.Common.EID.Enums;

namespace DigiD.Common.EID.CardOperations;

public class StatusOperation : BaseSecureCardOperation
{
	public StatusOperation(PasswordType passwordType, Action<float> progressChangedAction)
	{
		_003CpasswordType_003EP = passwordType;
		base._002Ector(progressChangedAction);
	}

	internal override async Task Init()
	{
		await base.Init();
		base.Steps.Add(new StepGap(null, _003CpasswordType_003EP, GapType.PaceStatus, this, base.ChangeProgress));
	}
}
