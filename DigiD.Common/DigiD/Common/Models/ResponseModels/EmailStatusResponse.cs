using System.Text.Json.Serialization;
using DigiD.Common.Converters.Json;
using DigiD.Common.Enums;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.ResponseModels;

public class EmailStatusResponse : BaseResponse
{
	[JsonPropertyName("email_status")]
	[JsonConverter(typeof(EmailStatusConverter))]
	public EmailStatus EmailStatus { get; set; }

	[JsonPropertyName("current_email_address")]
	public string? EmailAddress { get; set; }

	[JsonPropertyName("no_verified_email_address")]
	public string? NoVerifiedEmailAddress { get; set; }

	[JsonPropertyName("user_action_needed")]
	public bool UserActionNeeded { get; set; }
}
