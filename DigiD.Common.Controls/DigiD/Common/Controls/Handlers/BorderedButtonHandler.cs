using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Handlers;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace DigiD.Common.Controls.Handlers;

public class BorderedButtonHandler : ButtonHandler
{
	protected override void ConnectHandler(Microsoft.UI.Xaml.Controls.Button platformView)
	{
		base.ConnectHandler(platformView);
		platformView.GotFocus += PlatformView_GotFocus;
		platformView.LostFocus += PlatformView_LostFocus;
	}

	protected override void DisconnectHandler(Microsoft.UI.Xaml.Controls.Button platformView)
	{
		base.DisconnectHandler(platformView);
		platformView.GotFocus -= PlatformView_GotFocus;
		platformView.LostFocus -= PlatformView_LostFocus;
	}

	private void PlatformView_LostFocus(object sender, RoutedEventArgs e)
	{
		if (!(sender is BorderedButton borderedButton))
		{
			return;
		}
		try
		{
			if (borderedButton.IsEnabled)
			{
				Microsoft.Maui.Controls.VisualStateManager.GoToState(borderedButton, "Normal");
			}
			else
			{
				Microsoft.Maui.Controls.VisualStateManager.GoToState(borderedButton, "Disabled");
			}
		}
		catch (ObjectDisposedException)
		{
			Console.WriteLine("!!! PlatformView_LostFocus --> ObjectDisposedException no need te change visualstate");
		}
		catch (Exception ex2)
		{
			Console.WriteLine("!!! PlatformView_LostFocus --> Exception: " + ex2.Message);
		}
	}

	private void PlatformView_GotFocus(object sender, RoutedEventArgs e)
	{
		if (sender is BorderedButton visualElement)
		{
			Microsoft.Maui.Controls.VisualStateManager.GoToState(visualElement, "Focused");
		}
	}
}
