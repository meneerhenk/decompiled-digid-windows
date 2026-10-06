using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DigiD.Common.EID.Models.Network.Responses;

public class TerminalAuthenticationCommandResponsesData
{
	[JsonPropertyName("apdus")]
	public List<string> Commands { get; set; } = new List<string>();

	[JsonPropertyName("ephemeralPKey")]
	public string? EphemeralKey { get; set; }
}
