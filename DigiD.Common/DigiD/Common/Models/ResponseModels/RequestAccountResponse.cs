using System.Text.Json.Serialization;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.ResponseModels;

public class RequestAccountResponse : BaseResponse
{
	[JsonPropertyName("delay")]
	public int Delay { get; set; }

	[JsonPropertyName("app_session_id")]
	public string? AppSessionId { get; set; }
}
