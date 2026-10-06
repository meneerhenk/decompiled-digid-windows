using System.Text.Json.Serialization;

namespace DigiD.Common.Models.RequestModels;

public class KeyAttestUpgradeRequest : BaseRequest
{
	[JsonPropertyName("user_app_id")]
	public string AppId { get; set; } = null;

	[JsonPropertyName("ka_data")]
	public KeyAttestationRequestModel? KeyAttestationData { get; set; }
}
