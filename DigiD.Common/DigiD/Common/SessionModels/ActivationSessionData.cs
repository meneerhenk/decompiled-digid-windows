using System.Security;
using DigiD.Common.Models.Enums;

namespace DigiD.Common.SessionModels;

public class ActivationSessionData
{
	public SecureString? Pin { get; set; }

	public ActivationMethod ActivationMethod { get; set; }

	public string? UserName { get; set; }

	public string? Password { get; set; }

	public byte[]? IV { get; set; }
}
