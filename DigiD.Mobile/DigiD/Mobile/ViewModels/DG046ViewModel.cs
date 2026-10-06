using System.Collections.Generic;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls.Models;
using DigiD.Common.Enums;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Pages;
using Microsoft.Maui.Devices;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG046ViewModel : CommonBaseViewModel
{
	private readonly IMobileSettings mobileSettings;

	private readonly IAppService appService;

	private readonly IBiometricService biometricService;

	public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();

	public DG046ViewModel(IMobileSettings mobileSettings, IAppService appService, IBiometricService biometricService)
	{
		this.mobileSettings = mobileSettings;
		this.appService = appService;
		this.biometricService = biometricService;
		base.CloseButtonVisible = true;
		LoadItems();
	}

	private void LoadItems()
	{
		MenuItems.Add(new PageMenuItem<DG047>("Language", "DG046_Taal", "iconTaalSelectie"));
		MenuItems.Add(new PageMenuItem<DG048>("Darkmode", "DG046_DarkMode", "iconInstellingenSwitchTheme"));
		MenuItems.Add(new PageMenuItem<DG049>("FontSize", "DG046_Lettergrootte", "digidIconMenuTekstgrootte"));
		MenuItems.Add(new PageMenuItem<DG071>("Dyslexie", "DG046_Dyslexie", "digidIconMenuDyslexieFont"));
		if (DeviceInfo.Platform == DevicePlatform.Android)
		{
			MenuItems.Add(new PageMenuItem<DG058>("Screenshots", "DG058_Title", "iconScreenshots"));
		}
		bool isAuthenticated = AppSession.IsAuthenticated;
		bool flag = isAuthenticated;
		if (flag)
		{
			BiometricHwStatus authenticationStatus = biometricService.AuthenticationStatus;
			bool flag2 = ((authenticationStatus == BiometricHwStatus.Success || (uint)(authenticationStatus - 7) <= 1u) ? true : false);
			flag = flag2;
		}
		if (flag)
		{
			string icon = string.Empty;
			string title = string.Empty;
			switch (AppSession.BiometricType)
			{
			case BiometricType.FingerPrint:
				icon = "digidIconMenuFingerprint";
				title = "DG046_Fingerprint";
				break;
			case BiometricType.TouchID:
				icon = "digidIconMenuTouchId";
				title = "DG046_TouchID";
				break;
			case BiometricType.FaceID:
				icon = "digidIconMenuFaceId";
				title = "DG046_FaceID";
				break;
			}
			MenuItems.Add(new PageMenuItem<DG089>("Biometrics", title, icon));
		}
		MenuItems.Add(new PageMenuItem<DG050>("Statistics", "DG046_Statistieken", "iconMenuVerzamelenStatistieken"));
		if (mobileSettings.ActivationStatus != ActivationStatus.NotActivated)
		{
			MenuItems.Add(new ActionMenuItem("Deactivate", "DG046_OpnieuwInstellen", "digidIconMenuAppDeactiveren", async delegate
			{
				await appService.Deactivate((mobileSettings.ActivationStatus == ActivationStatus.Pending) ? AlertMessageType.FM102 : AlertMessageType.FM068);
			}, chevronVisible: false));
		}
	}
}
