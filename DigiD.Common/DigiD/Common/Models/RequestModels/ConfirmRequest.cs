using System.Text.Json.Serialization;
using DigiD.Common.Converters.Json;

namespace DigiD.Common.Models.RequestModels;

public class ConfirmRequest : BaseRequest
{
	[JsonPropertyName("user_app_id")]
	public required string AppId { get; set; }

	[JsonPropertyName("signature_of_pip")]
	[JsonConverter(typeof(Base16Converter))]
	public byte[]? SignatureOfPIP { get; set; }
}
