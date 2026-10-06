using System.Text.Json.Serialization;

namespace DigiD.Common.EID.Models.Network.Responses;

public class SetupSecureMessagingResponse : EIDBaseResponse
{
	[JsonPropertyName("responseData")]
	public SecureMessagingResponse? Data { get; set; }
}
