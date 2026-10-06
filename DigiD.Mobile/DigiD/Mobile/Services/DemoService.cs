using System;
using System.Threading.Tasks;
using DigiD.Common.Exceptions;
using DigiD.Common.Interfaces;
using DigiD.Common.Preferences;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Pages;
using DigiD.Mobile.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace DigiD.Mobile.Services;

public class DemoService(INavigationService navigationService, IPopupService popupService, IDialogService dialogService) : IDemoService
{
	private DateTime _lastPressed = DateTime.Now;

	private int count;

	public async Task<string> AskAuthenticationAction(bool widAuthentication)
	{
		TaskCompletionSource<string> tcs = new TaskCompletionSource<string>();
		await navigationService.PushModalAsync<DM001, DM001ViewModel>(delegate(DM001ViewModel vm)
		{
			vm.Initialize(async delegate(string action)
			{
				await navigationService.PopCurrentModalPage();
				tcs.SetResult(action);
			}, widAuthentication);
		});
		return await tcs.Task;
	}

	public async Task SetMode()
	{
		double ms = (DateTime.Now - _lastPressed).TotalMilliseconds;
		if (ms <= 500.0)
		{
			count++;
		}
		else
		{
			count = 1;
		}
		Console.WriteLine($"{ms}ms - {count} count");
		_lastPressed = DateTime.Now;
		if (count == 5)
		{
			bool? answer = await popupService.DisplayAlert("Demo-modus", "Wilt u de demo-modus " + (DemoSettings.IsDemoModeEnabled ? "deactiveren" : "activeren") + ". Start dan de app opnieuw.", CommonResources.Alg_Yes, CommonResources.Alg_No);
			if (answer.HasValue && answer.Value)
			{
				dialogService.Show();
				DemoSettings.IsDemoModeEnabled = !DemoSettings.IsDemoModeEnabled;
				AppSession.ServiceProvider.GetRequiredService<IAppService>().Reset();
				await Task.Delay(500);
				throw new DemoModeException();
			}
		}
	}
}
