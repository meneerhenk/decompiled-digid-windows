using System.Text.Json.Serialization;

namespace DigiD.Common.EID.Models.Network.Responses;

public class CertificateResponseData
{
	[JsonPropertyName("atCert")]
	public string? AtCertificate { get; set; }
}
