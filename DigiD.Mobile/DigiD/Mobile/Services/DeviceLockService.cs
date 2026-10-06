using System;
using System.Threading;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using DigiD.Mobile.Interfaces;

namespace DigiD.Mobile.Services;

public class DeviceLockService(IAuthenticationApi authenticationApi, ISessionService sessionService, INavigationService navigationService, AppConfig config, IAlertService alertService) : IDeviceLockService
{
	private DateTimeOffset? _lastKeyPress;

	private bool isRunning;

	public bool NeedLock => _lastKeyPress.HasValue && DateTimeOffset.UtcNow - _lastKeyPress.Value > config.DisplayLockTimeout;

	public async void Start()
	{
		_lastKeyPress = DateTimeOffset.UtcNow;
		PeriodicTimer timer = new PeriodicTimer(TimeSpan.FromSeconds(1L));
		isRunning = true;
		while (await timer.WaitForNextTickAsync() && isRunning)
		{
			if (!_lastKeyPress.HasValue || NeedLock)
			{
				isRunning = false;
				if (NeedLock)
				{
					Lock(userAction: false);
				}
			}
		}
		isRunning = false;
		timer.Dispose();
	}

	public void Stop()
	{
		isRunning = false;
	}

	public async void Lock(bool userAction, bool logoutSession = true, bool forced = false)
	{
		Stop();
		bool logout = !AppSession.IsAppVisible;
		if (!userAction && AppSession.IsAppVisible && !forced)
		{
			bool? result = await alertService.DisplayAlert(AlertMessageType.FM103, config.DisplayLockDelay);
			logout = !result.HasValue || !result.Value;
		}
		if (logout || userAction || forced)
		{
			if (logoutSession)
			{
				await authenticationApi.LogOutSession(userAction);
			}
			EIDSession.Card = null;
			HttpSession.AuthenticationSessionId = null;
			HttpSession.AppSessionId = null;
			HttpSession.WidSessionResponse = null;
			_lastKeyPress = null;
			await navigationService.PopToRootAsync();
			AppSession.IsAuthenticated = false;
			await sessionService.StartSession(sessionService.SetStartPage, startBiometrics: false, startNewSession: true);
		}
		else
		{
			AppSession.IsAuthenticated = true;
			Start();
		}
	}

	public void Update()
	{
		_lastKeyPress = DateTimeOffset.UtcNow;
	}
}
