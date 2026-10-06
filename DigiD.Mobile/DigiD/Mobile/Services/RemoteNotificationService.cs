using System.Threading.Tasks;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Responses;
using DigiD.Common.Resources;
using DigiD.Common.Settings;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Pages;
using DigiD.Mobile.ViewModels;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Devices;

namespace DigiD.Mobile.Services;

public class RemoteNotificationService(IMobileSettings mobileSettings, IRemoteNotificationsApi api, IPopupService popupService, IDialogService dialogService, ISessionService sessionService, INavigationService navigationService, IMatomoService matomoService, IPushNotificationService pushNotificationService) : IRemoteNotificationService
{
	public void SetToken(string token)
	{
		mobileSettings.NotificationToken = token;
	}

	public async Task UpdateToken(string token)
	{
		if ((await api.UpdateNotificationToken(token)).ApiResult == ApiResult.Ok)
		{
			mobileSettings.NotificationToken = token;
		}
	}

	public async Task ConfirmShowNotifications(bool askBeforeShow = false)
	{
		await MainThread.InvokeOnMainThreadAsync(async delegate
		{
			bool? result = true;
			if (askBeforeShow)
			{
				result = await popupService.DisplayAlert(CommonResources.x_NewNotificationsHeader, CommonResources.x_NewNotificationsMessage, CommonResources.Alg_Ok, CommonResources.Alg_Cancel);
			}
			if (result.HasValue && result.Value)
			{
				dialogService.Show();
				await sessionService.StartSession(Manage, startBiometrics: true);
				await dialogService.Hide();
			}
		});
	}

	private async Task Manage()
	{
		if (DeviceInfo.Idiom != DeviceIdiom.Desktop)
		{
			bool? permissionSet = mobileSettings.NotificationPermissionSet;
			if (!permissionSet.HasValue || !permissionSet.Value)
			{
				await dialogService.Hide();
				await AskForPermission();
			}
		}
		await navigationService.NavigateAsync<DG045, DG045ViewModel>(async delegate(DG045ViewModel vm)
		{
			await vm.Initialize();
		});
	}

	public async Task RequestToken(bool permissionSet)
	{
		matomoService.TrackAction("toestemming_pushnotificatie", permissionSet ? "ja" : "nee", navigationService.CurrentPageId);
		dialogService.Show();
		string token = null;
		if (permissionSet && pushNotificationService.NotificationsAvailable)
		{
			token = mobileSettings.NotificationToken;
			if (string.IsNullOrEmpty(token))
			{
				token = await pushNotificationService.GetToken();
			}
		}
		if (token != null)
		{
			BaseResponse result = await api.RegisterNotificationToken(token, permissionSet);
			mobileSettings.NotificationPermissionSet = result.ApiResult == ApiResult.Ok;
		}
		await dialogService.Hide();
	}

	public async Task AskForPermission()
	{
		TaskCompletionSource tcs = new TaskCompletionSource();
		await navigationService.PushModalAsync<DG035B, DG035ViewModel>(delegate(DG035ViewModel vm)
		{
			vm.HasBackButton = false;
			vm.NextAction = async delegate
			{
				tcs.SetResult();
				await navigationService.PopCurrentModalPage();
			};
		});
		await tcs.Task;
	}
}
