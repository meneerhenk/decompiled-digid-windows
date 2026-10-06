using DigiD.Common.EID.Demo;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Services;
using DigiD.Common.Interfaces;
using DigiD.Common.Plugins.Services;
using DigiD.Common.Preferences;
using DigiD.Common.Settings;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Services.KeyAttestation;
using DigiD.Mobile.Services.PushNotifications;
using DigiD.Mobile.Services.Signing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Hosting;

namespace DigiD.Mobile.Services;

public static class ServicesExtensions
{
	public static MauiAppBuilder ConfigureServices(this MauiAppBuilder builder)
	{
		builder.Services.AddSingleton<ISigningService, SigningService>();
		builder.Services.AddSingleton<IMobileSettings, MobileSettings>();
		builder.Services.AddSingleton<IAlertService, AlertService>();
		builder.Services.AddSingleton<ILetterService, LetterService>();
		builder.Services.AddSingleton<IActivationService, ActivationService>();
		builder.Services.AddSingleton<IConfigurationService, ConfigurationService>();
		builder.Services.AddSingleton<IPushNotificationService, PushNotificationService>();
		builder.Services.AddSingleton<ISessionService, SessionService>();
		builder.Services.AddSingleton<IApp2AppService, App2AppService>();
		builder.Services.AddSingleton<IAuthenticationService, AuthenticationService>();
		builder.Services.AddSingleton<IIncomingDataService, IncomingDataService>();
		builder.Services.AddSingleton<IRemoteNotificationService, RemoteNotificationService>();
		builder.Services.AddSingleton<IEmailService, EmailService>();
		builder.Services.AddSingleton<IAppService, AppService>();
		builder.Services.AddSingleton<IAccountRequestService, AccountRequestService>();
		builder.Services.AddSingleton<IDeviceLockService, DeviceLockService>();
		builder.Services.AddSingleton<IQRCodeScannerService, QrCodeScannerService>();
		builder.Services.AddSingleton<IWidService, WidService>();
		builder.Services.AddSingleton<IDemoService, DemoService>();
		builder.Services.AddSingleton<IConfirmService, ConfirmService>();
		builder.Services.AddSingleton<IAttestationService, KeyAttestationService>();
		builder.Services.AddSingleton<ISignerService, SignerService>();
		builder.Services.AddSingleton<IKeyboardService, KeyboardService>();
		builder.Services.AddSingleton<IDisplayService, DisplayService>();
		if (DemoSettings.IsDemoModeEnabled)
		{
			builder.Services.AddSingleton<IEIDOperationService, DigiD.Common.EID.Demo.EIDOperationService>();
		}
		else
		{
			builder.Services.AddSingleton<IEIDOperationService, DigiD.Common.EID.Services.EIDOperationService>();
		}
		return builder;
	}
}
