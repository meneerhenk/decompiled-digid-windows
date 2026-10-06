using System.Collections.Generic;
using System.Text.Json.Serialization;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.ResponseModels;

public class MessageCenterResponse : BaseResponse
{
	[JsonPropertyName("notifications")]
	public List<MessageModel> Messages { get; set; } = new List<MessageModel>();
}
