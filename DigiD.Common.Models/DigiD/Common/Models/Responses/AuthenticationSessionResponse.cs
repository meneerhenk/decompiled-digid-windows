using System;
using System.Text.Json.Serialization;

namespace DigiD.Common.Models.Responses;

public class AuthenticationSessionResponse : BaseResponse
{
	[JsonPropertyName("webservice")]
	public string? WebService { get; set; }

	[JsonPropertyName("action")]
	public string? Action { get; set; }

	[JsonPropertyName("return_url")]
	public string ReturnURL { get; set; } = string.Empty;

	[JsonPropertyName("device_name")]
	public string? DeviceName { get; set; }

	[JsonPropertyName("last_sign_in_at")]
	public DateTimeOffset? LastSignInDate { get; set; }

	[JsonPropertyName("app_to_destroy_id")]
	public string? AppIdToDestroy { get; set; }
}
