using System;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.SessionModels;

namespace DigiD.Common.EID.CardSteps.CAv1;

internal class StepVerifyAuthenticity : BaseSecureStep, IStep
{
	public StepVerifyAuthenticity(ISecureCardOperation operation)
		: base(operation)
	{
	}

	public Task<bool> Execute()
	{
		ArgumentNullException.ThrowIfNull(EIDSession.Card, "EIDSession.Card");
		return Task.FromResult(EIDSession.Card.Validate());
	}
}
