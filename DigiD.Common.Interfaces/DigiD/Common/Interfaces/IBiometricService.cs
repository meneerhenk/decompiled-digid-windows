using System.Threading;
using System.Threading.Tasks;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Requests;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Interfaces;

public interface IBiometricService
{
	BiometricHwStatus AuthenticationStatus { get; }

	BiometricType BiometricType { get; }

	Task<BiometricsAuthenticationResponse> AuthenticateAsync(BiometricsAuthenticationRequest request, CancellationToken token);

	void Reset();
}
