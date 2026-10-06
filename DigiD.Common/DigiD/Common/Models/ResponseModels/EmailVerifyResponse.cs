using System.Text.Json.Serialization;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.ResponseModels;

public class EmailVerifyResponse : BaseResponse
{
	[JsonPropertyName("remaining_attempts")]
	public int RemainingAttempts { get; set; }
}
