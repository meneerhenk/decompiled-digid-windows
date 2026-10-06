using System.Text.Json.Serialization;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models;

public class PrepareResponseModel : BaseResponse
{
	[JsonPropertyName("mappedNonce")]
	public byte[] MappedNonce { get; set; } = null;
}
