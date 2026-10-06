using System.Text.Json.Serialization;
using DigiD.Common.Converters.Json;

namespace DigiD.Common.Models.RequestModels;

public class ValidatePinRequest : BaseRequest
{
	[JsonPropertyName("user_app_id")]
	public string AppId { get; }

	[JsonPropertyName("app_public_key")]
	[JsonConverter(typeof(Base16Converter))]
	public byte[]? PublicKey { get; set; }

	[JsonPropertyName("signed_challenge")]
	[JsonConverter(typeof(Base16Converter))]
	public byte[]? Signature { get; set; }

	[JsonPropertyName("masked_pincode")]
	public string PIN { get; }

	[JsonPropertyName("ka_data")]
	public KeyAttestationRequestModel? KeyAttestation { get; set; }

	public ValidatePinRequest(string sessionId, string appId, string pin)
	{
		base.AuthenticationSessionId = sessionId;
		AppId = appId;
		PIN = pin;
	}
}
