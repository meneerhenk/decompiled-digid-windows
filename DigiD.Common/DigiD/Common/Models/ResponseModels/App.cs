using System.Text.Json.Serialization;

namespace DigiD.Common.Models.ResponseModels;

public class App
{
	[JsonPropertyName("name")]
	public required string Name { get; set; }

	[JsonPropertyName("url")]
	public required string Url { get; set; }
}
