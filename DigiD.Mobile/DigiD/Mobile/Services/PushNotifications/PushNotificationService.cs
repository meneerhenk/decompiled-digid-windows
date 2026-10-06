using System;
using System.Threading.Tasks;
using DigiD.Common.Interfaces;

namespace DigiD.Mobile.Services.PushNotifications;

internal class PushNotificationService : IPushNotificationService
{
	public bool NotificationsAvailable => false;

	public Task UnRegisterForRemoteNotifications()
	{
		throw new NotImplementedException();
	}

	public bool NotificationsEnabled()
	{
		return false;
	}

	public Task<string?> GetToken()
	{
		throw new NotImplementedException();
	}

	public Task<bool> RequestPermissionAsync()
	{
		throw new NotImplementedException();
	}
}
