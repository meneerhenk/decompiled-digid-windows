using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Models.Responses;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Models;
using DigiD.Mobile.Pages;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG004ViewModel : CommonBaseViewModel
{
	private readonly IActivationService activationService;

	private readonly IEnrollmentApi enrollmentApi;

	private readonly IAppService appService;

	private readonly IPopupService popupService;

	private readonly IAlertService alertService;

	private bool _fromError;

	private int _seconds = -1;

	private RequestSmsResponse? _requestSmsResponse;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CSmsCode_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CErrorMessage_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CPhoneNumber_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? validateCodeCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? noSmsReceivedCommand;

	[ObservableProperty]
	[NotifyPropertyChangedFor("IsValid")]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? SmsCode
	{
		get
		{
			return _003CSmsCode_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CSmsCode_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.SmsCode);
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsValid);
				_003CSmsCode_003Ek__BackingField = value;
				OnSmsCodeChanged(value);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.SmsCode);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsValid);
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

	public bool IsValid
	{
		get
		{
			string smsCode = SmsCode;
			return smsCode != null && smsCode.Length == 6;
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand ValidateCodeCommand => validateCodeCommand ?? (validateCodeCommand = new AsyncRelayCommand(ValidateCodeAsync, () => IsValid));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand NoSmsReceivedCommand => noSmsReceivedCommand ?? (noSmsReceivedCommand = new AsyncRelayCommand(NoSmsReceivedAsync));

	public DG004ViewModel(IActivationService activationService, IEnrollmentApi enrollmentApi, IAppService appService, IPopupService popupService, IAlertService alertService)
	{
		this.activationService = activationService;
		this.enrollmentApi = enrollmentApi;
		this.appService = appService;
		this.popupService = popupService;
		this.alertService = alertService;
		if (base.A11YService.IsInVoiceOverMode)
		{
			SmsCode = string.Empty;
		}
		base.IsError = false;
		base.HasBackButton = false;
		base.CloseButtonVisible = true;
	}

	public void Initialize(RequestSmsResponse requestSmsResponse)
	{
		_requestSmsResponse = requestSmsResponse;
		if (requestSmsResponse.ApiResult != ApiResult.Ok && requestSmsResponse.ErrorMessage == "sms_too_fast")
		{
			Task.Run(async delegate
			{
				await ResendSms(false);
			});
		}
		else
		{
			PhoneNumber = requestSmsResponse.PhoneNumber;
		}
	}

	protected override async Task CloseButtonClicked()
	{
		bool? result = await popupService.DisplayAlert(CommonResources.x_ActivationAnnulerenAlertHeader, CommonResources.x_ActivationAnnulerenAlertMessage, CommonResources.Alg_Yes, CommonResources.Alg_No);
		if (result.HasValue && result.Value)
		{
			AppSession.ResetActivationState();
			await base.NavigationService.PopToRootAsync();
		}
	}

	[RelayCommand(CanExecute = "IsValid")]
	private async Task ValidateCodeAsync()
	{
		base.DialogService.Show();
		SessionResponse result = await activationService.InitSession(SmsCode);
		ApiResult apiResult = result.ApiResult;
		ApiResult apiResult2 = apiResult;
		if (apiResult2 == ApiResult.Ok)
		{
			ArgumentNullException.ThrowIfNull(result.AppId, "result.AppId");
			ActivationResult activationResult = await activationService.StartChallenge(result.AppId);
			if (activationResult.ApiResult == ApiResult.Ok)
			{
				ArgumentNullException.ThrowIfNull(activationResult.IV, "activationResult.IV");
				if (HttpSession.ActivationSessionData.ActivationMethod == ActivationMethod.SMS)
				{
					if (HttpSession.ActivationSessionData.Pin != null)
					{
						await activationService.ActivateAsync(HttpSession.ActivationSessionData.Pin, activationResult.IV, alternative: true);
					}
					else
					{
						HttpSession.ActivationSessionData.IV = activationResult.IV;
						AppSession.SetNextState();
						await base.NavigationService.PopToRootAsync();
					}
				}
				else
				{
					HttpSession.ActivationSessionData.IV = activationResult.IV;
					await base.NavigationService.NavigateAsync<DG005>();
				}
			}
		}
		else
		{
			await HandleError(result);
		}
		await base.DialogService.Hide();
	}

	private async Task HandleError(BaseResponse result)
	{
		_fromError = true;
		base.IsError = false;
		SmsCode = string.Empty;
		_fromError = false;
		switch (result.ErrorMessage)
		{
		case "smscode_incorrect":
		case "smscode_invalid":
			base.PageId = "FM012";
			ErrorMessage = CommonResources.FM012_Melding;
			break;
		case "smscode_blocked":
			await alertService.DisplayAlert(AlertMessageType.FM013);
			appService.Reset();
			await base.NavigationService.PopToRootAsync();
			return;
		case "smscode_not_send":
			ErrorMessage = DigiDAppResources.DG004_SMS_NotSend;
			break;
		case "smscode_expired":
			ErrorMessage = DigiDAppResources.DG004_SMS_Expired;
			break;
		default:
			ErrorMessage = "Response '" + result.ErrorMessage + "' not specified";
			break;
		}
		base.IsError = true;
		base.A11YService.Speak(ErrorMessage, 1000);
		WeakEventManager.HandleEvent(this, EventArgs.Empty, "ChangeFocus");
	}

	[RelayCommand]
	private async Task NoSmsReceivedAsync()
	{
		await base.NavigationService.NavigateAsync<HLP002, Hlp002ViewModel>(delegate(Hlp002ViewModel vm)
		{
			vm.Initialize(_requestSmsResponse?.PhoneNumber, ResendSms);
		});
	}

	private async Task ResendSms(bool? spoken)
	{
		if (spoken.HasValue && _seconds <= 0)
		{
			ResendSMSResponse result = await enrollmentApi.ResendSMS(spoken.Value);
			if (result.ApiResult == ApiResult.Ok)
			{
				PhoneNumber = result.PhoneNumber;
			}
			else
			{
				await HandleSmsTooFast(result, spoken.Value);
			}
		}
	}

	private async Task HandleSmsTooFast(BaseResponse response, bool spoken = false)
	{
		base.IsError = true;
		string errorMessage = response.ErrorMessage;
		string text = errorMessage;
		if (text == "sms_too_fast")
		{
			ArgumentNullException.ThrowIfNull(response.Payload, "response.Payload");
			SmsTooFastModel error = JsonSerializer.Deserialize<SmsTooFastModel>(response.Payload.ToString());
			for (_seconds = int.Parse(error.TimeLeft); _seconds > 0; _seconds--)
			{
				ErrorMessage = string.Format(CultureInfo.InvariantCulture, CommonResources.FM014_Melding, _seconds);
				await Task.Delay(1000);
			}
			PhoneNumber = (await enrollmentApi.ResendSMS(spoken)).PhoneNumber;
			_seconds = -1;
			base.IsError = false;
			if (base.IsError)
			{
				WeakEventManager.HandleEvent(this, EventArgs.Empty, "ChangeFocus");
			}
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnSmsCodeChanged(string? value)
	{
		if (!_fromError)
		{
			_seconds = -1;
			base.IsError = false;
			base.PageId = "DG004";
		}
	}
}
