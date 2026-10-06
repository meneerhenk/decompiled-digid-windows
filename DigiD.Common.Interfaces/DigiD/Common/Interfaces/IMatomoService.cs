namespace DigiD.Common.Interfaces;

public interface IMatomoService
{
	void TrackScreen(string screenName);

	void TrackAction(string category, string action, string name);

	void ResetSession();
}
