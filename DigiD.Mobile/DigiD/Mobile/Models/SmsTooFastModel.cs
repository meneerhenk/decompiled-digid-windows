using System.Text.Json.Serialization;

namespace DigiD.Mobile.Models;

public class SmsTooFastModel
{
	[JsonPropertyName("time_left")]
	public string TimeLeft { get; set; } = string.Empty;
}
