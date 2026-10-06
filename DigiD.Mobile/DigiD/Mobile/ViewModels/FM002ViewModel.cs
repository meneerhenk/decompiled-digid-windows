using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Preferences;
using Microsoft.Maui.ApplicationModel;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class FM002ViewModel : CommonBaseViewModel
{
	private VersionCheckResponse? _response;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? openUpdateUrlCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand OpenUpdateUrlCommand => openUpdateUrlCommand ?? (openUpdateUrlCommand = new AsyncRelayCommand(OpenUpdateUrlAsync));

	public FM002ViewModel()
	{
		base.HasBackButton = false;
	}

	public void Initialize(VersionCheckResponse response)
	{
		_response = response;
		switch (response.VersionAction)
		{
		case VersionState.Warning:
			base.PageId = "FM002A";
			base.CloseButtonVisible = true;
			break;
		case VersionState.ForcedUpdate:
			base.PageId = "FM002B";
			break;
		case VersionState.Kill:
			base.PageId = "FM002C";
			break;
		}
	}

	[RelayCommand]
	private async Task OpenUpdateUrlAsync()
	{
		ArgumentNullException.ThrowIfNull(_response, "_response");
		if (_response.UpdateUrl != null)
		{
			await Browser.OpenAsync(new Uri(_response.UpdateUrl), BrowserLaunchMode.External);
		}
		if (DemoSettings.IsDemoModeEnabled)
		{
			await base.NavigationService.PopCurrentModalPage();
		}
	}

	protected override async Task CloseButtonClicked()
	{
		await base.NavigationService.PopCurrentModalPage();
	}
}
