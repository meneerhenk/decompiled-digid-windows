using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using DigiD.Common.Interfaces;
using DigiD.Common.SessionModels;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.WinUI;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.Windows.AppLifecycle;
using WinRT;
using WinRT.Interop;
using Windows.ApplicationModel.Activation;

namespace DigiD.Mobile.Platforms.Windows;

public class Program
{
	private static DigiD.Mobile.WinUI.App? _app;

	private const int SW_RESTORE = 9;

	[STAThread]
	private static void Main(string[] args)
	{
		ComWrappersSupport.InitializeComWrappers();
		if (!DecideRedirection())
		{
			Microsoft.UI.Xaml.Application.Start(delegate
			{
				DispatcherQueueSynchronizationContext synchronizationContext = new DispatcherQueueSynchronizationContext(DispatcherQueue.GetForCurrentThread());
				SynchronizationContext.SetSynchronizationContext(synchronizationContext);
				_app = new DigiD.Mobile.WinUI.App();
			});
		}
	}

	private static bool DecideRedirection()
	{
		bool result = false;
		AppActivationArguments activatedEventArgs = AppInstance.GetCurrent().GetActivatedEventArgs();
		AppInstance appInstance = AppInstance.FindOrRegisterForKey("digid_desktop_app");
		if (appInstance.IsCurrent)
		{
			appInstance.Activated += OnActivated;
		}
		else
		{
			result = true;
			appInstance.RedirectActivationToAsync(activatedEventArgs).AsTask().Wait();
		}
		return result;
	}

	private static void OnActivated(object? sender, AppActivationArguments args)
	{
		object data = args.Data;
		ProtocolActivatedEventArgs data2 = data as ProtocolActivatedEventArgs;
		if ((object)data2 == null || !(_app != null))
		{
			return;
		}
		try
		{
			if ((object)data2.Uri != null)
			{
				BringAppToForeground();
				Task.Run(async delegate
				{
					AppSession.IsAppActivatedFromBrowser = false;
					await ((IApp)Microsoft.Maui.Controls.Application.Current).ServiceProvider.GetRequiredService<IIncomingDataService>().HandleIncomingData(data2.Uri);
				});
			}
		}
		catch (UriFormatException)
		{
		}
	}

	private static void BringAppToForeground()
	{
		Microsoft.Maui.Controls.Application? current = Microsoft.Maui.Controls.Application.Current;
		if (current != null && current.Windows.Count == 0)
		{
			return;
		}
		Microsoft.Maui.Controls.Window window = Microsoft.Maui.Controls.Application.Current.Windows[0];
		object obj = window.Handler?.PlatformView;
		Microsoft.UI.Xaml.Window nativeWindow = obj as Microsoft.UI.Xaml.Window;
		if ((object)nativeWindow == null)
		{
			return;
		}
		nativeWindow.DispatcherQueue.TryEnqueue(delegate
		{
			nint windowHandle = WindowNative.GetWindowHandle(nativeWindow);
			if (windowHandle != 0)
			{
				ShowWindow(windowHandle, 9);
				SetForegroundWindow(windowHandle);
				nativeWindow.Activate();
			}
		});
	}

	[DllImport("user32.dll")]
	private static extern bool SetForegroundWindow(nint hWnd);

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(nint hWnd, int nCmdShow);
}
