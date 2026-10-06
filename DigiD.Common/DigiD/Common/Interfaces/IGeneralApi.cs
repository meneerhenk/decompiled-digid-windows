using System.Threading.Tasks;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Interfaces;

public interface IGeneralApi
{
	Task<BaseResponse> Cancel(bool cancelledByUser = false, bool timeout = false);

	Task<ConfigResponse> GetConfig();

	Task<BaseResponse> DoHealthCheck();
}
