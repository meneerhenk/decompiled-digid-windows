using System.Collections.Generic;

namespace DigiD.Common.Settings;

public class SslPinningSettings
{
	public List<string> Exclusions { get; set; } = new List<string>();

	public byte[]? PinningKey { get; set; }
}
