using System.Threading.Tasks;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Interfaces;

public interface IEmailApi
{
	Task<EmailStatusResponse> Status();

	Task<EmailRegisterResponse> Register(string? emailAddress);

	Task<EmailVerifyResponse> Verify(string code);

	Task<BaseResponse> Confirm(bool isValid);
}
