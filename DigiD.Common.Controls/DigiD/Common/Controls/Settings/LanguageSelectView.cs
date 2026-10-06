using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Messaging;
using DigiD.Common.Controls.Models;
using DigiD.Common.Enums;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Messages;
using DigiD.Common.Resources;
using DigiD.Common.Resources.Enums;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using LocalizationResourceManager.Maui;
using Microsoft.Extensions.DependencyInjection;

namespace DigiD.Common.Controls.Settings;

public class LanguageSelectView : SettingSelectView
{
	private static readonly IGeneralPreferences Preferences = AppSession.ServiceProvider.GetRequiredService<IGeneralPreferences>();

	private readonly IMobileSettings? mobileSettings;

	private readonly IDialogService dialogService;

	public static List<AppSettingsModel> SupportedLanguages { get; private set; } = new List<AppSettingsModel>();

	private static bool IsPapiamentuSupported => Localization.AppType == AppType.DigiDApp;

	public static void InitAndSetLanguagePreference()
	{
		ILocalizationResourceManager localizationResourceManager = AppSession.ServiceProvider.GetRequiredService<ILocalizationResourceManager>();
		int num = 2;
		List<AppSettingsModel> list = new List<AppSettingsModel>(num);
		CollectionsMarshal.SetCount(list, num);
		Span<AppSettingsModel> span = CollectionsMarshal.AsSpan(list);
		span[0] = new AppSettingsModel("nl", "DutchLanguage", new LocalizedString(() => localizationResourceManager["Alg_Language_NL"]));
		span[1] = new AppSettingsModel("en", "EnglishLanguage", new LocalizedString(() => localizationResourceManager["Alg_Language_EN"]));
		List<AppSettingsModel> list2 = list;
		if (IsPapiamentuSupported)
		{
			list2.Add(new AppSettingsModel("pap-AW", "PapiamentuLanguage", new LocalizedString(() => localizationResourceManager["Alg_Language_PAP"])));
		}
		CultureInfo cultureInfo;
		try
		{
			SupportedLanguages = list2;
			CheckSupportedLanguage();
			cultureInfo = CultureInfo.GetCultureInfo(Preferences.Language);
		}
		catch (Exception)
		{
			cultureInfo = CultureInfo.GetCultureInfo("nl");
		}
		localizationResourceManager.CurrentCulture = cultureInfo;
		Localization.SetCurrentCulture(cultureInfo);
	}

	private static void CheckSupportedLanguage()
	{
		if (SupportedLanguages.All((AppSettingsModel lang) => !((string)lang.Code).Equals(Preferences.Language, StringComparison.CurrentCultureIgnoreCase) && (!IsPapiamentuSupported || !Preferences.Language.Equals("es", StringComparison.CurrentCultureIgnoreCase))))
		{
			Preferences.Language = "nl";
		}
	}

	private void SetSelectedLanguage(string languageToCheck)
	{
		foreach (AppSettingsModel supportedSetting in base.SupportedSettings)
		{
			if (supportedSetting.Code is string text)
			{
				string text2 = (IsPapiamentuSupported ? CheckWorkaround(text) : text);
				supportedSetting.IsSelected = text2 == languageToCheck;
			}
		}
	}

	private void ChangeLanguage(string language)
	{
		Preferences.Language = language;
		CultureInfo currentCulture = new CultureInfo(language);
		LocalizationManager.CurrentCulture = currentCulture;
		Localization.SetCurrentCulture(currentCulture);
		SetItems();
		WeakReferenceMessenger.Default.Send(new LanguageChangedMessage(language));
		if (mobileSettings != null && mobileSettings.ActivationStatus != ActivationStatus.NotActivated)
		{
			AppSession.ServiceProvider.GetRequiredService<IDeviceLockService>().Lock(userAction: false, logoutSession: true, forced: true);
		}
		else
		{
			AppSession.ServiceProvider.GetRequiredService<INavigationService>().PopToRootAsync();
		}
	}

	protected override async Task SetSetting(object setting)
	{
		if (setting is string language)
		{
			dialogService.Show();
			await Task.Delay(100);
			string languageToCheck = (IsPapiamentuSupported ? CheckWorkaround(language) : language);
			SetSelectedLanguage(languageToCheck);
			await dialogService.Hide();
			await Task.Delay(100);
			ChangeLanguage(languageToCheck);
			SetTitle("Alg_Language");
		}
	}

	private static string CheckWorkaround(string language)
	{
		return language.Equals("pap-AW", StringComparison.InvariantCultureIgnoreCase) ? "es" : language;
	}

	public LanguageSelectView()
		: base("Alg_Language")
	{
		dialogService = AppSession.ServiceProvider.GetRequiredService<IDialogService>();
		mobileSettings = AppSession.ServiceProvider.GetService<IMobileSettings>();
		base.SupportedSettings = SupportedLanguages.ToList();
		CheckSupportedLanguage();
		SetSelectedLanguage(Preferences.Language);
	}
}
