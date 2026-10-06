using System.Text.Json.Serialization;

namespace DigiD.Common.Models.RequestModels;

public class ResendSmsRequest : BaseRequest
{
	[JsonPropertyName("spoken")]
	public string SpokenSMS { get; set; }

	public ResendSmsRequest(bool spoken)
	{
		SpokenSMS = spoken.ToString().ToLowerInvariant();
	}
}
