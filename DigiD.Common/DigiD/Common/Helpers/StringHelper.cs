using System;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Helpers;
using DigiD.Common.NFC.Enums;
using DigiD.Common.Resources;

namespace DigiD.Common.Helpers;

public static class StringHelper
{
	[GeneratedRegex("<[^>]*>")]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "10.0.14.42308")]
	private static Regex StripHtmlRegex()
	{
		return _003CRegexGenerator_g_003EF8A1A82AA081C17FF7863DB1460940C4296090F980CA89321FAE4DD9A8B1305C6__StripHtmlRegex_0.Instance;
	}

	public static string? StripHtml(this string? text)
	{
		if (text != null && text.Contains('<'))
		{
			return StripHtmlRegex().Replace(text, string.Empty);
		}
		return text;
	}

	public static DateTime ToDate(this string input)
	{
		try
		{
			return DateTime.Parse(input, CultureInfo.DefaultThreadCurrentCulture);
		}
		catch (Exception)
		{
			return DateTime.MinValue;
		}
	}

	public static string Translate(this DocumentType documentType)
	{
		return documentType switch
		{
			DocumentType.DrivingLicense => CommonResources.DrivingLicense, 
			DocumentType.IDCard => CommonResources.IDCard, 
			DocumentType.Passport => CommonResources.Passport, 
			_ => CommonResources.eID, 
		};
	}

	public static string Translate(this BiometricType type)
	{
		return type switch
		{
			BiometricType.FaceID => DigiDAppResources.BiometricsFaceId, 
			BiometricType.TouchID => DigiDAppResources.BiometricsTouchId, 
			BiometricType.FingerPrint => DigiDAppResources.BiometricsFingerprint.ToLower(), 
			_ => string.Empty, 
		};
	}

	public static string TranslateType(this BiometricType type)
	{
		switch (type)
		{
		case BiometricType.FaceID:
			return CommonResources.Alg_Face;
		case BiometricType.FingerPrint:
		case BiometricType.TouchID:
			return CommonResources.Alg_Fingerprint;
		default:
			return string.Empty;
		}
	}

	public static byte[] GetBytes(this string str)
	{
		return Encoding.UTF8.GetBytes(str);
	}

	public static byte[] Hash(this string str)
	{
		return SHA256.HashData(Encoding.UTF8.GetBytes(str));
	}

	public static byte[] FromBase16(this string hex)
	{
		int length = hex.Length;
		byte[] array = new byte[length / 2];
		for (int i = 0; i < length; i += 2)
		{
			array[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
		}
		return array;
	}

	public static string ReplaceEmoticons(this string text)
	{
		return ReplaceEmoticonsRegex().Replace(text, "?");
	}

	public static string DeObfuscate(this string value, string key)
	{
		return Convert.FromBase64String(value).DeObfuscate(Convert.FromBase64String(key));
	}

	[GeneratedRegex("[^\\u0000-\\u007F]+")]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "10.0.14.42308")]
	private static Regex ReplaceEmoticonsRegex()
	{
		return _003CRegexGenerator_g_003EF8A1A82AA081C17FF7863DB1460940C4296090F980CA89321FAE4DD9A8B1305C6__ReplaceEmoticonsRegex_1.Instance;
	}

	public static bool TryGetFromBase64String(string input, out byte[]? output)
	{
		output = null;
		try
		{
			output = Convert.FromBase64String(input);
			return true;
		}
		catch (FormatException)
		{
			return false;
		}
	}

	public static string FirstCharSubstring(this string input)
	{
		if (string.IsNullOrEmpty(input))
		{
			return string.Empty;
		}
		Span<char> span = stackalloc char[1];
		input.AsSpan(0, 1).ToUpperInvariant(span);
		return $"{(ReadOnlySpan<char>)span}{input.AsSpan(1)}";
	}
}
