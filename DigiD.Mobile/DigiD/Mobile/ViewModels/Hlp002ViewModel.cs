using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Mobile.Interfaces;
using Microsoft.Maui.ApplicationModel;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class Hlp002ViewModel(IPopupService popupService, IActivationService activationService, IConfigurationService configurationService) : CommonBaseViewModel()
{
	private Func<bool?, Task>? _returnAction;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CPhoneNumber_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<string>? resendSMSCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? changePhoneNumberCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? openBottomSheetCommand;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? PhoneNumber
	{
		get
		{
			return _003CPhoneNumber_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CPhoneNumber_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.PhoneNumber);
				_003CPhoneNumber_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.PhoneNumber);
			}
		}
	}

	public static bool CanRequestLetter
	{
		get
		{
			ActivationSessionData? activationSessionData = HttpSession.ActivationSessionData;
			return activationSessionData == null || activationSessionData.ActivationMethod != ActivationMethod.AccountAndApp;
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand<string> ResendSMSCommand => resendSMSCommand ?? (resendSMSCommand = new AsyncRelayCommand<string>(ResendSMSAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand ChangePhoneNumberCommand => changePhoneNumberCommand ?? (changePhoneNumberCommand = new AsyncRelayCommand(ChangePhoneNumber));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand OpenBottomSheetCommand => openBottomSheetCommand ?? (openBottomSheetCommand = new AsyncRelayCommand(OpenBottomSheet));

	public void Initialize(string? number, Func<bool?, Task> returnAction)
	{
		base.PageId = "HLP002";
		_returnAction = returnAction;
		PhoneNumber = number;
		base.HasBackButton = false;
		base.CloseButtonVisible = true;
	}

	protected override async Task CloseButtonClicked()
	{
		await base.NavigationService.PopAsync();
		if (_returnAction != null)
		{
			await _returnAction(null);
		}
	}

	[RelayCommand]
	private async Task ResendSMSAsync(string spoken)
	{
		await base.NavigationService.PopAsync();
		if (_returnAction != null)
		{
			await _returnAction(spoken == "1");
		}
	}

	[RelayCommand]
	private static async Task ChangePhoneNumber()
	{
		await Browser.OpenAsync("https://mijn.digid.nl");
	}

	private async Task ActivateWithLetter()
	{
		await base.NavigationService.PopAsync();
		base.DialogService.Show();
		HttpSession.ActivationSessionData.ActivationMethod = ActivationMethod.Password;
		await activationService.StartActivationAsync(null, useLetter: true);
	}

	[RelayCommand]
	private Task OpenBottomSheet()
	{
		string message = string.Format(DigiDAppResources.BS002_Text, configurationService.Configuration.LetterRequestDelay);
		return popupService.OpenBottomSheet("BS002", DigiDAppResources.BS002_Title, message, DigiDAppResources.BS002_BtnText, ActivateWithLetter, actionAsButton: true, firstCloseThenExecuteAction: true);
	}
}
