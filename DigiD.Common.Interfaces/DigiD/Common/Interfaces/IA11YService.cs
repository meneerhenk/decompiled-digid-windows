using Microsoft.Maui;

namespace DigiD.Common.Interfaces;

public interface IA11YService
{
	bool IsInVoiceOverMode { get; }

	bool HideAnimations { get; }

	void Speak(string? text, int pauseInMs = 0);

	void NotifyForNewPage(IView? view = null);
}
