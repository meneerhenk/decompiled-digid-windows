using System.Text.Json.Serialization;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.EID.Models.Network.Responses;

public class EIDBaseResponse : BaseResponse
{
	[JsonPropertyName("sessionId")]
	public string? SessionId { get; set; }
}
