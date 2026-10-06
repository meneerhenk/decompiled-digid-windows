using System.Runtime.CompilerServices;
using DigiD.Common.Interfaces;
using Microsoft.Maui.Controls;

namespace DigiD.Common.Controls;

public class CustomEntryImage : Image
{
	private bool alreadyVisible;

	protected override void OnPropertyChanged([CallerMemberName] string? propertyName = null)
	{
		base.OnPropertyChanged(propertyName);
		if (propertyName == "IsVisible" && !alreadyVisible)
		{
			string description = SemanticProperties.GetDescription(this);
			if (base.IsVisible && !string.IsNullOrEmpty(description))
			{
				alreadyVisible = true;
				((IApp)Application.Current).A11YService.Speak(description, 1500);
			}
		}
	}
}
