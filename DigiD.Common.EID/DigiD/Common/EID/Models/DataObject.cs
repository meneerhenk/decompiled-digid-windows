using System;
using System.Globalization;
using System.IO;
using DigiD.Common.Models.Helpers;
using Greensoft.TlvLib;

namespace DigiD.Common.EID.Models;

public class DataObject
{
	public uint Tag { get; set; }

	public byte[]? Value { get; set; }

	public byte[] Length => (Value != null) ? Value.Length.ToString("X2", CultureInfo.InvariantCulture).ToBytes() : new byte[1];

	public DataObject[] Children { get; set; } = Array.Empty<DataObject>();

	public string HexTag => BitConverter.GetBytes(Tag).ToHexString();

	public string HexValue => Value.ToHexString();

	public string HexLength => Length.ToHexString();

	public DataObject(byte tag, DataObject data)
	{
		ArgumentNullException.ThrowIfNull(data, "data");
		Tag = tag;
		Value = data.GetEncoded();
	}

	public DataObject(int tag, byte[]? data)
	{
		Tag = (uint)tag;
		Value = data;
	}

	public byte[] GetEncoded()
	{
		MemoryStream memoryStream = new MemoryStream();
		TlvEncoding.WriteTlv(memoryStream, Tag, Value);
		return memoryStream.ToArray();
	}
}
