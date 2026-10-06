using System.Text.Json.Serialization;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.ResponseModels;

public class EmailRegisterResponse : BaseResponse
{
	[JsonPropertyName("email_address")]
	public string? EmailAddress { get; set; }

	[JsonPropertyName("max_amount_emails")]
	public int MaxCount { get; set; }
}
