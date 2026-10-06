using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.SessionModels;
using DigiD.Mobile.Interfaces;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG018ViewModel : CommonBaseViewModel
{
	private readonly IActivationService activationService;

	private readonly IEnrollmentApi enrollmentApi;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? noDocumentCommand;

	public static bool NoDocumentsButtonVisible => HttpSession.ActivationSessionData != null;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand NoDocumentCommand => noDocumentCommand ?? (noDocumentCommand = new AsyncRelayCommand(NoDocumentAsync));

	public DG018ViewModel(IActivationService activationService, IEnrollmentApi enrollmentApi)
	{
		this.activationService = activationService;
		this.enrollmentApi = enrollmentApi;
		base.CloseButtonVisible = true;
		base.HasBackButton = false;
	}

	[RelayCommand]
	private async Task NoDocumentAsync()
	{
		AppSession.RDASkipped = true;
		bool flag;
		switch (HttpSession.ActivationSessionData?.ActivationMethod)
		{
		case ActivationMethod.App:
		case ActivationMethod.AccountAndApp:
		case ActivationMethod.RequestNewDigidAccount:
			flag = true;
			break;
		default:
			flag = false;
			break;
		}
		if (flag)
		{
			await enrollmentApi.SkipRda();
			AppSession.SetNextState();
			await base.NavigationService.PopToRootAsync();
		}
		else if (HttpSession.ActivationSessionData != null)
		{
			await activationService.SkipRda();
		}
	}
}
