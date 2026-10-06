using System;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.CardOperations;
using DigiD.Common.EID.CardSteps.BAC;
using DigiD.Common.EID.CardSteps.CAv1;
using DigiD.Common.EID.CardSteps.CAv2;
using DigiD.Common.EID.CardSteps.FileOperations;
using DigiD.Common.EID.CardSteps.PACE;
using DigiD.Common.EID.CardSteps.Randomize;
using DigiD.Common.EID.CardSteps.TA;
using DigiD.Common.EID.Enums;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.NFC.Enums;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;

namespace DigiD.Common.EID.CardSteps;

public class Gap : BaseSecureCardOperation
{
	private readonly BaseSecureCardOperation? _operation;

	private readonly CardCredentials? _credentials;

	private readonly Action? _progressChangedAction;

	public readonly PasswordType PasswordType;

	internal PaceOperation? Pace { get; set; }

	internal SMContext? SMContext { get; set; }

	public AuthenticationResult AuthenticationResult { get; set; }

	public ApiResult ApiResult { get; set; }

	public int? PinTriesLeft { get; set; }

	public bool ChangePinRequired { get; set; }

	public bool IsBlocked { get; set; }

	public bool IsSuspended { get; set; }

	internal EidSessionData? SessionData { get; }

	internal UserConsent UserConsent => SessionData?.Consent ?? UserConsent.NotNeeded;

	public Gap(PasswordType passwordType, CardCredentials? cardCredentials)
	{
		PasswordType = passwordType;
		Pace = new PaceOperation(this, cardCredentials, passwordType);
	}

	public Gap(BaseSecureCardOperation operation, CardCredentials? credentials, PasswordType passwordType, Action progressChangedAction, EidSessionData? sessionData)
	{
		_operation = operation;
		_credentials = credentials;
		PasswordType = passwordType;
		_progressChangedAction = progressChangedAction;
		SessionData = sessionData;
	}

	public Gap(CardCredentials credentials, PasswordType passwordType, BaseSecureCardOperation operation)
	{
		_credentials = credentials;
		PasswordType = passwordType;
		_operation = operation;
	}

	public async Task<bool> Init(GapType type)
	{
		EIDSession.Card = await ((IApp)Application.Current).ServiceProvider.GetRequiredService<INfcService>().ReadCard();
		ArgumentNullException.ThrowIfNull(EIDSession.Card, "EIDSession.Card");
		BaseSecureCardOperation operation = _operation;
		BaseSecureCardOperation baseSecureCardOperation = operation;
		if (!(baseSecureCardOperation is ChangePinOperation cp))
		{
			if (!(baseSecureCardOperation is StatusOperation cs))
			{
				if (!(baseSecureCardOperation is RandomizeOperation r))
				{
					if (baseSecureCardOperation is ResumeOperation resume)
					{
						resume.TotalSteps = EIDSession.Card.ResumeSteps;
					}
				}
				else
				{
					r.TotalSteps = EIDSession.Card.RandomizeSteps;
				}
			}
			else
			{
				cs.TotalSteps = EIDSession.Card.StatusSteps;
			}
		}
		else
		{
			cp.TotalSteps = EIDSession.Card.ChangePINSteps;
		}
		base.Steps.Add(new StepSelectMF(this));
		base.Steps.Add(new StepReadEFDir());
		switch (type)
		{
		case GapType.Bac:
			ArgumentNullException.ThrowIfNull(_credentials?.MRZ, "_credentials?.MRZ");
			base.Steps.Add(new BacOperation(this, _credentials.MRZ));
			base.Steps.Add(new StepPassiveAuthentication(this));
			base.Steps.Add(new StepActiveAuthentication(this));
			break;
		case GapType.Pace:
			base.Steps.Add(new PaceOperation(this, _credentials, PasswordType));
			break;
		case GapType.PaceStatus:
			base.Steps.Add(new PaceOperation(this, null, PasswordType));
			break;
		case GapType.PINResumeCAN:
			ArgumentNullException.ThrowIfNull(_credentials, "_credentials");
			base.Steps.Add(new PaceReset(this, _credentials, PasswordType, PasswordType.PIN));
			break;
		case GapType.PUKResumeCAN:
			ArgumentNullException.ThrowIfNull(_credentials, "_credentials");
			base.Steps.Add(new PaceReset(this, _credentials, PasswordType, PasswordType.PUK));
			break;
		case GapType.CAv1:
			base.Steps.Add(new PaceOperation(this, _credentials, PasswordType));
			base.Steps.Add(new StepSelecteDLApplication(this));
			base.Steps.Add(new StepReadFiles(this));
			base.Steps.Add(new ChipAuthentication(this));
			break;
		case GapType.CAv2:
			if (EIDSession.Card.DocumentType == DocumentType.DrivingLicense)
			{
				base.Steps.Add(new PaceOperation(this, _credentials, PasswordType));
				base.Steps.Add(new StepSelectPcaApplicationRdw(this));
				base.Steps.Add(new TerminalAuthenticationRdw(this));
				base.Steps.Add(new ChipAuthenticationRdw(this));
			}
			else
			{
				base.Steps.Add(new PaceOperation(this, _credentials, PasswordType));
				base.Steps.Add(new StepSelectPcaApplicationNik(this));
				base.Steps.Add(new ChipAuthenticationNik(this));
				base.Steps.Add(new TerminalAuthenticationNik(this));
			}
			break;
		default:
			throw new ArgumentOutOfRangeException("type", type, null);
		}
		return true;
	}

	public override void StepCompleted(IStep stepNumber)
	{
		_progressChangedAction?.Invoke();
	}
}
