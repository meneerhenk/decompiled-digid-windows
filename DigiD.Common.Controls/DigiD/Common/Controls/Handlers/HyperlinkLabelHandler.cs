using Microsoft.Maui.Controls;
using Microsoft.Maui.Handlers;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace DigiD.Common.Controls.Handlers;

public class HyperlinkLabelHandler : LabelHandler
{
	protected override TextBlock CreatePlatformView()
	{
		TextBlock textBlock = base.CreatePlatformView();
		textBlock.IsTextScaleFactorEnabled = true;
		textBlock.IsTabStop = true;
		textBlock.TextWrapping = TextWrapping.Wrap;
		textBlock.IsColorFontEnabled = true;
		textBlock.Padding = new Thickness(3.0);
		return textBlock;
	}

	protected override void ConnectHandler(TextBlock platformView)
	{
		base.ConnectHandler(platformView);
		platformView.GotFocus += PlatformView_FocusChanged;
		platformView.LostFocus += PlatformView_FocusChanged;
	}

	private void PlatformView_FocusChanged(object sender, RoutedEventArgs e)
	{
		if (sender is TextBlock && base.VirtualView.Parent is Microsoft.Maui.Controls.Border visualElement)
		{
			if (((TextBlock)e.OriginalSource).FocusState != FocusState.Unfocused)
			{
				Microsoft.Maui.Controls.VisualStateManager.GoToState(visualElement, "Focused");
			}
			else
			{
				Microsoft.Maui.Controls.VisualStateManager.GoToState(visualElement, "Normal");
			}
		}
	}

	protected override void DisconnectHandler(TextBlock platformView)
	{
		base.DisconnectHandler(platformView);
		platformView.GotFocus -= PlatformView_FocusChanged;
		platformView.LostFocus -= PlatformView_FocusChanged;
	}
}
