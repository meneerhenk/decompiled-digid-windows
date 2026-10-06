using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using DigiD.Common.Http.Models;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Responses;
using Microsoft.Extensions.Logging;

namespace DigiD.Common.Http;

public class BaseApiService(ILogger<BaseApiService> logger, IGeneralPreferences preferences, IHttpClientFactory factory)
{
	protected readonly IGeneralPreferences Preferences = preferences;

	protected readonly IHttpClientFactory Factory = factory;

	private readonly HttpClient httpClient = factory.CreateClient("DefaultHttpClient");

	private static readonly JsonSerializerOptions JsonSerializerOptions = new JsonSerializerOptions
	{
		PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
		Converters = { (JsonConverter)new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
	};

	protected async Task<T> GetAsync<T>(string uri) where T : BaseResponse, new()
	{
		return await GetAsync<T>(new Uri("https://" + preferences.SelectedHost + "/" + uri));
	}

	private async Task<T> GetAsync<T>(Uri uri) where T : BaseResponse, new()
	{
		return await SendAsync<T>(new HttpRequestMessage
		{
			Method = HttpMethod.Get,
			RequestUri = uri
		});
	}

	protected Task<T> PostAsync<T>(string uri, object data) where T : BaseResponse, new()
	{
		return PostAsync<T>(new Uri("https://" + preferences.SelectedHost + "/" + uri), data);
	}

	protected Task<T> PostAsync<T>(Uri uri, object data) where T : BaseResponse, new()
	{
		string text = JsonSerializer.Serialize(data, JsonSerializerOptions);
		logger.LogInformation("{uri} - RequestData: \"{postData}\"", uri, text);
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage();
		httpRequestMessage.Method = HttpMethod.Post;
		httpRequestMessage.RequestUri = uri;
		httpRequestMessage.Content = JsonContent.Create(data);
		return SendAsync<T>(httpRequestMessage);
	}

	protected async Task<T> SendAsync<T>(HttpRequestMessage message, Action<ExceptionModel>? exceptionAction = null) where T : BaseResponse, new()
	{
		T result = null;
		Dictionary<string, string> props = new Dictionary<string, string>
		{
			{
				"uri",
				message.RequestUri.ToString()
			},
			{
				"method",
				message.Method.ToString()
			}
		};
		HttpResponseMessage response = null;
		try
		{
			response = await httpClient.SendAsync(message);
			response.EnsureSuccessStatusCode();
			props.Add("status", ((int)response.StatusCode).ToString(CultureInfo.InvariantCulture));
			string json = await response.Content.ReadAsStringAsync();
			result = JsonSerializer.Deserialize<T>(json);
			logger.LogInformation("{uri} - ResponseData: \"{result}\"", message.RequestUri, json);
			if (result == null)
			{
				throw new InvalidDataException("ResponseData is invalid");
			}
			if (string.IsNullOrEmpty(result.Status))
			{
				result.Status = "";
			}
			switch (result.Status.ToLowerInvariant())
			{
			case "kill_app":
				result.ApiResult = ApiResult.Kill;
				break;
			case "no_documents":
				result.ApiResult = ApiResult.NoDocumentsFound;
				break;
			case "unknown":
				result.ApiResult = ApiResult.Unknown;
				break;
			case "nok":
				result.ApiResult = ApiResult.Nok;
				break;
			case "ok":
				result.ApiResult = ApiResult.Ok;
				break;
			case "pending":
				result.ApiResult = ApiResult.Pending;
				break;
			case "cancelled":
				result.ApiResult = ApiResult.Cancelled;
				break;
			case "disabled":
				result.ApiResult = ApiResult.Disabled;
				break;
			case "success":
				result.ApiResult = ApiResult.Ok;
				break;
			case "failed":
				result.ApiResult = ApiResult.Failed;
				break;
			case "error":
				result.ApiResult = ApiResult.Error;
				break;
			case "blocked":
				result.ApiResult = ApiResult.Blocked;
				break;
			case "pending_confirmed":
				result.ApiResult = ApiResult.PendingConfirmed;
				break;
			case "active":
				result.ApiResult = ApiResult.Active;
				break;
			case "inactive":
				result.ApiResult = ApiResult.InActive;
				break;
			case "aborted":
				result.ApiResult = ApiResult.Aborted;
				break;
			case "verified":
			case "completed":
				result.ApiResult = ApiResult.Verified;
				break;
			case "confirmed":
				result.ApiResult = ApiResult.Confirmed;
				break;
			case "bsns_not_identical":
				result.ApiResult = ApiResult.BsnNotIdentical;
				break;
			default:
				result.ApiResult = ApiResult.Ok;
				break;
			}
			return result;
		}
		catch (Exception ex)
		{
			exceptionAction?.Invoke(new ExceptionModel(ex, props));
			return await HandleException(ex, result, response);
		}
	}

	private async Task<T> HandleException<T>(Exception ex, T? result, HttpResponseMessage? response) where T : BaseResponse?, new()
	{
		if (result == null)
		{
			return new T
			{
				ApiResult = ApiResult.Unknown
			};
		}
		logger.LogError(ex, "{uri} - {message}", response?.RequestMessage?.RequestUri, ex.Message);
		if ((ex.InnerException?.Message.Contains("TrustFailure") ?? false) || (ex is WebException ex2 && ex2.Status == WebExceptionStatus.TrustFailure))
		{
			result.ApiResult = ApiResult.SSLPinningError;
			return result;
		}
		if (response != null)
		{
			switch (response.StatusCode)
			{
			case HttpStatusCode.Forbidden:
				result.ApiResult = ApiResult.Forbidden;
				return result;
			case HttpStatusCode.BadRequest:
				result.ApiResult = ApiResult.BadRequest;
				return result;
			case HttpStatusCode.NotFound:
				result.ApiResult = ApiResult.SessionNotFound;
				return result;
			case HttpStatusCode.ServiceUnavailable:
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
		}
		result.ApiResult = ApiResult.Unknown;
		return result;
	}
}
