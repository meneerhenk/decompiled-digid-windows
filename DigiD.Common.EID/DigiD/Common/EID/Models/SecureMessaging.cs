using System;
using System.Collections.Generic;
using System.Linq;
using BerTlv;
using DigiD.Common.EID.Helpers;
using DigiD.Common.NFC.Enums;
using DigiD.Common.NFC.Helpers;
using DigiD.Common.NFC.Models;
using Org.BouncyCastle.Utilities;

namespace DigiD.Common.EID.Models;

internal static class SecureMessaging
{
	internal static CommandApdu Encrypt(this CommandApdu cmd, SMContext ctx, bool chaining = false)
	{
		Debugger.DumpInfo("PLAIN", cmd);
		CLA cla = (chaining ? CLA.COMMAND_CHAINING_SM : CLA.SECURE_MESSAGING);
		byte[] data = (ctx.IsBAC ? GetCommandDataDES(cmd, ctx, cla) : GetCommandDataAES(cmd, ctx, cla));
		CommandApdu commandApdu = new CommandApdu(cla, cmd.INS, cmd.P1, cmd.P2, data)
		{
			IsSecureMessage = true
		};
		commandApdu.AppendLe();
		return commandApdu;
	}

	internal static CommandApdu[] EncryptMulti(this CommandApdu cmd, SMContext ctx)
	{
		Debugger.DumpInfo("PLAIN", cmd);
		byte[] commandDataAES = GetCommandDataAES(cmd, ctx, CLA.SECURE_MESSAGING);
		int num = commandDataAES.Length / 231;
		if (commandDataAES.Length % 231 != 0)
		{
			num++;
		}
		CommandApdu[] array = new CommandApdu[num];
		for (int i = 0; i <= num - 1; i++)
		{
			CLA cla = ((i < num - 1) ? CLA.COMMAND_CHAINING_SM : CLA.SECURE_MESSAGING);
			byte[] data = commandDataAES.Skip(i * 231).Take((i == num - 1) ? (commandDataAES.Length % 231) : 231).ToArray();
			CommandApdu commandApdu = new CommandApdu(cla, cmd.INS, cmd.P1, cmd.P2, data);
			if (i == num - 1)
			{
				commandApdu.AppendLe();
			}
			array[i] = commandApdu;
		}
		return array;
	}

	private static byte[] GetCommandDataDES(CommandApdu cmd, SMContext ctx, CLA cla)
	{
		ArgumentNullException.ThrowIfNull(ctx.KMac, "ctx.KMac");
		ArgumentNullException.ThrowIfNull(ctx.KEnc, "ctx.KEnc");
		byte[] second = Array.Empty<byte>();
		if (cmd.Ne.HasValue)
		{
			second = new DataObject(151, new byte[1] { (byte)cmd.Ne.Value }).GetEncoded();
		}
		byte[] data = new byte[4]
		{
			(byte)cla,
			(byte)cmd.INS,
			(byte)cmd.P1,
			(byte)cmd.P2
		};
		byte[] first = ByteHelper.AdjustPadding(data, 8);
		byte[] array = GetEncryptData();
		byte[] second2 = first.Concat(array).Concat(second).ToArray();
		byte[] first2 = ctx.IncrementSSC();
		byte[] inputBuffer = first2.Concat(second2).ToArray();
		byte[] data2 = CryptoDesHelper.ComputeMacTDes(inputBuffer, ctx.KMac);
		DataObject dataObject = new DataObject(142, data2);
		return array.Concat(second).Concat(dataObject.GetEncoded()).ToArray();
		byte[] GetEncryptData()
		{
			if (cmd.Data.Length == 0)
			{
				return Array.Empty<byte>();
			}
			byte[] inputBuffer2 = ByteHelper.AdjustPadding(cmd.Data, 8);
			byte[] second3 = CryptoDesHelper.TripleDesProvider(inputBuffer2, ctx.KEnc, encrypt: true);
			byte[] data3 = new byte[1] { 1 }.Concat(second3).ToArray();
			return new DataObject(135, data3).GetEncoded();
		}
	}

	private static byte[] GetCommandDataAES(CommandApdu cmd, SMContext ctx, CLA cla)
	{
		ArgumentNullException.ThrowIfNull(ctx.KMac, "ctx.KMac");
		ArgumentNullException.ThrowIfNull(ctx.KEnc, "ctx.KEnc");
		byte[] ssc = ctx.IncrementSSC();
		byte b = ssc.Skip(15).ToArray()[0];
		if (b % 2 == 0)
		{
			throw new ArgumentException("Wrong increment SSC", "ctx");
		}
		byte[] array = GetEncryptData();
		byte[] second = Array.Empty<byte>();
		if (cmd.Ne.HasValue)
		{
			second = new DataObject(151, new byte[1] { (byte)cmd.Ne.Value }).GetEncoded();
		}
		byte[] second2 = GetPaddedHeader();
		byte[] data = ByteHelper.AdjustPadding(ssc.Concat(second2).Concat(array).Concat(second)
			.ToArray(), 16);
		byte[] data2 = AesHelper.PerformCBC8(data, ctx.KMac);
		byte[] encoded = new DataObject(142, data2).GetEncoded();
		return array.Concat(second).Concat(encoded).ToArray();
		byte[] GetEncryptData()
		{
			if (cmd.Data.Length == 0)
			{
				return Array.Empty<byte>();
			}
			byte[] data3 = ByteHelper.AdjustPadding(cmd.Data, 16);
			byte[] iv = AesHelper.AESCBC(forEncryption: true, ssc, ctx.KEnc);
			byte[] second3 = AesHelper.AESCBC(forEncryption: true, data3, ctx.KEnc, iv);
			byte[] data4 = new byte[1] { 1 }.Concat(second3).ToArray();
			return new DataObject(135, data4).GetEncoded();
		}
		byte[] GetPaddedHeader()
		{
			byte[] data3 = new byte[4]
			{
				(byte)cla,
				(byte)cmd.INS,
				(byte)cmd.P1,
				(byte)cmd.P2
			};
			return ByteHelper.AdjustPadding(data3, 16);
		}
	}

	internal static ResponseApdu DecryptAES(this ResponseApdu resp, SMContext ctx, bool chaining = false)
	{
		ArgumentNullException.ThrowIfNull(ctx.KMac, "ctx.KMac");
		ArgumentNullException.ThrowIfNull(ctx.KEnc, "ctx.KEnc");
		byte[] array = ctx.IncrementSSC();
		byte b = array.Skip(15).ToArray()[0];
		if (b % 2 != 0)
		{
			throw new ArgumentException("Wrong increment SSC", "ctx");
		}
		byte[] data = resp.Data;
		if (chaining && resp.Data.Length == 0)
		{
			return resp;
		}
		byte[] b2 = Arrays.CopyOfRange(data, 0, data.Length - 10);
		b2 = Arrays.Concatenate(array, b2);
		b2 = ByteHelper.AdjustPadding(b2, 16);
		byte[] a = AesHelper.PerformCBC8(b2, ctx.KMac);
		byte[] array2 = Arrays.CopyOfRange(data, data.Length - 10, data.Length);
		if (!Arrays.AreEqual(a, Arrays.CopyOfRange(array2, 2, array2.Length)))
		{
			throw new ArgumentException("Could not verify integrity of response packet", "ctx");
		}
		byte[] a2 = Array.Empty<byte>();
		if (data[0] == 135)
		{
			ICollection<Tlv> source = Tlv.ParseTlv(data);
			byte[] data2 = source.First().Value.Skip(1).ToArray();
			byte[] iv = AesHelper.AESCBC(forEncryption: true, array, ctx.KEnc);
			a2 = AesHelper.AESCBC(forEncryption: false, data2, ctx.KEnc, iv);
			a2 = ByteHelper.RemovePadding(a2);
		}
		return new ResponseApdu(Arrays.Concatenate(a2, new byte[2]
		{
			(byte)resp.SW1,
			(byte)resp.SW2
		}));
	}

	internal static ResponseApdu DecryptDES(this ResponseApdu response, SMContext ctx)
	{
		ArgumentNullException.ThrowIfNull(ctx.KMac, "ctx.KMac");
		ArgumentNullException.ThrowIfNull(ctx.KEnc, "ctx.KEnc");
		byte[] data = response.Data;
		byte[] first = ctx.IncrementSSC();
		byte[] array = data.Skip(data.Length - 8).Take(8).ToArray();
		byte[] array2 = data.Take(data.Length - 14).ToArray();
		DataObject dataObject = new DataObject(153, new byte[2] { 144, 0 });
		byte[] inputBuffer = first.Concat(array2).Concat(dataObject.GetEncoded()).ToArray();
		byte[] array3 = CryptoDesHelper.ComputeMacTDes(inputBuffer, ctx.KMac);
		byte[] a = Array.Empty<byte>();
		if (((ReadOnlySpan<byte>)array3).SequenceEqual((ReadOnlySpan<byte>)array))
		{
			int num = ((array2.Length % 2 == 0) ? 4 : 3);
			byte[] inputBuffer2 = array2.Skip(num).Take(array2.Length - num).ToArray();
			a = CryptoDesHelper.TripleDesProvider(inputBuffer2, ctx.KEnc, encrypt: false);
			a = ByteHelper.RemovePadding(a);
		}
		return new ResponseApdu(Arrays.Concatenate(a, new byte[2]
		{
			(byte)response.SW1,
			(byte)response.SW2
		}));
	}
}
