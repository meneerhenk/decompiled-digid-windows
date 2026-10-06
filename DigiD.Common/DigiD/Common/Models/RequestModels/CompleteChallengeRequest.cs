using System.Text.Json.Serialization;
using DigiD.Common.Converters.Json;

namespace DigiD.Common.Models.RequestModels;

public class CompleteChallengeRequest : BaseRequest
{
	[JsonPropertyName("signed_challenge")]
	[JsonConverter(typeof(Base16Converter))]
	public byte[]? Signature { get; set; }

	[JsonPropertyName("app_public_key")]
	[JsonConverter(typeof(Base16Converter))]
	public byte[]? PublicKey { get; set; }

	[JsonPropertyName("hardware_support")]
	public bool HardwareSupport { get; set; }

	[JsonPropertyName("nfc_support")]
	public bool? NFCSupport { get; set; }

	[JsonPropertyName("ka_data")]
	public KeyAttestationRequestModel? KeyAttestation { get; set; }
}
