using System.Text.Json.Serialization;

namespace DigiD.Common.Models.RequestModels;

public class NotificationUpdateRequest : BaseRequest
{
	[JsonPropertyName("notification_id")]
	public required string NotificationToken { get; set; }

	[JsonPropertyName("instance_id")]
	public required string InstanceId { get; set; }

	[JsonPropertyName("user_app_id")]
	public required string UserAppId { get; set; }
}
