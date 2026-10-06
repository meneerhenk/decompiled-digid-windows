using System;
using System.Security;
using DigiD.Common.EID.Enums;
using DigiD.Common.EID.Helpers;

namespace DigiD.Common.EID.Models;

public class CardCredentials(SecureString? pin, SecureString? can, SecureString? puk, SecureString? mrz = null)
{
	public SecureString? PIN { get; } = pin;

	public SecureString? CAN { get; } = can;

	public SecureString? PUK { get; } = puk;

	public SecureString? MRZ { get; set; } = mrz;

	public byte[] Password(PasswordType passwordType)
	{
		switch (passwordType)
		{
		case PasswordType.CAN:
			ArgumentNullException.ThrowIfNull(CAN, "CAN");
			return CAN.ToBytes();
		case PasswordType.PIN:
			ArgumentNullException.ThrowIfNull(PIN, "PIN");
			return PIN.ToBytes();
		case PasswordType.PUK:
			ArgumentNullException.ThrowIfNull(PUK, "PUK");
			return PUK.ToBytes();
		case PasswordType.MRZ:
			ArgumentNullException.ThrowIfNull(MRZ, "MRZ");
			return MRZ.ToBytes();
		default:
			return Array.Empty<byte>();
		}
	}
}
