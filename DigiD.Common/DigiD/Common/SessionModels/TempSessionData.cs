namespace DigiD.Common.SessionModels;

public class TempSessionData(string sessionId)
{
	public string WebSessionId { get; } = sessionId;

	public void SwitchSession()
	{
		HttpSession.AppSessionId = WebSessionId;
	}
}
