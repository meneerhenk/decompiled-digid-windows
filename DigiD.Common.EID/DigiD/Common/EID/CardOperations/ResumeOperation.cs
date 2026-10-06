using System;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.CardSteps;
using DigiD.Common.EID.CardSteps.PACE;
using DigiD.Common.EID.CardSteps.PinManagement;
using DigiD.Common.EID.Enums;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.NFC.Enums;

namespace DigiD.Common.EID.CardOperations;

public class ResumeOperation : BaseSecureCardOperation
{
	private readonly CardCredentials _credentials;

	private readonly GapType _type;

	public ResumeOperation(GapType type, CardCredentials credentials, Action<float> progressChangedAction)
		: base(progressChangedAction)
	{
		_credentials = credentials;
		_type = type;
	}

	public override async Task<bool> Execute()
	{
		if (await new StepGap(_credentials, PasswordType.CAN, GapType.Pace, this, base.ChangeProgress).Execute())
		{
			return await base.Execute();
		}
		return false;
	}

	internal override async Task Init()
	{
		await base.Init();
		switch (EIDSession.Card.DocumentType)
		{
		case DocumentType.IDCard:
			switch (_type)
			{
			case GapType.PINResumeCAN:
				base.Steps.Add(new StepVerify(this, _credentials, PasswordType.PIN));
				break;
			case GapType.PUKResumeCAN:
				base.Steps.Add(new StepVerify(this, _credentials, PasswordType.PUK));
				break;
			}
			break;
		case DocumentType.DrivingLicense:
			ArgumentNullException.ThrowIfNull(base.GAP?.Pace, "GAP?.Pace");
			switch (_type)
			{
			case GapType.PINResumeCAN:
				base.Steps.Add(new StepResetPace(PasswordType.PIN, base.GAP.Pace));
				break;
			case GapType.PUKResumeCAN:
				base.Steps.Add(new StepResetPace(PasswordType.PUK, base.GAP.Pace));
				break;
			}
			base.Steps.Add(new StepSetAT(base.GAP));
			base.Steps.Add(new StepGetEncryptedNonce(base.GAP));
			base.Steps.Add(new StepGenerateKeyPair(this));
			base.Steps.Add(new StepMapNonce(base.GAP));
			base.Steps.Add(new StepGenerateAgreementKeyPair(base.GAP));
			base.Steps.Add(new StepGetCardAgreementPublicKey(base.GAP));
			base.Steps.Add(new StepCalculateMacKeys(base.GAP));
			base.Steps.Add(new StepMutualAuthentication(base.GAP));
			base.Steps.Add(new StepValidateOperation(base.GAP));
			break;
		}
	}
}
