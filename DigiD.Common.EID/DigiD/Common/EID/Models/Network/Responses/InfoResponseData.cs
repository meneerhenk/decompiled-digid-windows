using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DigiD.Common.EID.Models.Network.Responses;

public class InfoResponseData
{
	[JsonPropertyName("dvCert")]
	public byte[] DvCertificate { get; set; } = null;

	[JsonPropertyName("linkCerts")]
	public List<byte[]>? LinkCertificates { get; set; }

	[JsonPropertyName("ephemeralKey")]
	public byte[] EphemeralKey { get; set; } = null;
}
