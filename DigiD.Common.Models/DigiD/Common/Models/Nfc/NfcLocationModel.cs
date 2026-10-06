namespace DigiD.Common.Models.Nfc;

public class NfcLocationModel
{
	public string Model { get; set; } = string.Empty;

	public int? X { get; set; }

	public int? Y { get; set; }

	public int? Width { get; set; }

	public int? Height { get; set; }

	public bool IsFold { get; set; }

	public NfcPosition Position { get; set; }
}
