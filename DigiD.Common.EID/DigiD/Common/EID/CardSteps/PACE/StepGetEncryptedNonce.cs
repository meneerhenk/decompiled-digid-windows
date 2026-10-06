using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using BerTlv;
using DigiD.Common.EID.Enums;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.NFC.Enums;
using DigiD.Common.NFC.Models;

namespace DigiD.Common.EID.CardSteps.PACE;

internal class StepGetEncryptedNonce(Gap gap) : IStep
{
	public async Task<bool> Execute()
	{
		CommandApdu command = CommandApduBuilder.GetNonceCommand(gap.SMContext);
		ResponseApdu response = await CommandApduBuilder.SendAPDU("PACE GetEncryptedNonce", command, gap.SMContext);
		if (response.SW == 36864)
		{
			return ParseData(response.Data);
		}
		return false;
	}

	private bool ParseData(byte[] data)
	{
		ICollection<Tlv> source = Tlv.ParseTlv(data);
		Tlv tlv = source.FirstOrDefault()?.FindTag("80");
		if (tlv == null)
		{
			return false;
		}
		ArgumentNullException.ThrowIfNull(gap.Pace?.Password, "gap.Pace?.Password");
		ArgumentNullException.ThrowIfNull(EIDSession.Card, "EIDSession.Card");
		byte[] array = gap.Pace.Password;
		if (gap.Pace.PasswordType == PasswordType.MRZ && EIDSession.Card.DocumentType != DocumentType.DrivingLicense)
		{
			array = SHA1.HashData(array);
		}
		byte[] data2 = array.Concat(new byte[4] { 0, 0, 0, 3 }).ToArray();
		byte[] key = AesHelper.CalculateHash(data2, EIDSession.Card.MessageDigestAlgorithm, EIDSession.Card.KeyLength);
		gap.Pace.DecryptedNonce = AesHelper.AESCBC(forEncryption: false, tlv.Value, key);
		return true;
	}
}
