using System.Collections.Generic;
using System.Text.Json.Serialization;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models;

public class UsageHistoryResponseModel : BaseResponse
{
	[JsonPropertyName("total_items")]
	public int TotalItems { get; set; }

	[JsonPropertyName("total_pages")]
	public int TotalPages { get; set; }

	[JsonPropertyName("logs")]
	public List<UsageHistoryModel> Items { get; set; } = new List<UsageHistoryModel>();
}
