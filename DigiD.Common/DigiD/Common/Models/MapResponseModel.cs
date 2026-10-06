using System.Text.Json.Serialization;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models;

public class MapResponseModel : BaseResponse
{
	[JsonPropertyName("keyAgree")]
	public byte[] KeyAgree { get; set; } = null;
}
