using System;
using System.Security;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.CardSteps;
using DigiD.Common.EID.CardSteps.FileOperations;
using DigiD.Common.EID.CardSteps.PinManagement;
using DigiD.Common.EID.Enums;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.NFC.Enums;

namespace DigiD.Common.EID.CardOperations;

public class ChangePinOperation : BaseSecureCardOperation
{
	private readonly SecureString _newPin;

	private readonly CardCredentials _credentials;

	private readonly PasswordType _passwordType;

	public ChangePinOperation(SecureString newPin, CardCredentials credentials, PasswordType passwordType, Action<float> progressChangedAction)
		: base(progressChangedAction)
	{
		_credentials = credentials;
		_passwordType = passwordType;
		_newPin = newPin;
	}

	public override async Task<bool> Execute()
	{
		if (await new StepGap(_credentials, _passwordType, GapType.Pace, this, base.ChangeProgress).Execute())
		{
			bool result = await base.Execute();
			ArgumentNullException.ThrowIfNull(base.GAP, "GAP");
			if (!result && base.GAP.ChangePinRequired)
			{
				StepChangeReferenceData crd = new StepChangeReferenceData(this, _newPin);
				return await crd.Execute();
			}
			return result;
		}
		return false;
	}

	internal override async Task Init()
	{
		await base.Init();
		ArgumentNullException.ThrowIfNull(EIDSession.Card, "EIDSession.Card");
		if (EIDSession.Card.DocumentType == DocumentType.DrivingLicense)
		{
			base.Steps.Add(new StepSelectPcaApplicationRdw(this));
			base.Steps.Add(new StepSelectMF(this));
			base.Steps.Add(new StepResetRetryCounter(this, _newPin));
		}
		else
		{
			base.Steps.Add(new StepResetRetryCounter(this, _newPin));
		}
	}
}
