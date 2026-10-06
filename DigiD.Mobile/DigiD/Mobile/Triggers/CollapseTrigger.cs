using System;
using Microsoft.Maui;
using Microsoft.Maui.Accessibility;
using Microsoft.Maui.Controls;

namespace DigiD.Mobile.Triggers;

public class CollapseTrigger : TriggerAction<VisualElement>
{
	public bool IsVisible { get; set; }

	protected override void Invoke(VisualElement sender)
	{
		if (IsVisible)
		{
			Animate(sender);
		}
		else
		{
			sender.IsVisible = false;
		}
		static async void Animate(VisualElement element)
		{
			try
			{
				element.IsVisible = true;
				element.TranslationY = -100.0;
				await element.TranslateToAsync(0.0, 0.0, 1000u, Easing.Linear);
				string text = SemanticProperties.GetDescription(element);
				if (text != null)
				{
					SemanticScreenReader.Announce(text);
				}
			}
			catch (Exception ex)
			{
				Exception e = ex;
				Console.WriteLine(e);
			}
		}
	}
}
