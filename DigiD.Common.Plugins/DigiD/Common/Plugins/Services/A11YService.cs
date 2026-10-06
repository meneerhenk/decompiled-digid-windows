using DigiD.Common.Interfaces;
using Microsoft.Maui;
using Microsoft.Maui.Accessibility;
using Microsoft.Maui.ApplicationModel;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Automation.Peers;
using Microsoft.UI.Xaml.Media;

namespace DigiD.Common.Plugins.Services;

internal class A11YService : IA11YService
{
	public bool IsInVoiceOverMode => AutomationPeer.ListenerExists(AutomationEvents.AutomationFocusChanged);

	public bool HideAnimations => false;

	public void NotifyForNewPage(IView? view = null)
	{
		Window activeWindow = WindowStateManager.Default.GetActiveWindow();
		if ((object)activeWindow != null)
		{
			AutomationPeer automationPeer = FindAutomationPeer(activeWindow.Content);
			if (!(automationPeer == null))
			{
				automationPeer.RaiseStructureChangedEvent(AutomationStructureChangeType.ChildrenInvalidated, automationPeer);
			}
		}
	}

	private static AutomationPeer? FindAutomationPeer(DependencyObject depObj)
	{
		if (depObj != null)
		{
			for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
			{
				DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
				if (child is UIElement element && FrameworkElementAutomationPeer.FromElement(element) != null)
				{
					return FrameworkElementAutomationPeer.FromElement(element);
				}
				AutomationPeer automationPeer = FindAutomationPeer(child);
				if (automationPeer != null)
				{
					return automationPeer;
				}
			}
		}
		return null;
	}

	public void Speak(string? text, int pauseInMs = 0)
	{
		MainThread.BeginInvokeOnMainThread(delegate
		{
			if (IsInVoiceOverMode && text != null)
			{
				SemanticScreenReader.Announce(text);
			}
		});
	}
}
