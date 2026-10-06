using System.Text.Json.Serialization;

namespace DigiD.Common.Models.ResponseModels;

public class SessionResponse : ActivationResponse
{
	[JsonPropertyName("user_app_id")]
	public string? AppId { get; set; }

	[JsonPropertyName("koppelcode")]
	public string? VerificationToken { get; set; }
}
