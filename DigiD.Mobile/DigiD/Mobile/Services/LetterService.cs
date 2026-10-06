using System;
using System.Threading.Tasks;
using DigiD.Common.Models.Enums;
using DigiD.Mobile.Interfaces;
using Microsoft.Extensions.Logging;

namespace DigiD.Mobile.Services;

internal class LetterService(ILogger<LetterService> logger) : ILetterService
{
	private static readonly TimeSpan FirstNotificationAfter = TimeSpan.FromDays(4);

	private static readonly TimeSpan SecondNotificationAfter = TimeSpan.FromDays(15);

	public async Task Register()
	{
		Cancel();
		DateTime now = DateTime.Now.Date.AddHours(19.0);
		await SetNotification(now.Add(FirstNotificationAfter), NotificationType.LetterFirst);
		await SetNotification(now.Add(SecondNotificationAfter), NotificationType.LetterSecond);
	}

	public void Cancel()
	{
	}

	private Task SetNotification(DateTime date, NotificationType type)
	{
		if (logger.IsEnabled(LogLevel.Debug))
		{
			logger.LogDebug("SetNotification succeeded: {Type} - {Date}", type, date);
		}
		return Task.CompletedTask;
	}
}
