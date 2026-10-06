using System;
using System.Globalization;
using System.Linq;
using System.Security;
using DigiD.Common.EID.Helpers;

namespace DigiD.Common.Helpers;

public static class SecureStringHelper
{
	public static SecureString ToSecureString(this string? value)
	{
		ArgumentNullException.ThrowIfNull(value, "value");
		SecureString secureString = new SecureString();
		foreach (char c in value)
		{
			secureString.AppendChar(c);
		}
		return secureString;
	}

	public static bool IsIncreasing(this SecureString s)
	{
		return "01234567890".Contains(s.ToPlain());
	}

	public static bool IsDecreasing(this SecureString s)
	{
		return "09876543210".Contains(s.ToPlain());
	}

	public static bool AreEqual(this SecureString s)
	{
		return s.ToPlain().Distinct().Count() == 1;
	}

	public static void AppendChar(this SecureString? secureString, int value)
	{
		ArgumentNullException.ThrowIfNull(secureString, "secureString");
		string text = value.ToString(CultureInfo.InvariantCulture);
		foreach (char c in text)
		{
			secureString.AppendChar(c);
		}
	}

	public static void RemoveChar(this SecureString? secureString)
	{
		ArgumentNullException.ThrowIfNull(secureString, "secureString");
		secureString.RemoveAt(secureString.Length - 1);
	}
}
