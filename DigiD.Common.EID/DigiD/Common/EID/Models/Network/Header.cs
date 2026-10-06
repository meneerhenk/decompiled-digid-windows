using System.Text.Json.Serialization;

namespace DigiD.Common.EID.Models.Network;

public class Header
{
	[JsonPropertyName("sessionId")]
	public required string SessionId { get; set; }

	[JsonPropertyName("supportedAPIVersion")]
	public required SupportedApiVersion SupportedAPIVersion { get; set; }
}
