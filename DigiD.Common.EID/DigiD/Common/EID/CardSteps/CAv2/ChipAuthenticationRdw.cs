using System;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.CardSteps.FileOperations;
using DigiD.Common.EID.Cards;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.SessionModels;

namespace DigiD.Common.EID.CardSteps.CAv2;

internal class ChipAuthenticationRdw : BaseSecureCardOperation, IStep
{
	public byte[]? Ricc { get; set; }

	public byte[]? Ticc { get; set; }

	internal ChipAuthenticationRdw(ISecureCardOperation operation)
		: base((Gap)operation)
	{
	}

	internal override async Task Init()
	{
		await base.Init();
		base.Steps.Add(new StepReadEFCardSecurity(this));
		base.Steps.Add(new StepSelectMF(this));
		base.Steps.Add(new StepMseSetAT(this));
		base.Steps.Add(new StepGeneralAuthenticate(this, ((DrivingLicense)EIDSession.Card).TA?.PublicKey));
	}

	public override async Task<bool> Execute()
	{
		bool result = await base.Execute();
		ArgumentNullException.ThrowIfNull(EIDSession.Card, "EIDSession.Card");
		if (result)
		{
			((DrivingLicense)EIDSession.Card).CA = this;
		}
		return result;
	}

	public override void StepCompleted(IStep stepNumber)
	{
		ArgumentNullException.ThrowIfNull(base.GAP, "GAP");
		base.GAP.StepCompleted(stepNumber);
	}
}
