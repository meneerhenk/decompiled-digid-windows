using System.Threading.Tasks;
using DigiD.Common.BaseClasses;

namespace DigiD.Mobile.ViewModels;

public class HLP004ViewModel : CommonBaseViewModel
{
	public HLP004ViewModel()
	{
		base.PageId = "HLP004";
		base.HasBackButton = false;
		base.CloseButtonVisible = true;
	}

	protected override async Task CloseButtonClicked()
	{
		await base.NavigationService.PopCurrentModalPage();
	}
}
