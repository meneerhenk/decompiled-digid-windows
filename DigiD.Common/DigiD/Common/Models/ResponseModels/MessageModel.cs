using System;
using System.Text.Json.Serialization;

namespace DigiD.Common.Models.ResponseModels;

public class MessageModel
{
	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("content")]
	public required string Text { get; set; }

	[JsonPropertyName("created_at")]
	public DateTimeOffset CreatedAt { get; set; }

	[JsonPropertyName("status_read")]
	public bool IsRead { get; set; }

	public bool IsNew => !IsRead;

	public DateTime DateTime => CreatedAt.LocalDateTime;
}
