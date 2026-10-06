using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CommunityToolkit.Maui;
using DigiD.Common.Interfaces;
using DigiD.Common.Plugins.Popups;
using DigiD.Common.Plugins.Services;
using DigiD.Common.Plugins.ViewModels;
using DigiD.Common.Preferences;
using DigiD.Common.Resources;
using DigiD.Common.Resources.Enums;
using DigiD.Common.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Http.Resilience;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Devices;
using Microsoft.Maui.Hosting;
using Polly.Retry;

namespace DigiD.Common.Plugins;

public static class PluginExtensions
{
	private static DevicePlatform OSType
	{
		get
		{
			if (Localization.AppType == AppType.CheckID)
			{
				return DevicePlatform.Create((DeviceInfo.Current.Platform == DevicePlatform.Android) ? "idCheckerAndroid" : "idCheckeriOS");
			}
			if (DeviceInfo.Current.Platform == DevicePlatform.WinUI)
			{
				return DevicePlatform.Create("UWP");
			}
			if (DeviceInfo.Current.Platform == DevicePlatform.macOS || DeviceInfo.Current.Platform == DevicePlatform.MacCatalyst)
			{
				return DevicePlatform.Create("macOS");
			}
			return DeviceInfo.Platform;
		}
	}

	public static MauiAppBuilder UseDigiDServices(this MauiAppBuilder builder)
	{
		ServiceCollectionServiceExtensions.AddSingleton<ISslPinningService, SslPinningService>(builder.Services);
		ServiceCollectionServiceExtensions.AddSingleton<IGeneralPreferences, GeneralPreferences>(builder.Services);
		ServiceCollectionServiceExtensions.AddSingleton<INavigationService, NavigationService>(builder.Services);
		ServiceCollectionServiceExtensions.AddSingleton<IToastService, ToastService>(builder.Services);
		ServiceCollectionServiceExtensions.AddSingleton<IConnectionService, ConnectionService>(builder.Services);
		ServiceCollectionServiceExtensions.AddSingleton<IFontService, FontService>(builder.Services);
		ServiceCollectionServiceExtensions.AddSingleton<INfcService, NfcService>(builder.Services);
		ServiceCollectionServiceExtensions.AddSingleton<ISecurityService, SecurityService>(builder.Services);
		ServiceCollectionServiceExtensions.AddSingleton<IDeviceService, DeviceService>(builder.Services);
		ServiceCollectionServiceExtensions.AddSingleton<IHttpService, HttpService>(builder.Services);
		ServiceCollectionServiceExtensions.AddSingleton<ISecureStorageService, SecureStorageService>(builder.Services);
		ServiceCollectionServiceExtensions.AddSingleton<IDialogService, DialogService>(builder.Services);
		ServiceCollectionServiceExtensions.AddSingleton<IA11YService, A11YService>(builder.Services);
		ServiceCollectionServiceExtensions.AddSingleton<DigiD.Common.Interfaces.IPopupService, PopupService>(builder.Services);
		ServiceCollectionServiceExtensions.AddSingleton<ICrashService, SentryCrashService>(builder.Services);
		ServiceCollectionServiceExtensions.AddSingleton<INfcLocationService, NfcLocationService>(builder.Services);
		ServiceCollectionServiceExtensions.AddSingleton<IBiometricService, BiometricService>(builder.Services);
		builder.Services.AddSingleton(AppRating.Default);
		ServiceCollectionExtensions.AddTransient<AlertPopup, AlertPopupViewModel>(builder.Services);
		builder.Services.AddTransientPopup<SpinnerPopup, SpinnerPopupViewModel>();
		builder.Services.AddHttpClient("DefaultHttpClient").ConfigureHttpClient(delegate(IServiceProvider sp, HttpClient client)
		{
			IGeneralPreferences requiredService = sp.GetRequiredService<IGeneralPreferences>();
			client.AddDefaultRequestHeaders(requiredService);
		}).ConfigurePrimaryHttpMessageHandler((IServiceProvider sp) => sp.GetRequiredService<IHttpService>().GetNativeHandler())
			.AddStandardResilienceHandler((Action<HttpStandardResilienceOptions>)delegate(HttpStandardResilienceOptions config)
			{
				config.AttemptTimeout.Timeout = TimeSpan.FromSeconds(2L);
				config.Retry.ShouldHandle = RetryShouldHandle;
			});
		builder.Services.AddHttpClient("HealthCheckHttpClient").ConfigurePrimaryHttpMessageHandler(HttpService.CreateDefaultSocketsHandler).ConfigureHttpClient(delegate(IServiceProvider sp, HttpClient client)
		{
			IGeneralPreferences requiredService = sp.GetRequiredService<IGeneralPreferences>();
			client.AddDefaultRequestHeaders(requiredService);
			client.BaseAddress = new Uri("https://" + requiredService.SelectedHost + "/");
		})
			.AddStandardResilienceHandler((Action<HttpStandardResilienceOptions>)delegate(HttpStandardResilienceOptions config)
			{
				config.Retry.MaxRetryAttempts = 2;
				config.Retry.Delay = TimeSpan.FromSeconds(1L);
				config.AttemptTimeout.Timeout = TimeSpan.FromMilliseconds(1000L);
				config.Retry.ShouldHandle = RetryShouldHandle;
			});
		return builder;
	}

	private static ValueTask<bool> RetryShouldHandle(RetryPredicateArguments<HttpResponseMessage> arguments)
	{
		switch (arguments.Outcome.Result?.StatusCode)
		{
		case HttpStatusCode.OK:
		case HttpStatusCode.BadRequest:
		case HttpStatusCode.InternalServerError:
		case HttpStatusCode.ServiceUnavailable:
			return ValueTask.FromResult(result: false);
		default:
			return ValueTask.FromResult(result: true);
		}
	}

	private static void AddDefaultRequestHeaders(this HttpClient client, IGeneralPreferences preferences)
	{
		Version version = AppInfo.Version;
		client.DefaultRequestHeaders.TryAddWithoutValidation("API-Version", "3");
		client.DefaultRequestHeaders.TryAddWithoutValidation("App-Version", $"{version.Major}.{version.Minor}.{version.Build}");
		client.DefaultRequestHeaders.TryAddWithoutValidation("OS-Type", OSType.ToString());
		client.DefaultRequestHeaders.TryAddWithoutValidation("OS-Version", DeviceInfo.VersionString);
		client.DefaultRequestHeaders.TryAddWithoutValidation("Release-Type", "Productie");
		client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", preferences.InstanceId);
		client.DefaultRequestHeaders.TryAddWithoutValidation("Cache-Control", "no-cache, no-store");
		client.DefaultRequestHeaders.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
	}
}
