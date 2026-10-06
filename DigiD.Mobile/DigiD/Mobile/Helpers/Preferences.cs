using System;
using System.Reflection;
using DigiD.Common.Enums;
using DigiD.Common.Models.Helpers;
using Microsoft.Maui.Storage;

namespace DigiD.Mobile.Helpers;

public static class Preferences
{
	public static DateTimeOffset LetterRequestDate
	{
		get
		{
			return Microsoft.Maui.Storage.Preferences.ContainsKey("LetterRequestDate") ? ((DateTimeOffset)Microsoft.Maui.Storage.Preferences.Get("LetterRequestDate", 0L).FromUnixTime()) : DateTimeOffset.MinValue;
		}
		set
		{
			Microsoft.Maui.Storage.Preferences.Set("LetterRequestDate", value.ToUnixTimeSeconds());
		}
	}

	public static bool LetterReRequestAllowed
	{
		get
		{
			return !Microsoft.Maui.Storage.Preferences.ContainsKey("LetterReRequestAllowed") || Microsoft.Maui.Storage.Preferences.Get("LetterReRequestAllowed", defaultValue: true);
		}
		set
		{
			Microsoft.Maui.Storage.Preferences.Set("LetterReRequestAllowed", value);
		}
	}

	public static int NumberOfSuccessfulLogins
	{
		get
		{
			return Microsoft.Maui.Storage.Preferences.Get("NumberOfSuccessfulLogins", 0);
		}
		set
		{
			Microsoft.Maui.Storage.Preferences.Set("NumberOfSuccessfulLogins", value);
		}
	}

	public static bool IsRatingRequested
	{
		get
		{
			return Microsoft.Maui.Storage.Preferences.Get("IsRatingRequested", defaultValue: false);
		}
		set
		{
			Microsoft.Maui.Storage.Preferences.Set("IsRatingRequested", value);
		}
	}

	public static BiometricsState BiometricsState
	{
		get
		{
			if (Microsoft.Maui.Storage.Preferences.ContainsKey("BiometricsState"))
			{
				return Enum.Parse<BiometricsState>(Microsoft.Maui.Storage.Preferences.Get("BiometricsState", BiometricsState.NotEnrolled.ToString()));
			}
			return BiometricsState.NotEnrolled;
		}
		set
		{
			Microsoft.Maui.Storage.Preferences.Set("BiometricsState", value.ToString());
		}
	}

	public static void Reset()
	{
		PropertyInfo[] properties = typeof(Preferences).GetProperties(BindingFlags.Static | BindingFlags.Public);
		foreach (PropertyInfo propertyInfo in properties)
		{
			Microsoft.Maui.Storage.Preferences.Remove(propertyInfo.Name);
		}
	}
}
