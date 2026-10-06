using System.Text.Json.Serialization;

namespace DigiD.Common.Models.RequestModels;

public class SessionRequest : BaseRequest
{
	[JsonPropertyName("instance_id")]
	public required string InstanceId { get; set; }
}
