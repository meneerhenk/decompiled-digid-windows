using System.Text.Json.Serialization;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.ResponseModels;

public class StartSessionBaseResponse : BaseResponse
{
	[JsonPropertyName("app_session_id")]
	public string AppSessionId { get; set; } = null;

	[JsonPropertyName("at")]
	public int At { get; set; }
}
