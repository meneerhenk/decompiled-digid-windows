using System;
using System.Threading.Tasks;
using CommunityToolkit.Maui;
using DigiD.Common.Interfaces;
using DigiD.Common.Plugins.ViewModels;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Dispatching;
using Microsoft.Maui.Graphics;

namespace DigiD.Common.Plugins.Services;

internal class DialogService(IA11YService a11YService, CommunityToolkit.Maui.IPopupService popupService, IDispatcher dispatcher) : IDialogService
{
	private bool _isShowing;

	private PopupOptions? _popupOptions;

	private Page? _currentPage;

	public void Show()
	{
		if (_isShowing || _currentPage != null)
		{
			return;
		}
		_currentPage = GetCurrentPage();
		if (_currentPage != null)
		{
			_isShowing = true;
			if (_popupOptions == null)
			{
				_popupOptions = new PopupOptions
				{
					PageOverlayColor = Colors.Black.WithAlpha(0.5f),
					CanBeDismissedByTappingOutsideOfPopup = false,
					Shadow = null,
					Shape = null
				};
			}
			dispatcher.Dispatch(delegate
			{
				popupService.ShowPopup<SpinnerPopupViewModel>(_currentPage, _popupOptions);
			});
		}
	}

	public async Task Hide()
	{
		if (!_isShowing || _currentPage == null)
		{
			return;
		}
		_isShowing = false;
		await Application.Current.Dispatcher.DispatchAsync(async delegate
		{
			try
			{
				await Task.Delay(500);
				await popupService.ClosePopupAsync(_currentPage);
			}
			catch (Exception)
			{
			}
			finally
			{
				_currentPage = null;
			}
			if (a11YService.IsInVoiceOverMode)
			{
				a11YService.NotifyForNewPage();
			}
		});
	}

	private static Page? GetCurrentPage()
	{
		if (Application.Current == null || Application.Current.Windows.Count == 0)
		{
			return null;
		}
		Window window = Application.Current.Windows[0];
		return (window.Page is NavigationPage navigationPage) ? navigationPage.CurrentPage : window.Page;
	}
}
