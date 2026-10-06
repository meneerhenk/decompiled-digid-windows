using System.Text.Json.Serialization;
using DigiD.Common.Converters.Json;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.ResponseModels;

public class ChallengeResponse : BaseResponse
{
	[JsonPropertyName("challenge")]
	public string? Challenge { get; set; }

	[JsonPropertyName("iv")]
	[JsonConverter(typeof(Base16Converter))]
	public byte[]? IV { get; set; }
}
