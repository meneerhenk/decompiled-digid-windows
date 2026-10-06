using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Settings;
using DigiD.Common.Enums;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.Config;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Preferences;
using DigiD.Common.Resources;
using DigiD.Common.Resources.Enums;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Pages;
using DigiD.Mobile.Resources.Themes;
using DigiD.Mobile.Services.KeyAttestation;
using DigiD.Mobile.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Devices;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Storage;
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using SkiaSharp.Views.Maui.Controls;
using Syncfusion.Licensing;
using WinRT.Interop;

namespace DigiD.Mobile;

[XamlFilePath("App.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
public class App : Microsoft.Maui.Controls.Application, IApp
{
	private const string WindowXKey = "WindowX";

	private const string WindowYKey = "WindowY";

	private const string WindowWidthKey = "WindowWidth";

	private const string WindowHeightKey = "WindowHeight";

	private readonly IMobileSettings mobileSettings;

	private readonly INavigationService navigationService;

	private readonly IDeviceLockService deviceLockService;

	private readonly ISessionService sessionService;

	private static bool _versionChecked;

	public IServiceProvider ServiceProvider { get; }

	public IGeneralPreferences GeneralPreferences { get; }

	public IA11YService A11YService { get; }

	private static void HideNavigationViewBackButton(DependencyObject? element)
	{
		if (!(element == null))
		{
			if (element is NavigationView navigationView)
			{
				navigationView.IsBackButtonVisible = NavigationViewBackButtonVisible.Collapsed;
			}
			int childrenCount = VisualTreeHelper.GetChildrenCount(element);
			for (int i = 0; i < childrenCount; i++)
			{
				DependencyObject child = VisualTreeHelper.GetChild(element, i);
				HideNavigationViewBackButton(child);
			}
		}
	}

	private static void SaveWindowState(Microsoft.Maui.Controls.Window window)
	{
		Preferences.Set("WindowX", window.X);
		Preferences.Set("WindowY", window.Y);
		Preferences.Set("WindowWidth", window.Width);
		Preferences.Set("WindowHeight", window.Height);
	}

	private void InitializePlatform(IKeyboardService keyboardService)
	{
		WindowHandler.Mapper.AppendToMapping("IWindow", delegate(IWindowHandler handler, IWindow view)
		{
			nint windowHandle = WindowNative.GetWindowHandle(handler.PlatformView);
			WindowId windowIdFromWindow = Win32Interop.GetWindowIdFromWindow(windowHandle);
			AppWindow fromWindowId = AppWindow.GetFromWindowId(windowIdFromWindow);
			Microsoft.Maui.Controls.Window window = view as Microsoft.Maui.Controls.Window;
			if (window != null)
			{
				double width = Preferences.Get("WindowWidth", 1000.0);
				double height = Preferences.Get("WindowHeight", 650.0);
				bool flag = Preferences.ContainsKey("WindowX") && Preferences.ContainsKey("WindowY");
				window.Width = width;
				window.Height = height;
				if (window.Handler is WindowHandler windowHandler)
				{
					windowHandler.PlatformView.Content.PreviewKeyDown += delegate(object _, KeyRoutedEventArgs args)
					{
						keyboardService.PreviewKeyDown(args);
					};
					windowHandler.PlatformView.Content.KeyDown += delegate(object _, KeyRoutedEventArgs args)
					{
						keyboardService.KeyDown(args);
					};
					windowHandler.PlatformView.Content.PointerPressed += delegate
					{
						deviceLockService.Update();
					};
					windowHandler.PlatformView.Content.Tapped += delegate
					{
						deviceLockService.Update();
					};
					UIElement content = windowHandler.PlatformView.Content;
					FrameworkElement frameworkElement = content as FrameworkElement;
					if ((object)frameworkElement != null)
					{
						frameworkElement.Loaded += delegate
						{
							HideNavigationViewBackButton(frameworkElement);
						};
					}
				}
				DisplayArea fromWindowId2 = DisplayArea.GetFromWindowId(windowIdFromWindow, DisplayAreaFallback.Nearest);
				double density = DeviceDisplay.Current.MainDisplayInfo.Density;
				int width2 = fromWindowId2.WorkArea.Width;
				int height2 = fromWindowId2.WorkArea.Height;
				if (flag)
				{
					double value = Preferences.Get("WindowX", 0.0);
					double value2 = Preferences.Get("WindowY", 0.0);
					double val = (double)width2 / density - window.Width;
					double val2 = (double)height2 / density - window.Height;
					window.X = Math.Clamp(value, 0.0, Math.Max(0.0, val));
					window.Y = Math.Clamp(value2, 0.0, Math.Max(0.0, val2));
				}
				else
				{
					window.X = ((double)width2 / density - window.Width) / 2.0;
					window.Y = ((double)height2 / density - window.Height) / 2.0;
				}
				window.SizeChanged += delegate
				{
					SaveWindowState(window);
				};
				fromWindowId.Changed += delegate
				{
					SaveWindowState(window);
				};
			}
		});
		SwitchHandler.Mapper.AppendToMapping("NoLabel", delegate(ISwitchHandler handler, ISwitch _)
		{
			handler.PlatformView.OnContent = null;
			handler.PlatformView.OffContent = null;
			handler.PlatformView.MinWidth = 0.0;
		});
	}

	public App(ILogger<App> logger, IServiceProvider serviceProvider, INfcService nfcService, IFontService fontService, IMobileSettings mobileSettings, AppConfig config, INavigationService navigationService, IMatomoService matomoService, IDeviceLockService deviceLockService, IGeneralPreferences generalPreferences, ISessionService sessionService, IA11YService a11YService, IBiometricService biometricService, ICrashService crashService, IKeyboardService keyboardService, IConnectionService connectionService)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		AppSession.BiometricType = biometricService.BiometricType;
		this.mobileSettings = mobileSettings;
		this.navigationService = navigationService;
		this.deviceLockService = deviceLockService;
		this.sessionService = sessionService;
		GeneralPreferences = generalPreferences;
		A11YService = a11YService;
		AppSession.MyDigiDUrl = "https://mijn." + GeneralPreferences.SelectedHost + "/authn_app";
		crashService.Init();
		InitializeComponent();
		ServiceProvider = serviceProvider;
		InitializePlatform(keyboardService);
		ThemeHelper.InitThemes(new Dictionary<string, Microsoft.Maui.Controls.ResourceDictionary>
		{
			["General"] = new General(),
			["Dark"] = new Dark(),
			["DarkDyslexia"] = new DarkDyslexia(),
			["Light"] = new Light(),
			["LightDyslexia"] = new LightDyslexia()
		});
		ThemeHelper.SetTheme(generalPreferences.AppTheme);
		fontService.Init();
		fontService.SetFontSize();
		fontService.SetFontFamily();
		SyncfusionLicenseProvider.RegisterLicense(config.SyncFusionLicense);
		On<Android>().UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Resize);
		AppSession.HasNfc = ((!DemoSettings.IsDemoModeEnabled) ? nfcService.HasNFCSupport() : (DemoConfig.HasNfc && nfcService.HasNFCSupport()));
		AppSession.IsKeyAttestationSupported = mobileSettings.KeyAttestationResult == KeyAttestationResult.Success || KeyAttestationService.IsSupported;
		AppSession.ActivationStatus = mobileSettings.ActivationStatus;
		DemoConfig.UnreadMessagesCount = (DemoConfig.HasMessages ? 5 : 0);
		Localization.AppType = AppType.DigiDApp;
		LanguageSelectView.InitAndSetLanguagePreference();
		matomoService.TrackAction("General", "AppStart", "Launcher");
		if (logger.IsEnabled(LogLevel.Information))
		{
			logger.LogInformation("App Construct: {elapsedMilliseconds}ms", stopwatch.ElapsedMilliseconds);
		}
		connectionService.StartMonitor();
	}

	protected override Microsoft.Maui.Controls.Window CreateWindow(IActivationState? activationState)
	{
		if (mobileSettings.ActivationStatus == ActivationStatus.NotActivated)
		{
			return CreateWindow(new NavigationPage(navigationService.GetPage<DG001>()));
		}
		Microsoft.Maui.Controls.Page page = navigationService.GetPage<PinCodePage, PinCodeViewModel>(delegate(PinCodeViewModel vm)
		{
			vm.Initialize(new PinCodeModel(PinEntryType.Authentication)
			{
				IsAppAuthentication = true,
				NextAction = sessionService.SetStartPage,
				StartBiometrics = true
			});
		});
		Microsoft.Maui.Controls.Page page2;
		if (mobileSettings.ActivationStatus == ActivationStatus.Pending)
		{
			AppSession.SetNextState(AppActivationState.WaitingForLetter);
			page2 = navigationService.GetPage<DG001>();
		}
		else
		{
			page2 = navigationService.GetPage<DG037>();
		}
		NavigationPage navigationPage = new NavigationPage(page);
		navigationPage.Navigation.InsertPageBefore(page2, page);
		return CreateWindow(navigationPage);
	}

	private static Microsoft.Maui.Controls.Window CreateWindow(NavigationPage navPage)
	{
		Microsoft.Maui.Controls.Window window = new Microsoft.Maui.Controls.Window(navPage);
		window.MinimumHeight = DisplayHelper.MinWindowHeight;
		window.MinimumWidth = DisplayHelper.MinWindowWidth;
		window.MaximumHeight = DisplayHelper.MaxWindowHeight;
		window.MaximumWidth = DisplayHelper.MaxWindowWidth;
		window.Height = DisplayHelper.MaxContentHeight;
		window.Width = DisplayHelper.MaxContentWidth;
		return window;
	}

	public static async Task<bool> Initialize()
	{
		AppSession.ServiceProvider.GetRequiredService<IDialogService>().Show();
		bool isConnected = await AppSession.ServiceProvider.GetRequiredService<IConnectionService>().CheckNetworkConnection();
		bool initialized = false;
		if (isConnected)
		{
			await AppSession.ServiceProvider.GetRequiredService<IConfigurationService>().GetActualConfiguration();
			initialized = await CheckVersion();
		}
		await AppSession.ServiceProvider.GetRequiredService<IDialogService>().Hide();
		return initialized;
	}

	private static async Task<bool> CheckVersion()
	{
		if (_versionChecked)
		{
			return true;
		}
		IVersionApi versionApi = AppSession.ServiceProvider.GetRequiredService<IVersionApi>();
		INavigationService navigationService = AppSession.ServiceProvider.GetRequiredService<INavigationService>();
		VersionCheckResponse response = await versionApi.CheckVersion();
		_versionChecked = true;
		await AppSession.ServiceProvider.GetRequiredService<IDialogService>().Hide();
		await Task.Delay(350);
		switch (response.VersionAction)
		{
		case VersionState.Warning:
			await navigationService.PushModalAsync<FM002A, FM002ViewModel>(delegate(FM002ViewModel vm)
			{
				vm.Initialize(response);
			});
			break;
		case VersionState.ForcedUpdate:
			await navigationService.PushModalAsync<FM002B, FM002ViewModel>(delegate(FM002ViewModel vm)
			{
				vm.Initialize(response);
			});
			break;
		case VersionState.Kill:
			await navigationService.PushModalAsync<FM002C, FM002ViewModel>(delegate(FM002ViewModel vm)
			{
				vm.Initialize(response);
			});
			break;
		}
		return response.VersionAction == VersionState.Active;
	}

	protected override void OnResume()
	{
		base.OnResume();
		Microsoft.UI.Xaml.Application current = Microsoft.UI.Xaml.Application.Current;
		if ((object)current != null)
		{
			current.UnhandledException += delegate(object sender, Microsoft.UI.Xaml.UnhandledExceptionEventArgs args)
			{
				if (args.Exception is InvalidOperationException ex && ex.Message.Contains("already") && ex.Message.Contains("activated"))
				{
					args.Handled = true;
				}
			};
		}
		if (mobileSettings.ActivationStatus != ActivationStatus.NotActivated)
		{
			if (deviceLockService.NeedLock)
			{
				deviceLockService.Lock(userAction: false, logoutSession: true, forced: true);
			}
			else
			{
				deviceLockService.Start();
			}
		}
		AppSession.IsAppVisible = true;
	}

	protected override void OnSleep()
	{
		base.OnSleep();
		deviceLockService.Stop();
		AppSession.IsAppVisible = false;
	}

	internal static void DisplayTouched()
	{
		AppSession.ServiceProvider.GetRequiredService<IDeviceLockService>().Update();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(App).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(App)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		Microsoft.Maui.Controls.ResourceDictionary resourceDictionary = new Microsoft.Maui.Controls.ResourceDictionary();
		VisualDiagnostics.RegisterSourceInfo(resourceDictionary, new Uri("App.xaml;assembly=DigiD.Mobile", UriKind.Relative), 11, 18);
		Microsoft.Maui.Controls.ResourceDictionary resourceDictionary2 = new Microsoft.Maui.Controls.ResourceDictionary();
		VisualDiagnostics.RegisterSourceInfo(resourceDictionary2, new Uri("App.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		Microsoft.Maui.Controls.ControlTemplate controlTemplate = new Microsoft.Maui.Controls.ControlTemplate();
		VisualDiagnostics.RegisterSourceInfo(controlTemplate, new Uri("App.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 14);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("App.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 52);
		Microsoft.Maui.Controls.Setter setter = new Microsoft.Maui.Controls.Setter();
		VisualDiagnostics.RegisterSourceInfo(setter, new Uri("App.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 18);
		Microsoft.Maui.Controls.Style style = new Microsoft.Maui.Controls.Style(typeof(CustomAnimationView));
		VisualDiagnostics.RegisterSourceInfo(style, new Uri("App.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 14);
		Microsoft.Maui.Controls.Style style2 = new Microsoft.Maui.Controls.Style(typeof(CustomAnimationView));
		VisualDiagnostics.RegisterSourceInfo(style2, new Uri("App.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 14);
		Microsoft.Maui.Controls.ResourceDictionary resourceDictionary3 = new Microsoft.Maui.Controls.ResourceDictionary();
		VisualDiagnostics.RegisterSourceInfo(resourceDictionary3, new Uri("App.xaml;assembly=DigiD.Mobile", UriKind.Relative), 9, 10);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("App.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope value = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, value);
		INameScope nameScope = new NameScope();
		Resources = resourceDictionary3;
		Uri uri = new Uri("Resources/Themes/General.xaml;assembly=DigiD.Mobile", UriKind.RelativeOrAbsolute);
		resourceDictionary.SetAndCreateSource<General>(uri);
		resourceDictionary.Source = uri;
		ICollection<Microsoft.Maui.Controls.ResourceDictionary> mergedDictionaries = resourceDictionary3.MergedDictionaries;
		mergedDictionaries.Add(resourceDictionary);
		Uri uri2 = new Uri("Resources/Themes/Light.xaml;assembly=DigiD.Mobile", UriKind.RelativeOrAbsolute);
		resourceDictionary2.SetAndCreateSource<Light>(uri2);
		resourceDictionary2.Source = uri2;
		mergedDictionaries.Add(resourceDictionary2);
		controlTemplate.LoadTemplate = delegate
		{
			SKCanvasView sKCanvasView = new SKCanvasView();
			VisualDiagnostics.RegisterSourceInfo(sKCanvasView, new Uri("App.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 18);
			INameScope nameScope2 = new NameScope();
			NameScope.SetNameScope(sKCanvasView, nameScope2);
			nameScope2.RegisterName("PART_DrawingSurface", sKCanvasView);
			SKCanvasView sKCanvasView2 = sKCanvasView;
			if (sKCanvasView2.StyleId == null)
			{
				string text = (sKCanvasView2.StyleId = "PART_DrawingSurface");
			}
			return sKCanvasView;
		};
		resourceDictionary3["SKLottieViewControlTemplate"] = controlTemplate;
		setter.Property = TemplatedView.ControlTemplateProperty;
		staticResourceExtension.Key = "SKLottieViewControlTemplate";
		Microsoft.Maui.Controls.ControlTemplate controlTemplate2 = controlTemplate;
		if (VisualDiagnostics.GetSourceInfo(controlTemplate2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(controlTemplate2, new Uri("App.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 52);
		}
		setter.Value = controlTemplate2;
		Microsoft.Maui.Controls.Setter setter2 = new Microsoft.Maui.Controls.Setter
		{
			Property = TemplatedView.ControlTemplateProperty,
			Value = controlTemplate2
		};
		if (VisualDiagnostics.GetSourceInfo(setter2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter2, new Uri("App.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 18);
		}
		style.Setters.Add(setter2);
		resourceDictionary3["SKLottieViewStyle"] = style;
		style2.BaseResourceKey = "SKLottieViewStyle";
		resourceDictionary3.Add(style2);
		Resources = resourceDictionary3;
		static string? getPathForType(Type type)
		{
			Assembly assembly = type.Assembly;
			foreach (XamlResourceIdAttribute customAttribute in assembly.GetCustomAttributes<XamlResourceIdAttribute>())
			{
				if (customAttribute.Type == type)
				{
					return customAttribute.Path;
				}
			}
			return null;
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(App));
	}
}
