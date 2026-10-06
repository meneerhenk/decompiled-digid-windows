using System.Threading.Tasks;

namespace DigiD.Mobile.Interfaces;

public interface IRemoteNotificationService
{
	void SetToken(string token);

	Task UpdateToken(string token);

	Task ConfirmShowNotifications(bool askBeforeShow = false);

	Task RequestToken(bool permissionSet);

	Task AskForPermission();
}
