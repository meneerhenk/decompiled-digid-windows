using System.Threading.Tasks;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Interfaces;

public interface IRemoteNotificationsApi
{
	Task<BaseResponse> RegisterNotificationToken(string token, bool enabled);

	Task<BaseResponse> UpdateNotificationToken(string token);

	Task<MessageCenterResponse> GetMessages();
}
