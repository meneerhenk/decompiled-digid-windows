using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using WinRT;
using WinRT.DigiD_Common_ControlsVtableClasses;

namespace DigiD.Common.Controls;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Common_Controls_HyperlinkLabelWinRTTypeDetails))]
internal class PasswordToggle : ImageButton
{
	protected override void OnHandlerChanged()
	{
		base.OnHandlerChanged();
		IViewHandler handler = base.Handler;
		if (handler != null && handler.PlatformView is Microsoft.UI.Xaml.Controls.Button button)
		{
			Microsoft.UI.Xaml.Media.SolidColorBrush value = (Microsoft.UI.Xaml.Media.SolidColorBrush)(button.BorderBrush = (button.Background = new Microsoft.UI.Xaml.Media.SolidColorBrush(Colors.Transparent)));
			button.BorderThickness = new Microsoft.UI.Xaml.Thickness(0.0);
			button.Resources["ButtonBackground"] = value;
			button.Resources["ButtonBackgroundPointerOver"] = value;
			button.Resources["ButtonBackgroundPressed"] = value;
			button.Resources["ButtonBackgroundDisabled"] = value;
			button.Resources["ButtonBorderBrush"] = value;
			button.Resources["ButtonBorderBrushPointerOver"] = value;
			button.Resources["ButtonBorderBrushPressed"] = value;
			button.Resources["ButtonBorderBrushDisabled"] = value;
		}
	}
}
