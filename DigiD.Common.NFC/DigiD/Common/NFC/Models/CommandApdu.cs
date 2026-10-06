using System;
using System.IO;
using DigiD.Common.NFC.Enums;

namespace DigiD.Common.NFC.Models;

public class CommandApdu
{
	private byte[]? _apdu;

	private int _nc;

	private int? _ne;

	private int _dataOffset;

	public bool IsSecureMessage { get; set; }

	public virtual CLA CLA => (CLA)(_apdu[0] & 0xFF);

	public virtual INS INS => (INS)(_apdu[1] & 0xFF);

	public virtual int P1 => _apdu[2] & 0xFF;

	public virtual int P2 => _apdu[3] & 0xFF;

	public virtual int Nc => _nc;

	public virtual byte[] Data
	{
		get
		{
			ArgumentNullException.ThrowIfNull(_apdu, "_apdu");
			byte[] array = new byte[_nc];
			Array.Copy(_apdu, _dataOffset, array, 0, _nc);
			return array;
		}
	}

	public virtual int? Ne => _ne;

	public virtual byte[] Bytes => (byte[])_apdu.Clone();

	private static void CheckArrayBounds(byte[]? b, int ofs, int len)
	{
		if (ofs < 0 || len < 0)
		{
			throw new ArgumentException("Offset and length must not be negative");
		}
		if (b == null)
		{
			if (ofs != 0 && len != 0)
			{
				throw new ArgumentException("offset and length must be 0 if array is null");
			}
		}
		else if (ofs > b.Length - len)
		{
			throw new ArgumentException("Offset plus length exceed array size");
		}
	}

	public CommandApdu(byte[]? apdu)
	{
		if (apdu != null)
		{
			_apdu = (byte[])apdu.Clone();
			Parse();
		}
	}

	public CommandApdu(byte[] apdu, int apduOffset, int apduLength)
	{
		CheckArrayBounds(apdu, apduOffset, apduLength);
		apdu = new byte[apduLength];
		Array.Copy(apdu, apduOffset, apdu, 0, apduLength);
		Parse();
	}

	internal CommandApdu(CLA cla, INS ins, int p1, int p2)
		: this(cla, ins, p1, p2, null, 0, 0, null)
	{
	}

	internal CommandApdu(CLA cla, INS ins, int p1, int p2, int? ne)
		: this(cla, ins, p1, p2, null, 0, 0, ne)
	{
	}

	internal CommandApdu(CLA cla, INS ins, int p1, int p2, byte[] data, int dataOffset, int dataLength)
		: this(cla, ins, p1, p2, data, dataOffset, dataLength, null)
	{
	}

	public CommandApdu(CLA cla, INS ins, int p1, int p2, byte[] data)
		: this(cla, ins, p1, p2, data, 0, ArrayLength(data), null)
	{
	}

	public CommandApdu(CLA cla, INS ins, int p1, int p2, byte[]? data, int? ne)
		: this(cla, ins, p1, p2, data, 0, ArrayLength(data), ne)
	{
	}

	internal CommandApdu(CLA cla, INS ins, int p1, int p2, byte[]? data, int dataOffset, int dataLength, int? ne)
	{
		CheckArrayBounds(data, dataOffset, dataLength);
		if (dataLength > 65535)
		{
			throw new ArgumentException("dataLength is too large");
		}
		if (ne < 0)
		{
			throw new ArgumentException("ne must not be negative");
		}
		if (ne > 65536)
		{
			throw new ArgumentException("ne is too large");
		}
		_ne = ne;
		_nc = dataLength;
		if (dataLength == 0)
		{
			if (ne == 0)
			{
				_apdu = new byte[4];
				SetHeader(cla, ins, p1, p2);
				return;
			}
			if (ne <= 256)
			{
				int value = ((ne != 256) ? ((byte)ne.Value) : 0);
				_apdu = new byte[5];
				SetHeader(cla, ins, p1, p2);
				_apdu[4] = Convert.ToByte(value);
				return;
			}
			byte b;
			byte b2;
			if (ne == 65536)
			{
				b = 0;
				b2 = 0;
			}
			else
			{
				b = (byte)(ne >> 8).Value;
				b2 = (byte)ne.Value;
			}
			_apdu = new byte[7];
			SetHeader(cla, ins, p1, p2);
			_apdu[5] = b;
			_apdu[6] = b2;
			return;
		}
		if (!ne.HasValue)
		{
			if (dataLength <= 255)
			{
				_apdu = new byte[5 + dataLength];
				SetHeader(cla, ins, p1, p2);
				_apdu[4] = (byte)dataLength;
				_dataOffset = 5;
				Array.Copy(data, dataOffset, _apdu, 5, dataLength);
			}
			else
			{
				_apdu = new byte[7 + dataLength];
				SetHeader(cla, ins, p1, p2);
				_apdu[4] = 0;
				_apdu[5] = (byte)(dataLength >> 8);
				_apdu[6] = (byte)dataLength;
				_dataOffset = 7;
				Array.Copy(data, dataOffset, _apdu, 7, dataLength);
			}
			return;
		}
		ArgumentNullException.ThrowIfNull(data, "data");
		if (dataLength <= 255 && ne <= 256)
		{
			_apdu = new byte[6 + dataLength];
			SetHeader(cla, ins, p1, p2);
			_apdu[4] = (byte)dataLength;
			_dataOffset = 5;
			Array.Copy(data, dataOffset, _apdu, 5, dataLength);
			_apdu[^1] = Convert.ToByte((ne != 256) ? ((byte)ne.Value) : 0);
			return;
		}
		_apdu = new byte[9 + dataLength];
		SetHeader(cla, ins, p1, p2);
		_apdu[4] = 0;
		_apdu[5] = (byte)(dataLength >> 8);
		_apdu[6] = (byte)dataLength;
		_dataOffset = 7;
		Array.Copy(data, dataOffset, _apdu, 7, dataLength);
		if (ne != 65536)
		{
			int num = _apdu.Length - 2;
			_apdu[num] = (byte)(ne >> 8).Value;
			_apdu[num + 1] = (byte)ne.Value;
		}
	}

	private static int ArrayLength(byte[]? b)
	{
		return (b != null) ? b.Length : 0;
	}

	private void Parse()
	{
		if (_apdu == null)
		{
			return;
		}
		if (_apdu.Length < 4)
		{
			throw new ArgumentException("apdu must be at least 4 bytes long");
		}
		if (_apdu.Length == 4)
		{
			return;
		}
		int num = _apdu[4] & 0xFF;
		if (_apdu.Length == 5)
		{
			_ne = ((num == 0) ? 256 : num);
			return;
		}
		if (num != 0)
		{
			if (_apdu.Length == 5 + num)
			{
				_nc = num;
				_dataOffset = 5;
				return;
			}
			if (_apdu.Length != 6 + num)
			{
				throw new ArgumentException("Invalid APDU: length=" + _apdu.Length + ", b1=" + num);
			}
			_nc = num;
			_dataOffset = 5;
			int num2 = _apdu[_apdu.Length - 1] & 0xFF;
			_ne = ((num2 == 0) ? 256 : num2);
			return;
		}
		if (_apdu.Length < 7)
		{
			throw new ArgumentException("Invalid APDU: length=" + _apdu.Length + ", b1=" + num);
		}
		int num3 = ((_apdu[5] & 0xFF) << 8) | (_apdu[6] & 0xFF);
		if (_apdu.Length == 7)
		{
			_ne = ((num3 == 0) ? 65536 : num3);
			return;
		}
		if (num3 == 0)
		{
			throw new ArgumentException("Invalid APDU: length=" + _apdu.Length + ", b1=" + num + ", b2||b3=" + num3);
		}
		if (_apdu.Length == 7 + num3)
		{
			_nc = num3;
			_dataOffset = 7;
			return;
		}
		if (_apdu.Length == 9 + num3)
		{
			_nc = num3;
			_dataOffset = 7;
			int num4 = _apdu.Length - 2;
			int num5 = ((_apdu[num4] & 0xFF) << 8) | (_apdu[num4 + 1] & 0xFF);
			_ne = ((num5 == 0) ? 65536 : num5);
			return;
		}
		throw new ArgumentException("Invalid APDU: length=" + _apdu.Length + ", b1=" + num + ", b2||b3=" + num3);
	}

	private void SetHeader(CLA cla, INS ins, int p1, int p2)
	{
		ArgumentNullException.ThrowIfNull(_apdu, "_apdu");
		_apdu[0] = (byte)cla;
		_apdu[1] = (byte)ins;
		_apdu[2] = (byte)p1;
		_apdu[3] = (byte)p2;
	}

	public override string ToString()
	{
		string[] obj = new string[6]
		{
			"CommmandAPDU: ",
			_apdu.Length.ToString(),
			" bytes, nc=",
			_nc.ToString(),
			", ne=",
			null
		};
		int? ne = _ne;
		obj[5] = ne.ToString();
		return string.Concat(obj);
	}

	public void AppendLe()
	{
		using MemoryStream memoryStream = new MemoryStream();
		int num = 1;
		byte[] bytes = Bytes;
		if (bytes[4] == 0)
		{
			num = 2;
		}
		using BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(bytes);
		for (int i = 0; i < num; i++)
		{
			binaryWriter.Write(new byte[1]);
		}
		_apdu = memoryStream.ToArray();
	}
}
