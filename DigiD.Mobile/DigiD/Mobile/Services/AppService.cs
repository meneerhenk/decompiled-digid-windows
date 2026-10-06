using System.Threading.Tasks;
using DigiD.Common.Enums;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Preferences;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using DigiD.Mobile.Helpers;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Pages;

namespace DigiD.Mobile.Services;

public class AppService(IMobileSettings mobileSettings, IPushNotificationService pushNotificationService, INavigationService navigationService, IDeviceLockService deviceLockService, IAlertService alertService, ILetterService letterService, IToastService toastService, IBiometricService biometricService) : IAppService
{
	public async Task Deactivate(AlertMessageType? alert)
	{
		deviceLockService.Stop();
		bool? deactivate = true;
		if (alert.HasValue)
		{
			deactivate = await alertService.DisplayAlert(alert.Value);
		}
		if (deactivate == true)
		{
			toastService.Toasts.Clear();
			if (mobileSettings.ActivationStatus == ActivationStatus.Pending)
			{
				letterService.Cancel();
			}
			bool? permissionSet = mobileSettings.NotificationPermissionSet;
			if (permissionSet.HasValue && permissionSet.Value)
			{
				await pushNotificationService.UnRegisterForRemoteNotifications();
			}
			Reset();
			navigationService.SetRoot<DG001>();
		}
		else
		{
			deviceLockService.Start();
		}
	}

	public void Reset()
	{
		HttpSession.TempSessionData = null;
		HttpSession.ActivationSessionData = null;
		HttpSession.SetAuthenticationType(AuthenticationType.None);
		AppSession.Reset();
		biometricService.Reset();
		mobileSettings.Reset();
		Preferences.Reset();
		DemoSettings.Reset();
		deviceLockService.Stop();
	}
}
