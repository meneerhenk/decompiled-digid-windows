using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiD.Common.Enums;
using DigiD.Common.Helpers;
using DigiD.Common.Http.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Preferences;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using DigiD.Mobile.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Devices;

namespace DigiD.Mobile.Services;

public class IncomingDataService(INavigationService navigationService, IAuthenticationApi authenticationServiceApi, IApp2AppApi app2AppApiService, IDialogService dialogService, ISslPinningService sslPinningService, IAuthenticationService authentication, IMatomoService matomoService, ISessionService sessionService, IMobileSettings mobileSettings, IAlertService alertService, IWidService widService, AppConfig config, IToastService toastService) : IIncomingDataService
{
	public async Task HandleIncomingData(Uri uri)
	{
		HttpSession.SetAuthenticationType(AuthenticationType.Web2App);
		string scheme = uri.Scheme;
		string text = scheme;
		string text2 = text;
		if (text2 == "digid-app-auth" || text2 == "digid-app-wid")
		{
			await ScanCompletedAsync(uri, null);
		}
	}

	public QrScanResult? ProcessUriData(Uri? uri)
	{
		ArgumentNullException.ThrowIfNull(uri, "uri");
		try
		{
			QrScanResult qrScanResult = new QrScanResult
			{
				Identifier = uri.Scheme
			};
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			string[] array = uri.PathAndQuery.Split('&');
			foreach (string text in array)
			{
				int num = text.IndexOf('=');
				string key = text.Substring(0, num);
				string value = text.Substring(num + 1);
				dictionary.Add(key, value);
			}
			if (!dictionary.ContainsKey("app_session_id"))
			{
				return null;
			}
			qrScanResult.Properties = dictionary;
			return qrScanResult;
		}
		catch
		{
			return null;
		}
	}

	public async Task ScanCompletedAsync(Uri uri, string? koppelCode)
	{
		QrScanResult scanResult = ProcessUriData(uri);
		if (scanResult == null)
		{
			await alertService.DisplayAlert(AlertMessageType.FM062);
			return;
		}
		SessionData data = new SessionData();
		if (scanResult.Properties.TryGetValue("at", out string at) && int.TryParse(at, out var seconds))
		{
			TimeSpan delta = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(seconds);
			if (delta > TimeSpan.FromMinutes(config.QRCodeValidationTime))
			{
				await alertService.DisplayAlert(AlertMessageType.FM063);
				return;
			}
		}
		data.Identifier = scanResult.Identifier;
		data.Host = scanResult.Properties.GetValue("host");
		data.WebSessionId = scanResult.Properties.GetValue("app_session_id");
		data.verification_code = scanResult.Properties.GetValue("verification_code");
		data.source = scanResult.Properties.GetValue("source");
		data.action = scanResult.Properties.GetValue("action");
		if (DeviceInfo.Platform == DevicePlatform.Android && (HttpSession.IsWeb2AppSession || HttpSession.IsApp2AppSession))
		{
			HttpSession.Browser = Browser.Chrome;
		}
		else if ((DeviceInfo.Platform == DevicePlatform.iOS || DeviceInfo.Platform == DevicePlatform.MacCatalyst) && scanResult.Properties.ContainsKey("browser"))
		{
			switch (scanResult.Properties.GetValue("browser").ToLowerInvariant())
			{
			case "safari":
				HttpSession.Browser = Browser.Safari;
				break;
			case "chrome":
				HttpSession.Browser = Browser.Chrome;
				break;
			case "firefox":
				HttpSession.Browser = Browser.Firefox;
				break;
			case "microsoft+edge":
				HttpSession.Browser = Browser.Edge;
				break;
			}
			HttpSession.Browser = Browser.Chrome;
		}
		else if (DeviceInfo.Idiom == DeviceIdiom.Desktop)
		{
			HttpSession.Browser = Browser.Chrome;
		}
		if (HttpSession.IsWeb2AppSession && HttpSession.Browser == Browser.Unknown)
		{
			await toastService.ShowWarning(CommonResources.x_BrowserUnsupportedMessage);
		}
		else
		{
			await ProcessData(data, activation: false, koppelCode);
		}
	}

	private async Task HandleApp2AppDataSuccess(SessionData data, App2AppSessionData sessionData, bool activation, InitApp2AppResponse sessionResponse)
	{
		IApp2AppService app2AppService = AppSession.ServiceProvider.GetRequiredService<IApp2AppService>();
		data.WebSessionId = sessionResponse.WebSessionId;
		if (string.IsNullOrEmpty(data.WebSessionId))
		{
			await app2AppService.ReturnToClientApp();
			return;
		}
		if (mobileSettings.ActivationStatus != ActivationStatus.Activated && !activation)
		{
			HttpSession.AppSessionId = sessionResponse.WebSessionId;
			await authenticationServiceApi.AbortAuthentication((mobileSettings.ActivationStatus == ActivationStatus.NotActivated) ? "not_activated" : "app_is_pending");
			await app2AppService.ReturnToClientApp();
			return;
		}
		if (!string.IsNullOrEmpty(sessionData.Data.ReturnUrl))
		{
			App2AppSession.App = sessionResponse.Apps.FirstOrDefault((DigiD.Common.Models.ResponseModels.App x) => x.Url == sessionData.Data.ReturnUrl);
			if (App2AppSession.App == null)
			{
				HttpSession.AppSessionId = sessionResponse.WebSessionId;
				await authenticationServiceApi.AbortAuthentication("invalid_return_url");
				await navigationService.PopToRootAsync();
				return;
			}
			App2AppSession.AppReturnUrl = sessionData.Data.ReturnUrl;
			App2AppSession.SamlArt = sessionResponse.SAMLart;
			App2AppSession.RelayState = sessionResponse.RelayState;
		}
		if (IsValidImage(sessionData, sessionResponse))
		{
			App2AppSession.AppIconUrl = sessionData.Data.Icon;
		}
	}

	private async Task<bool> ProcessApp2AppData(SessionData data, App2AppSessionData sessionData, bool activation)
	{
		HttpSession.IsApp2AppSessionStarted = true;
		InitApp2AppResponse response = await app2AppApiService.InitSessionApp2App(sessionData.Data);
		ApiResult apiResult = response.ApiResult;
		ApiResult apiResult2 = apiResult;
		if (apiResult2 == ApiResult.Ok)
		{
			await HandleApp2AppDataSuccess(data, sessionData, activation, response);
			return true;
		}
		await toastService.ShowError(CommonResources.x_SessionTimeoutMessage);
		return false;
	}

	private static bool IsValidImage(App2AppSessionData sessionData, InitApp2AppResponse app2AppSession)
	{
		if (Uri.TryCreate(sessionData.Data.Icon, UriKind.RelativeOrAbsolute, out Uri result) && Uri.TryCreate(app2AppSession.ImagedDomain, UriKind.RelativeOrAbsolute, out Uri result2))
		{
			return result2.Host.Equals(result.Host, StringComparison.CurrentCultureIgnoreCase);
		}
		return false;
	}

	private async Task ProcessAuthentication(SessionData data, bool activation, string? koppelCode)
	{
		if (mobileSettings.ActivationStatus == ActivationStatus.NotActivated)
		{
			HttpSession.TempSessionData = new TempSessionData(data.WebSessionId);
			await alertService.DisplayAlert(AlertMessageType.FM076);
			await dialogService.Hide();
		}
		else if (SkipVerificationValidation() || data.verification_code.Equals(koppelCode, StringComparison.CurrentCultureIgnoreCase))
		{
			if (!(await sslPinningService.SslPinningCheck()))
			{
				await toastService.ShowWarning(CommonResources.SSLWarningMessage);
			}
			else
			{
				await authentication.ContinueAuthenticationAsync();
			}
		}
		else
		{
			matomoService.TrackAction("Koppelcode fout", "Ingevoerde Koppelcode: " + data.verification_code + ". Verwachte Koppelcode: " + koppelCode, navigationService.CurrentPageId);
			await authenticationServiceApi.AbortAuthentication("verification_code_invalid");
			await alertService.DisplayAlert(AlertMessageType.FM061);
		}
		bool SkipVerificationValidation()
		{
			return HttpSession.Browser != Browser.Unknown || HttpSession.IsApp2AppSession || activation || koppelCode == null;
		}
	}

	public async Task ProcessData(SessionData data, bool activation, string? koppelCode)
	{
		try
		{
			string host = ((!string.IsNullOrEmpty(data.Host)) ? data.Host : "digid.nl");
			if (config.Hosts.All((string x) => x.ToString() != host))
			{
				await alertService.DisplayAlert(AlertMessageType.FM062);
				return;
			}
			App2AppSessionData sessionData = default(App2AppSessionData);
			int num;
			if (HttpSession.IsApp2AppSession && !HttpSession.IsApp2AppSessionStarted)
			{
				sessionData = data as App2AppSessionData;
				num = ((sessionData != null) ? 1 : 0);
			}
			else
			{
				num = 0;
			}
			if (num != 0 && !(await ProcessApp2AppData(data, sessionData, activation)))
			{
				return;
			}
			if (DemoSettings.IsDemoModeEnabled && !HttpSession.IsApp2AppSession && string.IsNullOrEmpty(data.action))
			{
				await dialogService.Hide();
				DemoHelper.NewSession("webservice", data.WebSessionId, LoginLevel.Midden);
			}
			string identifier = data.Identifier;
			string text = identifier;
			string text2 = text;
			if (!(text2 == "digid-app-wid"))
			{
				if (text2 == "digid-app-auth")
				{
					if (data.action == null && mobileSettings.ActivationStatus != ActivationStatus.NotActivated)
					{
						await sessionService.StartSession(delegate
						{
							HttpSession.AppSessionId = data.WebSessionId;
							return ProcessAuthentication(data, activation, koppelCode);
						}, startBiometrics: true);
					}
					else
					{
						await ProcessAuthentication(data, activation, koppelCode);
					}
				}
				else
				{
					await alertService.DisplayAlert(AlertMessageType.FM062);
				}
			}
			else
			{
				HttpSession.AppSessionId = data.WebSessionId;
				await widService.AuthenticateAsync(data, koppelCode);
			}
		}
		catch
		{
			await toastService.ShowWarning(CommonResources.Alg_LoginUnknownMessage);
		}
	}
}
