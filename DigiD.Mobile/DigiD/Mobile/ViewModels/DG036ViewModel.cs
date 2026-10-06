using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Mobile.Pages;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG036ViewModel : CommonBaseViewModel
{
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<string>? backToPageCommand;

	public static bool IsSuffixVisible => !string.IsNullOrEmpty(DG012ViewModel.SelectedHouseNumberSuffix);

	public static string DateOfBirth => $"{DG011ViewModel.SelectedDay} {DG011ViewModel.SelectedMonth} {DG011ViewModel.SelectedYear}";

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand<string> BackToPageCommand => backToPageCommand ?? (backToPageCommand = new AsyncRelayCommand<string>(BackToPage));

	[RelayCommand]
	private async Task BackToPage(string pageId)
	{
		switch (pageId)
		{
		case "DG010":
			await base.NavigationService.PopToAsync<DG010>();
			break;
		case "DG011":
			await base.NavigationService.PopToAsync<DG011>();
			break;
		case "DG012":
			await base.NavigationService.PopToAsync<DG012>();
			break;
		}
	}
}
