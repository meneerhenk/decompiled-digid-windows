using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using DigiD.Common.BaseClasses;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Messages;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class FM065ViewModel : CommonBaseViewModel
{
	private readonly INfcService nfcService;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private RelayCommand? openSettingsCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand OpenSettingsCommand => openSettingsCommand ?? (openSettingsCommand = new RelayCommand(OpenSettings));

	public FM065ViewModel(INfcService nfcService)
	{
		this.nfcService = nfcService;
		base.HasBackButton = false;
		base.CloseButtonVisible = true;
	}

	[RelayCommand]
	private void OpenSettings()
	{
		nfcService.OpenNFCSettings();
	}

	protected override Task CloseButtonClicked()
	{
		WeakReferenceMessenger.Default.Send(new ActivityFinishedMessage(IsCancelled: true));
		return Task.CompletedTask;
	}
}
