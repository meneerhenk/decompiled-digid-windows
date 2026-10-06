using System;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.CardSteps;
using DigiD.Common.EID.Enums;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.Models.CardFiles;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;

namespace DigiD.Common.EID.Demo;

public class DemoCardOperation : BaseSecureCardOperation
{
	public CardOperationType OperationType { get; }

	public DemoCardOperation(CardOperationType type, Action<float> progressChangedAction, CardCredentials? credentials, PasswordType passwordType)
		: base(progressChangedAction)
	{
		base.GAP = new Gap(passwordType, credentials);
		OperationType = type;
	}

	internal override async Task Init()
	{
		await base.Init();
		ArgumentNullException.ThrowIfNull(base.GAP, "GAP");
		int x = 0;
		INfcService nfc = ((IApp)Application.Current).ServiceProvider.GetRequiredService<INfcService>();
		EIDSession.Card = await nfc.ReadCard();
		EIDSession.Card.EF_Dir = new EFDir(Array.Empty<byte>());
		switch (OperationType)
		{
		case CardOperationType.Authentication:
			TotalSteps = EIDSession.Card.RandomizeSteps;
			break;
		case CardOperationType.ChangePin:
			EIDSession.CardState.ChangePinRequired = false;
			TotalSteps = EIDSession.Card.ChangePINSteps;
			break;
		case CardOperationType.Status:
			TotalSteps = EIDSession.Card.StatusSteps;
			break;
		case CardOperationType.ResumePin:
			TotalSteps = EIDSession.Card.ResumeSteps;
			break;
		}
		while (x < TotalSteps - 1)
		{
			x++;
			DemoStep step = new DemoStep(base.GAP, OperationType);
			int num = x;
			if (num == 6)
			{
				if (OperationType == CardOperationType.Authentication && EIDSession.CardState.ChangePinRequired)
				{
					step.ValidateCredentials = true;
					step.ChangeTransportPin = true;
				}
				else
				{
					CardOperationType operationType = OperationType;
					if ((uint)operationType <= 2u)
					{
						step.ValidateCredentials = true;
					}
				}
			}
			base.Steps.Add(step);
		}
		base.Steps.Add(new DemoStep(base.GAP, OperationType)
		{
			IsFinalStep = true
		});
	}
}
