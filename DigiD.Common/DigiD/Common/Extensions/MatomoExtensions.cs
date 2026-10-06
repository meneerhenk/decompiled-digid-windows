using DigiD.Common.Interfaces;
using DigiD.Common.Matomo;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Hosting;

namespace DigiD.Common.Extensions;

public static class MatomoExtensions
{
	public static MauiAppBuilder ConfigureMatomo(this MauiAppBuilder builder)
	{
		builder.Services.AddSingleton<IMatomoService, MatomoTracker>();
		return builder;
	}
}
