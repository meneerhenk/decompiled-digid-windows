using System.Text.Json.Serialization;
using DigiD.Common.Models.RequestModels;

namespace DigiD.Common.Models;

public class UsageHistoryRequestModel : BaseMyDigiDRequest
{
	[JsonPropertyName("page_id")]
	public int PageId { get; set; }

	[JsonPropertyName("language")]
	public required string Language { get; set; }
}
