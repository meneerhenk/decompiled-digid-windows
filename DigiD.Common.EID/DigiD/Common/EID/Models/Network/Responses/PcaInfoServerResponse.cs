using System.Text.Json.Serialization;

namespace DigiD.Common.EID.Models.Network.Responses;

public class PcaInfoServerResponse : EIDBaseResponse
{
	[JsonPropertyName("responseData")]
	public InfoResponseData InfoResponse { get; set; } = null;
}
