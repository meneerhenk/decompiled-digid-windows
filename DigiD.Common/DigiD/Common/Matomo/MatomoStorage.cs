using System;
using Microsoft.Maui.Storage;

namespace DigiD.Common.Matomo;

internal static class MatomoStorage
{
	internal static int SessionsCount
	{
		get
		{
			return Microsoft.Maui.Storage.Preferences.Get("SessionsCount", 0);
		}
		set
		{
			Microsoft.Maui.Storage.Preferences.Set("SessionsCount", value);
		}
	}

	internal static DateTime FirstVisit
	{
		get
		{
			return Microsoft.Maui.Storage.Preferences.Get("FirstVisit", DateTime.Now);
		}
		set
		{
			Microsoft.Maui.Storage.Preferences.Set("FirstVisit", value);
		}
	}

	internal static DateTime LastVisit
	{
		get
		{
			return Microsoft.Maui.Storage.Preferences.Get("LastVisit", DateTime.Now);
		}
		set
		{
			Microsoft.Maui.Storage.Preferences.Set("LastVisit", value);
		}
	}
}
