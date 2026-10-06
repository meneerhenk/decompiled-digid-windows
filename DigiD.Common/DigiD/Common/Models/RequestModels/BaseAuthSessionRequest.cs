using System.Text.Json.Serialization;
using DigiD.Common.Interfaces;
using DigiD.Common.SessionModels;
using Microsoft.Extensions.DependencyInjection;

namespace DigiD.Common.Models.RequestModels;

public class BaseAuthSessionRequest : BaseRequest
{
	[JsonPropertyName("instance_id")]
	public string InstanceId { get; set; }

	[JsonPropertyName("user_app_id")]
	public string? AppId { get; set; }

	public BaseAuthSessionRequest()
	{
		base.AuthenticationSessionId = HttpSession.AuthenticationSessionId;
		InstanceId = AppSession.ServiceProvider.GetRequiredService<IGeneralPreferences>().InstanceId;
	}
}
