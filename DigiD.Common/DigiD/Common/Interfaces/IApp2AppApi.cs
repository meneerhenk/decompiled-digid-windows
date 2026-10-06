using System.Threading.Tasks;
using DigiD.Common.Models;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;

namespace DigiD.Common.Interfaces;

public interface IApp2AppApi
{
	Task<InitApp2AppResponse> InitSessionApp2App(App2AppRequest requestData);

	Task<SamlArtifactResponse> GetSamlArtifact(SamlArtifactRequest requestData);
}
