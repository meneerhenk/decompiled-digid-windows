using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Mobile.Interfaces;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class FM105ViewModel : CommonBaseViewModel
{
	private readonly IActivationService activationService;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? nextCommand;

	public static bool ButtonVisible => HttpSession.ActivationSessionData != null;

	public static string ContinueText => ButtonVisible ? CommonResources.FM105_Continue : CommonResources.FM105_CannotContinue;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand NextCommand => nextCommand ?? (nextCommand = new AsyncRelayCommand(NextAsync));

	public FM105ViewModel(IActivationService activationService)
	{
		this.activationService = activationService;
		base.HasBackButton = true;
	}

	[RelayCommand]
	private async Task NextAsync()
	{
		AppSession.RDASkipped = true;
		await activationService.SkipRda();
	}
}
