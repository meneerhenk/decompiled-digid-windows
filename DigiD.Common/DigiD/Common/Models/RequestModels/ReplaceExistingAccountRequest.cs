using System.Text.Json.Serialization;

namespace DigiD.Common.Models.RequestModels;

public class ReplaceExistingAccountRequest : BaseRequest
{
	[JsonPropertyName("replace_account")]
	public bool? ReplaceExistingAccount { get; private set; }

	public ReplaceExistingAccountRequest(bool replace)
	{
		ReplaceExistingAccount = replace;
	}
}
