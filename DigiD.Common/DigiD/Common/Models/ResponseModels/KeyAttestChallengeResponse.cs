using System.Text.Json.Serialization;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.ResponseModels;

public class KeyAttestChallengeResponse : BaseResponse
{
	[JsonPropertyName("challenge")]
	public string Challenge { get; set; } = null;

	[JsonPropertyName("app_session_id")]
	public string SessionId { get; set; } = null;
}
