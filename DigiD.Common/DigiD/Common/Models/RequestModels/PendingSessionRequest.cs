using System.Text.Json.Serialization;

namespace DigiD.Common.Models.RequestModels;

public class PendingSessionRequest : BaseRequest
{
	[JsonPropertyName("user_app_id")]
	public required string AppId { get; set; }
}
