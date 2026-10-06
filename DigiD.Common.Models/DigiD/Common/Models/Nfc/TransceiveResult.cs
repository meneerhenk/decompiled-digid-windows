using System;

namespace DigiD.Common.Models.Nfc;

public class TransceiveResult
{
	public byte[] Data { get; set; } = Array.Empty<byte>();

	public Exception? Exception { get; set; }

	public bool Success => Exception == null;

	public bool IsCardLost => Exception is CardLostException;
}
