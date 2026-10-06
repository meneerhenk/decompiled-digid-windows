using System;
using System.Text.Json.Serialization;
using DigiD.Common.Converters.Json;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.ResponseModels;

public class WebSessionInfoResponse : AuthenticationSessionResponse
{
	[JsonPropertyName("authentication_level")]
	[JsonConverter(typeof(LoginLevelConverter))]
	public LoginLevel AuthenticationLevel { get; set; }

	[JsonPropertyName("hashed_pip")]
	public string? HashedPIP { get; set; }

	[JsonPropertyName("new_authentication_level")]
	[JsonConverter(typeof(LoginLevelConverter))]
	public LoginLevel NewAuthenticationLevel { get; set; }

	[JsonPropertyName("new_level_start_date")]
	public DateTimeOffset? NewAuthenticationLevelStartDate { get; set; }

	[JsonPropertyName("icon_uri")]
	public string? IconUri { get; set; }

	[JsonPropertyName("oidc_session")]
	public bool IsOidcSession { get; set; }

	public bool IsWebservice => !string.IsNullOrEmpty(base.WebService);

	public bool IsConfirmAction => !string.IsNullOrEmpty(base.Action);
}
