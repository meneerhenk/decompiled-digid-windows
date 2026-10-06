using System;
using System.Security;
using System.Threading.Tasks;
using DigiD.Common.Enums;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.ResponseModels;
using LocalizationResourceManager.Maui;

namespace DigiD.Common.Models;

public class PinCodeModel(PinEntryType entryType, WebSessionInfoResponse? sessionInfo = null, WidSessionResponse? eidSessionResponse = null, int? triesLeft = null) : IPinCodeModel
{
	public PinEntryType EntryType { get; set; } = entryType;

	public WebSessionInfoResponse? SessionInfo { get; set; } = sessionInfo;

	public WidSessionResponse? EIDSessionResponse { get; } = eidSessionResponse;

	public int? TriesLeft { get; } = triesLeft;

	public bool WrongCAN { get; set; }

	public bool IsStatusChecked { get; set; }

	public bool IsWIDActivation { get; set; }

	public SecureString? PIN { get; set; }

	public byte[]? IV { get; set; }

	public bool NeedPinChange { get; set; }

	public bool ChangeAppPin { get; set; }

	public bool IsAppAuthentication { get; set; }

	public bool NeedAppDeactivation { get; set; }

	public bool? HasPinChanged { get; set; }

	public bool BiometricEnabled { get; set; } = true;

	public LocalizedString? MessageText { get; set; }

	public bool? HasBackButton { get; set; }

	public Func<Task>? NextAction { get; set; }

	public Func<Task>? CancelAction { get; set; }

	public bool StartBiometrics { get; set; }
}
