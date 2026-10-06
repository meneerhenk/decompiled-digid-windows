using System.Threading.Tasks;
using DigiD.Common.Models.Enums;

namespace DigiD.Mobile.Interfaces;

public interface IAppService
{
	Task Deactivate(AlertMessageType? alert);

	void Reset();
}
