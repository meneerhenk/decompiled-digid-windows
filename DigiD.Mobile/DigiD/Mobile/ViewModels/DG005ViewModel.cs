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
using DigiD.Common.Enums;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using DigiD.Mobile.Interfaces;
using Microsoft.Maui.Storage;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG005ViewModel : CommonBaseViewModel
{
	private readonly IEnrollmentApi api;

	private readonly IMobileSettings mobileSettings;

	private readonly IAlertService alertService;

	private readonly ILetterService letterService;

	private readonly IToastService toastService;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CCode_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CErrorMessage_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? validateCodeCommand;

	public static string InitialChar => "A";

	[ObservableProperty]
	[NotifyPropertyChangedFor("IsValidLength")]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? Code
	{
		get
		{
			return _003CCode_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CCode_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.Code);
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsValidLength);
				_003CCode_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.Code);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsValidLength);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? ErrorMessage
	{
		get
		{
			return _003CErrorMessage_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CErrorMessage_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.ErrorMessage);
				_003CErrorMessage_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.ErrorMessage);
			}
		}
	}

	public bool IsValidLength
	{
		get
		{
			if (Code != null)
			{
				if (Code.StartsWith(InitialChar, StringComparison.CurrentCultureIgnoreCase))
				{
					return Code.Length == 9;
				}
				string code = Code;
				return code != null && code.Length == 8;
			}
			return false;
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand ValidateCodeCommand => validateCodeCommand ?? (validateCodeCommand = new AsyncRelayCommand(ValidateCode, () => IsValidLength));

	public DG005ViewModel(IEnrollmentApi api, IMobileSettings mobileSettings, IAlertService alertService, ILetterService letterService, IToastService toastService)
	{
		this.api = api;
		this.mobileSettings = mobileSettings;
		this.alertService = alertService;
		this.letterService = letterService;
		this.toastService = toastService;
		base.MessageText = DigiDAppResources.DG005_Intro;
		base.HasBackButton = false;
		base.CloseButtonVisible = true;
	}

	[RelayCommand(CanExecute = "IsValidLength")]
	private async Task ValidateCode()
	{
		ArgumentNullException.ThrowIfNull(Code, "Code");
		base.DialogService.Show();
		string activationCode = Code.ToUpper();
		if (!activationCode.StartsWith(InitialChar))
		{
			activationCode = (InitialChar + Code).ToUpper();
		}
		LetterActivationRequest request = new LetterActivationRequest
		{
			ActivationCode = activationCode
		};
		ActivationSessionData? activationSessionData = HttpSession.ActivationSessionData;
		ActivationLetterResponse activationLetterResponse = ((activationSessionData == null || activationSessionData.ActivationMethod != ActivationMethod.AccountAndApp) ? (await api.CompleteLetterActivation(request)) : (await api.ActivateAccountByApp(request)));
		ActivationLetterResponse response = activationLetterResponse;
		await base.DialogService.Hide();
		switch (response.ApiResult)
		{
		case ApiResult.Ok:
			await HandleOk();
			break;
		case ApiResult.Nok:
			await HandleNok(response);
			break;
		case ApiResult.Blocked:
			await alertService.DisplayAlert(AlertMessageType.FM017);
			mobileSettings.Reset();
			await base.NavigationService.PopToRootAsync();
			break;
		case ApiResult.SessionNotFound:
			await base.ToastService.ShowError(CommonResources.x_SessionTimeoutMessage);
			break;
		case ApiResult.Disabled:
			await base.ToastService.ShowWarning(CommonResources.Alg_ActivationDisabledMessage);
			break;
		case ApiResult.HostNotReachable:
			await alertService.DisplayAlert(AlertMessageType.FM005);
			break;
		default:
			await base.ToastService.ShowWarning(CommonResources.Alg_LoginUnknownMessage);
			break;
		}
		Code = null;
	}

	private async Task HandleOk()
	{
		base.IsError = false;
		ActivationSessionData? activationSessionData = HttpSession.ActivationSessionData;
		if (activationSessionData != null && activationSessionData.ActivationMethod == ActivationMethod.AccountAndApp)
		{
			await toastService.ShowSuccess(DigiDAppResources.FM108_Text, DigiDAppResources.FM108_Title, popToRoot: false, ToastPriority.Normal);
			AppSession.SetNextState();
			await base.NavigationService.PopToRootAsync();
			return;
		}
		mobileSettings.ActivationStatus = ActivationStatus.Activated;
		letterService.Cancel();
		Preferences.Remove("LetterRequestDate");
		AppSession.RDASkipped = mobileSettings.LoginLevel == LoginLevel.Midden;
		AppSession.IsAppActivated = true;
		AppSession.ActivationStatus = mobileSettings.ActivationStatus;
		AppSession.SetNextState(AppActivationState.Completed);
		await base.NavigationService.PopToRootAsync();
	}

	private async Task HandleNok(ActivationLetterResponse response)
	{
		switch (response.ErrorMessage)
		{
		case "invalid":
		case "activation_code_not_correct":
			base.IsError = true;
			Code = null;
			if (base.A11YService.IsInVoiceOverMode)
			{
				await Task.Delay(2000);
			}
			base.PageId = "FM015";
			if (response.DateLetterSent.HasValue)
			{
				ErrorMessage = string.Format(CommonResources.FM015_Melding, response.DateLetterSent.Value.ToString("dd-MM-yyyy"));
			}
			else
			{
				ErrorMessage = DigiDAppResources.FM015_Melding_NoDate;
			}
			break;
		case "activation_code_invalid":
		case "activation_code_blocked":
			mobileSettings.Reset();
			await alertService.DisplayAlert(AlertMessageType.FM017);
			await base.NavigationService.PopToRootAsync();
			break;
		case "expired":
			mobileSettings.Reset();
			await alertService.DisplayAlert(AlertMessageType.FM018);
			await base.NavigationService.PopToRootAsync();
			break;
		}
	}
}
