using System.Text.Json.Serialization;
using DigiD.Common.Models.Enums;

namespace DigiD.Common.Models.Responses;

public class BaseResponse
{
	[JsonIgnore]
	public ApiResult ApiResult { get; set; }

	[JsonPropertyName("status")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public string? Status { get; set; }

	[JsonPropertyName("error")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public string? ErrorMessage { get; set; }

	[JsonPropertyName("payload")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public object? Payload { get; set; }
}
