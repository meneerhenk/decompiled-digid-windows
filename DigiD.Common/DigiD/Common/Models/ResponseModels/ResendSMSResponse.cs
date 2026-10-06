using System.Text.Json.Serialization;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.ResponseModels;

public class ResendSMSResponse : BaseResponse
{
	[JsonPropertyName("phonenumber")]
	public string? PhoneNumber { get; set; }
}
