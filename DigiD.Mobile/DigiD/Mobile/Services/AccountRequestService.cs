using System;
using System.Globalization;
using System.Text.Json;
using System.Threading.Tasks;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Models.Responses;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Models;
using DigiD.Mobile.Pages;
using DigiD.Mobile.ViewModels;

namespace DigiD.Mobile.Services;

public class AccountRequestService(IAlertService alertService, IActivationService activationService, ISslPinningService sslPinningService, INavigationService navigationService, IEnrollmentApi enrollmentApi, IDialogService dialogService, IToastService toastService) : IAccountRequestService
{
	public async Task RequestAccount()
	{
		if (!(await sslPinningService.SslPinningCheck()))
		{
			await toastService.ShowError(CommonResources.SSLWarningMessage);
			return;
		}
		dialogService.Show();
		HttpSession.ActivationSessionData = new ActivationSessionData
		{
			ActivationMethod = ActivationMethod.RequestNewDigidAccount
		};
		string bsn = DG010ViewModel.SelectedBsn;
		string ds = CultureInfo.DefaultThreadCurrentCulture?.DateTimeFormat.DateSeparator;
		string[] tmp = DG011ViewModel.SelectedDateOfBirth.Split(ds);
		string dob = tmp[0] + tmp[1] + tmp[2];
		ArgumentNullException.ThrowIfNull(DG012ViewModel.SelectedHouseNumber, "DG012ViewModel.SelectedHouseNumber");
		RequestAccountRequest request = new RequestAccountRequest
		{
			Bsn = bsn,
			DateOfBirth = dob,
			Postalcode = DG012ViewModel.SelectedPostalCode.ToUpper(CultureInfo.InvariantCulture),
			HouseNumber = DG012ViewModel.SelectedHouseNumber,
			HouseNumberSuffix = DG012ViewModel.SelectedHouseNumberSuffix,
			Language = DG012ViewModel.SelectedLanguage,
			HasNfcSupport = AppSession.HasNfc
		};
		RequestAccountResponse raResponse = await enrollmentApi.InitSessionAccountRequest(request);
		if (raResponse.ApiResult != ApiResult.Ok)
		{
			await HandleInvalidInput(raResponse);
		}
		else
		{
			HttpSession.AppSessionId = raResponse.AppSessionId;
			BaseRequest pollRequest = new BaseRequest();
			BaseResponse pollResult = await enrollmentApi.AccountRequestsBrpPoll(pollRequest);
			while (pollResult.ApiResult == ApiResult.Pending)
			{
				await Task.Delay(1000);
				pollResult = await enrollmentApi.AccountRequestsBrpPoll(pollRequest);
			}
			if (pollResult.ApiResult != ApiResult.Ok)
			{
				await HandleInvalidResponse(pollResult);
			}
			else
			{
				await CheckExistingRequest();
			}
		}
		await dialogService.Hide();
	}

	private async Task CheckExistingAccount()
	{
		BaseResponse baseResponse = await enrollmentApi.AccountRequestsCheckAccount(new BaseRequest());
		if (baseResponse.ApiResult == ApiResult.Ok)
		{
			await StartSession();
		}
		else if (baseResponse.ApiResult == ApiResult.Pending)
		{
			bool? stop = await alertService.DisplayAlert(AlertMessageType.FM033);
			if (stop.HasValue)
			{
				baseResponse = await enrollmentApi.AccountRequestsReplaceAccount(new ReplaceExistingAccountRequest(!stop.Value));
				if (!stop.Value && baseResponse.ApiResult == ApiResult.Ok)
				{
					await StartSession();
				}
				else
				{
					await navigationService.PopToRootAsync();
				}
			}
		}
		else
		{
			await toastService.ShowWarning(CommonResources.x_FM_RequestAccount_HelpDesk);
		}
	}

	private async Task CheckExistingRequest()
	{
		BaseResponse baseResponse = await enrollmentApi.AccountRequestsCheckApp(new BaseRequest());
		if (baseResponse.ApiResult == ApiResult.Ok)
		{
			await CheckExistingAccount();
		}
		else if (baseResponse.ApiResult == ApiResult.Pending)
		{
			await navigationService.NavigateAsync<FM032, FM032ViewModel>(delegate(FM032ViewModel vm)
			{
				vm.ResultAction = async delegate(bool newRequest)
				{
					baseResponse = await enrollmentApi.AccountRequestsReplaceApp(new ReplaceExistingApplicationRequest(newRequest));
					if (baseResponse.ApiResult == ApiResult.Ok && newRequest)
					{
						await StartSession();
					}
					else
					{
						await navigationService.PopToRootAsync();
					}
				};
			});
		}
		else
		{
			await toastService.ShowError(CommonResources.Alg_UnknownErrorOccurred);
		}
	}

	private async Task StartSession()
	{
		dialogService.Show();
		SessionResponse result = await activationService.InitSession();
		if (result.ApiResult == ApiResult.Ok)
		{
			ArgumentNullException.ThrowIfNull(result.AppId, "result.AppId");
			ActivationResult activationResult = await activationService.StartChallenge(result.AppId);
			if (activationResult.ApiResult == ApiResult.Ok)
			{
				HttpSession.ActivationSessionData.IV = activationResult.IV;
				AppSession.SetNextState();
				await navigationService.PopToRootAsync();
			}
		}
		await dialogService.Hide();
	}

	private async Task HandleInvalidResponse(BaseResponse pollResult)
	{
		switch (pollResult.ErrorMessage)
		{
		case "mismatch_personal_data_with_gba":
			await navigationService.NavigateAsync<DG036>();
			break;
		case "gba_timeout":
			await alertService.DisplayAlert(AlertMessageType.FM023);
			break;
		case "gba_emigrated_RNI":
			await alertService.DisplayAlert(AlertMessageType.FM028);
			break;
		case "gba_under_investigation":
			await alertService.DisplayAlert(AlertMessageType.FM026);
			break;
		case "gba_address_under_investigation":
			await alertService.DisplayAlert(AlertMessageType.FM027);
			break;
		case "gba_deceased":
			await alertService.DisplayAlert(AlertMessageType.FM025);
			break;
		case "BSN_unsubscribed":
			await alertService.DisplayAlert(AlertMessageType.FM023);
			break;
		case "application_too_soon":
			await alertService.DisplayAlert(AlertMessageType.FM030);
			break;
		case "too_many_applications_this_month":
		{
			int amount = 3;
			if (pollResult.Payload != null)
			{
				amount = JsonSerializer.Deserialize<AccountRequestValidationModel>(pollResult.Payload.ToString())?.Amount ?? 3;
			}
			await toastService.ShowWarning(string.Format(CommonResources.FM031_Body, amount));
			break;
		}
		default:
			await alertService.DisplayAlert(AlertMessageType.FM023);
			break;
		}
	}

	private async Task HandleInvalidInput(RequestAccountResponse raResponse)
	{
		if (raResponse.ErrorMessage != "invalid_parameters")
		{
			if (raResponse.Delay > 0)
			{
				await toastService.ShowWarning(string.Format(CommonResources.FM029_Body, raResponse.Delay));
			}
			else
			{
				await alertService.DisplayAlert(AlertMessageType.FM023);
			}
		}
		else
		{
			await navigationService.NavigateAsync<DG036>();
			await alertService.DisplayAlert(AlertMessageType.FM022);
		}
	}
}
