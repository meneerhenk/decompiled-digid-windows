using DigiD.Common.Enums;
using DigiD.Common.Models.Enums;

namespace DigiD.Common.Settings;

public interface IMobileSettings
{
	bool? NotificationPermissionSet { get; set; }

	string NotificationToken { get; set; }

	string SymmetricKey { get; set; }

	string AppId { get; set; }

	string MaskCode { get; set; }

	int BiometricsCancelCounter { get; set; }

	string? SubAttestationKeyId { get; set; }

	string? HighAttestationKeyId { get; set; }

	bool ScreenshotEnabled { get; set; }

	ActivationStatus ActivationStatus { get; set; }

	LoginLevel LoginLevel { get; set; }

	KeyAttestationResult KeyAttestationResult { get; set; }

	void Reset();
}
