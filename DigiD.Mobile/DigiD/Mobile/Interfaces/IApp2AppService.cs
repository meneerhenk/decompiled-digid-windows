using System.Threading.Tasks;

namespace DigiD.Mobile.Interfaces;

public interface IApp2AppService
{
	Task ProcessSamlRequest(string queryData);

	Task AbortSession(string reason);

	Task ReturnToClientApp(string? error = null);
}
