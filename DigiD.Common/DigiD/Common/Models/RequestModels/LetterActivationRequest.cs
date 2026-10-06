using System.Text.Json.Serialization;

namespace DigiD.Common.Models.RequestModels;

public class LetterActivationRequest : BaseRequest
{
	[JsonPropertyName("activationcode")]
	public string ActivationCode { get; set; } = null;
}
