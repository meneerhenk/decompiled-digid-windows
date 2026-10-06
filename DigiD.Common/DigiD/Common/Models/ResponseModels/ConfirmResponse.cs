using System.Text.Json.Serialization;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.ResponseModels;

public class ConfirmResponse : BaseResponse
{
	[JsonPropertyName("deactivate")]
	public bool NeedDeactivation { get; set; }
}
