using System;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using DigiD.Common.Enums;
using DigiD.Common.Helpers;
using DigiD.Common.Http;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Models.Responses;
using DigiD.Common.SessionModels;
using Microsoft.Extensions.Logging;
using Polly.Timeout;

namespace DigiD.Common.Api;

public class GeneralApi : BaseApiService, IGeneralApi
{
	public GeneralApi(ILogger<GeneralApi> logger, IGeneralPreferences preferences, IHttpClientFactory factory)
		: base(logger, preferences, factory)
	{
	}

	public async Task<BaseResponse> Cancel(bool cancelledByUser = false, bool timeout = false)
	{
		HttpSession.TempSessionData = null;
		Process process = AppSession.Process;
		Process process2 = process;
		if ((uint)(process2 - 1) <= 1u)
		{
			return await PostAsync<BaseResponse>("apps/wid/cancel_authentication", new BaseMyDigiDRequest());
		}
		if (HttpSession.ActivationSessionData != null)
		{
			if (HttpSession.ActivationSessionData.ActivationMethod == ActivationMethod.RequestNewDigidAccount)
			{
				return await PostAsync<BaseResponse>("apps/account_requests/cancel_application", new BaseMyDigiDRequest());
			}
			return await PostAsync<BaseResponse>("apps/cancel_activation", new BaseMyDigiDRequest());
		}
		return await PostAsync<BaseResponse>("apps/cancel_authentication?usercancel=" + (cancelledByUser ? "1" : "0") + "&timeout=" + (timeout ? "1" : "0"), new BaseMyDigiDRequest());
	}

	public async Task<ConfigResponse> GetConfig()
	{
		return await GetAsync<ConfigResponse>("apps/config");
	}

	public async Task<BaseResponse> DoHealthCheck()
	{
		BaseResponse result = new BaseResponse
		{
			ApiResult = ApiResult.Nok
		};
		try
		{
			HttpClient client = Factory.CreateClient("HealthCheckHttpClient");
			HttpResponseMessage response = await client.GetAsync("apps/config");
			if (response.IsSuccessStatusCode)
			{
				result.ApiResult = ApiResult.Ok;
				return result;
			}
			if (response.StatusCode == HttpStatusCode.ServiceUnavailable)
			{
				string text = (await response.Content.ReadAsStringAsync()).ToLower();
				string text2 = text;
				if (text2 == "onderhoud")
				{
					result.ApiResult = ApiResult.Maintenance;
				}
				else
				{
					result.ApiResult = ApiResult.TrafficMetered;
				}
				return result;
			}
		}
		catch (Exception ex)
		{
			if ((ex is TimeoutRejectedException || ex is TaskCanceledException) ? true : false)
			{
				Ping ping = new Ping();
				try
				{
					string ipAddress = "Q1mO4VnlIM/jvQ24".DeObfuscate("cm62z2vXDvfWkz+PupVN7cpu3zOf6NFolQ3qbGHDzwE=");
					result.ApiResult = (((await ping.SendPingAsync(ipAddress, 5000)).Status == IPStatus.Success) ? ApiResult.HostNotReachable : ApiResult.Nok);
					return result;
				}
				catch
				{
					return result;
				}
				finally
				{
					((IDisposable)ping)?.Dispose();
				}
			}
		}
		return result;
	}
}
