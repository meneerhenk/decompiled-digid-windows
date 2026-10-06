using DigiD.Common.Models.ResponseModels;

namespace DigiD.Common.SessionModels;

public static class App2AppSession
{
	public static string? AppIconUrl { get; set; }

	public static string? AppReturnUrl { get; set; }

	public static App? App { get; set; }

	public static string? SamlArt { get; set; }

	public static string? RelayState { get; set; }
}
