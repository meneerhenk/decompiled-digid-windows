using System.Text.Json.Serialization;

namespace DigiD.Common.EID.Models.Network;

public class SupportedApiVersion
{
	[JsonPropertyName("major")]
	public string? Major { get; set; }

	[JsonPropertyName("minor")]
	public string? Minor { get; set; }
}
