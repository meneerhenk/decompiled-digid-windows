using System.Text.Json.Serialization;

namespace DigiD.Common.Models.RequestModels;

public sealed class BasicAuthenticateRequest
{
	[JsonPropertyName("username")]
	public required string Username { get; set; }

	[JsonPropertyName("password")]
	public required string Password { get; set; }

	[JsonPropertyName("device_name")]
	public required string DeviceName { get; set; }

	[JsonPropertyName("instance_id")]
	public required string InstanceId { get; set; }

	[JsonPropertyName("remove_old_app")]
	public bool RemoveOldApp { get; set; }

	[JsonPropertyName("id_check_skipped")]
	public bool IsIdCheckSkipped { get; set; }

	[JsonPropertyName("use_letter")]
	public bool UseLetter { get; set; }
}
