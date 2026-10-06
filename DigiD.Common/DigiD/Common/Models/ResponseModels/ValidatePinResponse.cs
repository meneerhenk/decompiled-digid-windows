using System;
using System.Text.Json.Serialization;
using DigiD.Common.Converters.Json;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.ResponseModels;

public class ValidatePinResponse : BaseResponse
{
	[JsonPropertyName("remaining_attempts")]
	public int RemainingAttempts { get; set; }

	[JsonPropertyName("authentication_level")]
	[JsonConverter(typeof(LoginLevelConverter))]
	public LoginLevel AuthenticationLevel { get; set; }

	[JsonPropertyName("deceased")]
	public bool IsDeceased { get; set; }

	[JsonPropertyName("id_check_expired_date")]
	public DateTime? SubExpiryDate { get; set; }
}
