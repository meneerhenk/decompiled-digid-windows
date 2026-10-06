using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Cryptography;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using DigiD.Common.Interfaces;
using Microsoft.Extensions.Logging;

namespace DigiD.Common.Matomo;

internal class MatomoDispatcher
{
	private class JSonRequest
	{
		[JsonPropertyName("requests")]
		public IEnumerable<string> Requests { get; init; } = new List<string>();
	}

	private readonly ILogger<MatomoTracker> logger;

	private readonly IGeneralPreferences _generalPreferences;

	private readonly IDeviceService _deviceService;

	private readonly string _baseUrl;

	private readonly string _screenSize;

	private readonly HttpClient _httpClient;

	private string? _userAgent;

	private readonly JsonSerializerOptions settings = new JsonSerializerOptions
	{
		WriteIndented = false
	};

	internal MatomoDispatcher(ILogger<MatomoTracker> logger, IGeneralPreferences generalPreferences, IDeviceService deviceService, string baseUrl, string screenSize)
	{
		ArgumentNullException.ThrowIfNull(baseUrl, "baseUrl");
		this.logger = logger;
		_generalPreferences = generalPreferences;
		_deviceService = deviceService;
		_screenSize = screenSize;
		_baseUrl = baseUrl;
		_httpClient = new HttpClient();
		if (!baseUrl.EndsWith("/piwik.php", StringComparison.InvariantCulture))
		{
			throw new ArgumentException("Url should be a full url ending with /piwik.php", "baseUrl");
		}
	}

	public async Task<bool> Send(IEnumerable<MatomoEvent> events)
	{
		if (!_generalPreferences.MatomoTrackEnabled)
		{
			if (logger.IsEnabled(LogLevel.Information))
			{
				logger.LogInformation("Matomo suppressed by client: {json}", JsonSerializer.Serialize(events));
			}
			return true;
		}
		if (string.IsNullOrEmpty(_userAgent))
		{
			_userAgent = await _deviceService.UserAgent();
		}
		using HttpRequestMessage message = new HttpRequestMessage(requestUri: string.Concat(str2: RandomNumberGenerator.GetInt32(0, int.MaxValue).ToString(CultureInfo.InvariantCulture), str0: _baseUrl, str1: "?rand="), method: HttpMethod.Post);
		message.Headers.Add("User-Agent", _userAgent);
		MatomoEvent[] matomoEvents = (events as MatomoEvent[]) ?? events.ToArray();
		JSonRequest model = new JSonRequest
		{
			Requests = matomoEvents.Select(ConvertEvent)
		};
		message.Content = JsonContent.Create(model);
		HttpResponseMessage result = await _httpClient.SendAsync(message);
		if (logger.IsEnabled(LogLevel.Information))
		{
			logger.LogInformation("Matomo data: {data}", JsonSerializer.Serialize(matomoEvents));
		}
		return result.IsSuccessStatusCode;
	}

	private string ConvertEvent(MatomoEvent e)
	{
		ArgumentNullException.ThrowIfNull(e, "e");
		Dictionary<string, string> dictionary = new Dictionary<string, string>
		{
			{
				"idsite",
				e.SiteID.ToString()
			},
			{ "rec", "1" },
			{ "url", e.Url },
			{ "apiv", "1" },
			{
				"_idvc",
				e.SessionsCount.ToString(CultureInfo.InvariantCulture)
			},
			{
				"_viewts",
				e.LastVisit.ToUnixTimeSeconds().ToString(CultureInfo.InvariantCulture)
			},
			{
				"_idts",
				e.FirstVisit.ToUnixTimeSeconds().ToString(CultureInfo.InvariantCulture)
			},
			{
				"cdt",
				e.Date.ToUnixTimeSeconds().ToString(CultureInfo.InvariantCulture)
			},
			{ "res", _screenSize },
			{
				"h",
				e.Date.Hour.ToString(CultureInfo.InvariantCulture)
			},
			{
				"m",
				e.Date.Minute.ToString(CultureInfo.InvariantCulture)
			},
			{
				"s",
				e.Date.Second.ToString(CultureInfo.InvariantCulture)
			},
			{ "lang", e.Language },
			{ "uid", _generalPreferences.MatomoId },
			{
				"new_visit",
				e.IsNewSession ? "1" : "0"
			}
		};
		if (e.ActionName != null)
		{
			dictionary.Add("action_name", e.ActionName);
		}
		if (e.EventCategory != null)
		{
			dictionary.Add("e_c", e.EventCategory);
		}
		if (e.EventAction != null)
		{
			dictionary.Add("e_a", e.EventAction);
		}
		if (e.EventName != null)
		{
			dictionary.Add("e_n", e.EventName);
		}
		if (e.EventValue != null)
		{
			dictionary.Add("e_v", e.EventValue);
		}
		if (e.PageCustomVar.Count > 0)
		{
			dictionary.Add("_cvar", JsonSerializer.Serialize(e.PageCustomVar, settings));
		}
		return "?" + string.Join("&", dictionary.Select((KeyValuePair<string, string> kv) => kv.Key + "=" + WebUtility.UrlEncode(kv.Value)));
	}
}
