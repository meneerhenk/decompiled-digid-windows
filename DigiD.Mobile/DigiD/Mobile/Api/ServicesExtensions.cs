using DigiD.Common.Api;
using DigiD.Common.EID.Api;
using DigiD.Common.EID.Interfaces.Api;
using DigiD.Common.Interfaces;
using DigiD.Common.RDA.Api;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Hosting;

namespace DigiD.Mobile.Api;

public static class ServicesExtensions
{
	public static MauiAppBuilder ConfigureApi(this MauiAppBuilder builder)
	{
		builder.Services.AddSingleton<IEnrollmentApi, EnrollmentApi>();
		builder.Services.AddSingleton<IVersionApi, VersionApi>();
		builder.Services.AddSingleton<IGeneralApi, GeneralApi>();
		builder.Services.AddSingleton<IAccountInformationApi, AccountInformationApi>();
		builder.Services.AddSingleton<IAuthenticationApi, AuthenticationApi>();
		builder.Services.AddSingleton<IApp2AppApi, App2AppApi>();
		builder.Services.AddSingleton<IRdaApi, RdaApi>();
		builder.Services.AddSingleton<IChangePinApi, ChangePinApi>();
		builder.Services.AddSingleton<IRemoteNotificationsApi, RemoteNotificationsApi>();
		builder.Services.AddSingleton<IUsageHistoryApi, UsageHistoryApi>();
		builder.Services.AddSingleton<IEmailApi, EmailApi>();
		builder.Services.AddSingleton<IEIDApi, EIDApi>();
		builder.Services.AddSingleton<IAppAttestApi, AppAttestApi>();
		builder.Services.AddSingleton<INIKApi, NIKApi>();
		builder.Services.AddSingleton<IRDWApi, RDWApi>();
		return builder;
	}
}
