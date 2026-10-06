namespace DigiD.Common.Models.Messages;

public class PresentingModeMessage
{
	public bool IsPresentingMode { get; }

	public PresentingModeMessage(bool isPresentingMode)
	{
		IsPresentingMode = isPresentingMode;
	}
}
