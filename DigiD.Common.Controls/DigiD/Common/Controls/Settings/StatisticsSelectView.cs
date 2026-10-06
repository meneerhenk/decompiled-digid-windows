using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.Controls.Models;
using DigiD.Common.Interfaces;
using DigiD.Common.Resources;
using LocalizationResourceManager.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;

namespace DigiD.Common.Controls.Settings;

public class StatisticsSelectView : SettingSelectView
{
	private readonly IGeneralPreferences generalPreferences;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private RelayCommand<string>? switchSettingCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand<string> SwitchSettingCommand => switchSettingCommand ?? (switchSettingCommand = new RelayCommand<string>(SwitchSetting));

	public StatisticsSelectView()
		: base("Statistics_Title", "Statistics_Explanation")
	{
		generalPreferences = ((IApp)Application.Current).ServiceProvider.GetRequiredService<IGeneralPreferences>();
		bool matomoTrackEnabled = generalPreferences.MatomoTrackEnabled;
		int num = 2;
		List<AppSettingsModel> list = new List<AppSettingsModel>(num);
		CollectionsMarshal.SetCount(list, num);
		Span<AppSettingsModel> span = CollectionsMarshal.AsSpan(list);
		span[0] = new AppSettingsModel("1", "StatisticsOn", new LocalizedString(() => CommonResources.Alg_On))
		{
			IsSelected = matomoTrackEnabled
		};
		span[1] = new AppSettingsModel("0", "StatisticsOff", new LocalizedString(() => CommonResources.Alg_Off))
		{
			IsSelected = !matomoTrackEnabled
		};
		base.SupportedSettings = list;
		base.Command = SwitchSettingCommand;
	}

	[RelayCommand]
	private void SwitchSetting(string value)
	{
		ICrashService requiredService = ((IApp)Application.Current).ServiceProvider.GetRequiredService<ICrashService>();
		IMatomoService requiredService2 = ((IApp)Application.Current).ServiceProvider.GetRequiredService<IMatomoService>();
		bool flag = value == "1";
		if (!flag)
		{
			requiredService2.TrackAction("Preferences", "Matomo Analytics disabled", "StatisticsSelectView");
		}
		generalPreferences.MatomoTrackEnabled = flag;
		requiredService.Init();
	}
}
