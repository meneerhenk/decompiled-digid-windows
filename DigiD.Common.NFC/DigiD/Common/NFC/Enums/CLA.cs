namespace DigiD.Common.NFC.Enums;

public enum CLA : byte
{
	PLAIN = 0,
	COMMAND_CHAINING = 16,
	SECURE_MESSAGING = 12,
	COMMAND_CHAINING_SM = 28,
	TIMEOUT = byte.MaxValue
}
