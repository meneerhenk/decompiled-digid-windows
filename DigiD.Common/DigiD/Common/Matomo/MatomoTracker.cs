using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Preferences;
using DigiD.Common.Settings;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Devices;

namespace DigiD.Common.Matomo;

public class MatomoTracker : IMatomoService, IAsyncDisposable
{
	private readonly ILogger<MatomoTracker> logger;

	private readonly IGeneralPreferences generalPreferences;

	private readonly MatomoDispatcher dispatcher;

	private const int NumberOfEventsDispatchedAtOnce = 20;

	private readonly TimeSpan _defaultAutoSendTimerSeconds = TimeSpan.FromSeconds(15L);

	private bool _isDispatching;

	private bool _nextEventStartsANewSession = true;

	private MatomoSession matomoSession;

	private readonly int siteId;

	private readonly Queue<MatomoEvent> _queue = new Queue<MatomoEvent>();

	private readonly CancellationTokenSource _cts;

	private readonly PeriodicTimer _timer;

	private readonly Task _timerTask;

	public MatomoTracker(ILogger<MatomoTracker> logger, IDeviceService service, IGeneralPreferences generalPreferences, AppConfig config)
	{
		string baseUrl = config.MatomoSettings.BaseUrl.DeObfuscate(config.HostKey);
		this.logger = logger;
		this.generalPreferences = generalPreferences;
		dispatcher = new MatomoDispatcher(logger, generalPreferences, service, baseUrl, $"{DeviceDisplay.MainDisplayInfo.Width}x{DeviceDisplay.MainDisplayInfo.Height}");
		matomoSession = new MatomoSession();
		siteId = (DemoSettings.IsDemoModeEnabled ? config.MatomoSettings.SiteIdDemoMode : config.MatomoSettings.SiteId);
		_cts = new CancellationTokenSource();
		_timer = new PeriodicTimer(_defaultAutoSendTimerSeconds);
		_timerTask = HandleTimerAsync(_timer, _cts.Token);
	}

	public void TrackScreen(string screenName)
	{
		logger.LogInformation("TrackScreen: {screenName}", screenName);
		TrackEvent(screenName);
	}

	public void ResetSession()
	{
		matomoSession = new MatomoSession();
	}

	public Task Submit()
	{
		return StartDispatch();
	}

	public void TrackAction(string category, string action, string name)
	{
		logger.LogInformation("TrackAction: {category}-{action}-{name}", category, action, name);
		MatomoEvent matomoEventItem = new MatomoEvent(matomoSession)
		{
			Url = "https://" + generalPreferences.SelectedHost + "/",
			SiteID = siteId,
			EventCategory = category,
			EventName = name,
			EventAction = action,
			Language = CultureInfo.CurrentCulture.IetfLanguageTag,
			IsNewSession = _nextEventStartsANewSession
		};
		Enqueue(matomoEventItem);
	}

	private void TrackEvent(string screenName)
	{
		MatomoEvent matomoEvent = new MatomoEvent(matomoSession)
		{
			Url = "https://" + generalPreferences.SelectedHost + "/",
			SiteID = siteId,
			ActionName = screenName,
			Language = CultureInfo.CurrentCulture.IetfLanguageTag,
			IsNewSession = _nextEventStartsANewSession
		};
		matomoEvent.Url += screenName;
		Enqueue(matomoEvent);
	}

	private void Enqueue(MatomoEvent matomoEventItem)
	{
		lock (_queue)
		{
			_queue.Enqueue(matomoEventItem);
			_nextEventStartsANewSession = false;
		}
	}

	private async Task HandleTimerAsync(PeriodicTimer timer, CancellationToken cancel = default(CancellationToken))
	{
		try
		{
			while (await timer.WaitForNextTickAsync(cancel))
			{
				await StartDispatch();
			}
		}
		catch (Exception)
		{
		}
	}

	private async Task StartDispatch()
	{
		if (_isDispatching)
		{
			return;
		}
		try
		{
			_isDispatching = true;
			IEnumerable<MatomoEvent> toSend;
			lock (_queue)
			{
				toSend = _queue.Take(20).ToList();
			}
			bool flag = toSend.Any();
			bool flag2 = flag;
			if (flag2)
			{
				flag2 = await dispatcher.Send(toSend);
			}
			if (!flag2)
			{
				return;
			}
			lock (_queue)
			{
				foreach (MatomoEvent item in toSend)
				{
					_ = item;
					_queue.Dequeue();
				}
			}
			if (_queue.Count >= 20)
			{
				_isDispatching = false;
				await StartDispatch();
			}
		}
		finally
		{
			_isDispatching = false;
		}
	}

	public async ValueTask DisposeAsync()
	{
		_cts.Cancel(throwOnFirstException: false);
		_cts.Dispose();
		_timer.Dispose();
		await _timerTask;
		GC.SuppressFinalize(this);
	}
}
