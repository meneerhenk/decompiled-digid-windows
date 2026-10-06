using Microsoft.Maui;
using Microsoft.Maui.Controls;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.Controls;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class VerificationCodeLabel : Label
{
	public VerificationCodeLabel()
	{
		base.AutomationId = "VerificationCode";
		base.CharacterSpacing = 5.0;
		base.FontSize = 68.0;
		base.HorizontalOptions = LayoutOptions.Center;
		base.HorizontalTextAlignment = TextAlignment.Center;
		base.VerticalTextAlignment = TextAlignment.Center;
	}
}
