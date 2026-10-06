using System.Threading.Tasks;
using DigiD.Common.EID.Enums;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Models;

namespace DigiD.Common.EID.CardSteps.PACE;

public class PaceReset : PaceOperation
{
	private readonly PasswordType _resetType;

	internal PaceReset(ISecureCardOperation operation, CardCredentials credentials, PasswordType passwordType, PasswordType resetType)
		: base(operation, credentials, passwordType)
	{
		_resetType = resetType;
	}

	internal override async Task Init()
	{
		await base.Init();
		base.Steps.Add(new StepResetPace(_resetType, this));
		base.Steps.Add(new StepSetAT(base.Operation));
		base.Steps.Add(new StepGetEncryptedNonce(base.Operation));
		base.Steps.Add(new StepGenerateKeyPair(this));
		base.Steps.Add(new StepMapNonce(base.Operation));
		base.Steps.Add(new StepGenerateAgreementKeyPair(base.Operation));
		base.Steps.Add(new StepGetCardAgreementPublicKey(base.Operation));
		base.Steps.Add(new StepCalculateMacKeys(base.Operation));
		base.Steps.Add(new StepMutualAuthentication(base.Operation));
		base.Steps.Add(new StepValidateOperation(base.Operation));
	}
}
