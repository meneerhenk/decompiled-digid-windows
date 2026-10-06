using System.Text.Json.Serialization;

namespace DigiD.Common.Models.RequestModels;

public class NotificationRegisterRequest : BaseRequest
{
	[JsonPropertyName("notification_id")]
	public required string NotificationToken { get; set; }

	[JsonPropertyName("receive_notifications")]
	public required bool Enabled { get; set; }
}
