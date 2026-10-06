using System;
using System.Threading.Tasks;
using DigiD.Common.Controls;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Plugins.Popups;
using DigiD.Common.Plugins.ViewModels;
using DigiD.Common.Resources;
using Plugin.Maui.BottomSheet;
using Plugin.Maui.BottomSheet.Navigation;

namespace DigiD.Common.Plugins.Services;

internal class PopupService(INavigationService navigationService, IDialogService dialogService, IBottomSheetNavigationService? bottomSheetNavigationService = null) : IPopupService
{
	public async Task<bool?> DisplayAlert(string title, string? message, string? accept = null, string? cancel = null, bool invertCallToAction = false, AlertMessageType type = AlertMessageType.TBD, TimeSpan? autoHideDelay = null, string? imageSource = null, bool showCloseIcon = false)
	{
		TaskCompletionSource<bool?> tcs = new TaskCompletionSource<bool?>();
		await dialogService.Hide();
		await Task.Delay(100);
		await navigationService.PushModalAsync<AlertPopup, AlertPopupViewModel>(delegate(AlertPopupViewModel viewModel)
		{
			viewModel.Initialize(type, title, message, accept ?? CommonResources.Alg_Ok, cancel, invertCallToAction, async delegate(bool? result)
			{
				await navigationService.PopCurrentModalPage(animate: false);
				tcs.TrySetResult(result);
			}, autoHideDelay, imageSource, showCloseIcon);
		}, animate: false);
		return await tcs.Task;
	}

	public async Task OpenBottomSheet(string pageId, string title, string message, string? actionText = null, Func<Task>? action = null, bool actionAsButton = true, bool firstCloseThenExecuteAction = false)
	{
		if (bottomSheetNavigationService != null)
		{
			await bottomSheetNavigationService.NavigateToAsync<BottomSheetViewModel>("CustomBottomSheet", null, delegate(IBottomSheet bottomSheet)
			{
				if (bottomSheet.BindingContext is BottomSheetViewModel bottomSheetViewModel)
				{
					bottomSheetViewModel.Title = title;
					bottomSheetViewModel.ActionText = actionText;
					bottomSheetViewModel.Message = message;
					bottomSheetViewModel.IsActionButton = actionAsButton;
					bottomSheetViewModel.PageId = pageId;
					bottomSheetViewModel.FirstCloseThenExecuteAction = firstCloseThenExecuteAction;
					bottomSheetViewModel.Action = action;
				}
			});
		}
		else if (await DisplayAlert(title, message, actionText, null, invertCallToAction: false, AlertMessageType.TBD, null, null, showCloseIcon: true) == true && action != null)
		{
			await action();
		}
	}
}
