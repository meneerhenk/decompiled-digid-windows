using System.Threading.Tasks;

namespace DigiD.Common.Interfaces;

public interface IDeviceService
{
	string DeviceTypeName { get; }

	string DefaultLanguage { get; }

	bool IsPowerSaveMode { get; }

	string DeviceName { get; }

	void OpenSettings();

	bool OpenBrowser(string name, string uri);

	Task<string?> UserAgent();

	void CloseApp();
}
