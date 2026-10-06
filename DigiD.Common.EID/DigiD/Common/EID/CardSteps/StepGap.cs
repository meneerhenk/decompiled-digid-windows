using System;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.CardSteps.Randomize;
using DigiD.Common.EID.Enums;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Models;

namespace DigiD.Common.EID.CardSteps;

public class StepGap(CardCredentials? credentials, PasswordType passwordType, GapType type, BaseSecureCardOperation operation, Action progressChangedAction, EidSessionData? eidSessionData = null) : IStep
{
	public async Task<bool> Execute()
	{
		operation.GAP = new Gap(operation, credentials, passwordType, progressChangedAction, eidSessionData);
		if (!(await operation.GAP.Init(type)))
		{
			return false;
		}
		if (!(await operation.GAP.Execute()))
		{
			return false;
		}
		return true;
	}
}
