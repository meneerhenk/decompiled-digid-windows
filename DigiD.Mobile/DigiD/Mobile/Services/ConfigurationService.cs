using System.Threading.Tasks;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.ResponseModels;
using DigiD.Mobile.Interfaces;

namespace DigiD.Mobile.Services;

public class ConfigurationService(IGeneralApi generalServices) : IConfigurationService
{
	public ConfigResponse Configuration { get; private set; } = new ConfigResponse();

	public async Task GetActualConfiguration()
	{
		Configuration = await generalServices.GetConfig();
	}
}
