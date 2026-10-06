using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using Microsoft.Maui.ApplicationModel;

namespace DigiD.Common.Plugins.Services;

internal class ToastService(INavigationService navigationService) : IToastService
{
	public ObservableCollection<ToastModel> Toasts { get; } = new ObservableCollection<ToastModel>();

	public async Task ShowSuccess(string message, string? title = null, bool popToRoot = true, ToastPriority priority = ToastPriority.Low)
	{
		await Add(message, title, ToastType.Success, popToRoot, priority);
	}

	public async Task ShowWarning(string message, string? title = null, bool popToRoot = true, ToastPriority priority = ToastPriority.Low)
	{
		await Add(message, title, ToastType.Warning, popToRoot, priority);
	}

	public async Task ShowError(string message, string? title = null, bool popToRoot = true, ToastPriority priority = ToastPriority.Low)
	{
		await Add(message, title, ToastType.Error, popToRoot, priority);
	}

	public async Task Show(string message, ToastType type, string? title = null, bool popToRoot = true, ToastPriority priority = ToastPriority.Low)
	{
		await Add(message, title, type, popToRoot, priority);
	}

	public void Remove(ToastModel toastModel)
	{
		ToastModel toast = Toasts.FirstOrDefault((ToastModel x) => x.Type == toastModel.Type && x.Message.Equals(toastModel.Message) && x.CreationTime == toastModel.CreationTime);
		if (toast != null)
		{
			MainThread.BeginInvokeOnMainThread(delegate
			{
				Toasts.Remove(toast);
			});
		}
	}

	private async Task Add(string message, string? title, ToastType type, bool popToRoot = true, ToastPriority priority = ToastPriority.Low)
	{
		await MainThread.InvokeOnMainThreadAsync(async delegate
		{
			Toasts.Add(new ToastModel(message, title, type, priority));
			if (popToRoot)
			{
				await navigationService.PopToRootAsync();
			}
		});
	}
}
