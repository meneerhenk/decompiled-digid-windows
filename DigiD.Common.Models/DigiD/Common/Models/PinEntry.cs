using System.Linq;

namespace DigiD.Common.Models;

public class PinEntry
{
	public string[] HostNames { get; }

	public byte[][] Pins { get; }

	public PinEntry(string[] hostNames, byte[] pin)
		: this(hostNames, new byte[1][] { pin })
	{
	}

	public PinEntry(string hostName, byte[] pin)
		: this(new string[1] { hostName }, new byte[1][] { pin })
	{
	}

	public PinEntry(string hostName, byte[][] pins)
		: this(new string[1] { hostName }, pins)
	{
	}

	public PinEntry(string[] hostNames, byte[][] pins)
	{
		HostNames = hostNames.Select((string hostName) => hostName).ToArray();
		Pins = pins;
	}
}
