using System.Text.Json.Serialization;

namespace DigiD.Common.Models.RequestModels;

public class EmailVerifyRequest : BaseMyDigiDRequest
{
	[JsonPropertyName("verification_code")]
	public required string Code { get; set; }
}
