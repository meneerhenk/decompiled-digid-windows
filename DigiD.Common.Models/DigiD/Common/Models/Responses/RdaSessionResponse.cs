using System.Text.Json.Serialization;

namespace DigiD.Common.Models.Responses;

public class RdaSessionResponse : BaseResponse
{
	[JsonPropertyName("session_id")]
	public string SessionId { get; set; } = string.Empty;

	[JsonPropertyName("url")]
	public string? Url { get; set; }
}
