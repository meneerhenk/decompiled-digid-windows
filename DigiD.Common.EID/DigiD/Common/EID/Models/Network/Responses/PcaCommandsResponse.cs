using System.Text.Json.Serialization;

namespace DigiD.Common.EID.Models.Network.Responses;

public class PcaCommandsResponse : EIDBaseResponse
{
	[JsonPropertyName("responseData")]
	public ResponseData? Data { get; set; }
}
