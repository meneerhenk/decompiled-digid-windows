using System.Text.Json.Serialization;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.RequestModels;

public class SelectResponse : BaseResponse
{
	[JsonPropertyName("authenticate")]
	public string Authenticate { get; set; } = null;
}
