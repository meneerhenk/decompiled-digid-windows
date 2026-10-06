using System;
using System.Linq;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Nfc;
using DigiD.Common.Resources;

namespace DigiD.Common.Models.Helpers;

public static class StringHelper
{
	public static string ToHexString(this byte[]? data)
	{
		ArgumentNullException.ThrowIfNull(data, "data");
		return BitConverter.ToString(data);
	}

	public static string ToBase64(this byte[]? ba)
	{
		if (ba == null)
		{
			return string.Empty;
		}
		return Convert.ToBase64String(ba);
	}

	public static string ToBase16(this byte[]? ba)
	{
		if (ba == null)
		{
			return string.Empty;
		}
		string text = BitConverter.ToString(ba);
		return text.Replace("-", "").ToLowerInvariant();
	}

	public static byte[] ToBytes(this string? hexString)
	{
		if (string.IsNullOrEmpty(hexString))
		{
			return new byte[1];
		}
		hexString = hexString.Replace("-", string.Empty);
		if (hexString.Length % 2 != 0)
		{
			hexString = "0" + hexString;
		}
		return (from x in Enumerable.Range(0, hexString.Length)
			where x % 2 == 0
			select Convert.ToByte(hexString.Substring(x, 2), 16)).ToArray();
	}

	public static string Translate(this CodeType codeType)
	{
		return codeType switch
		{
			CodeType.SMS => CommonResources.Alg_SMS, 
			CodeType.Letter => CommonResources.Alg_Letter, 
			CodeType.Email => CommonResources.Alg_Email, 
			CodeType.KoppelCode => CommonResources.Alg_VerificationCode, 
			_ => "", 
		};
	}

	public static string Translate(this NfcPosition position)
	{
		return position switch
		{
			NfcPosition.Top => CommonResources.NfcLocation_Top, 
			NfcPosition.Middle => CommonResources.NfcLocation_Middle, 
			NfcPosition.Bottom => CommonResources.NfcLocation_Bottom, 
			_ => CommonResources.NfcLocation_Unknown, 
		};
	}
}
