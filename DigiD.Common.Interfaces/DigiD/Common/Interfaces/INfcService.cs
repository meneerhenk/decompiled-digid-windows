using System;
using System.Threading.Tasks;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Nfc;

namespace DigiD.Common.Interfaces;

public interface INfcService
{
	bool IsNFCEnabled { get; }

	bool IsCancelled { get; set; }

	string? SelectedAID { get; set; }

	AntennaLocation? AntennaLocation { get; }

	bool HasNFCSupport();

	Task<string[]> GetReaders();

	Task<bool> IsTagConnected();

	void OpenNFCSettings();

	Task<bool> StartScanningAsync(Func<Task> tagFoundAction, Func<NfcError, Task> errorAction, string? message = null);

	Task StopScanningAsync(string? message = null, bool waitForDisconnect = false);

	Task<TransceiveResult> SendApduAsync(byte[] command);

	void Disconnect();

	void UpdateStatus(double percentage);
}
