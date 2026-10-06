using System.Text.Json.Serialization;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.ResponseModels;

public class TwoFactorResponseModel : BaseResponse
{
	[JsonPropertyName("setting_2_factor")]
	public bool Enabled { get; set; }
}
