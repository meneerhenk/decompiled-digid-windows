using System;
using System.Globalization;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.CardOperations;
using DigiD.Common.EID.Demo;
using DigiD.Common.EID.Enums;
using DigiD.Common.EID.Exceptions;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Enums;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Nfc;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.NFC.Enums;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices;

namespace DigiD.Common.ViewModels;

public abstract class EidViewModel : BaseNfcViewModel
{
	private readonly IEIDOperationService eIdOperationService;

	private readonly IEIDApi eIdApi;

	private readonly IConfirmService confirmService;

	private readonly IToastService toastService;

	private readonly IDeviceLockService deviceLockService;

	private bool _isTagLost;

	protected readonly IAlertService AlertService;

	private bool _executionCompleted;

	protected bool IsScanning { get; set; }

	public static string DocumentName => (EIDSession.Card != null) ? EIDSession.Card.DocumentType.Translate().ToLowerInvariant() : CommonResources.eID.ToLowerInvariant();

	public NfcScannerModel Model { get; private set; } = new NfcScannerModel(PinEntryType.Authentication);

	protected abstract Task GoToPinCodePage(PinCodeModel model);

	protected abstract Task PopToRoot();

	protected abstract Task AttestApp();

	protected abstract Task ActionCompleted(MessageType successMessageType);

	protected abstract Task DeactivateApp();

	protected abstract Task NavigateToOverview(PinCodeModel? pinCodeModel);

	protected EidViewModel(IEIDOperationService eIdOperationService, IEIDApi eIdApi, IAlertService alertService, IConfirmService confirmService, IToastService toastService, IDeviceLockService deviceLockService)
	{
		this.eIdOperationService = eIdOperationService;
		this.eIdApi = eIdApi;
		this.confirmService = confirmService;
		this.toastService = toastService;
		this.deviceLockService = deviceLockService;
		AlertService = alertService;
		base.HasBackButton = false;
		base.CloseButtonVisible = true;
		base.DocumentType = EIDSession.Card?.DocumentType ?? DocumentType.Generic;
		if (DeviceInfo.Platform == DevicePlatform.Android)
		{
			base.PageId = "DG051";
		}
		else if (DeviceInfo.Platform == DevicePlatform.iOS || DeviceInfo.Platform == DevicePlatform.MacCatalyst)
		{
			base.PageId = "DG022";
		}
		else
		{
			base.PageId = "DSK08";
		}
		CancelAsync = new AsyncRelayCommand<bool>(CancelAction);
	}

	protected abstract Task CancelAction(bool retry);

	public void Initialize(NfcScannerModel model)
	{
		Model = model;
	}

	protected override async Task CloseButtonClicked()
	{
		await base.ServiceProvider.GetRequiredService<IEIDApi>().CancelAuthenticate();
		await NfcService.StopScanningAsync();
		IsScanning = false;
		await PopToRoot();
	}

	protected override Task OnNavigatingTo(NavigatedToEventArgs args)
	{
		if (!IsScanning && !_executionCompleted)
		{
			MainThread.InvokeOnMainThreadAsync(async delegate
			{
				await StartScan(retry: false);
			});
		}
		return base.OnNavigatingTo(args);
	}

	protected override async Task OnAppearing()
	{
		await base.DialogService.Hide();
		await base.OnAppearing();
	}

	public async Task Start()
	{
		base.ProgressVisible = true;
		IsScanning = true;
		_isTagLost = false;
		NfcService.IsCancelled = false;
		switch (Model.EntryType)
		{
		case PinEntryType.Authentication:
			if (Model.IsStatusChecked)
			{
				await Randomize();
			}
			else
			{
				await StatusCheck(PasswordType.PIN);
			}
			break;
		case PinEntryType.ChangePIN_PIN:
			if (Model.IsStatusChecked)
			{
				await ChangePin(PasswordType.PIN);
			}
			else
			{
				await StatusCheck(PasswordType.PIN);
			}
			break;
		case PinEntryType.ResumePIN_CAN:
			if (Model.IsStatusChecked)
			{
				await ResumePin();
			}
			else
			{
				await StatusCheck(PasswordType.PIN);
			}
			break;
		case PinEntryType.ChangeTransportPIN:
			await ChangePin(PasswordType.PIN);
			break;
		}
	}

	public virtual Task RandomizationComplete()
	{
		return Task.CompletedTask;
	}

	private async Task HandleStatusOperation(BaseSecureCardOperation operation)
	{
		ArgumentNullException.ThrowIfNull(operation.GAP, "operation.GAP");
		if (operation.GAP.IsBlocked)
		{
			if (operation.GAP.PasswordType != PasswordType.PUK)
			{
				await HandlePINBlocked();
				return;
			}
			await eIdApi.AbortAuthentication(new AbortAuthenticationRequest("puk_blocked"));
			await toastService.ShowError(CommonResources.x_WIDPUKBlockedMessage);
			await PopToRoot();
			return;
		}
		PinCodeModel model;
		if (operation.GAP.IsSuspended)
		{
			model = new PinCodeModel(PinEntryType.ResumePIN_CAN, null, Model.EIDSessionResponse);
		}
		else
		{
			PinEntryType entryType = Model.EntryType;
			PinEntryType pinEntryType = entryType;
			if (pinEntryType == PinEntryType.ChangePIN_PIN)
			{
				if (operation.GAP.PasswordType == PasswordType.PUK)
				{
					await AlertService.DisplayAlert(AlertMessageType.FM082);
					await PopToRoot();
					return;
				}
				model = new PinCodeModel(Model.EntryType, null, null, operation.GAP.PinTriesLeft);
			}
			else
			{
				if (Model.EIDSessionResponse != null && operation.GAP.PasswordType == PasswordType.PUK)
				{
					await eIdApi.AbortAuthentication(new AbortAuthenticationRequest("pin_blocked"));
					await AlertService.DisplayAlert(AlertMessageType.FM082);
					await PopToRoot();
					return;
				}
				model = new PinCodeModel(PinEntryType.Authentication, null, Model.EIDSessionResponse, operation.GAP.PinTriesLeft);
			}
		}
		model.IsStatusChecked = true;
		model.IsWIDActivation = Model.IsActivation;
		model.NeedAppDeactivation = Model.NeedAppDeactivation;
		if (model.EntryType == PinEntryType.ResumePIN_CAN)
		{
			await AlertService.DisplayAlert(AlertMessageType.FM084);
		}
		await GoToPinCodePage(model);
	}

	private async Task ExecuteOperation(BaseSecureCardOperation operation)
	{
		_executionCompleted = false;
		try
		{
			bool success = await operation.Execute();
			ArgumentNullException.ThrowIfNull(operation.GAP, "operation.GAP");
			_executionCompleted = true;
			base.WaitForRemoval = false;
			if (DeviceInfo.Platform == DevicePlatform.Android)
			{
				if (success)
				{
					base.WaitForRemoval = true;
				}
				else if (Model.IsActivation && operation.GAP.ChangePinRequired)
				{
					base.WaitForRemoval = true;
				}
			}
			if ((Model.IsActivation && operation.GAP.ChangePinRequired) || operation.GAP.AuthenticationResult == AuthenticationResult.Failed)
			{
				base.ProgressValue = 1.0;
			}
			await NfcService.StopScanningAsync(null, waitForDisconnect: true);
			IsScanning = false;
			if (NfcService.IsCancelled)
			{
				await base.ServiceProvider.GetRequiredService<IEIDApi>().CancelAuthenticate();
				if (Model.EIDSessionResponse != null)
				{
					await base.ToastService.ShowWarning(CommonResources.Alg_LoginAbortedMessage, null, popToRoot: false);
				}
				await PopToRoot();
				return;
			}
			if (operation is StatusOperation || (operation is DemoCardOperation && !Model.IsStatusChecked))
			{
				await HandleStatusOperation(operation);
			}
			else if (success)
			{
				await Task.Delay(1500);
				if (operation is RandomizeOperation)
				{
					goto IL_077d;
				}
				if (operation is DemoCardOperation demoCardOperation)
				{
					switch (demoCardOperation.OperationType)
					{
					case CardOperationType.Authentication:
						goto IL_077d;
					case CardOperationType.ChangePin:
						goto IL_07ea;
					case CardOperationType.ResumePin:
						goto IL_0855;
					}
				}
				else
				{
					if (operation is ChangePinOperation)
					{
						goto IL_07ea;
					}
					if (operation is ResumeOperation)
					{
						goto IL_0855;
					}
				}
			}
			else
			{
				if (_isTagLost)
				{
					return;
				}
				if (EIDSession.Card?.EF_Dir == null)
				{
					await base.ServiceProvider.GetRequiredService<IEIDApi>().CancelAuthenticate();
					await AlertService.DisplayAlert(AlertMessageType.FM081);
					await PopToRoot();
				}
				else if (operation.GAP.IsBlocked)
				{
					await HandlePINBlocked();
				}
				else if (operation.GAP.IsSuspended && Model.EIDSessionResponse == null)
				{
					await base.ToastService.ShowWarning(string.Format(CommonResources.WIDSuspendedMessage, DocumentName), null, popToRoot: false);
					await PopToRoot();
				}
				else if (Model.IsActivation && operation.GAP.ChangePinRequired)
				{
					PinCodeModel model = new PinCodeModel(PinEntryType.ChangeTransportPIN, null, Model.EIDSessionResponse)
					{
						IsWIDActivation = true,
						PIN = Model.Pin,
						IsStatusChecked = Model.IsStatusChecked,
						NeedPinChange = true,
						NeedAppDeactivation = Model.NeedAppDeactivation
					};
					EIDSession.ActivationState++;
					EIDSession.TransportPINChange = true;
					await NavigateToOverview(model);
				}
				else if (operation.GAP.ChangePinRequired)
				{
					await base.ServiceProvider.GetRequiredService<IEIDApi>().AbortAuthentication(new AbortAuthenticationRequest("activation_needed"));
					await base.ToastService.ShowWarning(CommonResources.x_WIDActivationNeededMessage, null, popToRoot: false);
					await PopToRoot();
				}
				else if (operation.GAP.AuthenticationResult == AuthenticationResult.Failed)
				{
					PinCodeModel model2 = new PinCodeModel(Model.EntryType, null, Model.EIDSessionResponse, operation.GAP.PinTriesLeft - 1)
					{
						WrongCAN = (!operation.GAP.PinTriesLeft.HasValue && Model.EntryType == PinEntryType.ResumePIN_CAN)
					};
					if (operation.GAP.PinTriesLeft == 2)
					{
						model2.EntryType = PinEntryType.ResumePIN_CAN;
					}
					model2.IsStatusChecked = true;
					model2.IsWIDActivation = Model.IsActivation;
					model2.NeedAppDeactivation = Model.NeedAppDeactivation;
					if (model2.EntryType == PinEntryType.ResumePIN_CAN)
					{
						await AlertService.DisplayAlert(AlertMessageType.FM084);
					}
					await GoToPinCodePage(model2);
				}
				else if (Model.IsActivation && !operation.GAP.ChangePinRequired)
				{
					await base.ServiceProvider.GetRequiredService<IEIDApi>().CancelAuthenticate();
					await base.ToastService.ShowWarning(string.Format(CommonResources.x_WIDFailedMessage, DocumentName), null, popToRoot: false);
					await PopToRoot();
				}
				else
				{
					switch (operation.GAP.ApiResult)
					{
					case ApiResult.Unknown:
						await base.ServiceProvider.GetRequiredService<IEIDApi>().CancelAuthenticate();
						await base.ToastService.ShowWarning(string.Format(CommonResources.x_WIDFailedMessage, DocumentName), null, popToRoot: false);
						break;
					case ApiResult.SessionNotFound:
						await base.ToastService.ShowError(CommonResources.x_SessionTimeoutMessage, null, popToRoot: false);
						break;
					case ApiResult.BadRequest:
						await base.ServiceProvider.GetRequiredService<IEIDApi>().CancelAuthenticate();
						await base.ToastService.ShowWarning(CommonResources.x_WIDRandomizeFailedMessage, null, popToRoot: false);
						break;
					case ApiResult.Cancelled:
						await base.ToastService.ShowWarning(string.Format(CommonResources.x_WIDCancelledMessage, DocumentName), null, popToRoot: false);
						break;
					default:
						await base.ToastService.ShowWarning(string.Format(CommonResources.x_WIDFailedMessage, DocumentName), null, popToRoot: false);
						break;
					}
					await PopToRoot();
				}
			}
			goto end_IL_0260;
			IL_077d:
			await HandleRandomizationCompletion();
			goto end_IL_0260;
			IL_07ea:
			await HandleChangePinCompletion();
			goto end_IL_0260;
			IL_0855:
			await HandlePinResumeCompletion();
			end_IL_0260:;
		}
		catch (CardLostException)
		{
			_isTagLost = true;
		}
		catch (CardPermissionDenialException)
		{
			_isTagLost = true;
		}
		catch (CardNotSupportedException)
		{
			await base.ServiceProvider.GetRequiredService<IEIDApi>().CancelAuthenticate();
			await base.ToastService.ShowError(CommonResources.x_WIDNotSupportedMessage, null, popToRoot: false);
			await PopToRoot();
		}
		catch (Exception)
		{
			throw;
		}
		if (_isTagLost)
		{
			await MainThread.InvokeOnMainThreadAsync(async delegate
			{
				base.ProgressVisible = false;
				base.ProgressValue = 0.0;
				NfcService.UpdateStatus(0.0);
				await StartScan(retry: true);
			});
		}
	}

	private async Task HandlePINBlocked()
	{
		await base.ServiceProvider.GetRequiredService<IEIDApi>().AbortAuthentication(new AbortAuthenticationRequest("pin_blocked"));
		await AlertService.DisplayAlert(AlertMessageType.FM082);
		await PopToRoot();
	}

	private Task HandlePinResumeCompletion()
	{
		if (Model.EIDSessionResponse != null)
		{
			Model.Pin = Model.NewPin;
			return Randomize();
		}
		return ActionCompleted(MessageType.ResumePincodeSuccess);
	}

	private async Task HandleChangePinCompletion()
	{
		if (Model.EIDSessionResponse != null)
		{
			Model.Pin = Model.NewPin;
			Model.NeedPinChange = false;
			Model.EntryType = PinEntryType.Authentication;
			EIDSession.ActivationState++;
			await NavigateToOverview(null);
		}
		else
		{
			await ActionCompleted(MessageType.ChangePincodeSuccess);
		}
	}

	private async Task HandleRandomizationCompletion()
	{
		base.DialogService.Show();
		await Task.Delay(1000);
		WidPollResponse pollingResult = await eIdApi.Poll();
		await base.DialogService.Hide();
		if (pollingResult.AttestApp)
		{
			await AttestApp();
		}
		if (pollingResult.ApiResult == ApiResult.Verified && Model.NeedAppDeactivation)
		{
			await DeactivateApp();
			return;
		}
		if (HttpSession.IsWeb2AppSession)
		{
			if (string.IsNullOrEmpty(pollingResult.ErrorMessage))
			{
				deviceLockService.Lock(userAction: false, logoutSession: false, forced: true);
				await RandomizationComplete();
			}
			else
			{
				await base.ToastService.ShowWarning(CommonResources.x_WIDActivationNeededMessage, null, popToRoot: false);
				await PopToRoot();
			}
			return;
		}
		if (Model.IsActivation)
		{
			if (pollingResult.ApiResult == ApiResult.Verified)
			{
				await ActionCompleted(MessageType.ActivationCompleted);
			}
			else
			{
				await ActionCompleted(MessageType.ActivationFailed);
			}
			return;
		}
		if (DeviceInfo.Idiom == DeviceIdiom.Desktop)
		{
			await ActionCompleted(MessageType.LoginSuccess);
			return;
		}
		switch (pollingResult.ApiResult)
		{
		case ApiResult.Verified:
			ArgumentNullException.ThrowIfNull(Model.EIDSessionResponse, "Model.EIDSessionResponse");
			if (await confirmService.SetSuccessMessage(Model.EIDSessionResponse))
			{
				MainThread.BeginInvokeOnMainThread(delegate
				{
					deviceLockService.Lock(userAction: true);
				});
			}
			break;
		case ApiResult.Aborted:
			if (pollingResult.ErrorMessage == "msc_issued")
			{
				await base.ToastService.ShowWarning(CommonResources.x_WIDActivationNeededMessage, null, popToRoot: false);
				await PopToRoot();
				break;
			}
			if (!(pollingResult.ErrorMessage == "msc_inactive"))
			{
				goto case ApiResult.Cancelled;
			}
			await base.ToastService.ShowWarning(string.Format(CommonResources.x_WIDFailedMessage, DocumentName), null, popToRoot: false);
			await PopToRoot();
			break;
		case ApiResult.Cancelled:
			await base.ToastService.ShowWarning(string.Format(CommonResources.x_WIDCancelledMessage, DocumentName), null, popToRoot: false);
			await PopToRoot();
			break;
		case ApiResult.Timeout:
			await base.ToastService.ShowWarning(CommonResources.x_WIDRandomizeFailedMessage, null, popToRoot: false);
			await PopToRoot();
			break;
		default:
			await base.ToastService.ShowWarning(CommonResources.x_WIDLoginFailedMessage, null, popToRoot: false);
			await PopToRoot();
			break;
		}
	}

	private async Task Randomize()
	{
		ArgumentNullException.ThrowIfNull(Model.EIDSessionResponse, "Model.EIDSessionResponse");
		CardCredentials credentials = new CardCredentials(Model.Pin, null, null);
		EIDSession.Host = Model.EIDSessionResponse.Host;
		EIDSession.SessionId = Model.EIDSessionResponse.SessionId;
		BaseSecureCardOperation operation = eIdOperationService.StartRandomize(UserConsent.PIP, credentials, base.ProgressChanged);
		UpdateStatusForA11Y();
		await ExecuteOperation(operation);
	}

	private async Task ChangePin(PasswordType type)
	{
		ArgumentNullException.ThrowIfNull(Model.NewPin, "Model.NewPin");
		CardCredentials credentials = new CardCredentials(Model.Pin, null, Model.Pin);
		BaseSecureCardOperation operation = eIdOperationService.StartChangePin(Model.NewPin, credentials, type, base.ProgressChanged);
		UpdateStatusForA11Y();
		await ExecuteOperation(operation);
	}

	private async Task ResumePin()
	{
		CardCredentials credentials = new CardCredentials(Model.NewPin, Model.Pin, Model.NewPin);
		BaseSecureCardOperation operation = eIdOperationService.StartResumePin((Model.EntryType == PinEntryType.ResumePIN_CAN) ? GapType.PINResumeCAN : GapType.PUKResumeCAN, credentials, base.ProgressChanged);
		await ExecuteOperation(operation);
	}

	private async Task StatusCheck(PasswordType type)
	{
		BaseSecureCardOperation operation = eIdOperationService.StartStatus(type, base.ProgressChanged);
		base.MessageText = CommonResources.x_WIDCheckStatus;
		UpdateStatusForA11Y();
		await ExecuteOperation(operation);
	}

	private void UpdateStatusForA11Y()
	{
		base.A11YService.Speak(base.MessageText, 2000);
	}

	private async Task StartScan(bool retry)
	{
		_isTagLost = false;
		IsScanning = true;
		base.ProgressValue = 0.0;
		base.ProgressVisible = false;
		base.WaitForRemoval = false;
		NfcService.IsCancelled = false;
		bool success = false;
		UpdateStatusForA11Y();
		while (!success)
		{
			string message = (retry ? string.Format(CultureInfo.InvariantCulture, CommonResources.x_RDAReStartScanning_iOS, CommonResources.eID.ToLowerInvariant(), "iPhone") : string.Format(CultureInfo.InvariantCulture, CommonResources.x_RDAStartScanning_iOS, CommonResources.eID.ToLowerInvariant(), "iPhone"));
			success = await NfcService.StartScanningAsync(StartReading, HandleError, message);
			await Task.Delay(1000);
		}
	}

	private static Task HandleError(NfcError e)
	{
		return Task.CompletedTask;
	}

	private async Task StartReading()
	{
		UpdateStatusForA11Y();
		await Start();
	}
}
