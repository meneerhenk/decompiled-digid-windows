using System;
using System.Text;

namespace DigiD.Common.Models.Helpers;

public static class ObfuscateHelper
{
	public static byte[] Obfuscate(this string text, byte[] byteKey)
	{
		ArgumentNullException.ThrowIfNull(byteKey, "byteKey");
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		byte[] array = new byte[bytes.Length];
		for (int i = 0; i < bytes.Length; i++)
		{
			array[i] = (byte)(bytes[i] ^ byteKey[i % byteKey.Length]);
		}
		return array;
	}

	public static string DeObfuscate(this byte[]? text, byte[] key)
	{
		ArgumentNullException.ThrowIfNull(key, "key");
		if (text == null)
		{
			return string.Empty;
		}
		byte[] array = new byte[text.Length];
		for (int i = 0; i < text.Length; i++)
		{
			array[i] = (byte)(text[i] ^ key[i % key.Length]);
		}
		return Encoding.UTF8.GetString(array);
	}
}
