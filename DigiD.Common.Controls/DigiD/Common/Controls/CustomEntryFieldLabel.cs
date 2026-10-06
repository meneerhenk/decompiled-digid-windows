using System.Runtime.CompilerServices;
using DigiD.Common.Interfaces;
using Microsoft.Maui.Controls;

namespace DigiD.Common.Controls;

public class CustomEntryFieldLabel : Label
{
	protected override void OnPropertyChanged([CallerMemberName] string? propertyName = null)
	{
		base.OnPropertyChanged(propertyName);
		if (propertyName == "IsVisible" && base.IsVisible && !string.IsNullOrEmpty(base.Text))
		{
			((IApp)Application.Current).A11YService.Speak(base.Text, 1500);
		}
	}
}
