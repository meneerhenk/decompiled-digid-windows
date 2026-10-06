using System;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Models.Enums;
using DigiD.Mobile.Interfaces;

namespace DigiD.Mobile.ViewModels;

public class HLP005ViewModel : CommonBaseViewModel
{
	public HLP005ViewModel(IAppService appService)
	{
		base.ButtonCommand = new AsyncRelayCommand((Func<Task>)async delegate
		{
			await appService.Deactivate(AlertMessageType.FM054);
		});
	}
}
