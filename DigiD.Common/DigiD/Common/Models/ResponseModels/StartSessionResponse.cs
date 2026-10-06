using System.Text.Json.Serialization;

namespace DigiD.Common.Models.ResponseModels;

public class StartSessionResponse : StartSessionBaseResponse
{
	[JsonPropertyName("koppelcode")]
	public string VerificationCode { get; set; } = null;
}
