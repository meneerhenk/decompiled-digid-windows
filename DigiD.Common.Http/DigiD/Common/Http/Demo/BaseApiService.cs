using System.Text.Json;
using DigiD.Common.Models.Config;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Responses;
using Microsoft.Extensions.Logging;

namespace DigiD.Common.Http.Demo;

public class BaseApiService(ILogger<BaseApiService> logger)
{
	protected T SendAsync<T>(string url, object? requestData, T responseData) where T : BaseResponse, new()
	{
		logger.LogInformation("[Demo] {verb} - {url} ", (requestData == null) ? "GET" : "POST", url);
		JsonSerializerOptions options = new JsonSerializerOptions
		{
			WriteIndented = false
		};
		if (DemoConfig.TrafficMeteringEnabled)
		{
			responseData.ApiResult = ApiResult.TrafficMetered;
		}
		else if (DemoConfig.MaintenanceEnabled)
		{
			responseData.ApiResult = ApiResult.Maintenance;
		}
		if (requestData != null)
		{
			logger.LogInformation("[Demo] RequestData: {json}", JsonSerializer.Serialize(requestData, options));
		}
		logger.LogInformation("[Demo] ResponseData: {json}", JsonSerializer.Serialize(responseData, options));
		return responseData;
	}
}
