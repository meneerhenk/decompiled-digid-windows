using System.Collections.ObjectModel;
using System.Threading.Tasks;
using DigiD.Common.Models;

namespace DigiD.Common.Interfaces;

public interface IToastService
{
	ObservableCollection<ToastModel> Toasts { get; }

	Task ShowSuccess(string message, string? title = null, bool popToRoot = true, ToastPriority priority = ToastPriority.Low);

	Task ShowWarning(string message, string? title = null, bool popToRoot = true, ToastPriority priority = ToastPriority.Low);

	Task ShowError(string message, string? title = null, bool popToRoot = true, ToastPriority priority = ToastPriority.Low);

	Task Show(string message, ToastType type, string? title = null, bool popToRoot = true, ToastPriority priority = ToastPriority.Low);

	void Remove(ToastModel toastModel);
}
