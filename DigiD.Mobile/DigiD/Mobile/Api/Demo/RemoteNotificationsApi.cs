using System;
using System.Threading.Tasks;
using DigiD.Common.Http.Demo;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Config;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Models.Responses;
using DigiD.Common.Settings;
using Microsoft.Extensions.Logging;

namespace DigiD.Mobile.Api.Demo;

public class RemoteNotificationsApi : BaseApiService, IRemoteNotificationsApi
{
	private readonly IGeneralPreferences _generalPreferences;

	private readonly IMobileSettings _mobileSettings;

	public RemoteNotificationsApi(IGeneralPreferences generalPreferences, IMobileSettings mobileSettings, ILogger<RemoteNotificationsApi> logger)
		: base(logger)
	{
		_generalPreferences = generalPreferences;
		_mobileSettings = mobileSettings;
	}

	public async Task<BaseResponse> RegisterNotificationToken(string token, bool enabled)
	{
		await Task.Delay(0);
		return SendAsync("/apps/notifications/register", new NotificationRegisterRequest
		{
			NotificationToken = token,
			Enabled = enabled
		}, new BaseResponse
		{
			ApiResult = ApiResult.Ok
		});
	}

	public async Task<BaseResponse> UpdateNotificationToken(string token)
	{
		await Task.Delay(0);
		return SendAsync("/apps/notifications/update", new NotificationUpdateRequest
		{
			NotificationToken = token,
			InstanceId = _generalPreferences.InstanceId,
			UserAppId = _mobileSettings.AppId
		}, new BaseResponse
		{
			ApiResult = ApiResult.Ok
		});
	}

	public async Task<MessageCenterResponse> GetMessages()
	{
		await Task.Delay(0);
		MessageCenterRequest requestData = new MessageCenterRequest
		{
			Language = _generalPreferences.Language
		};
		MessageCenterResponse result = new MessageCenterResponse
		{
			ApiResult = ApiResult.Ok
		};
		if (DemoConfig.HasMessages)
		{
			result.Messages.Add(new MessageModel
			{
				CreatedAt = new DateTime(2020, 3, 3, 8, 0, 0),
				Text = "Hallo, dit is een langere bericht. Dit textveld heeft een maximale breedte. Breder dan dit wordt het niet. Dit bericht heeft ook loremipsum.nl",
				IsRead = true
			});
			result.Messages.Add(new MessageModel
			{
				CreatedAt = new DateTime(2020, 3, 3, 8, 23, 0),
				Text = "Lorem ipsum dolor sit amet illusi.",
				IsRead = true
			});
			result.Messages.Add(new MessageModel
			{
				CreatedAt = new DateTime(2020, 4, 17, 16, 30, 0),
				Text = "Dit is een korte bericht van DigiD.",
				IsRead = true
			});
			result.Messages.Add(new MessageModel
			{
				CreatedAt = new DateTime(2020, 4, 17, 16, 45, 0),
				Text = "Lorem ipsum.",
				IsRead = true
			});
			result.Messages.Add(new MessageModel
			{
				CreatedAt = new DateTime(2020, 7, 2, 13, 49, 0),
				Text = "Hallo, dit is een langere bericht. Dit textveld heeft een maximale breedte. Breder dan dit wordt het niet. Dit bericht heeft ook een link.nl",
				IsRead = true
			});
			result.Messages.Add(new MessageModel
			{
				CreatedAt = DateTime.Now.AddDays(-1.0).AddMinutes(20.0),
				Text = "Meerdere berichten op dezelfde dag staan zo onder elkaar.",
				IsRead = true
			});
			result.Messages.Add(new MessageModel
			{
				CreatedAt = DateTime.Now.AddDays(-1.0).AddMinutes(40.0),
				Text = "Dit is een extra lange bericht. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum.",
				IsRead = true
			});
			result.Messages.Add(new MessageModel
			{
				CreatedAt = DateTime.Now.AddDays(-1.0).AddMinutes(35.0),
				Text = "Lorem ipsum.",
				IsRead = true
			});
			result.Messages.Add(new MessageModel
			{
				CreatedAt = DateTime.Now,
				Text = "Dit is een korte bericht van DigiD.",
				IsRead = false
			});
		}
		return SendAsync("/apps/notifications/get_notifications", requestData, result);
	}
}
