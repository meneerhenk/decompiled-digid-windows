using System;
using System.Threading.Tasks;

namespace DigiD.Mobile.Interfaces;

public interface ISessionService
{
	Task StartSession(Func<Task> nextAction, bool startBiometrics, bool startNewSession = false);

	Task CancelSession(bool byUser, Func<Task>? completeAction = null);

	void ClearSession();

	Task SetStartPage();
}
