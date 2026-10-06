using System;
using System.Text.Json.Serialization;

namespace DigiD.Common.Models;

public class UsageHistoryModel
{
	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("created_at")]
	public DateTime DateTime { get; set; }

	[JsonPropertyName("name")]
	public required string Message { get; set; }
}
