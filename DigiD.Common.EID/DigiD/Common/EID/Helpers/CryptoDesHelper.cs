using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using DigiD.Common.EID.Models;
using DigiD.Common.NFC.Models;

namespace DigiD.Common.EID.Helpers;

public static class CryptoDesHelper
{
	public static byte[] ComputeKey(byte[] kSeed, byte[] cBytes)
	{
		byte[] source = kSeed.Concat(cBytes).ToArray();
		byte[] source2 = SHA1.HashData(source);
		byte[] bytes = source2.Take(8).ToArray();
		byte[] bytes2 = source2.Skip(8).Take(8).ToArray();
		byte[] first = ByteHelper.AdjustParity(bytes);
		byte[] second = ByteHelper.AdjustParity(bytes2);
		return first.Concat(second).ToArray();
	}

	internal static bool IsValidResponse(this ResponseApdu apdu, SMContext context)
	{
		if (context == null || !context.IsBAC)
		{
			return true;
		}
		if (context.KMac == null)
		{
			return false;
		}
		byte[] first = context.IncrementSSC();
		IEnumerable<byte> second = apdu.Data.Skip(6).Take(8);
		DataObject dataObject = new DataObject(153, new byte[2] { 144, 0 });
		byte[] inputBuffer = first.Concat(dataObject.GetEncoded()).ToArray();
		byte[] first2 = ComputeMacTDes(inputBuffer, context.KMac);
		return first2.SequenceEqual(second);
	}

	public static byte[] TripleDesProvider(byte[] inputBuffer, byte[] key, bool encrypt)
	{
		TripleDES tripleDES = TripleDES.Create();
		tripleDES.Key = key;
		tripleDES.IV = new byte[8];
		tripleDES.Padding = PaddingMode.None;
		tripleDES.Mode = CipherMode.CBC;
		using MemoryStream memoryStream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(memoryStream, encrypt ? tripleDES.CreateEncryptor() : tripleDES.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(inputBuffer, 0, inputBuffer.Length);
		cryptoStream.Flush();
		return memoryStream.ToArray();
	}

	public static byte[] ComputeMacTDes(byte[] inputBuffer, byte[] key)
	{
		byte[] key2 = key.Take(8).ToArray();
		byte[] key3 = key.Skip(8).Take(8).ToArray();
		DES dES = DES.Create();
		dES.BlockSize = 64;
		dES.Key = key2;
		dES.Mode = CipherMode.CBC;
		dES.Padding = PaddingMode.None;
		dES.IV = new byte[8];
		DES dES2 = DES.Create();
		dES2.BlockSize = 64;
		dES2.Key = key3;
		dES2.Mode = CipherMode.CBC;
		dES2.Padding = PaddingMode.None;
		dES2.IV = new byte[8];
		byte[] array = ByteHelper.AdjustPadding(inputBuffer, 8);
		byte[] array2 = new byte[8];
		byte[] array3 = dES.CreateEncryptor().TransformFinalBlock(array.Take(8).ToArray(), 0, 8);
		for (int i = 1; i < array.Length / 8; i++)
		{
			byte[] array4 = array.Skip(8 * i).Take(8).ToArray();
			for (int j = 0; j < 8; j++)
			{
				array2[j] = (byte)(array3[j] ^ array4[j]);
			}
			array3 = dES.CreateEncryptor().TransformFinalBlock(array2, 0, 8);
		}
		byte[] inputBuffer2 = dES2.CreateDecryptor().TransformFinalBlock(array3, 0, 8);
		return dES.CreateEncryptor().TransformFinalBlock(inputBuffer2, 0, 8);
	}
}
