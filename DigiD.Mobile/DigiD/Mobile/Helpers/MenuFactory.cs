using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DigiD.Common.Controls.Models;
using DigiD.Common.Enums;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Config;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Pages;
using DigiD.Mobile.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices;

namespace DigiD.Mobile.Helpers;

public static class MenuFactory
{
	private static readonly INavigationService NavigationService = AppSession.ServiceProvider.GetRequiredService<INavigationService>();

	private static readonly IMobileSettings MobileSettings = AppSession.ServiceProvider.GetRequiredService<IMobileSettings>();

	private static readonly IAccountInformationApi AccountInformationApi = AppSession.ServiceProvider.GetRequiredService<IAccountInformationApi>();

	private static readonly IRemoteNotificationService RemoteNotificationService = AppSession.ServiceProvider.GetRequiredService<IRemoteNotificationService>();

	private static readonly IDeviceLockService DeviceLockService = AppSession.ServiceProvider.GetRequiredService<IDeviceLockService>();

	private static readonly IAlertService AlertService = AppSession.ServiceProvider.GetRequiredService<IAlertService>();

	private static readonly PageMenuItem<DG046> SettingsPageMenuItem = new PageMenuItem<DG046>("Settings", "DG044_MenuInstellingen", "iconMenuInstellingen");

	private static readonly ActionMenuItem LogOutActionMenuItem = new ActionMenuItem("Logout", "DG044_MenuUitloggen", "digidIconMenuUitloggen", async delegate
	{
		if (await AlertService.DisplayAlert(AlertMessageType.FM066) == true)
		{
			DeviceLockService.Lock(userAction: true);
		}
	}, chevronVisible: false);

	private static readonly PageMenuItem<DG059> HelpPageMenuItem = new PageMenuItem<DG059>("HelpInfo", "DG044_MenuHulpInfo", "iconMenuFaq");

	public static List<DigiD.Common.Controls.Models.MenuItem> SecondMenuItems { get; private set; } = new List<DigiD.Common.Controls.Models.MenuItem>();

	public static List<DigiD.Common.Controls.Models.MenuItem> PrimaryMenuItems { get; private set; } = new List<DigiD.Common.Controls.Models.MenuItem>();

	private static List<DigiD.Common.Controls.Models.MenuItem> Items { get; } = new List<DigiD.Common.Controls.Models.MenuItem>();

	public static void BuildMainMenu()
	{
		Items.Clear();
		List<DigiD.Common.Controls.Models.MenuItem> list = new List<DigiD.Common.Controls.Models.MenuItem>();
		if (MobileSettings.ActivationStatus == ActivationStatus.Activated && AppSession.IsAuthenticated)
		{
			LoginLevel loginLevel = MobileSettings.LoginLevel;
			bool flag = (uint)(loginLevel - 2) <= 2u;
			if (flag && !HttpSession.IsDeceased && DeviceInfo.Idiom != DeviceIdiom.Desktop)
			{
				bool flag2 = MobileSettings.LoginLevel == LoginLevel.Midden || HttpSession.WillIDCheckExpire;
				Items.Add(new ActionMenuItem("IDcheck", "DG044_MenuIDcheck", flag2 ? "digidIconDocumentCheckAlert" : "digidIconDocumentCheckOk", async delegate
				{
					if (!AppSession.HasNfc)
					{
						await NavigationService.NavigateAsync<DG056>();
					}
					else if (!AppSession.IsKeyAttestationSupported || MobileSettings.KeyAttestationResult == KeyAttestationResult.Failed)
					{
						await NavigationService.NavigateAsync<DG019>();
					}
					else if (MobileSettings.LoginLevel == LoginLevel.Midden)
					{
						await NavigationService.NavigateAsync<DG017, DG017ViewModel>((Func<DG017ViewModel, Task>?)null, animated: true);
					}
					else
					{
						await NavigationService.NavigateAsync<DG055>();
					}
				})
				{
					State = ((MobileSettings.LoginLevel == LoginLevel.Midden) ? DigiDAppResources.DG044_UpgradeToSubNotPerformed : DigiDAppResources.DG044_UpgradeToSubPerformed)
				});
			}
			Task<AccountStatusResponse> task = Task.Run(async () => await AccountInformationApi.GetAccountStatus());
			AccountStatusResponse result = task.Result;
			ActionMenuItem messagesMenuItem = null;
			messagesMenuItem = new ActionMenuItem("Messages", "DG044_MenuBerichten", result.HasUnreadMessages ? "digidIconMenuBerichtenNieuweBericht" : "digidIconMenuBerichten", async delegate
			{
				await RemoteNotificationService.ConfirmShowNotifications();
				messagesMenuItem.IconSource = (ImageSource)Application.Current.Resources["digidIconMenuBerichten"];
				messagesMenuItem.State = null;
				DemoConfig.UnreadMessagesCount = 0;
			});
			if (result.HasUnreadMessages)
			{
				messagesMenuItem.State = CommonResources.x_NewNotificationsHeader;
			}
			Items.Add(messagesMenuItem);
			Items.Add(new PageMenuItem<DG052>("MyDigid", "DG044_MenuMijnDigiD", "digidIconMenuMijnDigid"));
		}
		list.Add(SettingsPageMenuItem);
		list.Add(HelpPageMenuItem);
		if (MobileSettings.ActivationStatus != ActivationStatus.NotActivated && AppSession.IsAuthenticated)
		{
			list.Add(LogOutActionMenuItem);
		}
		PrimaryMenuItems = ((Items.Count > 0) ? Items : list);
		if (Items.Count > 0)
		{
			SecondMenuItems = list;
		}
	}
}
