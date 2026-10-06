using DigiD.Common.EID.Models.CardFiles;

namespace DigiD.Common.Interfaces;

internal interface IChipAuthentication
{
	byte[] Ricc { get; set; }

	byte[] Ticc { get; set; }

	byte[] TerminalToken { get; set; }

	EFCardSecurity EFCardSecurity { get; set; }
}
