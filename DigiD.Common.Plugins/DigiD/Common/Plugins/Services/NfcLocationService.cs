using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Config;
using DigiD.Common.Models.Nfc;
using DigiD.Common.Preferences;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Devices;

namespace DigiD.Common.Plugins.Services;

internal class NfcLocationService : INfcLocationService
{
	private readonly Dictionary<string, NfcPosition> _nfcLocations;

	private readonly INfcService nfcService;

	private readonly ILogger<NfcLocationService> logger;

	private JsonSerializerOptions serializerOptions { get; } = new JsonSerializerOptions
	{
		ReadCommentHandling = JsonCommentHandling.Skip
	};

	public NfcPosition Position
	{
		get
		{
			if (DemoSettings.IsDemoModeEnabled)
			{
				return DemoConfig.NfcPosition;
			}
			if (DeviceInfo.Platform != DevicePlatform.Android)
			{
				return NfcPosition.Top;
			}
			if (_nfcLocations.TryGetValue(DeviceInfo.Model, out var value))
			{
				logger.LogInformation("Use position from local storage: {Position}", value);
				return value;
			}
			if ((object)nfcService.AntennaLocation == null)
			{
				logger.LogInformation("NFC Antenna Location is null");
				return NfcPosition.Unknown;
			}
			logger.LogInformation("NFC Api Data: {Width}x{Height} - X:{x} Y: {y}", nfcService.AntennaLocation.Width, nfcService.AntennaLocation.Height, nfcService.AntennaLocation.X, nfcService.AntennaLocation.Y);
			if (nfcService.AntennaLocation.X == 0 && nfcService.AntennaLocation.Y == 0)
			{
				return NfcPosition.Unknown;
			}
			AntennaLocation antennaLocation = nfcService.AntennaLocation;
			if ((object)antennaLocation != null && antennaLocation.Height > 0)
			{
				if ((double)antennaLocation.Y < (double)antennaLocation.Height * 0.25)
				{
					return NfcPosition.Top;
				}
				if ((double)antennaLocation.Y > (double)antennaLocation.Height * 0.75)
				{
					return NfcPosition.Bottom;
				}
				return NfcPosition.Middle;
			}
			return NfcPosition.Unknown;
		}
	}

	public NfcLocationService(INfcService nfcService, ILogger<NfcLocationService> logger)
	{
		this.nfcService = nfcService;
		this.logger = logger;
		Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("DigiD.Common.Plugins.Resources.NfcLocations.json");
		using StreamReader streamReader = new StreamReader(manifestResourceStream ?? throw new InvalidOperationException());
		string json = streamReader.ReadToEnd();
		Dictionary<string, NfcPosition> dictionary = JsonSerializer.Deserialize<Dictionary<string, NfcPosition>>(json, serializerOptions) ?? new Dictionary<string, NfcPosition>();
		_nfcLocations = new Dictionary<string, NfcPosition>(dictionary, StringComparer.InvariantCultureIgnoreCase);
	}
}
