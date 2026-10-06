namespace DigiD.Mobile.Platforms.iOS.Models;

internal class AppleAttestationModel
{
	public string? fmt { get; set; }

	public StmtFormat? attStmt { get; set; }

	public byte[]? authData { get; set; }
}
