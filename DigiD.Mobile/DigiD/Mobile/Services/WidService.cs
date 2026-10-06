using System;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Messaging;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Models;
using DigiD.Mobile.Pages;

namespace DigiD.Mobile.Services;

public class WidService(INavigationService navigationService, IEIDApi api, IToastService toastService, IAlertService alertService) : IWidService
{
	public async Task AuthenticateAsync(SessionData sessionData, string? koppelCode)
	{
		if (!AppSession.HasNfc)
		{
			await api.AbortAuthentication(new AbortAuthenticationRequest("no_nfc"));
			await toastService.ShowError(CommonResources.x_NoNFCMessage);
			return;
		}
		string code = string.Empty;
		if (!string.IsNullOrEmpty(sessionData.verification_code))
		{
			code = sessionData.verification_code;
		}
		if (string.IsNullOrEmpty(code) || sessionData.verification_code.Equals(koppelCode, StringComparison.CurrentCultureIgnoreCase))
		{
			await StartSession();
			return;
		}
		await api.AbortAuthentication(new AbortAuthenticationRequest("verification_code_invalid"));
		await alertService.DisplayAlert(AlertMessageType.FM061);
	}

	private async Task StartSession()
	{
		WidSessionResponse response = await api.InitSessionEID(new WidSessionRequest());
		switch (response.ApiResult)
		{
		case ApiResult.Ok:
			HttpSession.WidSessionResponse = response;
			if (!string.IsNullOrEmpty(response.WebService))
			{
				await navigationService.NavigateAsync<DG038>();
			}
			else if (!string.IsNullOrEmpty(response.Action))
			{
				await navigationService.NavigateAsync<DG067B>();
			}
			WeakReferenceMessenger.Default.Send(new CancelBiometricsAuthenticationMessage());
			break;
		case ApiResult.Nok:
			await toastService.ShowError(CommonResources.Alg_UnknownErrorOccurred);
			break;
		case ApiResult.HostNotReachable:
			await alertService.DisplayAlert(AlertMessageType.FM005);
			break;
		case ApiResult.SSLPinningError:
			await toastService.ShowError(CommonResources.SSLWarningMessage);
			break;
		case ApiResult.Disabled:
		case ApiResult.Forbidden:
			break;
		}
	}
}
