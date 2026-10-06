using System.Collections.Generic;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls.Models;
using DigiD.Common.Enums;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Settings;
using DigiD.Mobile.Pages;
using Microsoft.Maui.ApplicationModel;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG059ViewModel : CommonBaseViewModel
{
	public List<MenuItem> PrimaryMenuItems { get; } = new List<MenuItem>();

	public List<MenuItem> SecondaryMenuItems { get; } = new List<MenuItem>();

	public DG059ViewModel(IMobileSettings mobileSettings, IAppRating ratingService)
	{
		base.CloseButtonVisible = true;
		PrimaryMenuItems.Add(new PageMenuItem<DG062>("Contact", "DG059_Contact", "digidIconMenuContact"));
		PrimaryMenuItems.Add(new PageMenuItem<DG063>("AboutTheApp", "DG059_OverdeApp", "iconMenuInfoOverDeApp"));
		PrimaryMenuItems.Add(new PageMenuItem<DG064>("Support", "DG059_Ondersteuning", "digidIconMenuOndersteuning"));
		if (mobileSettings.ActivationStatus == ActivationStatus.Activated)
		{
			SecondaryMenuItems.Add(new ActionMenuItem("Rate", "DG059_Beoordeel", "digidIconMenuRate", async delegate
			{
				await ratingService.PerformRatingOnStoreAsync("nl.rijksoverheid.digid.pub", "1208460960", "9MZBJ216SPCV");
			}, chevronVisible: false, isExternalLink: true));
		}
		SecondaryMenuItems.Add(new PageMenuItem<DG065>("Accessibility", "Alg_AccessibilityWebPageMenuItem", "digidIconMenuToegankelijkheid"));
		SecondaryMenuItems.Add(new ActionMenuItem("Privacy", "DG059_Privacy", "iconMenuExternalLink", async delegate
		{
			await Microsoft.Maui.ApplicationModel.Browser.OpenAsync("gTYB9n9QAVxraXhAhSXL/qOH6aV4Yw9/0H5llnXRvQCbKwPnbxM=".DeObfuscate("6UJ1hgxqLnMcHg9u4Uysl8eph8lXFG4L/RoM8Ry1knA="));
		}, chevronVisible: false, isExternalLink: true));
		SecondaryMenuItems.Add(new PageMenuItem<DG066>("OpenSource", "DG059_OpenSource", "digidIconOpensourceLibraries"));
	}
}
