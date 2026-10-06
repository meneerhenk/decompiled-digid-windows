using System;
using System.Text.Json.Serialization;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.ResponseModels;

public class ActivationLetterResponse : BaseResponse
{
	[JsonPropertyName("remaining_attempts")]
	public int RemainingAttempts { get; set; }

	[JsonPropertyName("date_letter_sent")]
	public DateTime? DateLetterSent { get; set; }
}
