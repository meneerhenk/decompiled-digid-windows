using System;
using System.Globalization;
using LocalizationResourceManager.Maui;

namespace DigiD.Common.Extensions;

public static class LocalizationExtension
{
	public static void SetDefaultLanguage(this ILocalizationSettings settings)
	{
		string ietfLanguageTag = CultureInfo.InstalledUICulture.IetfLanguageTag;
		string name = (ietfLanguageTag.Equals("pap-AW", StringComparison.InvariantCultureIgnoreCase) ? "es" : ietfLanguageTag);
		settings.InitialCulture(CultureInfo.GetCultureInfo(name));
		settings.RestoreLatestCulture(restore: true);
	}
}
