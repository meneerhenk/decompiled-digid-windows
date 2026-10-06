using System;
using System.Security;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.CardOperations;
using DigiD.Common.EID.Enums;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Models;

namespace DigiD.Common.EID.Services;

public class EIDOperationService : IEIDOperationService
{
	public BaseSecureCardOperation StartRandomize(UserConsent userConsent, CardCredentials credentials, Action<float> progressChangedAction)
	{
		return new RandomizeOperation(userConsent, credentials, progressChangedAction);
	}

	public BaseSecureCardOperation StartChangePin(SecureString newPin, CardCredentials credentials, PasswordType passwordType, Action<float> progressChangedAction)
	{
		return new ChangePinOperation(newPin, credentials, passwordType, progressChangedAction);
	}

	public BaseSecureCardOperation StartResumePin(GapType type, CardCredentials credentials, Action<float> progressChangedAction)
	{
		return new ResumeOperation(type, credentials, progressChangedAction);
	}

	public BaseSecureCardOperation StartStatus(PasswordType passwordType, Action<float> progressChangedAction)
	{
		return new StatusOperation(passwordType, progressChangedAction);
	}
}
