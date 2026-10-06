using System.Text.Json.Serialization;

namespace DigiD.Common.Models.Responses;

public class InitSessionResponse : BaseResponse
{
	[JsonPropertyName("app_session_id")]
	public string? SessionId { get; set; }
}
