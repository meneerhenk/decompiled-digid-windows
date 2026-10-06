using System;
using DigiD.Common.BaseClasses;
using DigiD.Common.Enums;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Settings;

namespace DigiD.Mobile.Services;

public class MobileSettings : BaseAppSettings, IMobileSettings
{
	public bool? NotificationPermissionSet
	{
		get
		{
			return GetValue<bool?>(null, "NotificationPermissionSet");
		}
		set
		{
			SetValue(value, "NotificationPermissionSet");
		}
	}

	public string NotificationToken
	{
		get
		{
			return GetValue(string.Empty, "NotificationToken");
		}
		set
		{
			SetValue(value, "NotificationToken");
		}
	}

	public string SymmetricKey
	{
		get
		{
			return GetValue(string.Empty, "SymmetricKey");
		}
		set
		{
			SetValue(value, "SymmetricKey");
		}
	}

	public string AppId
	{
		get
		{
			return GetValue(string.Empty, "AppId");
		}
		set
		{
			SetValue(value, "AppId");
		}
	}

	public string MaskCode
	{
		get
		{
			return GetValue(string.Empty, "MaskCode");
		}
		set
		{
			SetValue(value, "MaskCode");
		}
	}

	public string? SubAttestationKeyId
	{
		get
		{
			return GetValue<string>(null, "SubAttestationKeyId");
		}
		set
		{
			SetValue(value, "SubAttestationKeyId");
		}
	}

	public string? HighAttestationKeyId
	{
		get
		{
			return GetValue<string>(null, "HighAttestationKeyId");
		}
		set
		{
			SetValue(value, "HighAttestationKeyId");
		}
	}

	public bool ScreenshotEnabled
	{
		get
		{
			return GetValue(defaultValue: false, "ScreenshotEnabled");
		}
		set
		{
			SetValue(value, "ScreenshotEnabled");
		}
	}

	public ActivationStatus ActivationStatus
	{
		get
		{
			return Enum.Parse<ActivationStatus>(GetValue("NotActivated", "ActivationStatus").Replace("\"", string.Empty));
		}
		set
		{
			base.Store.SetValue("ActivationStatus", value.ToString());
		}
	}

	public LoginLevel LoginLevel
	{
		get
		{
			return Enum.Parse<LoginLevel>(GetValue("Unknown", "LoginLevel").Replace("\"", string.Empty));
		}
		set
		{
			base.Store.SetValue("LoginLevel", value.ToString());
		}
	}

	public KeyAttestationResult KeyAttestationResult
	{
		get
		{
			return Enum.Parse<KeyAttestationResult>(GetValue("NotPerformed", "KeyAttestationResult"));
		}
		set
		{
			base.Store.SetValue("KeyAttestationResult", value.ToString());
		}
	}

	public int BiometricsCancelCounter
	{
		get
		{
			return GetValue(0, "BiometricsCancelCounter");
		}
		set
		{
			SetValue(value, "BiometricsCancelCounter");
		}
	}

	public MobileSettings(ISecureStorageService store)
		: base(store)
	{
	}
}
