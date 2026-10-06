using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using BerTlv;

namespace DigiD.Common.EID.Helpers;

public static class ByteHelper
{
	public static byte[] ToBytes(this SecureString secureString)
	{
		return Encoding.UTF8.GetBytes(secureString.ToPlain());
	}

	public static string ToPlain(this SecureString? value)
	{
		if (value == null)
		{
			return string.Empty;
		}
		nint num = IntPtr.Zero;
		try
		{
			num = Marshal.SecureStringToGlobalAllocUnicode(value);
			return Marshal.PtrToStringUni(num) ?? string.Empty;
		}
		finally
		{
			Marshal.ZeroFreeGlobalAllocUnicode(num);
		}
	}

	public static byte[] Xor(byte[] lhs, byte[] rhs)
	{
		if (lhs.Length != rhs.Length)
		{
			throw new ArgumentException("The arrays to XOR are not the same length");
		}
		byte[] array = new byte[lhs.Length];
		for (int i = 0; i < lhs.Length; i++)
		{
			array[i] = (byte)(lhs[i] ^ rhs[i]);
		}
		return array;
	}

	public static byte[] AdjustPadding(byte[] data, int size)
	{
		using MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(data, 0, data.Length);
		memoryStream.WriteByte(128);
		while (memoryStream.Length % size != 0)
		{
			memoryStream.WriteByte(0);
		}
		return memoryStream.ToArray();
	}

	public static byte[] RemovePadding(byte[] data)
	{
		ArgumentNullException.ThrowIfNull(data, "data");
		int num = data.Length;
		if (data[num - 1] == 128)
		{
			num--;
		}
		else
		{
			int num2 = data.Length - 1;
			while (num2 >= 0)
			{
				if (data[num2] == 0)
				{
					num--;
					num2--;
					continue;
				}
				if (data[num2] == 128)
				{
					num--;
					break;
				}
				throw new InvalidDataException("Error removing AES padding");
			}
		}
		return data.Take(num).ToArray();
	}

	public static byte[] AdjustParity(byte[] bytes)
	{
		for (int i = 0; i < bytes.Length; i++)
		{
			int num = bytes[i];
			bytes[i] = (byte)((num & 0xFE) | (((num >> 1) ^ (num >> 2) ^ (num >> 3) ^ (num >> 4) ^ (num >> 5) ^ (num >> 6) ^ (num >> 7) ^ 1) & 1));
		}
		return bytes;
	}

	internal static byte[] GetSignature(byte[] rawSignature)
	{
		ICollection<Tlv> source = Tlv.ParseTlv(rawSignature);
		List<Tlv> list = source.First().Children.ToList();
		byte[] array = list[0].Value;
		byte[] array2 = list[1].Value;
		if (array[0] == 0)
		{
			array = array.Skip(1).ToArray();
		}
		if (array2[0] == 0)
		{
			array2 = array2.Skip(1).ToArray();
		}
		return array.Concat(array2).ToArray();
	}
}
