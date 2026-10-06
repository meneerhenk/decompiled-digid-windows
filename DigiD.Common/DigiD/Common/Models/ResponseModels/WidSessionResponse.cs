using System.Text.Json.Serialization;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.ResponseModels;

public class WidSessionResponse : AuthenticationSessionResponse
{
	[JsonPropertyName("url")]
	public string? Host { get; set; }

	[JsonPropertyName("session_id")]
	public string? SessionId { get; set; }
}
