using System.Text.Json.Serialization;
using DigiD.Common.Converters.Json;
using DigiD.Common.Models.Enums;

namespace DigiD.Common.Models.ResponseModels;

public class BasicAuthenticationResponse : ActivationResponse
{
	[JsonPropertyName("app_session_id")]
	public string? SessionId { get; set; }

	[JsonPropertyName("activation_method")]
	[JsonConverter(typeof(ActivationMethodConverter))]
	public ActivationMethod ActivationMethod { get; set; }

	[JsonPropertyName("app_authenticator_pending")]
	public bool PendingActivation { get; set; }

	[JsonPropertyName("sms_check_requested")]
	public bool IsSmsCheckRequested { get; set; }
}
