using System.Text.Json.Serialization;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.ResponseModels;

public class EnrollmentChallengeResponse : BaseResponse
{
	[JsonPropertyName("challenge")]
	public string Challenge { get; set; } = null;
}
