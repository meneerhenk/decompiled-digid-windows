using System.Text.Json.Serialization;

namespace DigiD.Common.Models.RequestModels;

public class EmailRegisterRequest : BaseMyDigiDRequest
{
	[JsonPropertyName("email_address")]
	public string? EmailAddress { get; set; }
}
