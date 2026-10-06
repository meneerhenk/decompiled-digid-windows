using System;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Nfc;
using Microsoft.Maui.Storage;

namespace DigiD.Common.Models.Config;

public static class DemoConfig
{
	public static ActivationMethod ActivationMethod
	{
		get
		{
			return Enum.Parse<ActivationMethod>(Preferences.Get("DemoConfig.ActivationMethod", ActivationMethod.SMS.ToString()));
		}
		set
		{
			Preferences.Set("DemoConfig.ActivationMethod", value.ToString());
		}
	}

	public static bool TwoFactorEnabled
	{
		get
		{
			return Preferences.Get("DemoConfig.TwoFactorEnabled", defaultValue: false);
		}
		set
		{
			Preferences.Set("DemoConfig.TwoFactorEnabled", value);
		}
	}

	public static bool HasEmailAddress
	{
		get
		{
			return Preferences.Get("DemoConfig.HasEmailAddress", defaultValue: true);
		}
		set
		{
			Preferences.Set("DemoConfig.HasEmailAddress", value);
		}
	}

	public static bool IsEmailAddressVerified
	{
		get
		{
			return Preferences.Get("DemoConfig.IsEmailAddressVerified", defaultValue: true);
		}
		set
		{
			Preferences.Set("DemoConfig.IsEmailAddressVerified", value);
		}
	}

	public static bool UserActionNeeded
	{
		get
		{
			return Preferences.Get("DemoConfig.UserActionNeeded", defaultValue: false);
		}
		set
		{
			Preferences.Set("DemoConfig.UserActionNeeded", value);
		}
	}

	public static bool HasMessages
	{
		get
		{
			return Preferences.Get("DemoConfig.HasMessages", defaultValue: true);
		}
		set
		{
			Preferences.Set("DemoConfig.HasMessages", value);
		}
	}

	public static bool EIDASUser
	{
		get
		{
			return Preferences.Get("DemoConfig.EIDASUser", defaultValue: false);
		}
		set
		{
			Preferences.Set("DemoConfig.EIDASUser", value);
		}
	}

	public static bool EIDASSuccess
	{
		get
		{
			return Preferences.Get("DemoConfig.EIDASSuccess", defaultValue: true);
		}
		set
		{
			Preferences.Set("DemoConfig.EIDASSuccess", value);
		}
	}

	public static bool RdaFailed
	{
		get
		{
			return Preferences.Get("DemoConfig.RdaFailed", defaultValue: false);
		}
		set
		{
			Preferences.Set("DemoConfig.RdaFailed", value);
		}
	}

	public static bool HasNoDocuments
	{
		get
		{
			return Preferences.Get("DemoConfig.HasNoDocuments", defaultValue: false);
		}
		set
		{
			Preferences.Set("DemoConfig.HasNoDocuments", value);
		}
	}

	public static bool IsSmsCheckRequested
	{
		get
		{
			return Preferences.Get("DemoConfig.IsSmsCheckRequested", defaultValue: false);
		}
		set
		{
			Preferences.Set("DemoConfig.IsSmsCheckRequested", value);
		}
	}

	public static bool IsEHAEnabled
	{
		get
		{
			return Preferences.Get("DemoConfig.IsEHAEnabled", defaultValue: false);
		}
		set
		{
			Preferences.Set("DemoConfig.IsEHAEnabled", value);
		}
	}

	public static bool IsClassifiedDeceased
	{
		get
		{
			return Preferences.Get("DemoConfig.IsClassifiedDeceased", defaultValue: false);
		}
		set
		{
			Preferences.Set("DemoConfig.IsClassifiedDeceased", value);
		}
	}

	public static bool HasPendingActivation
	{
		get
		{
			return Preferences.Get("DemoConfig.HasPendingActivation", defaultValue: false);
		}
		set
		{
			Preferences.Set("DemoConfig.HasPendingActivation", value);
		}
	}

	public static bool HasNfc
	{
		get
		{
			return Preferences.Get("DemoConfig.HasNfc", defaultValue: true);
		}
		set
		{
			Preferences.Set("DemoConfig.HasNfc", value);
		}
	}

	public static VersionState VersionState
	{
		get
		{
			return Enum.Parse<VersionState>(Preferences.Get("DemoConfig.VersionState", VersionState.Active.ToString()));
		}
		set
		{
			Preferences.Set("DemoConfig.VersionState", value.ToString());
		}
	}

	public static bool TrafficMeteringEnabled
	{
		get
		{
			return Preferences.Get("DemoConfig.TrafficMeteringEnabled", defaultValue: false);
		}
		set
		{
			Preferences.Set("DemoConfig.TrafficMeteringEnabled", value);
		}
	}

	public static bool MaintenanceEnabled
	{
		get
		{
			return Preferences.Get("DemoConfig.MaintenanceEnabled", defaultValue: false);
		}
		set
		{
			Preferences.Set("DemoConfig.MaintenanceEnabled", value);
		}
	}

	public static bool HasTooManyActiveDevices
	{
		get
		{
			return Preferences.Get("DemoConfig.HasTooManyActiveDevices", defaultValue: false);
		}
		set
		{
			Preferences.Set("DemoConfig.HasTooManyActiveDevices", value);
		}
	}

	public static NfcPosition NfcPosition
	{
		get
		{
			return Enum.Parse<NfcPosition>(Preferences.Get("DemoConfig.NfcPosition", NfcPosition.Middle.ToString()));
		}
		set
		{
			Preferences.Set("DemoConfig.NfcPosition", value.ToString());
		}
	}

	public static bool IsHealthCheckSuccess
	{
		get
		{
			return Preferences.Get("DemoConfig.IsHealthCheckSuccess", defaultValue: true);
		}
		set
		{
			Preferences.Set("DemoConfig.IsHealthCheckSuccess", value);
		}
	}

	public static bool KeyAttestationSuccess
	{
		get
		{
			return Preferences.Get("DemoConfig.KeyAttestationSuccess", defaultValue: true);
		}
		set
		{
			Preferences.Set("DemoConfig.KeyAttestationSuccess", value);
		}
	}

	public static int UnreadMessagesCount
	{
		get
		{
			return Preferences.Get("DemoConfig.UnreadMessagesCount", 0);
		}
		set
		{
			Preferences.Set("DemoConfig.UnreadMessagesCount", value);
		}
	}

	public static DateTime? SubExpiryDate
	{
		get
		{
			try
			{
				if (Preferences.ContainsKey("DemoConfig.SubExpiryDate"))
				{
					return Preferences.Get("DemoConfig.SubExpiryDate", DateTime.MinValue);
				}
			}
			catch (Exception)
			{
				return null;
			}
			return null;
		}
		set
		{
			if (value.HasValue)
			{
				Preferences.Set("DemoConfig.SubExpiryDate", value.Value);
			}
			else
			{
				Preferences.Remove("DemoConfig.SubExpiryDate");
			}
		}
	}

	public static bool NeedSubInFuture
	{
		get
		{
			return Preferences.Get("DemoConfig.NeedSubInFuture", defaultValue: false);
		}
		set
		{
			Preferences.Set("DemoConfig.NeedSubInFuture", value);
		}
	}

	public static bool EnableEasterEgg
	{
		get
		{
			return Preferences.Get("EnableEasterEgg", defaultValue: true);
		}
		set
		{
			Preferences.Set("EnableEasterEgg", value);
		}
	}
}
