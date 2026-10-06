using System;
using System.Threading.Tasks;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;

namespace DigiD.Mobile.Api.Demo;

internal class AppAttestApi : IAppAttestApi
{
	public Task<KeyAttestChallengeResponse> Challenge()
	{
		throw new NotImplementedException();
	}

	public Task<KeyAttestUpgradeResponse> Upgrade(KeyAttestUpgradeRequest model)
	{
		throw new NotImplementedException();
	}
}
