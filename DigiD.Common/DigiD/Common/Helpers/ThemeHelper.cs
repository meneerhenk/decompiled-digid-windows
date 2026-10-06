using System.Collections.Generic;
using CommunityToolkit.Mvvm.Messaging;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Messages;
using DigiD.Common.SessionModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices;

namespace DigiD.Common.Helpers;

public static class ThemeHelper
{
	public static Dictionary<string, ResourceDictionary> Themes { get; } = new Dictionary<string, ResourceDictionary>();

	public static bool IsAutomaticAppThemePossible => (DeviceInfo.Platform == DevicePlatform.Android && DeviceInfo.Version.Major >= 10) || (DeviceInfo.Platform == DevicePlatform.iOS && DeviceInfo.Version.Major >= 13) || DeviceInfo.Idiom == DeviceIdiom.Desktop;

	public static bool IsInDarkMode { get; private set; } = false;

	public static void InitThemes(Dictionary<string, ResourceDictionary> themes)
	{
		foreach (string key in themes.Keys)
		{
			Themes.Add(key, themes[key]);
		}
		Application.Current.RequestedThemeChanged += delegate(object? _, AppThemeChangedEventArgs e)
		{
			AppTheme appTheme = AppSession.ServiceProvider.GetRequiredService<IGeneralPreferences>().AppTheme;
			if (appTheme == AppTheme.Unspecified)
			{
				SetTheme(e.RequestedTheme);
			}
			else
			{
				SetTheme(appTheme);
			}
			SetStatusBarStyleAndColor();
		};
		SetTheme(AppSession.ServiceProvider.GetRequiredService<IGeneralPreferences>().AppTheme);
	}

	public static void SetTheme(AppTheme theme)
	{
		SetResources(theme);
	}

	public static void SetStatusBarStyleAndColor()
	{
	}

	private static void SetResources(AppTheme theme)
	{
		bool useDyslexiaFont = AppSession.ServiceProvider.GetRequiredService<IFontService>().UseDyslexiaFont;
		if (theme == AppTheme.Unspecified)
		{
			theme = Application.Current.PlatformAppTheme;
		}
		Application.Current.Resources.MergedDictionaries.Clear();
		Application.Current.Resources.MergedDictionaries.Add(Themes["General"]);
		string text = ((theme == AppTheme.Dark) ? "Dark" : "Light");
		text += (useDyslexiaFont ? "Dyslexia" : "");
		ResourceDictionary item = Themes[text];
		IsInDarkMode = theme == AppTheme.Dark;
		Application.Current.Resources.MergedDictionaries.Add(item);
		WeakReferenceMessenger.Default.Send(new ThemeChangedMessage());
	}
}
