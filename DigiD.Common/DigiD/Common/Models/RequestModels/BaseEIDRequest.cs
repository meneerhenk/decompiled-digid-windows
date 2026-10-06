using System.Text.Json.Serialization;

namespace DigiD.Common.Models.RequestModels;

public class BaseEIDRequest : BaseRequest
{
	[JsonPropertyName("auth_session_id")]
	public new static string? AuthenticationSessionId => null;
}
