namespace DigiD.Mobile.Platforms.iOS.Models;

internal class AssertionModel
{
	public byte[]? signature { get; set; }

	public byte[]? authenticatorData { get; set; }
}
