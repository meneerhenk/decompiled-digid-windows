using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Helpers;
using Microsoft.Maui.ApplicationModel;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class HLP007ViewModel : CommonBaseViewModel
{
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? openAnimationCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand OpenAnimationCommand => openAnimationCommand ?? (openAnimationCommand = new AsyncRelayCommand(OpenAnimationAsync));

	public HLP007ViewModel()
	{
		base.CloseButtonVisible = true;
		base.HasBackButton = false;
	}

	[RelayCommand]
	private static async Task OpenAnimationAsync()
	{
		await Browser.Default.OpenAsync("gTYB9n9QAVxraXhAhSXL/qOH6aV4ZxpqjWppn2zZ8x7GNBziaQUDGnJyYAmGKcK6qszz5DNxQ2+UfWWVMdTiAMZhRLQ8Xw==".DeObfuscate("6UJ1hgxqLnMcHg9u4Uysl8eph8lXFG4L/RoM8Ry1knA="), BrowserLaunchMode.SystemPreferred);
	}

	protected override async Task CloseButtonClicked()
	{
		await base.NavigationService.PopCurrentModalPage();
	}
}
