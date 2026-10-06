using System.Text.Json.Serialization;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.ResponseModels;

public class ConfigResponse : BaseResponse
{
	[JsonPropertyName("digid_rda_enabled")]
	public bool RDAEnabled { get; set; } = true;

	[JsonPropertyName("letter_request_delay")]
	public int LetterRequestDelay { get; set; } = 3;

	[JsonPropertyName("max_pin_change_per_day")]
	public int MaxPinChangePerDay { get; set; } = 1;

	[JsonPropertyName("eha_enabled")]
	public bool EHAEnabled { get; set; }
}
