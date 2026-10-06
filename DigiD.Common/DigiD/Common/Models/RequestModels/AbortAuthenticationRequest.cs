using System.Text.Json.Serialization;

namespace DigiD.Common.Models.RequestModels;

public class AbortAuthenticationRequest : BaseEIDRequest
{
	[JsonPropertyName("code")]
	public string Code { get; }

	public AbortAuthenticationRequest(string code)
	{
		Code = code;
	}
}
