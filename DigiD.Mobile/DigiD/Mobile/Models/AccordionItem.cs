using DigiD.Common.SessionModels;
using LocalizationResourceManager.Maui;
using Microsoft.Extensions.DependencyInjection;

namespace DigiD.Mobile.Models;

public class AccordionItem
{
	public LocalizedString Title { get; } = new LocalizedString(() => AppSession.ServiceProvider.GetRequiredService<ILocalizationResourceManager>()[titleKey]);

	public LocalizedString FaqText { get; } = new LocalizedString(() => AppSession.ServiceProvider.GetRequiredService<ILocalizationResourceManager>()[faqTextKey]);

	public string AccessibilityId { get; }

	public AccordionItem(string accessibilityId, string titleKey, string faqTextKey)
	{
		AccessibilityId = accessibilityId;
		base._002Ector();
	}
}
