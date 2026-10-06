using System.Text.Json.Serialization;

namespace DigiD.Common.Models.RequestModels;

public class EmailConfirmRequest : BaseMyDigiDRequest
{
	[JsonPropertyName("email_address_confirmed")]
	public bool IsConfirmed { get; set; }
}
