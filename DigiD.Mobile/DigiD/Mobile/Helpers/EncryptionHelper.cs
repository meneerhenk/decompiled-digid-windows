using System.IO;
using System.Security.Cryptography;
using DigiD.Common.Helpers;
using DigiD.Common.Models.Helpers;

namespace DigiD.Mobile.Helpers;

internal static class EncryptionHelper
{
	internal static string Encrypt(string data, byte[] iv, byte[] key)
	{
		using Aes aes = Aes.Create();
		aes.Mode = CipherMode.CBC;
		aes.KeySize = 256;
		using ICryptoTransform transform = aes.CreateEncryptor(key, iv);
		using MemoryStream memoryStream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
		byte[] bytes = data.GetBytes();
		cryptoStream.Write(bytes, 0, bytes.Length);
		cryptoStream.FlushFinalBlock();
		return memoryStream.ToArray().ToBase16();
	}

	internal static string Decrypt(string data, byte[] iv, byte[] key)
	{
		using Aes aes = Aes.Create();
		aes.Mode = CipherMode.CBC;
		aes.KeySize = 256;
		using ICryptoTransform transform = aes.CreateDecryptor(key, iv);
		byte[] buffer = data.FromBase16();
		using MemoryStream stream = new MemoryStream(buffer);
		using CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
		using StreamReader streamReader = new StreamReader(stream2);
		return streamReader.ReadToEnd();
	}
}
