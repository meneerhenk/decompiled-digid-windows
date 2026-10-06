using System.Security;
using DigiD.Common.Enums;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.ResponseModels;

namespace DigiD.Common.Models;

public class NfcScannerModel(PinEntryType entryType) : INfcScannerModel
{
	public PinEntryType EntryType { get; set; } = entryType;

	public WidSessionResponse? EIDSessionResponse { get; set; }

	public SecureString? Pin { get; set; }

	public SecureString? NewPin { get; set; }

	public bool IsStatusChecked { get; set; }

	public bool NeedPinChange { get; set; }

	public bool IsActivation { get; set; }

	public bool NeedAppDeactivation { get; set; }
}
