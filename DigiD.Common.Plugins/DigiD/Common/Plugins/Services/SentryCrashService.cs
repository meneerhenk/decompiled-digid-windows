using System;
using System.Collections.Generic;
using System.Linq;
using DigiD.Common.Interfaces;
using DigiD.Common.Preferences;
using DigiD.Common.Settings;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;
using Sentry;

namespace DigiD.Common.Plugins.Services;

internal class SentryCrashService(IGeneralPreferences generalPreferences, AppConfig appConfig) : ICrashService
{
	private const string CURRENT_PAGE_ID_KEY = "page";

	public void TrackError(Exception ex, Dictionary<string, string>? props = null)
	{
		if (!generalPreferences.MatomoTrackEnabled)
		{
			return;
		}
		SentrySdk.CaptureException(ex, delegate(Scope scope)
		{
			if (props != null)
			{
				scope.SetExtras(AddPageId(props));
			}
		});
	}

	public void Init()
	{
		SentrySdk.Init(delegate(SentryOptions options)
		{
			if (generalPreferences.MatomoTrackEnabled)
			{
				options.IsGlobalModeEnabled = true;
				options.AutoSessionTracking = true;
				options.CaptureFailedRequests = false;
				options.Dsn = appConfig.SentrySettings.Dsn;
				options.StackTraceMode = StackTraceMode.Enhanced;
				options.DetectStartupTime = StartupTimeDetectionMode.Fast;
				options.DisableUnobservedTaskExceptionCapture();
				if (DemoSettings.IsDemoModeEnabled)
				{
					options.Environment = "Demo";
				}
				else
				{
					options.Environment = "Productie";
				}
				options.TracesSampleRate = 0.1;
				options.SetBeforeSend(delegate(SentryEvent @event)
				{
					@event.User = new SentryUser
					{
						Id = generalPreferences.InstanceId
					};
					return @event;
				});
			}
			else
			{
				options.IsGlobalModeEnabled = false;
				options.Dsn = string.Empty;
			}
		});
	}

	private static List<KeyValuePair<string, object?>> AddPageId(Dictionary<string, string>? props)
	{
		List<KeyValuePair<string, object>> list = props?.Select((KeyValuePair<string, string> x) => new KeyValuePair<string, object>(x.Key, x.Value)).ToList() ?? new List<KeyValuePair<string, object>>();
		if (Application.Current is IApp app)
		{
			INavigationService requiredService = app.ServiceProvider.GetRequiredService<INavigationService>();
			if (string.IsNullOrEmpty(requiredService.CurrentPageId))
			{
				return list;
			}
			list.Add(new KeyValuePair<string, object>("page", requiredService.CurrentPageId));
		}
		return list;
	}
}
