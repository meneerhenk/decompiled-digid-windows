using System.Text.Json.Serialization;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.ResponseModels;

public class WidPollResponse : BaseResponse
{
	[JsonPropertyName("attest_app")]
	public bool AttestApp { get; set; }
}
