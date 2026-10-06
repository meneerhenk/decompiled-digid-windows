using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using Microsoft.Maui.ApplicationModel;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class HLP001ViewModel : CommonBaseViewModel
{
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? noDigiDCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? recoverPasswordCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? recoverUserNameCommand;

	private string LanguageSuffix
	{
		get
		{
			string language = base.GeneralPreferences.Language;
			if (1 == 0)
			{
			}
			string result;
			switch (language)
			{
			case "en":
				result = "/en";
				break;
			case "pap":
			case "es":
				result = "/pap";
				break;
			default:
				result = string.Empty;
				break;
			}
			if (1 == 0)
			{
			}
			return result;
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand NoDigiDCommand => noDigiDCommand ?? (noDigiDCommand = new AsyncRelayCommand(NoDigiDAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand RecoverPasswordCommand => recoverPasswordCommand ?? (recoverPasswordCommand = new AsyncRelayCommand(RecoverPasswordAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand RecoverUserNameCommand => recoverUserNameCommand ?? (recoverUserNameCommand = new AsyncRelayCommand(RecoverUserNameAsync));

	public HLP001ViewModel()
	{
		base.PageId = "HLP001";
		base.HasBackButton = false;
		base.CloseButtonVisible = true;
	}

	[RelayCommand]
	private Task<bool> NoDigiDAsync()
	{
		Uri uri = new Uri("https://" + base.GeneralPreferences.SelectedHost + LanguageSuffix + "/aanvragen");
		return Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
	}

	[RelayCommand]
	private Task<bool> RecoverPasswordAsync()
	{
		Uri uri = new Uri("https://" + base.GeneralPreferences.SelectedHost + LanguageSuffix + "/herstellen/persoonsgegevens");
		return Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
	}

	[RelayCommand]
	private Task<bool> RecoverUserNameAsync()
	{
		Uri uri = new Uri("https://" + base.GeneralPreferences.SelectedHost + LanguageSuffix + "/herstellen/gebruikersnaam/opvragen_via_digid");
		return Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
	}

	protected override Task CloseButtonClicked()
	{
		return base.NavigationService.PopCurrentModalPage();
	}
}
