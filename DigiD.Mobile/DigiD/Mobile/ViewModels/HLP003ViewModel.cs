using System.Threading.Tasks;
using DigiD.Common.BaseClasses;

namespace DigiD.Mobile.ViewModels;

public class HLP003ViewModel : CommonBaseViewModel
{
	public HLP003ViewModel()
	{
		base.PageId = "HLP003";
		base.HasBackButton = false;
		base.CloseButtonVisible = true;
	}

	protected override Task CloseButtonClicked()
	{
		return base.NavigationService.PopCurrentModalPage();
	}
}
