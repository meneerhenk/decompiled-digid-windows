using System;
using System.Text;

namespace DigiD.Common.Helpers;

public static class Base64UrlEncoder
{
	private const char Base64Character62 = '+';

	private const char Base64Character63 = '/';

	private const string Base64DoublePadCharacter = "==";

	private const char Base64PadCharacter = '=';

	private const char Base64UrlCharacter62 = '-';

	private const char Base64UrlCharacter63 = '_';

	public static string Decode(string s)
	{
		return Encoding.UTF8.GetString(DecodeBytes(s));
	}

	public static byte[] DecodeBytes(string s)
	{
		ArgumentNullException.ThrowIfNull(s, "s");
		s = s.Replace('-', '+');
		s = s.Replace('_', '/');
		switch (s.Length % 4)
		{
		case 2:
			s += "==";
			break;
		case 3:
			s += "=";
			break;
		default:
			throw new FormatException("Invalid Base64 URL encoding.");
		case 0:
			break;
		}
		return Convert.FromBase64String(s);
	}

	public static string Encode(string s)
	{
		ArgumentNullException.ThrowIfNull(s, "s");
		return Encode(Encoding.UTF8.GetBytes(s));
	}

	public static string Encode(byte[] bytes)
	{
		ArgumentNullException.ThrowIfNull(bytes, "bytes");
		string text = Convert.ToBase64String(bytes, 0, bytes.Length);
		text = text.Split('=')[0];
		text = text.Replace('+', '-');
		return text.Replace('/', '_');
	}

	public static string Encode(byte[] bytes, int offset, int length)
	{
		ArgumentNullException.ThrowIfNull(bytes, "bytes");
		string text = Convert.ToBase64String(bytes, offset, length);
		text = text.Split('=')[0];
		text = text.Replace('+', '-');
		return text.Replace('/', '_');
	}
}
