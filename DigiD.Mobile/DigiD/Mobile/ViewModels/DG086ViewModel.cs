using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Resources;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Pages;
using Microsoft.Maui.ApplicationModel;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG086ViewModel(IPopupService popupService, IConfigurationService configurationService) : CommonBaseViewModel()
{
	private PinCodeModel? _pinCodeModel;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<bool>? nextCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? openLinkCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand<bool> NextCommand => nextCommand ?? (nextCommand = new AsyncRelayCommand<bool>(NextAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand OpenLinkCommand => openLinkCommand ?? (openLinkCommand = new AsyncRelayCommand(OpenLinkAsync));

	private Task OpenHelpdeskLink()
	{
		return Browser.OpenAsync(DigiDAppResources.DG086_Contact_Link, BrowserLaunchMode.SystemPreferred);
	}

	public void Initialize(PinCodeModel pinCodeModel)
	{
		_pinCodeModel = pinCodeModel;
		base.HeaderText = DigiDAppResources.DG086_Title;
		base.MessageText = string.Format(DigiDAppResources.DG086_Message, EIDSession.Card?.DocumentType.Translate().ToLower());
	}

	[RelayCommand]
	private Task NextAsync(bool pinChanged)
	{
		ArgumentNullException.ThrowIfNull(_pinCodeModel, "_pinCodeModel");
		_pinCodeModel.HasPinChanged = pinChanged;
		return base.NavigationService.NavigateAsync<PinCodePage, PinCodeViewModel>(delegate(PinCodeViewModel vm)
		{
			vm.IsCardAuthentication = true;
			vm.Initialize(_pinCodeModel);
		});
	}

	[RelayCommand]
	private async Task OpenLinkAsync()
	{
		string bottomSheetMessage = string.Format(DigiDAppResources.DG086_ButtomSheet_Message, configurationService.Configuration.LetterRequestDelay);
		await popupService.OpenBottomSheet("HLP16", DigiDAppResources.DG086_ButtomSheet_Title, bottomSheetMessage, DigiDAppResources.DG086_ButtomSheet_LinkText, OpenHelpdeskLink, actionAsButton: false);
	}
}
