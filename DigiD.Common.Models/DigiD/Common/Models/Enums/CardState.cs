namespace DigiD.Common.Models.Enums;

public class CardState
{
	public int PINTries { get; set; } = 5;

	public double CANDelay { get; set; } = 1.0;

	public string Pin { get; set; } = "12345";

	public string? NewPin { get; set; }

	public bool IsSuspended => PINTries == 1;

	public bool IsBlocked => PINTries == 0;

	public bool ChangePinRequired { get; set; } = true;
}
