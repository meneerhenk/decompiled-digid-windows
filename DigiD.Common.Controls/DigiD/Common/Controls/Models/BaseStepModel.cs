using DigiD.Common.SessionModels;
using LocalizationResourceManager.Maui;
using Microsoft.Extensions.DependencyInjection;

namespace DigiD.Common.Controls.Models;

public abstract class BaseStepModel(string title, string text, params object[] args)
{
	private readonly ILocalizationResourceManager _localizationResourceManager = AppSession.ServiceProvider.GetRequiredService<ILocalizationResourceManager>();

	public int Index { get; set; }

	public LocalizedString Title => new LocalizedString(() => _localizationResourceManager[title, args]);

	public LocalizedString Text => new LocalizedString(() => _localizationResourceManager[text, args]);

	public abstract bool HasSkipped { get; }

	public string ImageSource
	{
		get
		{
			if (HasSkipped)
			{
				return "digid_icon_vink_later.png";
			}
			return "digid_icon_vink.png";
		}
	}
}
