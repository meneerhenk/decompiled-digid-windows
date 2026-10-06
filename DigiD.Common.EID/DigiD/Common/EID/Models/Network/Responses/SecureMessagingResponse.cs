using System;
using System.Text.Json.Serialization;

namespace DigiD.Common.EID.Models.Network.Responses;

public class SecureMessagingResponse
{
	[JsonPropertyName("apdus")]
	public string[] Commands { get; set; } = Array.Empty<string>();
}
