using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG042ViewModel : CommonBaseViewModel
{
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? nextCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand NextCommand => nextCommand ?? (nextCommand = new AsyncRelayCommand(NextAsync));

	public void Initialize(string? webservice)
	{
		ArgumentNullException.ThrowIfNull(HttpSession.WebSessionInfoResponse, "HttpSession.WebSessionInfoResponse");
		ArgumentNullException.ThrowIfNull(webservice, "webservice");
		base.MessageText = string.Format(DigiDAppResources.DG041_Intro, webservice, HttpSession.WebSessionInfoResponse.NewAuthenticationLevelStartDate.Value.ToString("dd-MM-yyyy"));
	}

	[RelayCommand]
	private async Task NextAsync()
	{
		await base.NavigationService.PopToRootAsync();
	}
}
