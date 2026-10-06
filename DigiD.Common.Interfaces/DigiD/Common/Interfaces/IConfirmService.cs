using System.Threading.Tasks;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Interfaces;

public interface IConfirmService
{
	Task<bool> SetSuccessMessage(AuthenticationSessionResponse response);
}
