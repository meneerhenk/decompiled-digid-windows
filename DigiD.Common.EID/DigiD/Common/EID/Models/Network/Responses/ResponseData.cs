using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DigiD.Common.EID.Models.Network.Responses;

public class ResponseData
{
	[JsonPropertyName("apdus")]
	public List<string> APDUCommandos { get; set; } = new List<string>();
}
