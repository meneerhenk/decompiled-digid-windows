using System.Collections.Generic;
using System.Text.Json.Serialization;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.ResponseModels;

public class InitApp2AppResponse : BaseResponse
{
	[JsonPropertyName("app_session_id")]
	public string WebSessionId { get; set; } = null;

	[JsonPropertyName("authentication_level")]
	public int AuthenticationLevel { get; set; }

	[JsonPropertyName("image_domain")]
	public string? ImagedDomain { get; set; }

	[JsonPropertyName("apps")]
	public List<App> Apps { get; set; } = new List<App>();

	public string? SAMLart { get; set; }

	public string? RelayState { get; set; }
}
