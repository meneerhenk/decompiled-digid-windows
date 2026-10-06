using System.Text.Json.Serialization;

namespace DigiD.Mobile.Models;

internal class AccountRequestValidationModel
{
	[JsonPropertyName("max_amount_of_account_application_per_month")]
	public int Amount { get; set; }
}
