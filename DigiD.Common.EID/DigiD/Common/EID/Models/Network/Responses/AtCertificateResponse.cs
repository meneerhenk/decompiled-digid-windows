using System.Text.Json.Serialization;

namespace DigiD.Common.EID.Models.Network.Responses;

public class AtCertificateResponse : EIDBaseResponse
{
	[JsonPropertyName("responseData")]
	public CertificateResponseData? Data { get; set; }
}
