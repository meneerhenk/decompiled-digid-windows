using System;
using System.Threading.Tasks;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Enums;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Responses;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Pages;
using DigiD.Mobile.ViewModels;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;

namespace DigiD.Mobile.Services;

public class SessionService(IAuthenticationApi authenticationService, IGeneralApi generalServices, ILogger<SessionService> logger, IMobileSettings mobileSettings, IToastService toastService, INavigationService navigationService) : ISessionService
{
	private DateTime? _sessionStart;

	public async Task SetStartPage()
	{
		AppSession.IsAuthenticated = true;
		if (((IApp)Application.Current).A11YService.IsInVoiceOverMode)
		{
			await Task.Delay(250);
		}
		if (mobileSettings.ActivationStatus == ActivationStatus.Activated)
		{
			await navigationService.PopToRootAsync();
		}
		else
		{
			await navigationService.NavigateAsync<DG031>();
		}
	}

	public async Task StartSession(Func<Task> nextAction, bool startBiometrics, bool startNewSession = false)
	{
		if (startNewSession)
		{
			await StartNewSession(nextAction, startBiometrics);
			return;
		}
		BaseResponse status = await authenticationService.SessionStatus();
		ApiResult apiResult = status.ApiResult;
		ApiResult apiResult2 = apiResult;
		ApiResult apiResult3 = apiResult2;
		if (apiResult3 <= ApiResult.Nok)
		{
			if (apiResult3 == ApiResult.Ok)
			{
				AppSession.IsAuthenticated = true;
				logger.LogInformation("Active session found");
				await nextAction();
				return;
			}
			if (apiResult3 == ApiResult.Nok && status.ErrorMessage == "no_session")
			{
				goto IL_02a5;
			}
		}
		else if (apiResult3 == ApiResult.SessionNotFound || (uint)(apiResult3 - 24) <= 1u)
		{
			goto IL_02a5;
		}
		HttpSession.AuthenticationSessionId = null;
		await toastService.ShowError(CommonResources.Alg_UnknownErrorOccurred);
		return;
		IL_02a5:
		await StartNewSession(nextAction, startBiometrics);
	}

	private Task StartNewSession(Func<Task> nextAction, bool startBiometrics)
	{
		if (_sessionStart.HasValue && (DateTime.Now - _sessionStart.Value).TotalMilliseconds < 1000.0)
		{
			return Task.CompletedTask;
		}
		return MainThread.InvokeOnMainThreadAsync(async delegate
		{
			_sessionStart = DateTime.Now;
			if (await navigationService.IsWindowAndPageAvailable())
			{
				if (navigationService.Navigation?.NavigationStack != null)
				{
					foreach (Page item in navigationService.Navigation.NavigationStack)
					{
						object obj = item?.BindingContext;
						PinCodeViewModel vm = obj as PinCodeViewModel;
						if (vm != null && !vm.IsCardAuthentication)
						{
							vm.NextAction = nextAction;
							if (startBiometrics)
							{
								vm.StartBiometricsAuthenticationCommand.Execute(parameter: true);
							}
							return;
						}
					}
				}
				await navigationService.NavigateAsync<PinCodePage, PinCodeViewModel>(delegate(PinCodeViewModel pinCodeViewModel)
				{
					pinCodeViewModel.Initialize(new PinCodeModel(PinEntryType.Authentication)
					{
						IsAppAuthentication = true,
						NextAction = nextAction
					});
					if (startBiometrics)
					{
						pinCodeViewModel.StartBiometricsAuthenticationCommand.Execute(parameter: true);
					}
				});
			}
		});
	}

	public async Task CancelSession(bool byUser, Func<Task>? completeAction = null)
	{
		if (HttpSession.AppSessionId == null)
		{
			if (completeAction != null)
			{
				await completeAction();
			}
			return;
		}
		await generalServices.Cancel(byUser);
		ClearSession();
		if (completeAction != null)
		{
			await completeAction();
		}
	}

	public void ClearSession()
	{
		HttpSession.AppSessionId = null;
		HttpSession.TempSessionData = null;
		HttpSession.ActivationSessionData = null;
		HttpSession.Browser = DigiD.Common.Enums.Browser.Unknown;
		HttpSession.SetAuthenticationType(AuthenticationType.None);
		HttpSession.IsApp2AppSessionStarted = false;
		HttpSession.SourceApplication = null;
		HttpSession.WebSessionInfoResponse = null;
		HttpSession.WidSessionResponse = null;
		HttpSession.RemoveOldApp = false;
		AppSession.Process = Process.NotSet;
		App2AppSession.AppIconUrl = null;
		EIDSession.SessionId = null;
		EIDSession.CommandAPDUs = null;
		EIDSession.Host = null;
		EIDSession.Card = null;
	}
}
