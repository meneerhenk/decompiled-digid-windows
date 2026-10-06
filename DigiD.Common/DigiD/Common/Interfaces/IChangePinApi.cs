using System.Threading.Tasks;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Interfaces;

public interface IChangePinApi
{
	Task<StartSessionBaseResponse> InitSession();

	Task<BaseResponse> ChangePin(string encryptedPin);
}
