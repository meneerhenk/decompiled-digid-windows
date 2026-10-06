using System;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.CardSteps;
using DigiD.Common.EID.CardSteps.FileOperations;
using DigiD.Common.EID.CardSteps.Randomize;
using DigiD.Common.EID.Enums;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.NFC.Enums;

namespace DigiD.Common.EID.CardOperations;

public class RandomizeOperation : BaseSecureCardOperation
{
	private readonly UserConsent _userConsent;

	private readonly CardCredentials _credentials;

	public RandomizeOperation(UserConsent userConsent, CardCredentials credentials, Action<float> progressChangedAction)
		: base(progressChangedAction)
	{
		_userConsent = userConsent;
		_credentials = credentials;
	}

	public override async Task<bool> Execute()
	{
		if (await new StepGap(eidSessionData: new EidSessionData
		{
			Consent = _userConsent
		}, credentials: _credentials, passwordType: PasswordType.PIN, type: GapType.CAv2, operation: this, progressChangedAction: base.ChangeProgress).Execute())
		{
			return await base.Execute();
		}
		return false;
	}

	internal override async Task Init()
	{
		await base.Init();
		ArgumentNullException.ThrowIfNull(EIDSession.Card, "EIDSession.Card");
		ArgumentNullException.ThrowIfNull(base.GAP, "GAP");
		if (EIDSession.Card.DocumentType == DocumentType.DrivingLicense)
		{
			base.Steps.Add(new StepGetSecureCommands(this));
			base.Steps.Add(new StepSendSecureCommandsToPca(this));
			base.Steps.Add(new StepSendResponsesToServer(this));
		}
		else
		{
			base.Steps.Add(new StepRandomizeNik(this));
			base.Steps.Add(new StepSelectPcaApplicationNik(base.GAP));
		}
	}
}
