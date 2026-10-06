using System;
using System.Threading.Tasks;
using DigiD.Common.Models.Enums;

namespace DigiD.Common.Interfaces;

public interface IPopupService
{
	Task<bool?> DisplayAlert(string title, string? message, string? accept = null, string? cancel = null, bool invertCallToAction = false, AlertMessageType type = AlertMessageType.TBD, TimeSpan? autoHideDelay = null, string? imageSource = null, bool showCloseIcon = false);

	Task OpenBottomSheet(string pageId, string title, string message, string? actionText = null, Func<Task>? action = null, bool actionAsButton = true, bool firstCloseThenExecuteAction = false);
}
