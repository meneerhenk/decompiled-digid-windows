using System.Net.Http;
using System.Threading.Tasks;
using DigiD.Common.Http;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Models.Responses;
using Microsoft.Extensions.Logging;

namespace DigiD.Mobile.Api;

public class EmailApi : BaseApiService, IEmailApi
{
	public EmailApi(ILogger<EmailApi> logger, IGeneralPreferences preferences, IHttpClientFactory factory)
		: base(logger, preferences, factory)
	{
	}

	public async Task<EmailStatusResponse> Status()
	{
		return await PostAsync<EmailStatusResponse>("apps/email/status", new BaseMyDigiDRequest());
	}

	public async Task<EmailRegisterResponse> Register(string? emailAddress)
	{
		EmailRegisterRequest requestData = new EmailRegisterRequest
		{
			EmailAddress = emailAddress
		};
		return await PostAsync<EmailRegisterResponse>("apps/email/register", requestData);
	}

	public async Task<EmailVerifyResponse> Verify(string code)
	{
		EmailVerifyRequest requestData = new EmailVerifyRequest
		{
			Code = code
		};
		return await PostAsync<EmailVerifyResponse>("apps/email/verify", requestData);
	}

	public async Task<BaseResponse> Confirm(bool isValid)
	{
		EmailConfirmRequest requestData = new EmailConfirmRequest
		{
			IsConfirmed = isValid
		};
		return await PostAsync<EmailVerifyResponse>("apps/email/confirm", requestData);
	}
}
