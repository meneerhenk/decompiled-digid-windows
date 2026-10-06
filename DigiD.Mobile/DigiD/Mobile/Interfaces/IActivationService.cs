using System.Security;
using System.Threading.Tasks;
using DigiD.Common.Models.ResponseModels;
using DigiD.Mobile.Models;

namespace DigiD.Mobile.Interfaces;

public interface IActivationService
{
	Task<SessionResponse> InitSession(string? smsCode = null);

	Task<BasicAuthenticationResponse?> LoginAsync(string userName, string password, bool isIdCheckSkipped = false, bool useLetter = false);

	Task LoginAndRemoveAsync();

	Task HandlePendingCompletion();

	Task SetPreferencesNotificationsAsync();

	Task<bool> ActivateAsync(SecureString pin, byte[] iv, bool alternative = false);

	Task StartActivationAsync(BasicAuthenticationResponse? result, bool useLetter = false);

	Task SetPreferencesEmailAsync();

	Task CompleteActivation();

	Task<ActivationResult> StartChallenge(string appId);

	Task<ActivationResult> RequestLetter(SessionResponse? result = null);

	Task SkipRda();
}
