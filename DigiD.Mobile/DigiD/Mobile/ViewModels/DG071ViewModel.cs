using DigiD.Common.BaseClasses;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG071ViewModel : CommonBaseViewModel
{
	public DG071ViewModel()
	{
		base.PageId = "DG071";
		base.CloseButtonVisible = true;
	}
}
