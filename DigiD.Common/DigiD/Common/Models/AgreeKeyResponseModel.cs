using System.Text.Json.Serialization;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models;

public class AgreeKeyResponseModel : BaseResponse
{
	[JsonPropertyName("token")]
	public byte[] Token { get; set; } = null;
}
