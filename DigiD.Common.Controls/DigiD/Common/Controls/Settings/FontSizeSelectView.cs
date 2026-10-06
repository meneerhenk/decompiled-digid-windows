using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.Controls.Models;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Resources;
using LocalizationResourceManager.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;

namespace DigiD.Common.Controls.Settings;

public class FontSizeSelectView : SettingSelectView
{
	private readonly IFontService fontService;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private RelayCommand<FontSize>? setFontSizeCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand<FontSize> SetFontSizeCommand => setFontSizeCommand ?? (setFontSizeCommand = new RelayCommand<FontSize>(SetFontSize));

	public FontSizeSelectView()
		: base("FontSize_Title", "FontSize_Explanation")
	{
		fontService = ((IApp)Application.Current).ServiceProvider.GetRequiredService<IFontService>();
		FontSize selectedFontSize = fontService.SelectedFontSize;
		int num = 5;
		List<AppSettingsModel> list = new List<AppSettingsModel>(num);
		CollectionsMarshal.SetCount(list, num);
		Span<AppSettingsModel> span = CollectionsMarshal.AsSpan(list);
		span[0] = new AppSettingsModel(FontSize.Small, "SmallFont", new LocalizedString(() => CommonResources.FontSize_Small))
		{
			IsSelected = (selectedFontSize == FontSize.Small)
		};
		span[1] = new AppSettingsModel(FontSize.Default, "DefaultFont", new LocalizedString(() => CommonResources.FontSize_Normal))
		{
			IsSelected = (selectedFontSize == FontSize.Default)
		};
		span[2] = new AppSettingsModel(FontSize.Medium, "MediumFont", new LocalizedString(() => CommonResources.FontSize_Large))
		{
			IsSelected = (selectedFontSize == FontSize.Medium)
		};
		span[3] = new AppSettingsModel(FontSize.Large, "LargeFont", new LocalizedString(() => CommonResources.FontSize_Largest))
		{
			IsSelected = (selectedFontSize == FontSize.Large)
		};
		span[4] = new AppSettingsModel(FontSize.Auto, "AutoFont", new LocalizedString(() => CommonResources.FontSize_Automatic))
		{
			IsSelected = (selectedFontSize == FontSize.Auto)
		};
		base.SupportedSettings = list;
		base.Command = SetFontSizeCommand;
	}

	[RelayCommand]
	private void SetFontSize(FontSize fontSize)
	{
		fontService.SelectedFontSize = fontSize;
	}
}
