namespace DigiD.Common.Models;

public class PinCodeValidationResult
{
	public bool Success { get; set; }

	public string? Message { get; set; }

	public required string Header { get; set; }
}
