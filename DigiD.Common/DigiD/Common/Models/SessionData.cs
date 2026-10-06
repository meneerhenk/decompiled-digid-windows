namespace DigiD.Common.Models;

public class SessionData
{
	public string? Identifier { get; set; }

	public string? Host { get; set; }

	public string WebSessionId { get; set; } = null;

	public string verification_code { get; set; } = null;

	public string? source { get; set; }

	public string? action { get; set; }
}
