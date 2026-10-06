using System.Net.Http;
using System.Threading.Tasks;
using DigiD.Common.Http;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Models.Responses;
using DigiD.Common.Settings;
using Microsoft.Extensions.Logging;

namespace DigiD.Mobile.Api;

public class RemoteNotificationsApi : BaseApiService, IRemoteNotificationsApi
{
	private readonly IGeneralPreferences _prefs;

	public RemoteNotificationsApi(ILogger<RemoteNotificationsApi> logger, IGeneralPreferences preferences, IMobileSettings mobileSettings, IHttpClientFactory factory)
	{
		_003CmobileSettings_003EP = mobileSettings;
		_prefs = preferences;
		base._002Ector(logger, preferences, factory);
	}

	public async Task<BaseResponse> RegisterNotificationToken(string token, bool enabled)
	{
		if (string.IsNullOrEmpty(token) && enabled)
		{
			return new BaseResponse
			{
				ApiResult = ApiResult.Nok
			};
		}
		return await PostAsync<BaseResponse>("apps/notifications/register", new NotificationRegisterRequest
		{
			NotificationToken = token,
			Enabled = enabled
		});
	}

	public async Task<BaseResponse> UpdateNotificationToken(string token)
	{
		if (string.IsNullOrEmpty(token))
		{
			return new BaseResponse
			{
				ApiResult = ApiResult.Nok
			};
		}
		return await PostAsync<BaseResponse>("apps/notifications/update", new NotificationUpdateRequest
		{
			NotificationToken = token,
			InstanceId = _prefs.InstanceId,
			UserAppId = _003CmobileSettings_003EP.AppId
		});
	}

	public async Task<MessageCenterResponse> GetMessages()
	{
		MessageCenterRequest requestData = new MessageCenterRequest
		{
			Language = _prefs.Language
		};
		return await PostAsync<MessageCenterResponse>("apps/notifications/get_notifications", requestData);
	}
}
