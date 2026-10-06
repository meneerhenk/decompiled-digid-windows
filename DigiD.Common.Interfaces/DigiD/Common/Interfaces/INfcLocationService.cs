using DigiD.Common.Models.Nfc;

namespace DigiD.Common.Interfaces;

public interface INfcLocationService
{
	NfcPosition Position { get; }
}
