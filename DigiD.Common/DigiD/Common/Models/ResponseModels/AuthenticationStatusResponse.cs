using System.Text.Json.Serialization;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.ResponseModels;

public class AuthenticationStatusResponse : BaseResponse
{
	[JsonPropertyName("session_received")]
	public bool SessionReceived { get; set; }
}
