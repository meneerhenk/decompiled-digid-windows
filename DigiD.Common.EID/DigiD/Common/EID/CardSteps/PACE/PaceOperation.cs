using System;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.CardSteps.FileOperations;
using DigiD.Common.EID.Enums;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.NFC.Enums;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;

namespace DigiD.Common.EID.CardSteps.PACE;

public class PaceOperation : BaseCardOperation, IStep
{
	internal readonly CardCredentials? Credentials;

	public bool IsSuccess => (TerminalAuthToken != null && CardAuthToken != null && ((ReadOnlySpan<byte>)TerminalAuthToken).SequenceEqual((ReadOnlySpan<byte>)CardAuthToken)) || Operation.ChangePinRequired;

	public AsymmetricCipherKeyPair? EphemeralKeyPair { get; set; }

	public ECPublicKeyParameters? CardPublicKey { get; set; }

	public AsymmetricCipherKeyPair? AgreementKeyPair { get; set; }

	public ECPublicKeyParameters? CardAgreedPublicKey { get; set; }

	public byte[]? DecryptedNonce { get; set; }

	public byte[]? KEnc { get; set; }

	public byte[]? KMac { get; set; }

	public byte[]? TerminalAuthToken { get; set; }

	public byte[]? TerminalToken { get; set; }

	public byte[]? CardAuthToken { get; set; }

	public byte[]? Car { get; set; }

	public PasswordType PasswordType { get; set; }

	public byte[]? Password => Credentials?.Password(PasswordType);

	protected Gap Operation { get; }

	internal PaceOperation(ISecureCardOperation operation, CardCredentials? credentials, PasswordType passwordType)
	{
		Operation = (Gap)operation;
		PasswordType = passwordType;
		Credentials = credentials;
	}

	internal override async Task Init()
	{
		await base.Init();
		Operation.Pace = this;
		DocumentType? documentType = EIDSession.Card?.DocumentType;
		DocumentType? documentType2 = documentType;
		if (documentType2.HasValue)
		{
			switch (documentType2.GetValueOrDefault())
			{
			case DocumentType.DrivingLicense:
				base.Steps.Add(new StepReadCardAccess());
				base.Steps.Add(new StepSelectMF(Operation));
				if (Operation.UserConsent != UserConsent.NotNeeded)
				{
					base.Steps.Add(new StepGetATCertificateRdw(Operation));
				}
				break;
			case DocumentType.IDCard:
				base.Steps.Add(new StepSelectPcaApplicationNik(Operation));
				base.Steps.Add(new StepSelectMF(Operation));
				base.Steps.Add(new StepStartSessionNik(Operation));
				base.Steps.Add(new StepReadCardAccess());
				break;
			}
		}
		base.Steps.Add(new StepSetAT(Operation));
		if (Credentials != null)
		{
			base.Steps.Add(new StepGetEncryptedNonce(Operation));
			base.Steps.Add(new StepGenerateKeyPair(this));
			base.Steps.Add(new StepMapNonce(Operation));
			base.Steps.Add(new StepGenerateAgreementKeyPair(Operation));
			base.Steps.Add(new StepGetCardAgreementPublicKey(Operation));
			base.Steps.Add(new StepCalculateMacKeys(Operation));
			base.Steps.Add(new StepMutualAuthentication(Operation));
			base.Steps.Add(new StepValidateOperation(Operation));
		}
	}

	public override async Task<bool> Execute()
	{
		bool result = await base.Execute() && (IsSuccess || Credentials == null);
		if (result)
		{
			Operation.Pace = this;
		}
		return result;
	}

	public override void StepCompleted(IStep stepNumber)
	{
		Operation.StepCompleted(stepNumber);
	}
}
