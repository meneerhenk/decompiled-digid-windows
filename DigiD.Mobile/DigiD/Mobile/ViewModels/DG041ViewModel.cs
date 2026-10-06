using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Mobile.Pages;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG041ViewModel(IAlertService service) : CommonBaseViewModel()
{
	private Func<Task>? _nextAction;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? skipScanCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? nextCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand SkipScanCommand => skipScanCommand ?? (skipScanCommand = new AsyncRelayCommand(SkipScanAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand NextCommand => nextCommand ?? (nextCommand = new AsyncRelayCommand(NextAsync));

	public void Initialize(string? webservice, Func<Task> nextAction)
	{
		_nextAction = nextAction;
		ArgumentNullException.ThrowIfNull(HttpSession.WebSessionInfoResponse, "HttpSession.WebSessionInfoResponse");
		ArgumentNullException.ThrowIfNull(webservice, "webservice");
		base.MessageText = string.Format(DigiDAppResources.DG041_Intro, webservice, HttpSession.WebSessionInfoResponse.NewAuthenticationLevelStartDate.Value.ToString("dd-MM-yyyy"));
	}

	[RelayCommand]
	private async Task SkipScanAsync()
	{
		await service.DisplayAlert(AlertMessageType.FM016);
		if (_nextAction != null)
		{
			await _nextAction();
		}
	}

	[RelayCommand]
	private async Task NextAsync()
	{
		await base.NavigationService.NavigateAsync<DG017, DG017ViewModel>((Func<DG017ViewModel, Task>?)null, animated: true);
	}
}
