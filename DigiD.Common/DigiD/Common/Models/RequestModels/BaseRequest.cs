using System.Text.Json.Serialization;
using DigiD.Common.SessionModels;

namespace DigiD.Common.Models.RequestModels;

public class BaseRequest
{
	[JsonPropertyName("auth_session_id")]
	public string? AuthenticationSessionId { get; protected set; } = HttpSession.AuthenticationSessionId;

	[JsonPropertyName("app_session_id")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public string? AppSessionId { get; } = HttpSession.AppSessionId;
}
