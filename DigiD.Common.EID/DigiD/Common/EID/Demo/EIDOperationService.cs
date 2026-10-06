using System;
using System.Security;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.Enums;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.SessionModels;

namespace DigiD.Common.EID.Demo;

public class EIDOperationService : IEIDOperationService
{
	public BaseSecureCardOperation StartRandomize(UserConsent userConsent, CardCredentials credentials, Action<float> progressChangedAction)
	{
		return new DemoCardOperation(CardOperationType.Authentication, progressChangedAction, credentials, PasswordType.PIN);
	}

	public BaseSecureCardOperation StartChangePin(SecureString newPin, CardCredentials credentials, PasswordType passwordType, Action<float> progressChangedAction)
	{
		EIDSession.CardState.NewPin = newPin.ToPlain();
		return new DemoCardOperation(CardOperationType.ChangePin, progressChangedAction, credentials, passwordType);
	}

	public BaseSecureCardOperation StartResumePin(GapType type, CardCredentials credentials, Action<float> progressChangedAction)
	{
		return new DemoCardOperation(CardOperationType.ResumePin, progressChangedAction, credentials, PasswordType.CAN);
	}

	public BaseSecureCardOperation StartStatus(PasswordType passwordType, Action<float> progressChangedAction)
	{
		return new DemoCardOperation(CardOperationType.Status, progressChangedAction, null, passwordType);
	}
}
