using System.Text.Json.Serialization;
using DigiD.Common.Converters.Json;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.ResponseModels;

public class CompleteChallengeResponse : BaseResponse
{
	[JsonPropertyName("symmetric_key")]
	[JsonConverter(typeof(Base16Converter))]
	public byte[] SymmetricKey { get; set; } = null;

	[JsonPropertyName("iv")]
	[JsonConverter(typeof(Base16Converter))]
	public byte[]? IV { get; set; }
}
