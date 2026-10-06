namespace DigiD.Mobile.Interfaces;

public interface ISigningService
{
	bool HardwareSupport { get; }

	bool GenerateKeyPair();

	byte[]? ExportPublicKey();

	byte[]? Sign(string data);

	bool RemoveKeyPair();
}
