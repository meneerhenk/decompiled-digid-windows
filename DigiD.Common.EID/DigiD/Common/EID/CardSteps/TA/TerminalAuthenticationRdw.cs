using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.CardSteps.FileOperations;
using DigiD.Common.EID.CardSteps.TA.RDW;
using DigiD.Common.EID.Cards;
using DigiD.Common.EID.Enums;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.SessionModels;
using Org.BouncyCastle.Crypto.Parameters;

namespace DigiD.Common.EID.CardSteps.TA;

public class TerminalAuthenticationRdw : BaseSecureCardOperation, IStep
{
	public List<Certificate> LinkCerts { get; set; } = new List<Certificate>();

	public Certificate? DvCert { get; set; }

	public ECPublicKeyParameters? PublicKey { get; set; }

	public byte[]? Ricc { get; set; }

	internal TerminalAuthenticationRdw(ISecureCardOperation operation)
		: base((Gap)operation)
	{
	}

	internal override async Task Init()
	{
		await base.Init();
		base.Steps.Clear();
		base.Steps.Add(new StepSelectMF(this));
		base.Steps.Add(new StepSendPcaInfo(this));
		base.Steps.Add(new StepMseSetDst(this, CertificateType.DVCACertificate));
		base.Steps.Add(new StepMseSetDst(this, CertificateType.ATCertificate));
		base.Steps.Add(new StepMseSetAT(this));
		base.Steps.Add(new StepGetChallenge(this));
		base.Steps.Add(new StepExternalAuthentication(this));
	}

	public override async Task<bool> Execute()
	{
		bool result = await base.Execute();
		DrivingLicense card2 = default(DrivingLicense);
		int num;
		if (result)
		{
			Card card = EIDSession.Card;
			card2 = card as DrivingLicense;
			num = ((card2 != null) ? 1 : 0);
		}
		else
		{
			num = 0;
		}
		if (num != 0)
		{
			card2.TA = this;
		}
		return result;
	}

	public override void StepCompleted(IStep stepNumber)
	{
		ArgumentNullException.ThrowIfNull(base.GAP, "GAP");
		base.GAP.StepCompleted(stepNumber);
	}
}
