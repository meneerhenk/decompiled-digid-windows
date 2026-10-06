using System.Text.Json.Serialization;

namespace DigiD.Common.EID.Models.Network.Responses;

public class PcaChallengeResponse : EIDBaseResponse
{
	[JsonPropertyName("responseData")]
	public ChallengeResponseData? ChallengeResponse { get; set; }
}
