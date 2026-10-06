using DigiD.Common.Models.Responses;

namespace DigiD.Common.SessionModels;

public class RdaSession
{
	public string? Url { get; } = response.Url;

	public string SessionId { get; } = response.SessionId;

	public RdaSession(RdaSessionResponse response)
	{
	}
}
