namespace DigiD.Common.Settings;

public class SentrySettings
{
	public string iOS { get; set; } = "";

	public string Android { get; set; } = "";

	public string MacOS { get; set; } = "";

	public string Windows { get; set; } = "";

	public string Dsn => Windows;
}
