using System.Text.Json.Serialization;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.ResponseModels;

public class ActivationResponse : BaseResponse
{
	[JsonPropertyName("max_amount")]
	public int MaxAmount { get; set; }

	[JsonPropertyName("device_name")]
	public string? DeviceName { get; set; }

	[JsonPropertyName("latest_date")]
	public string? LastUsed { get; set; }
}
