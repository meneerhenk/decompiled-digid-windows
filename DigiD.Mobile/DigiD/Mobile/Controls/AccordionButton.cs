using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.Controls;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class AccordionButton : Microsoft.Maui.Controls.Button
{
	public AccordionButton()
	{
		base.LineBreakMode = LineBreakMode.WordWrap;
		base.HorizontalOptions = LayoutOptions.Start;
	}

	protected override void OnHandlerChanged()
	{
		base.OnHandlerChanged();
		if (base.Handler?.PlatformView is Microsoft.UI.Xaml.Controls.Button button)
		{
			button.HorizontalContentAlignment = HorizontalAlignment.Left;
			button.VerticalContentAlignment = VerticalAlignment.Center;
		}
	}
}
