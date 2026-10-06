using System;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;
using DigiD.Common.Enums;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Pages;
using Microsoft.Maui.ApplicationModel;

namespace DigiD.Mobile.Services;

public class App2AppService(INavigationService navigationService, IApp2AppApi app2AppService, IMobileSettings mobileSettings, IAuthenticationApi authenticationService, IIncomingDataService incomingDataService, IGeneralApi generalApi, ICrashService crashService, IAlertService alertService, IDeviceLockService deviceLockService, ISessionService sessionService) : IApp2AppService
{
	private async Task<bool> ProcessDataValid(App2AppRequest? data)
	{
		if (data == null)
		{
			await navigationService.CurrentPage.DisplayAlertAsync(CommonResources.Alg_Error, "Session Time-out", CommonResources.Alg_Ok);
			await navigationService.PopToRootAsync();
			return false;
		}
		if (string.IsNullOrEmpty(data.ReturnUrl))
		{
			await navigationService.CurrentPage.DisplayAlertAsync(CommonResources.Alg_Error, "Controleer parameters, ReturnURL is niet aanwezig", CommonResources.Alg_Ok);
			await navigationService.PopToRootAsync();
			return false;
		}
		if (!data.IsValid(crashService))
		{
			await navigationService.CurrentPage.DisplayAlertAsync(CommonResources.Alg_Error, "Controleer parameters, SAMLRequest is ongeldig", CommonResources.Alg_Ok);
			await navigationService.PopToRootAsync();
			return false;
		}
		return true;
	}

	public async Task ProcessSamlRequest(string queryData)
	{
		HttpSession.IsApp2AppSessionStarted = false;
		string base64 = HttpUtility.UrlDecode(queryData.Replace("app-app=", string.Empty));
		if (!StringHelper.TryGetFromBase64String(base64, out byte[] encodedData))
		{
			return;
		}
		if (encodedData == null)
		{
			return;
		}
		string decodedData = Encoding.UTF8.GetString(encodedData);
		App2AppRequest data = JsonSerializer.Deserialize<App2AppRequest>(decodedData);
		if (await MainThread.InvokeOnMainThreadAsync(async () => await ProcessDataValid(data)))
		{
			App2AppSession.AppReturnUrl = data.ReturnUrl;
			if ((DateTime.Now - data.IssueInstant).TotalMinutes > 1.0)
			{
				await ReturnToClientApp("timeout");
			}
			else if (string.IsNullOrEmpty(data.Icon))
			{
				await ReturnToClientApp("icon_missing");
			}
			else
			{
				await ProcessApp2AppAsync(data);
			}
		}
	}

	private async Task ProcessApp2AppAsync(App2AppRequest? data)
	{
		if (data == null)
		{
			await alertService.DisplayAlert(AlertMessageType.FM062);
			return;
		}
		HttpSession.SetAuthenticationType(AuthenticationType.App2App);
		App2AppSessionData sessionData = new App2AppSessionData(data);
		switch (mobileSettings.ActivationStatus)
		{
		case ActivationStatus.NotActivated:
			await incomingDataService.ProcessData(sessionData, activation: true, null);
			await navigationService.PopToRootAsync();
			break;
		case ActivationStatus.Pending:
			await incomingDataService.ProcessData(sessionData, activation: true, null);
			await navigationService.NavigateAsync<DG031>();
			break;
		default:
			await incomingDataService.ProcessData(sessionData, activation: false, null);
			break;
		}
	}

	public async Task ReturnToClientApp(string? error = null)
	{
		if (string.IsNullOrEmpty(App2AppSession.SamlArt))
		{
			SamlArtifactResponse samlResponse = await app2AppService.GetSamlArtifact(new SamlArtifactRequest());
			if (samlResponse.ApiResult == ApiResult.Ok)
			{
				App2AppSession.RelayState = samlResponse.RelayState;
				App2AppSession.SamlArt = samlResponse.SAMLart;
			}
		}
		App2AppResponse response = new App2AppResponse
		{
			RelayState = App2AppSession.RelayState,
			SAMLart = App2AppSession.SamlArt,
			ErrorMessage = error
		};
		string json = JsonSerializer.Serialize(response);
		string url = string.Concat(str2: Convert.ToBase64String(Encoding.UTF8.GetBytes(json)), str0: App2AppSession.AppReturnUrl, str1: "?app-app=");
		deviceLockService.Lock(userAction: true, logoutSession: false);
		sessionService.ClearSession();
		if (Uri.TryCreate(url, UriKind.Absolute, out Uri uri))
		{
			await Launcher.OpenAsync(uri);
		}
		App2AppSession.AppReturnUrl = null;
		App2AppSession.AppIconUrl = null;
		App2AppSession.RelayState = null;
		App2AppSession.SamlArt = null;
	}

	public async Task AbortSession(string reason)
	{
		HttpSession.TempSessionData?.SwitchSession();
		await authenticationService.AbortAuthentication(reason);
		if (HttpSession.AppSessionId == null)
		{
			await navigationService.PopToRootAsync();
			return;
		}
		await generalApi.Cancel(cancelledByUser: true);
		string errorMessage = "cancelled_by_user";
		if (mobileSettings.ActivationStatus != ActivationStatus.Activated)
		{
			errorMessage = "not_activated";
		}
		await ReturnToClientApp(errorMessage);
		await navigationService.PopToRootAsync();
	}
}
