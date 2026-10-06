using Microsoft.Maui.Devices;
using Microsoft.Maui.Graphics;
using Windows.Devices.Input;

namespace DigiD.Common.Helpers;

public static class DisplayHelper
{
	public static bool IsTablet => DeviceInfo.Idiom == DeviceIdiom.Tablet && DeviceInfo.Platform != DevicePlatform.WinUI;

	public static double MinContentWidth => (DeviceInfo.Idiom == DeviceIdiom.Phone) ? Width : 600.0;

	public static double MaxContentWidth => (DeviceInfo.Idiom == DeviceIdiom.Phone) ? Width : 800.0;

	public static double MinContentHeight => (DeviceInfo.Idiom == DeviceIdiom.Phone) ? Height : 390.0;

	public static double MaxContentHeight => (DeviceInfo.Idiom == DeviceIdiom.Phone) ? MinContentHeight : (MinContentHeight * 2.0);

	public static double MinWindowWidth => MinContentWidth + (double)((!(DeviceInfo.Idiom == DeviceIdiom.Phone)) ? 280 : 0);

	public static double MinWindowHeight => MinContentHeight + (double)((DeviceInfo.Idiom == DeviceIdiom.Phone) ? 280 : 0);

	public static double MaxWindowWidth => (DeviceInfo.Idiom == DeviceIdiom.Phone) ? MinWindowWidth : (MinWindowWidth * 2.0);

	public static double MaxWindowHeight => (DeviceInfo.Idiom == DeviceIdiom.Phone) ? MinWindowHeight : (MinWindowHeight * 2.0);

	public static double Width => DeviceDisplay.MainDisplayInfo.Width / DeviceDisplay.MainDisplayInfo.Density;

	public static double Height => DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density;

	public static Size Size => new Size(Width, Height);

	public static bool HasTouchCapabilities()
	{
		return new TouchCapabilities().TouchPresent > 0;
	}
}
