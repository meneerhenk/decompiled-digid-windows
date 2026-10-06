using DigiD.Common.Interfaces;
using DigiD.Common.SessionModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;

namespace DigiD.Common.Controls.Models;

public class PageMenuItem<TPage> : MenuItem where TPage : Page
{
	public PageMenuItem(string testId, string title, string icon)
		: base(testId, title, icon, () => AppSession.ServiceProvider.GetRequiredService<INavigationService>().NavigateAsync<TPage>())
	{
		base.IsChevronVisible = true;
	}
}
