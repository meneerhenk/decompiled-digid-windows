using System.Text.Json.Serialization;

namespace DigiD.Common.Models.ResponseModels;

public class PendingSessionResponse : WebSessionInfoResponse
{
	[JsonPropertyName("app_session_id")]
	public string? SessionId { get; set; }
}
