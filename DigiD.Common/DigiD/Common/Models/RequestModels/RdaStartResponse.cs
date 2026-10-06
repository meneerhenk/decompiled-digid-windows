using System.Text.Json.Serialization;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.RequestModels;

public class RdaStartResponse : BaseResponse
{
	[JsonPropertyName("challenge")]
	public string Challenge { get; set; } = null;

	[JsonPropertyName("pace")]
	public byte[] Pace { get; set; } = null;

	[JsonPropertyName("nonce")]
	public byte[] Nonce { get; set; } = null;

	[JsonPropertyName("select")]
	public byte[] Select { get; set; } = null;
}
