using System.Text.Json.Serialization;

namespace DigiD.Common.Models.RequestModels;

public class PincodeRequest : BaseRequest
{
	[JsonPropertyName("masked_pincode")]
	public required string MaskedPincode { get; set; }

	[JsonPropertyName("user_app_id")]
	public required string AppId { get; set; }

	[JsonIgnore]
	public byte[]? IV { get; set; }
}
