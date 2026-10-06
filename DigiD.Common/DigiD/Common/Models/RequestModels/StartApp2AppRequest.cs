using System.Text.Json.Serialization;

namespace DigiD.Common.Models.RequestModels;

public class StartApp2AppRequest : BaseRequest
{
	[JsonPropertyName("SAMLRequest")]
	public required string SAMLRequest { get; set; }

	[JsonPropertyName("RelayState")]
	public string? RelayState { get; set; }

	[JsonPropertyName("SigAlg")]
	public string? SigAlg { get; set; }

	[JsonPropertyName("Signature")]
	public string? Signature { get; set; }

	[JsonPropertyName("Type")]
	public required string Type { get; set; }
}
