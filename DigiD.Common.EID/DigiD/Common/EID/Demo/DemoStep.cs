using System;
using System.Text;
using System.Threading.Tasks;
using DigiD.Common.EID.CardSteps;
using DigiD.Common.EID.Enums;
using DigiD.Common.EID.Exceptions;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Nfc;
using DigiD.Common.NFC.Enums;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;

namespace DigiD.Common.EID.Demo;

internal class DemoStep(Gap gap, CardOperationType operationType) : IStep
{
	public bool ChangeTransportPin { get; set; }

	public bool ValidateCredentials { get; set; }

	public bool IsFinalStep { get; set; }

	public async Task<bool> Execute()
	{
		byte[] cmd = ((EIDSession.Card.DocumentType == DocumentType.DrivingLicense) ? Convert.FromBase64String("AKQEDAugAAAEVkVETC0wMQ==") : Convert.FromBase64String("AKQEDAegAAACRxAB"));
		TransceiveResult response = await ((IApp)Application.Current).ServiceProvider.GetRequiredService<INfcService>().SendApduAsync(cmd);
		if (!response.Success && response.Exception != null)
		{
			throw response.Exception;
		}
		if (gap.IsSuspended || (EIDSession.CardState.IsSuspended && operationType != CardOperationType.ResumePin))
		{
			EIDSession.CardState.NewPin = null;
			gap.IsSuspended = true;
			gap.AuthenticationResult = AuthenticationResult.Failed;
			throw new CardSuspendException();
		}
		if (gap.IsBlocked || EIDSession.CardState.IsBlocked)
		{
			gap.IsBlocked = true;
			gap.AuthenticationResult = AuthenticationResult.Failed;
			throw new CardBlockedException();
		}
		if (ValidateCredentials && gap.Pace?.Password != null)
		{
			string password = Encoding.UTF8.GetString(gap.Pace.Password);
			string pin;
			if (gap.PasswordType == PasswordType.PIN)
			{
				pin = EIDSession.CardState.Pin;
				if (password != pin)
				{
					if (EIDSession.CardState.IsSuspended)
					{
						gap.IsSuspended = true;
						gap.AuthenticationResult = AuthenticationResult.Failed;
						throw new CardSuspendException();
					}
				}
				else
				{
					if (EIDSession.CardState.IsSuspended)
					{
						gap.IsSuspended = true;
						gap.AuthenticationResult = AuthenticationResult.Failed;
						throw new CardSuspendException();
					}
					if (EIDSession.CardState.IsBlocked)
					{
						gap.IsBlocked = true;
						gap.AuthenticationResult = AuthenticationResult.Failed;
						throw new CardBlockedException();
					}
				}
				gap.PinTriesLeft = EIDSession.CardState.PINTries--;
			}
			else
			{
				double delay = EIDSession.CardState.CANDelay * 1.8;
				if (delay > 20000.0)
				{
					delay = 200000.0;
				}
				EIDSession.CardState.CANDelay = delay;
				await Task.Delay((int)delay);
				pin = ((EIDSession.Card.DocumentType == DocumentType.DrivingLicense) ? "1234567890" : "123456");
			}
			if (password == pin)
			{
				gap.ChangePinRequired = ChangeTransportPin;
				if (ChangeTransportPin)
				{
					gap.AuthenticationResult = AuthenticationResult.Success;
					throw new TransportPinException();
				}
				if (gap.PasswordType == PasswordType.CAN && gap.Pace.Credentials?.PIN != null && gap.Pace.Credentials.PIN.ToPlain() != EIDSession.CardState.Pin)
				{
					EIDSession.CardState.PINTries = 0;
					gap.IsBlocked = true;
					gap.AuthenticationResult = AuthenticationResult.Failed;
					throw new CardBlockedException();
				}
				gap.AuthenticationResult = AuthenticationResult.Success;
				return true;
			}
			gap.AuthenticationResult = AuthenticationResult.Failed;
			return false;
		}
		if (IsFinalStep && gap.AuthenticationResult == AuthenticationResult.Success)
		{
			if (!string.IsNullOrEmpty(EIDSession.CardState.NewPin))
			{
				EIDSession.CardState.Pin = EIDSession.CardState.NewPin;
				EIDSession.CardState.NewPin = null;
			}
			gap.PinTriesLeft = null;
			EIDSession.CardState.PINTries = 5;
			EIDSession.CardState.CANDelay = 0.0;
			return true;
		}
		return response.Success;
	}
}
