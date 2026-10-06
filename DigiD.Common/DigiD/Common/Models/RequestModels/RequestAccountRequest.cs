using System.Text.Json.Serialization;

namespace DigiD.Common.Models.RequestModels;

public class RequestAccountRequest : BaseRequest
{
	[JsonPropertyName("BSN")]
	public required string Bsn { get; set; }

	[JsonPropertyName("date_of_birth")]
	public required string DateOfBirth { get; set; }

	[JsonPropertyName("postal_code")]
	public required string Postalcode { get; set; }

	[JsonPropertyName("house_number")]
	public required string HouseNumber { get; set; }

	[JsonPropertyName("house_number_additions")]
	public string? HouseNumberSuffix { get; set; }

	[JsonPropertyName("language")]
	public required string Language { get; set; }

	[JsonPropertyName("nfc_support")]
	public bool HasNfcSupport { get; set; }
}
