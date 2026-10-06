using DigiD.Common.Models.Enums;

namespace DigiD.Common.Models.Responses;

public class BiometricsAuthenticationResponse
{
	public BiometricResponseStatus Status { get; set; }

	public BiometricsAuthenticationType AuthenticationType { get; set; }

	public byte[]? Result { get; set; }
}
