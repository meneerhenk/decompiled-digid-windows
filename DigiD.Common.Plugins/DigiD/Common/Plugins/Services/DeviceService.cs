using System;
using System.Globalization;
using System.Threading.Tasks;
using DigiD.Common.Interfaces;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Devices;
using Microsoft.UI.Xaml.Controls;
using Windows.ApplicationModel.Core;

namespace DigiD.Common.Plugins.Services;

internal class DeviceService : IDeviceService
{
	public string DeviceName => DeviceInfo.Name;

	public string DeviceTypeName => "Desktop";

	public string DefaultLanguage => CultureInfo.InstalledUICulture.TwoLetterISOLanguageName;

	public bool IsPowerSaveMode => false;

	public void OpenSettings()
	{
		AppInfo.Current.ShowSettingsUI();
	}

	public bool OpenBrowser(string name, string uri)
	{
		throw new NotImplementedException();
	}

	public async Task<string?> UserAgent()
	{
		WebView2 wv = new WebView2();
		await wv.EnsureCoreWebView2Async();
		return await wv.ExecuteScriptAsync("navigator.userAgent");
	}

	public void CloseApp()
	{
		CoreApplication.Exit();
	}
}
