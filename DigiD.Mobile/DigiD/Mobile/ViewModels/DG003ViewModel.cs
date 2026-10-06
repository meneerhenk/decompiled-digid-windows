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
using DigiD.Common.Preferences;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Models;
using DigiD.Mobile.Pages;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.ApplicationModel;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG003ViewModel : CommonBaseViewModel
{
	private readonly ISslPinningService sslPinningService;

	private readonly IActivationService activationService;

	private readonly IAlertService alertService;

	private bool _canTap = true;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CUserName_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CPassword_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CErrorMessage_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? loginCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? forgotUserNameCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? noDigiDCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? otherMethodsCommand;

	public bool IsValid => !string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password);

	[ObservableProperty]
	[NotifyPropertyChangedFor("IsValid")]
	[NotifyCanExecuteChangedFor("LoginCommand")]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? UserName
	{
		get
		{
			return _003CUserName_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CUserName_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.UserName);
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsValid);
				_003CUserName_003Ek__BackingField = value;
				OnUserNameChanged(value);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.UserName);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsValid);
				LoginCommand.NotifyCanExecuteChanged();
			}
		}
	}

	[ObservableProperty]
	[NotifyPropertyChangedFor("IsValid")]
	[NotifyCanExecuteChangedFor("LoginCommand")]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? Password
	{
		get
		{
			return _003CPassword_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CPassword_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.Password);
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsValid);
				_003CPassword_003Ek__BackingField = value;
				OnPasswordChanged(value);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.Password);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsValid);
				LoginCommand.NotifyCanExecuteChanged();
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

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand LoginCommand => loginCommand ?? (loginCommand = new AsyncRelayCommand(LoginAsync, () => IsValid));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand ForgotUserNameCommand => forgotUserNameCommand ?? (forgotUserNameCommand = new AsyncRelayCommand(ForgotUserNameAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand NoDigiDCommand => noDigiDCommand ?? (noDigiDCommand = new AsyncRelayCommand(NoDigiDAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand OtherMethodsCommand => otherMethodsCommand ?? (otherMethodsCommand = new AsyncRelayCommand(OtherMethodsAsync));

	public DG003ViewModel(ISslPinningService sslPinningService, IActivationService activationService, IAlertService alertService)
	{
		this.alertService = alertService;
		this.sslPinningService = sslPinningService;
		this.activationService = activationService;
		base.CloseButtonVisible = false;
	}

	[RelayCommand(CanExecute = "IsValid")]
	private async Task LoginAsync()
	{
		if (_canTap)
		{
			_canTap = false;
			HttpSession.ActivationSessionData = null;
			await StartLoginAsync();
			_canTap = true;
		}
	}

	protected async Task StartLoginAsync()
	{
		if (!IsValid)
		{
			return;
		}
		base.DialogService.Show();
		bool flag = !DemoSettings.IsDemoModeEnabled;
		bool flag2 = flag;
		if (flag2)
		{
			flag2 = !(await sslPinningService.SslPinningCheck());
		}
		if (flag2)
		{
			await base.DialogService.Hide();
			await base.ToastService.ShowWarning(CommonResources.SSLWarningMessage);
			return;
		}
		if (UserName != null && Password != null)
		{
			BasicAuthenticationResponse response = await activationService.LoginAsync(UserName, Password, !AppSession.HasNfc);
			Password = string.Empty;
			if (response != null)
			{
				await HandleResponse(response);
			}
		}
		await base.DialogService.Hide();
	}

	protected async Task HandleResponse(BasicAuthenticationResponse result)
	{
		switch (result.ApiResult)
		{
		case ApiResult.TrafficMetered:
			await alertService.DisplayAlert(AlertMessageType.FM100);
			break;
		case ApiResult.Maintenance:
			await alertService.DisplayAlert(AlertMessageType.FM104);
			break;
		case ApiResult.Ok:
			if (result != null)
			{
				if (result.PendingActivation && !AppSession.HasNfc)
				{
					HttpSession.AuthenticationResponse = result;
					await base.NavigationService.NavigateAsync<FM051>();
					break;
				}
				ActivationMethod activationMethod = result.ActivationMethod;
				ActivationMethod activationMethod2 = activationMethod;
				if (activationMethod2 != ActivationMethod.SMS)
				{
					if (activationMethod2 == ActivationMethod.AccountAndApp)
					{
						goto IL_0357;
					}
				}
				else if (!AppSession.HasNfc || !AppSession.IsKeyAttestationSupported)
				{
					goto IL_0357;
				}
			}
			AppSession.SetNextState();
			await base.DialogService.Hide();
			HttpSession.AuthenticationResponse = result;
			await base.NavigationService.PopToRootAsync();
			break;
		case ApiResult.Nok:
			await HandleNok(result);
			break;
		case ApiResult.Timeout:
			await base.ToastService.ShowError(CommonResources.Alg_UnknownErrorOccurred);
			break;
		case ApiResult.Disabled:
			await base.ToastService.ShowWarning(CommonResources.Alg_ActivationDisabledMessage);
			break;
		case ApiResult.HostNotReachable:
			await alertService.DisplayAlert(AlertMessageType.FM005);
			break;
		case ApiResult.SessionNotFound:
			await base.ToastService.ShowError(CommonResources.x_SessionTimeoutMessage);
			break;
		case ApiResult.SSLPinningError:
			await base.ToastService.ShowWarning(CommonResources.SSLWarningMessage);
			break;
		default:
			{
				await base.ToastService.ShowWarning(CommonResources.x_ActivationFailedMessage);
				break;
			}
			IL_0357:
			await activationService.StartActivationAsync(result);
			break;
		}
	}

	[RelayCommand]
	private Task ForgotUserNameAsync()
	{
		return base.NavigationService.PushModalAsync<HLP001>();
	}

	[RelayCommand]
	private Task<bool> NoDigiDAsync()
	{
		return Browser.OpenAsync(DigiDAppResources.DG003_RequestAccountLink, BrowserLaunchMode.External);
	}

	[RelayCommand]
	private Task OtherMethodsAsync()
	{
		return base.NavigationService.NavigateAsync<DG006>();
	}

	private void ResetErrorIfNecessary(string? value)
	{
		if (!string.IsNullOrEmpty(value) && base.IsError)
		{
			base.IsError = false;
			ErrorMessage = "";
		}
	}

	protected async Task HandleNok(BaseResponse result)
	{
		await base.DialogService.Hide();
		switch (result.ErrorMessage)
		{
		case "invalid":
			base.PageId = "FM006";
			UserName = string.Empty;
			Password = string.Empty;
			ErrorMessage = CommonResources.FM006_Melding;
			break;
		case "request_for_account_basic":
			if (result is BasicAuthenticationResponse)
			{
				await base.ServiceProvider.GetRequiredService<IGeneralApi>().Cancel();
			}
			await base.ToastService.ShowWarning(CommonResources.x_AccountNotYetActivated);
			return;
		case "account_inactive":
			base.PageId = "FM009";
			ErrorMessage = CommonResources.FM009_Melding;
			break;
		case "account_blocked":
			base.PageId = "FM007";
			ArgumentNullException.ThrowIfNull(result.Payload, "result.Payload");
			ErrorMessage = string.Format(arg0: JsonSerializer.Deserialize<AccountBlockedModel>(result.Payload.ToString()).minutes, provider: CultureInfo.InvariantCulture, format: CommonResources.x_SingleDeviceAccountBlocked);
			break;
		case "no_bsn_on_account":
			base.PageId = "FM008";
			ErrorMessage = CommonResources.x_SingleDeviceNoBSNOnAccount;
			break;
		case "too_many_active":
		{
			BasicAuthenticationResponse basicAuthenticationResponse = result as BasicAuthenticationResponse;
			if (basicAuthenticationResponse == null)
			{
				break;
			}
			await base.NavigationService.PushModalAsync<FM011, FM011ViewModel>(delegate(FM011ViewModel vm)
			{
				vm.Initialize(basicAuthenticationResponse, async delegate
				{
					HttpSession.RemoveOldApp = true;
					if (!AppSession.HasNfc)
					{
						await StartLoginAsync();
					}
					else
					{
						AppSession.SetNextState();
						await base.NavigationService.PopToRootAsync();
					}
				});
			});
			return;
		}
		case "classified_deceased":
			await alertService.DisplayAlert(AlertMessageType.FM010);
			AppSession.Reset();
			await base.NavigationService.PopToRootAsync();
			return;
		}
		base.IsError = true;
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnUserNameChanged(string? value)
	{
		ResetErrorIfNecessary(value);
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnPasswordChanged(string? value)
	{
		ResetErrorIfNecessary(value);
	}
}
