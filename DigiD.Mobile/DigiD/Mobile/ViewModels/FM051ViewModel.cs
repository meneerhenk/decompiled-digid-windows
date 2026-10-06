using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using DigiD.Mobile.Interfaces;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class FM051ViewModel : CommonBaseViewModel
{
	private readonly IActivationService activationService;

	private readonly IMobileSettings settings;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? requestNewLetterCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand RequestNewLetterCommand => requestNewLetterCommand ?? (requestNewLetterCommand = new AsyncRelayCommand(RequestNewLetterAsync));

	public FM051ViewModel(IActivationService activationService, IMobileSettings settings, IConfigurationService configurationService)
	{
		this.activationService = activationService;
		this.settings = settings;
		base.HasBackButton = false;
		base.CloseButtonVisible = true;
		base.MessageText = string.Format(CommonResources.FM051_Text1, configurationService.Configuration.LetterRequestDelay);
	}

	[RelayCommand]
	private async Task RequestNewLetterAsync()
	{
		ArgumentNullException.ThrowIfNull(HttpSession.AuthenticationResponse, "HttpSession.AuthenticationResponse");
		if (HttpSession.ActivationSessionData != null)
		{
			await activationService.StartActivationAsync(HttpSession.AuthenticationResponse);
			return;
		}
		AppSession.SetNextState();
		await base.NavigationService.PopToRootAsync();
	}

	protected override async Task CloseButtonClicked()
	{
		AppSession.ResetActivationState();
		settings.Reset();
		await base.NavigationService.PopToRootAsync();
	}
}
