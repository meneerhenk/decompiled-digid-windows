namespace DigiD.Common.Models.Requests;

public class BiometricsAuthenticationRequest(string title, string negativeText)
{
	public required bool IsEnrollment { get; set; }

	public string Title { get; set; } = title;

	public string? Subtitle { get; set; }

	public string NegativeText { get; set; } = negativeText;

	public string? Description { get; set; }

	public byte[]? Secret { get; set; }
}
