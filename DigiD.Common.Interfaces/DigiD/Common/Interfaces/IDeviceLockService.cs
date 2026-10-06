namespace DigiD.Common.Interfaces;

public interface IDeviceLockService
{
	bool NeedLock { get; }

	void Lock(bool userAction, bool logoutSession = true, bool forced = false);

	void Update();

	void Start();

	void Stop();
}
