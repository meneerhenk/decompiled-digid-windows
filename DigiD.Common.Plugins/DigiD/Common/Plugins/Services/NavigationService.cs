using System;
using System.Linq;
using System.Threading.Tasks;
using DigiD.Common.BaseClasses;
using DigiD.Common.Enums;
using DigiD.Common.Interfaces;
using DigiD.Common.SessionModels;
using DigiD.Common.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;

namespace DigiD.Common.Plugins.Services;

internal class NavigationService(IServiceProvider services, ILogger<NavigationService> logger, IA11YService a11YService) : INavigationService
{
	public INavigation? Navigation
	{
		get
		{
			if (Application.Current == null || Application.Current.Windows.Count == 0 || Application.Current.Windows[0].Page == null)
			{
				return null;
			}
			return Application.Current.Windows[0].Page.Navigation;
		}
	}

	public Page? CurrentPage
	{
		get
		{
			Application? current = Application.Current;
			return (current != null && current.Windows.Count > 0) ? Application.Current.Windows[0].Page : null;
		}
	}

	public string CurrentPageId => (CurrentPage is NavigationPage { CurrentPage: { BindingContext: CommonBaseViewModel bindingContext } }) ? bindingContext.PageId : "TBD";

	private T ResolvePage<T>() where T : Page
	{
		return services.GetRequiredService<T>();
	}

	public TPage GetPage<TPage>() where TPage : Page
	{
		TPage val = ResolvePage<TPage>();
		ArgumentNullException.ThrowIfNull(val.BindingContext, "page.BindingContext");
		return val;
	}

	private async Task<Page> GetPage<TPage, TVm>(Func<TVm, Task>? configureTask = null) where TPage : Page where TVm : IViewModel
	{
		TVm vm = services.GetRequiredService<TVm>();
		if (configureTask != null)
		{
			await configureTask(vm);
		}
		TPage page = services.GetRequiredService<TPage>();
		page.BindingContext = vm;
		return page;
	}

	public Page GetPage<TPage, TVm>(Action<TVm>? configureAction = null) where TPage : Page where TVm : IViewModel
	{
		TVm requiredService = services.GetRequiredService<TVm>();
		configureAction?.Invoke(requiredService);
		TPage requiredService2 = services.GetRequiredService<TPage>();
		requiredService2.BindingContext = requiredService;
		return requiredService2;
	}

	private Task NavigateAsync<TPage, TVm>(Action<TVm>? configureAction = null, Func<TVm, Task>? configureTask = null, bool animated = true) where TPage : Page where TVm : IViewModel
	{
		return MainThread.InvokeOnMainThreadAsync(async delegate
		{
			try
			{
				Page page = ((configureAction == null) ? (await GetPage<TPage, TVm>(configureTask)) : GetPage<TPage, TVm>(configureAction));
				Page page2 = page;
				if (Navigation != null)
				{
					try
					{
						await Navigation.PushAsync(page2, animated);
					}
					catch (InvalidOperationException)
					{
						await Task.Delay(100);
						await Navigation.PushAsync(page2, animated);
					}
				}
			}
			catch (Exception ex2)
			{
				Exception e = ex2;
				Console.WriteLine(e);
			}
		});
	}

	public Task NavigateAsync<TPage, TVm>(Action<TVm>? configureAction = null, bool animated = true) where TPage : Page where TVm : IViewModel
	{
		return NavigateAsync<TPage, TVm>(configureAction, null, animated);
	}

	public Task NavigateAsync<TPage, TVm>(Func<TVm, Task>? configureTask = null, bool animated = true) where TPage : Page where TVm : IViewModel
	{
		return NavigateAsync<TPage, TVm>(null, configureTask, animated);
	}

	public Task NavigateAsync<TPage>(bool animated = true) where TPage : Page
	{
		return MainThread.InvokeOnMainThreadAsync(async delegate
		{
			try
			{
				TPage page = GetPage<TPage>();
				if (Navigation != null)
				{
					try
					{
						await Navigation.PushAsync(page, animated);
					}
					catch (InvalidOperationException)
					{
						await Task.Delay(100);
						await Navigation.PushAsync(page, animated);
					}
				}
			}
			catch (Exception ex2)
			{
				Exception e = ex2;
				logger.LogError("Error on NavigateAsync {error}", e.ToString());
				Console.WriteLine(e);
			}
		});
	}

	public void SetRoot<TPage>() where TPage : Page
	{
		MainThread.BeginInvokeOnMainThread(delegate
		{
			Application.Current.Windows[0].Page = new NavigationPage(GetPage<TPage>());
			a11YService.NotifyForNewPage();
		});
	}

	public Task PushModalAsync<TPage>(bool animate = true, bool navPage = false) where TPage : Page
	{
		return MainThread.InvokeOnMainThreadAsync(async delegate
		{
			try
			{
				TPage page = GetPage<TPage>();
				await DoTheModalPushAsync(animate, navPage, page);
			}
			catch (Exception ex)
			{
				Exception e = ex;
				logger.LogError(e, "PushModalAsync ln 142");
			}
		});
	}

	public Task PushModalAsync<TPage, TVm>(Action<TVm>? configureAction = null, bool animate = true, bool navPage = false) where TPage : Page where TVm : IViewModel
	{
		return MainThread.InvokeOnMainThreadAsync(async delegate
		{
			try
			{
				Page page = GetPage<TPage, TVm>(configureAction);
				await DoTheModalPushAsync(animate, navPage, page);
			}
			catch (Exception ex)
			{
				Exception e = ex;
				logger.LogError(e, "PushModalAsync ln 158");
			}
		});
	}

	private async Task DoTheModalPushAsync(bool animate, bool navPage, Page page)
	{
		if (Navigation != null)
		{
			try
			{
				await Navigation.PushModalAsync(navPage ? new NavigationPage(page) : page, animate);
			}
			catch (InvalidOperationException)
			{
				await Task.Delay(100);
				await Navigation.PushModalAsync(navPage ? new NavigationPage(page) : page, animate);
			}
		}
	}

	public async Task<bool> IsWindowAndPageAvailable()
	{
		int tries = 0;
		while (Application.Current == null || Application.Current.Windows.Count == 0 || Application.Current.Windows[0].Page == null || Application.Current.Windows[0].Page.Navigation == null)
		{
			tries++;
			if (tries == 10)
			{
				return false;
			}
			await Task.Delay(100);
		}
		return true;
	}

	public Task PopToRootAsync()
	{
		return MainThread.InvokeOnMainThreadAsync(async delegate
		{
			if (!AppSession.IsAuthenticated && AppSession.ActivationStatus != ActivationStatus.NotActivated && !AppSession.IsAppActivated)
			{
				await CheckAndCloseModalPage();
				if (await IsWindowAndPageAvailable())
				{
					foreach (Page page in Application.Current.Windows[0].Page.Navigation.NavigationStack.Reverse().ToList())
					{
						if (page.BindingContext is BasePinCodeViewModel)
						{
							return;
						}
						if (Navigation != null)
						{
							try
							{
								await Navigation.PopAsync(animated: false);
							}
							catch (InvalidOperationException)
							{
								await Task.Delay(100);
								await Navigation.PopAsync(animated: false);
							}
						}
					}
				}
			}
			else
			{
				await CheckAndCloseModalPage();
				if (Navigation != null)
				{
					try
					{
						await Navigation.PopToRootAsync(animated: true);
					}
					catch (InvalidOperationException)
					{
						await Task.Delay(100);
						await Navigation.PopToRootAsync(animated: true);
					}
				}
			}
		});
	}

	private async Task CheckAndCloseModalPage()
	{
		if (Navigation != null && Navigation.ModalStack.Count > 0)
		{
			try
			{
				await Navigation.PopModalAsync(animated: false);
			}
			catch (InvalidOperationException)
			{
				await Task.Delay(100);
				await Navigation.PopModalAsync(animated: false);
			}
		}
	}

	public Task PopAsync(bool animate = true)
	{
		return MainThread.InvokeOnMainThreadAsync(async delegate
		{
			if (Navigation != null)
			{
				if (Navigation.ModalStack.Count > 0)
				{
					await PopCurrentModalPage(animate);
				}
				else
				{
					try
					{
						await Navigation.PopAsync(animate);
					}
					catch (InvalidOperationException)
					{
						await Task.Delay(100);
						await Navigation.PopAsync(animate);
					}
				}
			}
		});
	}

	public Task PopToAsync<TPage>() where TPage : Page
	{
		return MainThread.InvokeOnMainThreadAsync(async delegate
		{
			if (Navigation != null)
			{
				foreach (Page page in Navigation.NavigationStack.Reverse().ToList())
				{
					if (page is TPage)
					{
						a11YService.NotifyForNewPage();
						return;
					}
					try
					{
						await Navigation.PopAsync(animated: false);
					}
					catch (InvalidOperationException)
					{
						await Task.Delay(100);
						await Navigation.PopAsync(animated: false);
					}
				}
			}
		});
	}

	public Task PopCurrentModalPage(bool animate = true)
	{
		return MainThread.InvokeOnMainThreadAsync(async delegate
		{
			if (Navigation == null)
			{
				return Task.CompletedTask;
			}
			try
			{
				return (Navigation.ModalStack.Count == 0) ? Task.CompletedTask : Navigation.PopModalAsync(animate);
			}
			catch (InvalidOperationException)
			{
				await Task.Delay(100);
				return Navigation.PopToRootAsync(animated: true);
			}
		});
	}
}
