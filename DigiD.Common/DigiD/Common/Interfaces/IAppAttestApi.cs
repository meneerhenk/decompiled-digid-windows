using System.Threading.Tasks;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;

namespace DigiD.Common.Interfaces;

public interface IAppAttestApi
{
	Task<KeyAttestChallengeResponse> Challenge();

	Task<KeyAttestUpgradeResponse> Upgrade(KeyAttestUpgradeRequest model);
}
