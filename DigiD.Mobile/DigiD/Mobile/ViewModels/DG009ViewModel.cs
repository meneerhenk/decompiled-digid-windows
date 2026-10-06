using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Helpers;
using DigiD.Common.Resources;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Pages;
using Microsoft.Maui.ApplicationModel;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG009ViewModel : CommonBaseViewModel
{
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? requestDigiDCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? requestDigiDAbroadCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand RequestDigiDCommand => requestDigiDCommand ?? (requestDigiDCommand = new AsyncRelayCommand(RequestDigiDAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand RequestDigiDAbroadCommand => requestDigiDAbroadCommand ?? (requestDigiDAbroadCommand = new AsyncRelayCommand(RequestDigiDAbroadAsync));

	public DG009ViewModel(IConfigurationService configurationService)
	{
		base.PageId = "DG009";
		base.MessageText = string.Format(DigiDAppResources.DG009_InfoAanvragen, configurationService.Configuration.LetterRequestDelay);
	}

	[RelayCommand]
	private async Task RequestDigiDAsync()
	{
		DG010ViewModel.SelectedBsn = string.Empty;
		DG011ViewModel.SelectedDateOfBirth = null;
		DG012ViewModel.SelectedHouseNumber = null;
		DG012ViewModel.SelectedHouseNumberSuffix = null;
		DG012ViewModel.SelectedPostalCode = null;
		base.DialogService.Show();
		await base.NavigationService.NavigateAsync<DG010>();
		await base.DialogService.Hide();
	}

	[RelayCommand]
	private static async Task RequestDigiDAbroadAsync()
	{
		await Browser.OpenAsync("gTYB9n9QAVx4d2gHhWLC++jI5qchZg9smHRTk2nc5hWHLhToaA==".DeObfuscate("6UJ1hgxqLnMcHg9u4Uysl8eph8lXFG4L/RoM8Ry1knA="));
	}
}
