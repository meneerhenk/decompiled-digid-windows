using System.Threading.Tasks;
using Microsoft.Maui.ApplicationModel;

namespace DigiD.Common.Helpers;

public static class PermissionHelper
{
	public static async Task<bool> CheckCameraPermissions()
	{
		if ((uint)(await Permissions.CheckStatusAsync<Permissions.Camera>()) <= 2u)
		{
			return false;
		}
		return true;
	}
}
