using System;
using System.Threading;
using System.Threading.Tasks;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Requests;
using DigiD.Common.Models.Responses;
using Microsoft.Extensions.Logging;

namespace DigiD.Common.Plugins.Services;

internal class BiometricService(ILogger<BiometricService> logger) : IBiometricService
{
	protected readonly ILogger<BiometricService> Logger = logger;

	public BiometricType BiometricType => BiometricType.None;

	public BiometricHwStatus AuthenticationStatus => BiometricHwStatus.Unsupported;

	public Task<BiometricsAuthenticationResponse> AuthenticateAsync(BiometricsAuthenticationRequest request, CancellationToken token)
	{
		throw new NotImplementedException();
	}

	public void Reset()
	{
	}
}
