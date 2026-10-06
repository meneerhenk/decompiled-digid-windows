using DigiD.Common.Interfaces;
using DigiD.Common.Pages.Pages;
using DigiD.Common.Pages.ViewModels;
using DigiD.Common.RDA.Interfaces;
using DigiD.Common.RDA.Pages;
using DigiD.Common.RDA.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Hosting;

namespace DigiD.Common.RDA.Services;

public static class ServicesExtensions
{
	public static MauiAppBuilder ConfigureRdaServices(this MauiAppBuilder builder)
	{
		builder.Services.AddSingleton<IRdaScanService, RdaScanService>();
		builder.Services.AddSingleton<IRdaService, RdaService>();
		builder.Services.AddTransient<DG078>();
		builder.Services.AddTransient<DG079>();
		builder.Services.AddTransient<DG080>();
		builder.Services.AddTransient<DG083>();
		builder.Services.AddTransient<DG084>();
		builder.Services.AddTransient<DG078ViewModel>();
		builder.Services.AddTransient<DG079ViewModel>();
		builder.Services.AddTransient<DG080ViewModel>();
		builder.Services.AddTransient<DG083ViewModel>();
		builder.Services.AddTransient<DG084ViewModel>();
		return builder;
	}
}
