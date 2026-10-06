using System.Threading.Tasks;
using DigiD.Common.Models.ResponseModels;

namespace DigiD.Mobile.Interfaces;

public interface IConfigurationService
{
	ConfigResponse Configuration { get; }

	Task GetActualConfiguration();
}
