using System.Text.Json.Serialization;

namespace DigiD.Common.Models.RequestModels;

public class BasicAuthenticationSessionRequest : SessionRequest
{
	[JsonPropertyName("smscode")]
	public string? SMSCode { get; set; }

	[JsonPropertyName("device_name")]
	public required string DeviceName { get; set; }

	[JsonPropertyName("remove_old_app")]
	public bool RemoveOldApp { get; set; }
}
