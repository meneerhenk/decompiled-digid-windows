using System.Text.Json.Serialization;

namespace DigiD.Common.Models.RequestModels;

public class MessageCenterRequest : BaseMyDigiDRequest
{
	[JsonPropertyName("language")]
	public required string Language { get; set; }
}
