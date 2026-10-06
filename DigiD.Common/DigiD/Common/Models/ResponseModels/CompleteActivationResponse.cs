using System.Text.Json.Serialization;
using DigiD.Common.Converters.Json;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.ResponseModels;

public class CompleteActivationResponse : BaseResponse
{
	[JsonPropertyName("authentication_level")]
	[JsonConverter(typeof(LoginLevelConverter))]
	public LoginLevel AuthenticationLevel { get; set; }
}
