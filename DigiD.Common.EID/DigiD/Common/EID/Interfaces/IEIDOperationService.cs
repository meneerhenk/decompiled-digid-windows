using System;
using System.Security;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.Enums;
using DigiD.Common.EID.Models;

namespace DigiD.Common.EID.Interfaces;

public interface IEIDOperationService
{
	BaseSecureCardOperation StartRandomize(UserConsent userConsent, CardCredentials credentials, Action<float> progressChangedAction);

	BaseSecureCardOperation StartChangePin(SecureString newPin, CardCredentials credentials, PasswordType passwordType, Action<float> progressChangedAction);

	BaseSecureCardOperation StartResumePin(GapType type, CardCredentials credentials, Action<float> progressChangedAction);

	BaseSecureCardOperation StartStatus(PasswordType passwordType, Action<float> progressChangedAction);
}
