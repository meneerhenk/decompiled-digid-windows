using System.Text.Json.Serialization;

namespace DigiD.Common.EID.Models.Network.Responses;

public class SendSecureCommandsResponse : EIDBaseResponse
{
	[JsonPropertyName("responseData")]
	public SendCommandsResult? Data { get; set; }
}
