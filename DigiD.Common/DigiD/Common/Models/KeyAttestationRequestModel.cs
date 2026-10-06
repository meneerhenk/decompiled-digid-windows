using System.Text.Json.Serialization;

namespace DigiD.Common.Models;

public class KeyAttestationRequestModel
{
	[JsonPropertyName("android_certificates")]
	public byte[][]? AndroidResult { get; set; }

	[JsonPropertyName("ios_result")]
	public byte[]? iOSResult { get; set; }

	[JsonPropertyName("key_id")]
	public string KeyID { get; set; } = null;
}
