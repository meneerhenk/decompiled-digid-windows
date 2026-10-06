using System;
using System.Threading;
using System.Threading.Tasks;
using DigiD.Common.BaseClasses;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using Microsoft.Maui.Devices;

namespace DigiD.Mobile.ViewModels;

public class DG070ViewModel : CommonBaseViewModel
{
	private readonly IRdaApi api;

	private readonly IMobileSettings mobileSettings;

	private readonly IToastService toastService;

	private readonly IDeviceLockService lockService;

	public DG070ViewModel(IRdaApi api, IMobileSettings mobileSettings, IToastService toastService, IDeviceLockService lockService)
	{
		this.api = api;
		this.mobileSettings = mobileSettings;
		this.toastService = toastService;
		this.lockService = lockService;
		base.CloseButtonVisible = true;
		base.HasBackButton = false;
		Task.Run((Func<Task?>)StartTimer);
		lockService.Stop();
	}

	protected override async Task CloseButtonClicked()
	{
		await api.Cancel();
	}

	private async Task StartTimer()
	{
		ApiResult status = await api.Verified();
		PeriodicTimer timer = new PeriodicTimer(TimeSpan.FromSeconds(1L));
		while (await timer.WaitForNextTickAsync() && status == ApiResult.Pending)
		{
			status = await api.Verified();
		}
		lockService.Start();
		timer.Dispose();
		ApiResult apiResult = status;
		if (apiResult == ApiResult.Ok)
		{
			if (DeviceInfo.Platform == DevicePlatform.Android && DeviceInfo.Version.Major >= 10)
			{
				base.A11YService.Speak(CommonResources.x_UpgradeAccountWithIDCheckerSuccessHeader);
			}
			mobileSettings.LoginLevel = LoginLevel.Substantieel;
			bool isEHASession = HttpSession.WebSessionInfoResponse is PendingSessionResponse;
			base.MatomoService.TrackAction("ID Check", "Toevoegen" + (isEHASession ? " (EHA)" : ""), "Succesvol");
			await toastService.ShowSuccess(CommonResources.FM096_Body);
			await base.NavigationService.PopToRootAsync();
		}
		else
		{
			base.MatomoService.TrackAction("ID Check", "Toevoegen", "Mislukt");
			await toastService.ShowWarning(CommonResources.FM069_Titel);
			await base.NavigationService.PopToRootAsync();
		}
	}
}
