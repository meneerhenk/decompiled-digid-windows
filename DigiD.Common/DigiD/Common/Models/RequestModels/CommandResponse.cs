using System.Collections.Generic;
using System.Text.Json.Serialization;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.RequestModels;

public class CommandResponse : BaseResponse
{
	[JsonPropertyName("authenticate")]
	public string Authenticate { get; set; } = null;

	[JsonPropertyName("commands")]
	public List<byte[]> Commands { get; set; } = new List<byte[]>();
}
