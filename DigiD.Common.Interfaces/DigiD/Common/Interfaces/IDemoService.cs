using System.Threading.Tasks;

namespace DigiD.Common.Interfaces;

public interface IDemoService
{
	Task<string> AskAuthenticationAction(bool widAuthentication);

	Task SetMode();
}
