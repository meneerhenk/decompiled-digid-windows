using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.Controls.Models;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Resources;
using LocalizationResourceManager.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;

namespace DigiD.Common.Controls.Settings;

public class DarkModeSelectView : SettingSelectView
{
	private readonly IGeneralPreferences generalPreferences;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private RelayCommand<AppTheme>? setAppThemeCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand<AppTheme> SetAppThemeCommand => setAppThemeCommand ?? (setAppThemeCommand = new RelayCommand<AppTheme>(SetAppTheme));

	public DarkModeSelectView()
		: base("DarkMode_Title", "DarkMode_Explanation")
	{
		generalPreferences = ((IApp)Application.Current).ServiceProvider.GetRequiredService<IGeneralPreferences>();
		AppTheme appTheme = generalPreferences.AppTheme;
		int num = 3;
		List<AppSettingsModel> list = new List<AppSettingsModel>(num);
		CollectionsMarshal.SetCount(list, num);
		Span<AppSettingsModel> span = CollectionsMarshal.AsSpan(list);
		span[0] = new AppSettingsModel(AppTheme.Dark, "DarkModeOn", new LocalizedString(() => CommonResources.Alg_On))
		{
			IsSelected = (appTheme == AppTheme.Dark)
		};
		span[1] = new AppSettingsModel(AppTheme.Light, "DarkModeOff", new LocalizedString(() => CommonResources.Alg_Off))
		{
			IsSelected = (appTheme == AppTheme.Light)
		};
		span[2] = new AppSettingsModel(AppTheme.Unspecified, "DarkModeAutomatic", new LocalizedString(() => CommonResources.DarkMode_Automatic))
		{
			IsSelected = (appTheme == AppTheme.Unspecified)
		};
		base.SupportedSettings = list;
		base.Command = SetAppThemeCommand;
	}

	[RelayCommand]
	private void SetAppTheme(AppTheme appTheme)
	{
		generalPreferences.AppTheme = appTheme;
		ThemeHelper.SetTheme(appTheme);
		ThemeHelper.SetStatusBarStyleAndColor();
	}
}
