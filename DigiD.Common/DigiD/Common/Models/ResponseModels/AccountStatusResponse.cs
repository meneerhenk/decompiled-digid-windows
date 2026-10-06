using System.Text.Json.Serialization;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.ResponseModels;

public class AccountStatusResponse : BaseResponse
{
	[JsonPropertyName("unread_notification_count")]
	public int UnreadMessagesCount { get; set; }

	[JsonIgnore]
	public bool HasUnreadMessages => UnreadMessagesCount > 0;
}
