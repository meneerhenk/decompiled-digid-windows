using System;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace DigiD.Common.Interfaces;

public interface INavigationService
{
	string CurrentPageId { get; }

	INavigation? Navigation { get; }

	Page? CurrentPage { get; }

	Task PopToRootAsync();

	Task PopToAsync<TPage>() where TPage : Page;

	Task PopAsync(bool animate = true);

	Task PopCurrentModalPage(bool animate = true);

	Task NavigateAsync<TP>(bool animated = true) where TP : Page;

	Task NavigateAsync<TP, TVm>(Action<TVm>? configureAction = null, bool animated = true) where TP : Page where TVm : IViewModel;

	Task NavigateAsync<TP, TVm>(Func<TVm, Task>? configureTask = null, bool animated = true) where TP : Page where TVm : IViewModel;

	Task PushModalAsync<TP>(bool animate = true, bool navPage = false) where TP : Page;

	Task PushModalAsync<TP, TVm>(Action<TVm>? configureAction = null, bool animate = true, bool navPage = false) where TP : Page where TVm : IViewModel;

	void SetRoot<TPage>() where TPage : Page;

	TPage GetPage<TPage>() where TPage : Page;

	Page GetPage<TPage, TVm>(Action<TVm>? configureAction = null) where TPage : Page where TVm : IViewModel;

	Task<bool> IsWindowAndPageAvailable();
}
