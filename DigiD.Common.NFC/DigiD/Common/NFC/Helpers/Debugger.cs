using System;
using System.Text;
using DigiD.Common.Models.Helpers;
using DigiD.Common.NFC.Models;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace DigiD.Common.NFC.Helpers;

public class Debugger
{
	protected Debugger()
	{
	}

	public static void WriteLine(string line)
	{
	}

	public static void DumpInfo(Exception ex)
	{
	}

	public static void DumpInfo(string header, CommandApdu command)
	{
		ArgumentNullException.ThrowIfNull(command, "command");
		if (command.IsSecureMessage)
		{
			WriteLine("SM: ");
		}
		WriteLine("++++ START " + header);
		WriteLine($"CLA: {command.CLA:X2}");
		WriteLine($"INS: {command.INS:X2}");
		WriteLine($"P1: {command.P1:X2}");
		WriteLine($"P2: {command.P2:X2}");
		WriteLine($"Nc: {command.Nc:X2}");
		WriteLine(command.Ne.HasValue ? $"Ne: {command.Ne:X2}" : "Ne: NULL");
		WriteLine("---------------");
		WriteLine("Data: " + command.Data.ToHexString());
		WriteLine("Bytes: " + command.Bytes.ToHexString());
	}

	public static void DumpInfo(string header, ResponseApdu response)
	{
		ArgumentNullException.ThrowIfNull(response, "response");
		DumpBytes("++++ RESPONSE " + header, response.Bytes);
		WriteLine("");
		WriteLine($"SW1: {response.SW1:X2}");
		WriteLine($"SW2: {response.SW2:X2}");
		WriteLine($"Nr: {response.Nr:X2}");
		WriteLine("");
		WriteLine("++++ END " + header);
		WriteLine("############################");
	}

	public static void DumpInfo(string title, byte[]? bytes)
	{
		if (bytes == null)
		{
			WriteLine(title + " (0)");
			return;
		}
		using Asn1InputStream asn1InputStream = new Asn1InputStream(bytes);
		WriteLine("File: " + title);
		WriteLine(Asn1Dump.DumpAsString(asn1InputStream.ReadObject()));
	}

	private static void DumpBytes(string title, byte[]? buffer)
	{
		WriteLine((buffer == null) ? (title + " (0)") : $"{title} ({buffer.Length})");
		DumpBytes(buffer);
	}

	private static void DumpBytes(byte[]? buffer)
	{
		if (buffer == null)
		{
			return;
		}
		StringBuilder stringBuilder = new StringBuilder(16);
		for (int i = 0; i < buffer.Length; i += 16)
		{
			StringBuilder stringBuilder2 = new StringBuilder();
			StringBuilder stringBuilder3 = stringBuilder2;
			StringBuilder stringBuilder4 = stringBuilder3;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(3, 1, stringBuilder3);
			handler.AppendFormatted(Hex.ToHexString(new byte[2]
			{
				(byte)(i / 256),
				(byte)i
			}));
			handler.AppendLiteral("   ");
			stringBuilder4.Append(ref handler);
			for (int j = 0; j < 16; j++)
			{
				if (j + i < buffer.Length)
				{
					stringBuilder3 = stringBuilder2;
					StringBuilder stringBuilder5 = stringBuilder3;
					handler = new StringBuilder.AppendInterpolatedStringHandler(1, 1, stringBuilder3);
					handler.AppendFormatted(new byte[1] { buffer[j + i] }.ToHexString());
					handler.AppendLiteral(" ");
					stringBuilder5.Append(ref handler);
				}
				else
				{
					stringBuilder2.Append("   ");
					stringBuilder.Append(' ');
				}
			}
			WriteLine(stringBuilder2?.ToString() + "  " + stringBuilder);
			stringBuilder.Clear();
		}
	}
}
