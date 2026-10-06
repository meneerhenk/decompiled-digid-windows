using System.Text.Json.Serialization;

namespace DigiD.Common.Models.RequestModels;

public class SetTwoFactorRequestModel : BaseMyDigiDRequest
{
	[JsonPropertyName("setting_2_factor")]
	public bool Enabled { get; set; }

	public SetTwoFactorRequestModel(bool enabled)
	{
		Enabled = enabled;
	}
}
