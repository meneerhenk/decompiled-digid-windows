using System.Text.Json.Serialization;

namespace DigiD.Common.Models.RequestModels;

public class ReplaceExistingApplicationRequest : BaseRequest
{
	[JsonPropertyName("replace_application")]
	public bool? ReplaceExistingApplication { get; private set; }

	public ReplaceExistingApplicationRequest(bool replace)
	{
		ReplaceExistingApplication = replace;
	}
}
