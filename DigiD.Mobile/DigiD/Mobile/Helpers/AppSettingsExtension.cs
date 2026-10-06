using System;
using System.IO;
using System.Reflection;
using DigiD.Common.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Hosting;

namespace DigiD.Mobile.Helpers;

internal static class AppSettingsExtension
{
	internal static MauiAppBuilder LoadConfiguration(this MauiAppBuilder builder)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		using Stream stream = executingAssembly.GetManifestResourceStream("DigiD.Mobile.appsettings.json");
		using Stream stream2 = executingAssembly.GetManifestResourceStream("DigiD.Mobile.appsettings.Environment.json");
		if (stream != null && stream2 != null)
		{
			IConfigurationRoot configurationRoot = new ConfigurationBuilder().AddJsonStream(stream).AddJsonStream(stream2).Build();
			builder.Configuration.AddConfiguration(configurationRoot);
			AppConfig appConfig = configurationRoot.Get<AppConfig>();
			MatomoSettings matomoSettings = configurationRoot.GetRequiredSection("Matomo").Get<MatomoSettings>();
			ArgumentNullException.ThrowIfNull(matomoSettings, "matomoSettings");
			ArgumentNullException.ThrowIfNull(appConfig, "settings");
			appConfig.MatomoSettings = matomoSettings;
			appConfig.SslPinningSettings = configurationRoot.GetSection("SSLPinning").Get<SslPinningSettings>();
			appConfig.SentrySettings = configurationRoot.GetSection("Sentry").Get<SentrySettings>();
			builder.Services.AddSingleton(appConfig);
		}
		return builder;
	}
}
