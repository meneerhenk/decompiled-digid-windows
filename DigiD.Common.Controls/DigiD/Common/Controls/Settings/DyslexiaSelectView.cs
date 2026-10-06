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
using Microsoft.Maui.Controls;

namespace DigiD.Common.Controls.Settings;

public class DyslexiaSelectView : SettingSelectView
{
	private readonly IMatomoService matomoService;

	private readonly IFontService fontService;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private RelayCommand<string>? setDyslexiaCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand<string> SetDyslexiaCommand => setDyslexiaCommand ?? (setDyslexiaCommand = new RelayCommand<string>(SetDyslexia));

	public DyslexiaSelectView()
		: base("Dyslexia_Title", "Dyslexia_Explanation")
	{
		fontService = ((IApp)Application.Current).ServiceProvider.GetRequiredService<IFontService>();
		matomoService = ((IApp)Application.Current).ServiceProvider.GetRequiredService<IMatomoService>();
		bool useDyslexiaFont = fontService.UseDyslexiaFont;
		int num = 2;
		List<AppSettingsModel> list = new List<AppSettingsModel>(num);
		CollectionsMarshal.SetCount(list, num);
		Span<AppSettingsModel> span = CollectionsMarshal.AsSpan(list);
		span[0] = new AppSettingsModel("1", "DyslexieOn", new LocalizedString(() => CommonResources.Alg_On))
		{
			IsSelected = useDyslexiaFont
		};
		span[1] = new AppSettingsModel("0", "DysLexieOff", new LocalizedString(() => CommonResources.Alg_Off))
		{
			IsSelected = !useDyslexiaFont
		};
		base.SupportedSettings = list;
		base.Command = SetDyslexiaCommand;
	}

	[RelayCommand]
	private void SetDyslexia(string value)
	{
		IGeneralPreferences requiredService = ((IApp)Application.Current).ServiceProvider.GetRequiredService<IGeneralPreferences>();
		bool flag = value == "1";
		fontService.UseDyslexiaFont = flag;
		matomoService.TrackAction("Preferences", "DyslexiaFont " + (flag ? "ingeschakeld" : "uitgeschakeld"), "DyslexiaSetting");
		ThemeHelper.SetTheme(requiredService.AppTheme);
	}
}
