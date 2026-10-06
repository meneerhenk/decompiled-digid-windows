using DigiD.Common.Interfaces;
using LocalizationResourceManager.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;

namespace DigiD.Common.Controls.Settings;

public class BaseSettingsView : ContentView
{
	private readonly ILocalizationResourceManager localizationManager;

	public static readonly BindableProperty IntroProperty = BindableProperty.Create("Intro", typeof(string), typeof(BaseSettingsView));

	public string Intro
	{
		get
		{
			string text = (string)GetValue(IntroProperty);
			return (!string.IsNullOrWhiteSpace(text)) ? localizationManager[text] : string.Empty;
		}
		set
		{
			SetValue(IntroProperty, value);
		}
	}

	public BaseSettingsView()
	{
		localizationManager = ((IApp)Application.Current).ServiceProvider.GetRequiredService<ILocalizationResourceManager>();
	}
}
