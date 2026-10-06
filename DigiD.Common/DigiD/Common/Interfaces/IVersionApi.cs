using System.Threading.Tasks;
using DigiD.Common.Models.ResponseModels;

namespace DigiD.Common.Interfaces;

public interface IVersionApi
{
	Task<VersionCheckResponse> CheckVersion();
}
