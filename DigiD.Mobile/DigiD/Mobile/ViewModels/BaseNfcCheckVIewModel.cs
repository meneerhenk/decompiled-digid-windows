using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using DigiD.Common.BaseClasses;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Messages;
using DigiD.Mobile.Pages;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class BaseNfcCheckVIewModel(INfcService nfcService) : CommonBaseViewModel()
{
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? startScanCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand StartScanCommand => startScanCommand ?? (startScanCommand = new AsyncRelayCommand(StartScan));

	[RelayCommand]
	private async Task StartScan()
	{
		if (nfcService.IsNFCEnabled)
		{
			await Next();
			return;
		}
		WeakReferenceMessenger.Default.Register<ActivityFinishedMessage>(this, async delegate
		{
			await base.NavigationService.PopCurrentModalPage();
			if (nfcService.IsNFCEnabled)
			{
				await Next();
			}
			WeakReferenceMessenger.Default.Unregister<ActivityFinishedMessage>(this);
		});
		await base.NavigationService.PushModalAsync<FM065>();
	}

	protected virtual Task Next()
	{
		return Task.CompletedTask;
	}
}
