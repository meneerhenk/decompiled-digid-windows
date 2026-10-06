using System;
using Microsoft.Maui.Storage;

namespace DigiD.Common.Preferences;

public static class DemoSettings
{
	public static bool IsDemoModeEnabled
	{
		get
		{
			return Microsoft.Maui.Storage.Preferences.Get("IsDemoModeEnabled", defaultValue: false);
		}
		set
		{
			Microsoft.Maui.Storage.Preferences.Set("IsDemoModeEnabled", value);
		}
	}

	public static string DemoPin
	{
		get
		{
			return Microsoft.Maui.Storage.Preferences.Get("DemoPin", string.Empty);
		}
		set
		{
			Microsoft.Maui.Storage.Preferences.Set("DemoPin", value);
		}
	}

	public static string EmailAddress
	{
		get
		{
			return Microsoft.Maui.Storage.Preferences.Get("EmailAddress", string.Empty);
		}
		set
		{
			Microsoft.Maui.Storage.Preferences.Set("EmailAddress", value);
		}
	}

	public static DateTime? EmailCheckDate
	{
		get
		{
			return Microsoft.Maui.Storage.Preferences.Get("EmailCheckDate", default(DateTime));
		}
		set
		{
			if (value.HasValue)
			{
				Microsoft.Maui.Storage.Preferences.Set("EmailCheckDate", value.Value);
			}
			else
			{
				Microsoft.Maui.Storage.Preferences.Remove("EmailCheckDate");
			}
		}
	}

	public static bool? EmailAddressVerified
	{
		get
		{
			return Microsoft.Maui.Storage.Preferences.Get("EmailAddressVerified", defaultValue: false);
		}
		set
		{
			if (value.HasValue)
			{
				Microsoft.Maui.Storage.Preferences.Set("EmailAddressVerified", value.Value);
			}
			else
			{
				Microsoft.Maui.Storage.Preferences.Remove("EmailAddressVerified");
			}
		}
	}

	public static bool? TwoFactorEnabled
	{
		get
		{
			return Microsoft.Maui.Storage.Preferences.Get("TwoFactorEnabled", defaultValue: false);
		}
		set
		{
			if (value.HasValue)
			{
				Microsoft.Maui.Storage.Preferences.Set("TwoFactorEnabled", value.Value);
			}
			else
			{
				Microsoft.Maui.Storage.Preferences.Remove("TwoFactorEnabled");
			}
		}
	}

	public static string? KACertificate
	{
		get
		{
			string text = Microsoft.Maui.Storage.Preferences.Get("KACertificate", string.Empty);
			return string.IsNullOrEmpty(text) ? null : text;
		}
		set
		{
			Microsoft.Maui.Storage.Preferences.Set("KACertificate", value);
		}
	}

	public static int KACounter
	{
		get
		{
			return Microsoft.Maui.Storage.Preferences.Get("KACounter", 0);
		}
		set
		{
			Microsoft.Maui.Storage.Preferences.Set("KACounter", value);
		}
	}

	public static void Reset()
	{
		Microsoft.Maui.Storage.Preferences.Remove("DemoPin");
		Microsoft.Maui.Storage.Preferences.Remove("EmailAddress");
		Microsoft.Maui.Storage.Preferences.Remove("EmailCheckDate");
		Microsoft.Maui.Storage.Preferences.Remove("EmailAddressVerified");
		Microsoft.Maui.Storage.Preferences.Remove("TwoFactorEnabled");
		Microsoft.Maui.Storage.Preferences.Remove("KACertificate");
		Microsoft.Maui.Storage.Preferences.Remove("KACounter");
	}
}
