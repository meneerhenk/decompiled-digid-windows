using System.Text.Json.Serialization;

namespace DigiD.Common.EID.Models.Network.Responses;

public class TerminalAuthenticationCommandResponses : EIDBaseResponse
{
	[JsonPropertyName("responseData")]
	public TerminalAuthenticationCommandResponsesData? Data { get; set; }
}
