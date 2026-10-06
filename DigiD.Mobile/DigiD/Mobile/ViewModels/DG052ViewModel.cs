using System;
using System.Collections.Generic;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls.Models;
using DigiD.Common.Enums;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Helpers;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.SessionModels;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Pages;
using Microsoft.Maui.ApplicationModel;

namespace DigiD.Mobile.ViewModels;

public class DG052ViewModel : CommonBaseViewModel
{
	public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();

	public MenuItem? MyDigiDMenuItem { get; private set; }

	public DG052ViewModel(ISessionService sessionService, IEmailService emailService, IConfigurationService config, IAccountInformationApi accountInformationApi, IGeneralApi generalServices)
	{
		DG052ViewModel dG052ViewModel = this;
		base.CloseButtonVisible = true;
		HttpSession.AppSessionId = null;
		ArgumentNullException.ThrowIfNull(AppSession.MyDigiDUrl, "AppSession.MyDigiDUrl");
		MyDigiDMenuItem = new ActionMenuItem("ToMyDigiDWebSite", "DG052_Website", "digidIconMenuMijnDigid", async delegate
		{
			AppSession.LaunchMyDigiDFromMenu = true;
			if (await Launcher.CanOpenAsync(AppSession.MyDigiDUrl))
			{
				await Launcher.OpenAsync(AppSession.MyDigiDUrl);
			}
		}, chevronVisible: true, isExternalLink: true);
		if (!HttpSession.IsDeceased)
		{
			MenuItems.Add(new ActionMenuItem("ManageEmail", "DG052_Emailadres", "digidIconMenuEmail", async delegate
			{
				await sessionService.StartSession(async delegate
				{
					await emailService.Manage(() => dG052ViewModel.NavigationService.PopToAsync<DG052>());
				}, startBiometrics: true);
			}));
		}
		MenuItems.Add(new ActionMenuItem("UsageHistory", "DG052_Gebruiksgeschiedenis", "digidIconMenuAppGebruiksgeschiedenis", async delegate
		{
			await sessionService.StartSession(async delegate
			{
				await dG052ViewModel.NavigationService.NavigateAsync<DG053, DG053ViewModel>(async delegate(DG053ViewModel vm)
				{
					await vm.Initialize();
				});
			}, startBiometrics: true);
		}));
		if (!HttpSession.IsDeceased)
		{
			MenuItems.Add(new ActionMenuItem("ChangePincode", "DG052_Pincode", "digidIconPincodeVeranderen", async delegate
			{
				if (AppSession.HasNfc)
				{
					await dG052ViewModel.NavigationService.NavigateAsync<DG057>();
				}
				else
				{
					await dG052ViewModel.NavigationService.NavigateAsync<PinCodePage, PinCodeViewModel>(delegate(PinCodeViewModel vm)
					{
						vm.Initialize(new PinCodeModel(PinEntryType.Authentication)
						{
							ChangeAppPin = true,
							BiometricEnabled = false
						});
					});
				}
			}));
		}
		bool flag = false;
		TwoFactorResponseModel twoFactorResponseModel = AsyncUtil.RunSync(accountInformationApi.GetTwoFactorStatus);
		if (twoFactorResponseModel != null && twoFactorResponseModel.ApiResult == ApiResult.Nok && twoFactorResponseModel.ErrorMessage == "no_username_password")
		{
			flag = true;
		}
		if (HttpSession.IsDeceased || flag)
		{
			return;
		}
		MenuItems.Add(new ActionMenuItem("TwoFactor", "DG052_2Stappen", "digidIconMenu2fa", async delegate
		{
			await sessionService.StartSession(async delegate
			{
				TwoFactorResponseModel enabled = await accountInformationApi.GetTwoFactorStatus();
				await dG052ViewModel.NavigationService.NavigateAsync<DG035C, DG035CViewModel>(delegate(DG035CViewModel vm)
				{
					vm.TwoFactorEnabled = enabled.Enabled;
				});
			}, startBiometrics: true);
		}));
	}
}
