using System;
using System.Globalization;
using DigiD.Common.BaseClasses;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Storage;

namespace DigiD.Common.Preferences;

public class GeneralPreferences : BaseAppSettings, IGeneralPreferences
{
	public string SelectedHost => "digid.nl";

	public bool MatomoTrackEnabled
	{
		get
		{
			return Microsoft.Maui.Storage.Preferences.Get("PiwikTrackEnabled", defaultValue: true);
		}
		set
		{
			Microsoft.Maui.Storage.Preferences.Set("PiwikTrackEnabled", value);
		}
	}

	public string Language
	{
		get
		{
			string text = Microsoft.Maui.Storage.Preferences.Get("Language", CultureInfo.InstalledUICulture.IetfLanguageTag);
			if (text.Equals("pap-AW", StringComparison.InvariantCultureIgnoreCase))
			{
				return "es";
			}
			return text.Split('-')[0];
		}
		set
		{
			Microsoft.Maui.Storage.Preferences.Set("Language", value);
		}
	}

	public AppTheme AppTheme
	{
		get
		{
			AppTheme result = ((!ThemeHelper.IsAutomaticAppThemePossible) ? AppTheme.Light : AppTheme.Unspecified);
			if (Microsoft.Maui.Storage.Preferences.ContainsKey("AppTheme"))
			{
				string value = Microsoft.Maui.Storage.Preferences.Get("AppTheme", result.ToString());
				if (Enum.TryParse<AppTheme>(value, out var result2))
				{
					return result2;
				}
			}
			return result;
		}
		set
		{
			Microsoft.Maui.Storage.Preferences.Set("AppTheme", value.ToString());
		}
	}

	public string InstanceId
	{
		get
		{
			string text = GetValue(string.Empty, "InstanceId");
			if (string.IsNullOrEmpty(text))
			{
				text = Guid.NewGuid().ToString();
				SetValue(text, "InstanceId");
			}
			return text;
		}
	}

	public string MatomoId
	{
		get
		{
			string text = Microsoft.Maui.Storage.Preferences.Get("MatomoId", string.Empty);
			if (string.IsNullOrEmpty(text))
			{
				text = Guid.NewGuid().ToString();
				Microsoft.Maui.Storage.Preferences.Set("MatomoId", text);
			}
			return text;
		}
	}

	public GeneralPreferences(ISecureStorageService secureStorageService)
		: base(secureStorageService)
	{
	}
}
