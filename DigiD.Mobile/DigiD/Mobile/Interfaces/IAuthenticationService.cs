using System.Security;
using System.Threading.Tasks;
using DigiD.Common.Models.ResponseModels;

namespace DigiD.Mobile.Interfaces;

public interface IAuthenticationService
{
	Task<ValidatePinResponse> AuthenticateAsync(SecureString pin, ChallengeResponse response, string sessionId);

	Task ProcessWebAuthentication(string returnUrl);

	Task<ChallengeResponse?> GetChallenge(string sessionId);

	Task ContinueAuthenticationAsync();

	Task HandleWeb2AppSuccess();
}
