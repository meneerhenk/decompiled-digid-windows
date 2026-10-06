using System.Text.Json.Serialization;
using DigiD.Common.Models.RequestModels;

namespace DigiD.Common.Models;

public class MutualAuthResponseModel : CommandResponse
{
	[JsonPropertyName("mappedNonce")]
	public byte[] MappedNonce { get; set; } = null;
}
