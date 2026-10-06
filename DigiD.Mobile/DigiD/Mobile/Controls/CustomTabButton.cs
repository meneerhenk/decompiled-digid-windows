using DigiD.Common.Controls;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Interfaces;
using DigiD.Common.Resources;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace DigiD.Mobile.Controls;

public class CustomTabButton : BorderedButton
{
	public int TabIndex { get; set; } = 1;

	public int NumberOfTabs { get; set; } = 1;

	public CustomTabButton()
	{
		base.Margin = new Thickness(5.0, 5.0, 5.0, 0.0);
	}

	protected override void OnPropertyChanged(string? propertyName = null)
	{
		base.OnPropertyChanged(propertyName);
		if ((propertyName == "Text" || propertyName == "ButtonType") ? true : false)
		{
			SetSemantics();
		}
	}

	private void SetSemantics()
	{
		bool flag = base.ButtonType == ButtonType.TabActive;
		string text = $"{string.Format(CommonResources.Alg_TabPage, TabIndex, NumberOfTabs)},  {base.Text} {(flag ? CommonResources.Alg_Selected : "")}";
		SemanticProperties.SetDescription(this, text);
		if (flag)
		{
			((IApp)Application.Current).A11YService.Speak(text);
		}
	}
}
