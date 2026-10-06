using System;
using System.Threading.Tasks;
using DigiD.Common.Enums;
using DigiD.Common.Http.Demo;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Config;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Models.Responses;
using DigiD.Common.Preferences;
using Microsoft.Extensions.Logging;

namespace DigiD.Mobile.Api.Demo;

public class EmailApi : BaseApiService, IEmailApi
{
	private int _attempts;

	public EmailApi(ILogger<EmailApi> logger)
		: base(logger)
	{
	}

	public async Task<EmailStatusResponse> Status()
	{
		await Task.Delay(0);
		EmailStatusResponse response = new EmailStatusResponse
		{
			ApiResult = ApiResult.Ok
		};
		if (DemoConfig.HasEmailAddress)
		{
			if ((DemoSettings.EmailAddressVerified.HasValue && DemoSettings.EmailAddressVerified.Value) || DemoConfig.IsEmailAddressVerified)
			{
				response.EmailAddress = "verified@digid.nl";
				response.EmailStatus = EmailStatus.Verified;
			}
			else
			{
				response.NoVerifiedEmailAddress = "not_verified@digid.nl";
				response.EmailStatus = EmailStatus.NotVerified;
			}
		}
		else
		{
			response.EmailStatus = EmailStatus.None;
			response.UserActionNeeded = true;
		}
		if (!DemoSettings.EmailCheckDate.HasValue)
		{
			response.UserActionNeeded = DemoConfig.UserActionNeeded;
		}
		else
		{
			response.UserActionNeeded = (DateTime.Now - DemoSettings.EmailCheckDate.Value).TotalMinutes > 2.0;
		}
		return SendAsync("/apps/email/status", new BaseRequest(), response);
	}

	public async Task<EmailRegisterResponse> Register(string? emailAddress)
	{
		await Task.Delay(0);
		_attempts = 0;
		if (emailAddress == null)
		{
			DemoSettings.EmailCheckDate = DateTime.Now;
		}
		else
		{
			DemoSettings.EmailAddress = emailAddress;
			DemoSettings.EmailAddressVerified = false;
		}
		return SendAsync("/apps/email/register", new EmailRegisterRequest
		{
			EmailAddress = emailAddress
		}, new EmailRegisterResponse
		{
			ApiResult = ApiResult.Ok,
			EmailAddress = emailAddress
		});
	}

	public async Task<BaseResponse> Confirm(bool isValid)
	{
		await Task.Delay(0);
		DemoSettings.EmailCheckDate = DateTime.Now;
		return SendAsync("/apps/email/confirm", new EmailConfirmRequest
		{
			IsConfirmed = isValid
		}, new BaseResponse
		{
			ApiResult = ApiResult.Ok
		});
	}

	public async Task<EmailVerifyResponse> Verify(string code)
	{
		await Task.Delay(0);
		_attempts++;
		EmailVerifyResponse response;
		if (code.ToUpper() == "E23456789")
		{
			DemoSettings.EmailAddressVerified = true;
			DemoSettings.EmailCheckDate = DateTime.Now;
			_attempts = 0;
			response = new EmailVerifyResponse
			{
				ApiResult = ApiResult.Ok
			};
		}
		else
		{
			int remainingAttempts = 3 - _attempts;
			response = new EmailVerifyResponse
			{
				ApiResult = ApiResult.Nok,
				ErrorMessage = ((remainingAttempts > 0) ? "code_incorrect" : "code_blocked"),
				RemainingAttempts = remainingAttempts
			};
		}
		return SendAsync("/apps/email/verify", new EmailVerifyRequest
		{
			Code = code
		}, response);
	}
}
