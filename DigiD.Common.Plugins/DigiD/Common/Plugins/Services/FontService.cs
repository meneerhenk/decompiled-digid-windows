using System;
using CommunityToolkit.Mvvm.Messaging;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Messages;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;

namespace DigiD.Common.Plugins.Services;

internal class FontService : IFontService
{
	public FontSize SelectedFontSize
	{
		get
		{
			return Enum.Parse<FontSize>(Microsoft.Maui.Storage.Preferences.Get("SelectedFontSize", FontSize.Auto.ToString()));
		}
		set
		{
			Microsoft.Maui.Storage.Preferences.Set("SelectedFontSize", value.ToString());
			SetFontSize();
		}
	}

	public bool UseDyslexiaFont
	{
		get
		{
			return Microsoft.Maui.Storage.Preferences.Get("UseDyslexiaFont", defaultValue: false);
		}
		set
		{
			Microsoft.Maui.Storage.Preferences.Set("UseDyslexiaFont", value);
		}
	}

	public void Init()
	{
		ArgumentNullException.ThrowIfNull(Application.Current, "Application.Current");
		WeakReferenceMessenger.Default.Register<ThemeChangedMessage>(this, delegate
		{
			SetFontFamily();
			SetFontSize();
			SetColors();
		});
	}

	public void SetFontSize()
	{
		double num = 1.0;
		bool flag = true;
		switch (SelectedFontSize)
		{
		case FontSize.Small:
			num = 0.8;
			flag = false;
			break;
		case FontSize.Medium:
			num = 1.25;
			flag = false;
			break;
		case FontSize.Large:
			num = 2.0;
			flag = false;
			break;
		case FontSize.Default:
			flag = false;
			break;
		}
		Application.Current.Resources["FontAutoScalingEnabled"] = flag;
		Application.Current.Resources["MenuFontSize"] = 24;
		Application.Current.Resources["CaptionFontSize"] = 18.0 * num;
		Application.Current.Resources["DefaultFontSize"] = 24.0 * num;
		Application.Current.Resources["DefaultButtonFontSize"] = 26.0 * num;
		Application.Current.Resources["DefaultSecondaryButtonFontSize"] = 24.0 * num;
		Application.Current.Resources["DefaultHeaderFontSize"] = 34.0 * num;
	}

	public void SetFontFamily()
	{
		if (Application.Current != null)
		{
			Application.Current.Resources["FontLineHeight"] = (UseDyslexiaFont ? 1.1 : 1.0);
			Application.Current.Resources["FontRegular"] = (UseDyslexiaFont ? "Dyslexie-Regular" : "RO-Regular");
			Application.Current.Resources["FontBold"] = (UseDyslexiaFont ? "Dyslexie-Bold" : "RO-Bold");
			SetColors();
		}
	}

	private static void SetColors()
	{
		Application.Current.Resources["FontTextColor"] = Application.Current.Resources["FontColor"];
		Application.Current.Resources["AppPageBackground"] = Application.Current.Resources["BackgroundColor"];
	}
}
