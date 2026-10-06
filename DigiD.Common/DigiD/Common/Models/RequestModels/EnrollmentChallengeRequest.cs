using System.Text.Json.Serialization;
using DigiD.Common.Converters.Json;

namespace DigiD.Common.Models.RequestModels;

public class EnrollmentChallengeRequest : BaseRequest
{
	[JsonPropertyName("user_app_id")]
	public required string AppId { get; set; }

	[JsonPropertyName("app_public_key")]
	[JsonConverter(typeof(Base16Converter))]
	public required byte[] PublicKey { get; set; }
}
