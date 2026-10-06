using System.Collections.Generic;

namespace DigiD.Common.Models;

public class QrScanResult
{
	public required string Identifier { get; set; }

	public Dictionary<string, string> Properties { get; set; } = new Dictionary<string, string>();
}
