using System.Text.Json.Serialization;

namespace DigiD.Common.EID.Models.Network.Responses;

public class SendCommandsResult
{
	[JsonPropertyName("result")]
	public string? Result { get; set; }
}
