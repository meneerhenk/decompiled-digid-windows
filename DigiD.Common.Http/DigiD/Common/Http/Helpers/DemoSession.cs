using DigiD.Common.Models.Enums;

namespace DigiD.Common.Http.Helpers;

public class DemoSession
{
	public byte[]? IV { get; set; }

	public string? Action { get; set; }

	public string? Challenge { get; set; }

	public bool IsAuthenticated { get; set; }

	public LoginLevel LoginLevel { get; set; }
}
