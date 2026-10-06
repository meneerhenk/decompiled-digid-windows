using System.Collections.Generic;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.ResponseModels;

public class MessageCenterResponseModel : BaseResponse
{
	public List<MessageModel> Messages { get; set; } = new List<MessageModel>();
}
