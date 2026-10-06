using System;
using System.Threading.Tasks;
using DigiD.Common.Interfaces;
using Microsoft.Maui;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;
using Microsoft.UI.Dispatching;
using WinRT.Interop;
using Windows.Services.Store;
using Windows.System;

namespace DigiD.Common.Plugins.Services;

internal class AppRatingImplementation : IAppRating
{
	public bool ThrowErrors { get; set; }

	public async Task PerformInAppRateAsync()
	{
		Microsoft.UI.Dispatching.DispatcherQueue dispatcher = Microsoft.UI.Dispatching.DispatcherQueue.GetForCurrentThread() ?? WindowStateManager.Default.GetActiveWindow()?.DispatcherQueue;
		if ((object)dispatcher == null)
		{
			return;
		}
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		dispatcher.TryEnqueue(Microsoft.UI.Dispatching.DispatcherQueuePriority.Normal, async delegate
		{
			try
			{
				StoreContext storeContext = StoreContext.GetDefault();
				nint hwnd = GetWindowHandle();
				InitializeWithWindow.Initialize(storeContext, hwnd);
				StoreRateAndReviewResult result = await storeContext.RequestRateAndReviewAppAsync();
				switch (result.Status)
				{
				default:
					tcs.SetResult(result.Status == StoreRateAndReviewStatus.Succeeded);
					break;
				}
			}
			catch (Exception)
			{
				if (ThrowErrors)
				{
					throw;
				}
				tcs.SetResult(result: false);
			}
		});
		await tcs.Task;
	}

	public Task PerformRatingOnStoreAsync(string appId)
	{
		return PerformRatingOnStoreAsync("", "", appId);
	}

	public async Task PerformRatingOnStoreAsync(string packageName = "", string applicationId = "", string productId = "")
	{
		if (string.IsNullOrEmpty(productId))
		{
			return;
		}
		try
		{
			await Windows.System.Launcher.LaunchUriAsync(new Uri("ms-windows-store://review/?ProductId=" + productId));
		}
		catch (Exception)
		{
			if (ThrowErrors)
			{
				throw;
			}
		}
	}

	private static nint GetWindowHandle()
	{
		return ((MauiWinUIWindow)(Application.Current?.Windows[0].Handler.PlatformView)).WindowHandle;
	}
}
