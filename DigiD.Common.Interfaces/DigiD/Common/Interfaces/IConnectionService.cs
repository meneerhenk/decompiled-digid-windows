using System.Threading.Tasks;

namespace DigiD.Common.Interfaces;

public interface IConnectionService
{
	Task<bool> CheckNetworkConnection();

	void StartMonitor(bool resume = false);

	void StopMonitor();
}
