using System.Text.Json.Serialization;
using DigiD.Common.SessionModels;

namespace DigiD.Common.Models.RequestModels;

public class BaseMyDigiDRequest : BaseRequest
{
	[JsonPropertyName("mijn_digid_session_id")]
	public string? SessionId => HttpSession.AuthenticationSessionId;

	[JsonPropertyName("auth_session_id")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public new string? AuthenticationSessionId => null;
}
