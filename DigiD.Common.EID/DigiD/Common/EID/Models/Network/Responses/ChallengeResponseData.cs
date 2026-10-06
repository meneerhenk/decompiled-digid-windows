using System.Text.Json.Serialization;

namespace DigiD.Common.EID.Models.Network.Responses;

public class ChallengeResponseData
{
	[JsonPropertyName("signature")]
	public string? Signature { get; set; }
}
