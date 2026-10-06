using System.Text.Json.Serialization;
using DigiD.Common.Converters.Json;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.ResponseModels;

public class VersionCheckResponse : BaseResponse
{
	[JsonPropertyName("action")]
	[JsonConverter(typeof(VersionStateConverter))]
	public VersionState VersionAction { get; set; }

	[JsonPropertyName("update_url")]
	public string? UpdateUrl { get; set; }
}
