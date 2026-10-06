using System.Threading.Tasks;
using DigiD.Common.Models;

namespace DigiD.Mobile.Interfaces;

public interface IWidService
{
	Task AuthenticateAsync(SessionData sessionData, string? koppelCode);
}
