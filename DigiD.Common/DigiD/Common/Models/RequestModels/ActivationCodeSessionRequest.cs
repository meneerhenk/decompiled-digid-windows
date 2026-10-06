using System.Text.Json.Serialization;

namespace DigiD.Common.Models.RequestModels;

public class ActivationCodeSessionRequest : BaseAuthSessionRequest
{
	[JsonPropertyName("re_request_letter")]
	public bool RequestNewLetter { get; set; }
}
