using System;
using System.Text.Json.Serialization;
using DigiD.Common.EID.SessionModels;

namespace DigiD.Common.EID.Models.Network.Requests;

public class EIDBaseRequest
{
	[JsonPropertyName("header")]
	public Header Header { get; set; }

	[JsonPropertyName("messageData")]
	public object MessageData { get; set; }

	public EIDBaseRequest(object data)
	{
		ArgumentNullException.ThrowIfNull(EIDSession.SessionId, "EIDSession.SessionId");
		Header = new Header
		{
			SessionId = EIDSession.SessionId,
			SupportedAPIVersion = new SupportedApiVersion
			{
				Major = "1",
				Minor = "1"
			}
		};
		MessageData = data;
	}
}
