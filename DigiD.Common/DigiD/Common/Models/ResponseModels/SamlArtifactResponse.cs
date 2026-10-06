using DigiD.Common.Models.Responses;

namespace DigiD.Common.Models.ResponseModels;

public class SamlArtifactResponse : BaseResponse
{
	public string? SAMLart { get; set; }

	public string? RelayState { get; set; }
}
