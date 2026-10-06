using System.Threading.Tasks;
using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Handlers;
using DigiD.Common.Extensions;
using DigiD.Common.Interfaces;
using DigiD.Common.Plugins;
using DigiD.Common.Preferences;
using DigiD.Common.RDA.Services;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Mobile.Api;
using DigiD.Mobile.Api.Demo;
using DigiD.Mobile.Helpers;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Pages;
using DigiD.Mobile.Services;
using DigiD.Mobile.ViewModels;
using LocalizationResourceManager.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.LifecycleEvents;
using Microsoft.Windows.AppLifecycle;
using SkiaSharp.Views.Maui.Controls.Hosting;
using Syncfusion.Maui.Core.Hosting;
using Windows.ApplicationModel.Activation;

namespace DigiD.Mobile;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		MauiAppBuilder mauiAppBuilder = MauiApp.CreateBuilder();
		mauiAppBuilder.LoadConfiguration().UseMauiApp<App>().UseMauiCommunityToolkit(delegate(Options options)
		{
			options.SetShouldSuppressExceptionsInConverters(value: true);
			options.SetShouldUseStatusBarBehaviorOnAndroidModalPage(value: true);
		})
			.UseMauiCommunityToolkitMarkup()
			.UseSkiaSharp()
			.UseDigiDServices()
			.ConfigureMauiHandlers(delegate(IMauiHandlersCollection handlers)
			{
				handlers.AddHandler<BorderedButton, BorderedButtonHandler>();
				handlers.AddHandler<BottomSheetLabel, BottomSheetLabelHandler>();
				handlers.AddHandler<HyperlinkLabel, HyperlinkLabelHandler>();
			})
			.UseLocalizationResourceManager(delegate(ILocalizationSettings settings)
			{
				settings.AddResource(CommonResources.ResourceManager);
				settings.AddResource(DigiDAppResources.ResourceManager);
				settings.SetDefaultLanguage();
				settings.SuppressTextNotFoundException();
			})
			.ConfigureSyncfusionCore()
			.ConfigureEssentials()
			.ConfigureServices()
			.ConfigureRdaServices()
			.ConfigureMatomo()
			.ConfigurePages()
			.ConfigureViewModels()
			.ConfigureFonts(delegate(IFontCollection fonts)
			{
				fonts.AddFont("Dyslexie_Bold.ttf", "Dyslexie-Bold");
				fonts.AddFont("Dyslexie_Regular.ttf", "Dyslexie-Regular");
				fonts.AddFont("RijksoverheidSansWebText_Bold.ttf", "RO-Bold");
				fonts.AddFont("RijksoverheidSansWebText_Regular.ttf", "RO-Regular");
			})
			.ConfigureLifecycleEvents(delegate(ILifecycleBuilder events)
			{
				events.AddWindows(delegate(IWindowsLifecycleBuilder windows)
				{
					windows.OnActivated(delegate
					{
						AppActivationArguments activatedEventArgs = AppInstance.GetCurrent().GetActivatedEventArgs();
						object data = activatedEventArgs.Data;
						ProtocolActivatedEventArgs data2 = data as ProtocolActivatedEventArgs;
						if ((object)data2 != null && !AppSession.IsAppActivatedFromBrowser)
						{
							AppSession.IsAppActivatedFromBrowser = true;
							Task.Run(async delegate
							{
								await ((IApp)Application.Current).ServiceProvider.GetRequiredService<IIncomingDataService>().HandleIncomingData(data2.Uri);
							});
						}
					}).OnClosed(delegate
					{
						if (HttpSession.WidSessionResponse != null)
						{
							((IApp)Application.Current).ServiceProvider.GetRequiredService<IEIDApi>().CancelAuthenticate();
						}
					});
				});
			});
		if (DemoSettings.IsDemoModeEnabled)
		{
			mauiAppBuilder.ConfigureDemoApi();
		}
		else
		{
			mauiAppBuilder.ConfigureApi();
		}
		return mauiAppBuilder.Build();
	}
}
