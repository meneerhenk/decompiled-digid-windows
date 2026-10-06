using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using DigiD.Common.Controls.Models;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Messages;
using DigiD.Common.Resources;
using DigiD.Common.Settings;
using LocalizationResourceManager.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;

namespace DigiD.Common.Controls.Settings;

public class ScreenshotSelectView : SettingSelectView
{
	private readonly IMobileSettings settings;

	private readonly IMatomoService matomoService;

	private readonly IPopupService popupService;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<bool>? switchSettingCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand<bool> SwitchSettingCommand => switchSettingCommand ?? (switchSettingCommand = new AsyncRelayCommand<bool>(SwitchSetting));

	public ScreenshotSelectView()
		: base("DG058_Title", "DG058_Explanation")
	{
		settings = ((IApp)Application.Current).ServiceProvider.GetRequiredService<IMobileSettings>();
		matomoService = ((IApp)Application.Current).ServiceProvider.GetRequiredService<IMatomoService>();
		popupService = ((IApp)Application.Current).ServiceProvider.GetRequiredService<IPopupService>();
		bool screenshotEnabled = settings.ScreenshotEnabled;
		int num = 2;
		List<AppSettingsModel> list = new List<AppSettingsModel>(num);
		CollectionsMarshal.SetCount(list, num);
		Span<AppSettingsModel> span = CollectionsMarshal.AsSpan(list);
		span[0] = new AppSettingsModel(true, "ScreenshotOn", new LocalizedString(() => CommonResources.Alg_On))
		{
			IsSelected = screenshotEnabled
		};
		span[1] = new AppSettingsModel(false, "ScreenshotOff", new LocalizedString(() => DigiDAppResources.DG058_OffSwitch))
		{
			IsSelected = !screenshotEnabled
		};
		base.SupportedSettings = list;
		base.Command = SwitchSettingCommand;
	}

	[RelayCommand]
	private async Task SwitchSetting(bool enabled)
	{
		if (enabled)
		{
			bool? confirm = await popupService.DisplayAlert(DigiDAppResources.FM109_Title, DigiDAppResources.FM109_Message, DigiDAppResources.FM109_TurnOn, CommonResources.Alg_Cancel, invertCallToAction: false, AlertMessageType.FM109);
			if (!confirm.HasValue || !confirm.Value)
			{
				foreach (AppSettingsModel setting in base.SupportedSettings)
				{
					setting.IsSelected = !(bool)setting.Code;
				}
				return;
			}
			matomoService.TrackAction("Preferences", "Screenshot disabled", "ScreenshotSelectView");
		}
		else
		{
			matomoService.TrackAction("Preferences", "Screenshot enabled", "ScreenshotSelectView");
		}
		settings.ScreenshotEnabled = enabled;
		WeakReferenceMessenger.Default.Send(new ScreenshotSettingsChangedMessage(enabled));
	}
}
