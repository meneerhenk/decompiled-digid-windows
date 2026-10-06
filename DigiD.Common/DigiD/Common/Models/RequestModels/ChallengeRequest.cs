using System.Text.Json.Serialization;

namespace DigiD.Common.Models.RequestModels;

public class ChallengeRequest : BaseRequest
{
	[JsonPropertyName("user_app_id")]
	public required string AppId { get; set; }

	[JsonPropertyName("instance_id")]
	public required string InstanceId { get; set; }

	public ChallengeRequest(string sessionId)
	{
		base.AuthenticationSessionId = sessionId;
	}
}
