using System;
using System.Collections.Generic;
using Microsoft.Maui.Devices;

namespace DigiD.Common.Settings;

public class AppConfig
{
	public string SyncFusionLicense { get; set; } = string.Empty;

	public string HostKey { get; set; } = string.Empty;

	public string PublicFileAndroid { get; set; } = string.Empty;

	public string PublicFileiOS { get; set; } = string.Empty;

	public int QRCodeValidationTime { get; set; } = 15;

	public int RatingLimit { get; set; } = 5;

	public List<string> Hosts { get; set; } = new List<string>();

	public int BiometricsTimeout { get; set; } = 15;

	internal string PublicFileUrl => (DeviceInfo.Platform == DevicePlatform.Android) ? PublicFileAndroid : PublicFileiOS;

	public TimeSpan DisplayLockTimeout { get; } = TimeSpan.FromSeconds(90L);

	public TimeSpan DisplayLockDelay => TimeSpan.FromSeconds(30L);

	public SslPinningSettings? SslPinningSettings { get; set; }

	public MatomoSettings MatomoSettings { get; set; } = null;

	public SentrySettings SentrySettings { get; set; } = new SentrySettings();
}
