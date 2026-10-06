using System.Threading.Tasks;

namespace DigiD.Common.Interfaces;

public interface IPushNotificationService
{
	bool NotificationsAvailable { get; }

	Task UnRegisterForRemoteNotifications();

	bool NotificationsEnabled();

	Task<string?> GetToken();

	Task<bool> RequestPermissionAsync();
}
