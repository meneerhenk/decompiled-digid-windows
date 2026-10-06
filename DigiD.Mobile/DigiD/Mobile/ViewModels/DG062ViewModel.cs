using DigiD.Common.BaseClasses;
using DigiD.Common.Controls.Models;
using DigiD.Mobile.Pages;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG062ViewModel : CommonBaseViewModel
{
	public static PageMenuItem<DG060> FAQMenuItem => new PageMenuItem<DG060>("Faq", "DG062_FAQ", "iconMenuFaq");

	public DG062ViewModel()
	{
		base.CloseButtonVisible = true;
	}
}
