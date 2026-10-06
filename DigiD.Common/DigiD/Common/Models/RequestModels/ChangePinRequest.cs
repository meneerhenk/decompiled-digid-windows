using System.Text.Json.Serialization;

namespace DigiD.Common.Models.RequestModels;

public class ChangePinRequest : BaseRequest
{
	[JsonPropertyName("masked_pincode")]
	public string NewPIN { get; set; }

	public ChangePinRequest(string encryptedPin)
	{
		NewPIN = encryptedPin;
	}
}
