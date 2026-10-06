using System;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using DigiD.Common.EID.Enums;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.Models.SecurityInfoObjects;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Nfc;
using DigiD.Common.NFC.Enums;
using DigiD.Common.NFC.Helpers;
using DigiD.Common.NFC.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;

namespace DigiD.Common.EID.Helpers;

internal static class CommandApduBuilder
{
	internal static CommandApdu GetMSESetATCommand(byte[] caOID, byte[]? keyReference, SMContext context)
	{
		byte[] encoded = new DataObject(128, caOID).GetEncoded();
		byte[] array = encoded.ToArray();
		if (keyReference != null)
		{
			byte[] encoded2 = new DataObject(132, keyReference).GetEncoded();
			array = array.Concat(encoded2).ToArray();
		}
		CommandApdu cmd = new CommandApdu(CLA.PLAIN, INS.MANAGE_SEC_ENV, 65, 164, array);
		return cmd.Encrypt(context);
	}

	internal static CommandApdu GetGeneralAuthenticate(byte[] publicKey, SMContext context)
	{
		DataObject data = new DataObject(128, publicKey);
		DataObject dataObject = new DataObject(124, data);
		return new CommandApdu(CLA.PLAIN, INS.GENERAL_AUTH, 0, 0, dataObject.GetEncoded(), 22).Encrypt(context);
	}

	internal static CommandApdu GetMSESetATCAv1Command(byte[] caOID, SMContext context)
	{
		byte[] encoded = new DataObject(128, caOID).GetEncoded();
		CommandApdu cmd = new CommandApdu(CLA.PLAIN, INS.MANAGE_SEC_ENV, 65, 164, encoded);
		return cmd.Encrypt(context);
	}

	internal static CommandApdu GetGeneralAuthenticateCAv1(byte[] publicKey, SMContext context)
	{
		DataObject data = new DataObject(128, publicKey);
		DataObject dataObject = new DataObject(124, data);
		CommandApdu cmd = new CommandApdu(CLA.PLAIN, INS.GENERAL_AUTH, 0, 0, dataObject.GetEncoded(), 0);
		return cmd.Encrypt(context);
	}

	internal static async Task<ResponseApdu> SendAPDU(string header, CommandApdu command, SMContext? context, bool autoDecrypt = true, bool alwaysDecrypt = false)
	{
		Debugger.DumpInfo(header, command);
		TransceiveResult result = await ((IApp)Application.Current).ServiceProvider.GetRequiredService<INfcService>().SendApduAsync(command.Bytes);
		if (!result.Success)
		{
			ArgumentNullException.ThrowIfNull(result.Exception, "result.Exception");
			throw result.Exception;
		}
		ResponseApdu response = new ResponseApdu(result.Data);
		if (autoDecrypt && (IsSuccessOrWarning() || alwaysDecrypt) && context != null && !context.IsBAC)
		{
			response = response.DecryptAES(context);
		}
		Debugger.DumpInfo(header, response);
		return response;
		bool IsSuccessOrWarning()
		{
			int result2;
			if (response.SW1 != 144)
			{
				if (response != null && response.SW1 == 99)
				{
					int sW = response.SW2;
					if (sW >= 193)
					{
						result2 = ((sW <= 207) ? 1 : 0);
						goto IL_004f;
					}
				}
				result2 = 0;
			}
			else
			{
				result2 = 1;
			}
			goto IL_004f;
			IL_004f:
			return (byte)result2 != 0;
		}
	}

	internal static bool ValidateAPDU(byte[] bytes, int index)
	{
		CommandApdu commandApdu = new CommandApdu(bytes);
		return index switch
		{
			0 => commandApdu != null && commandApdu.CLA == CLA.SECURE_MESSAGING && commandApdu.INS == INS.SELECT_FILE && commandApdu.P1 == 4 && commandApdu.P2 == 12, 
			1 => commandApdu != null && commandApdu.CLA == CLA.SECURE_MESSAGING && commandApdu.INS == INS.MANAGE_SEC_ENV && commandApdu.P1 == 65 && commandApdu.P2 == 164, 
			2 => commandApdu != null && commandApdu.CLA == CLA.SECURE_MESSAGING && commandApdu.INS == INS.GENERAL_AUTH && commandApdu.P1 == 0 && commandApdu.P2 == 0, 
			_ => throw new NotImplementedException(), 
		};
	}

	internal static CommandApdu GetMFSelectCommand(SMContext? context, bool enik)
	{
		CommandApdu commandApdu = new CommandApdu(CLA.PLAIN, INS.SELECT_FILE, 0, enik ? 12 : 0, null, 0);
		return (context != null) ? commandApdu.Encrypt(context) : commandApdu;
	}

	internal static CommandApdu GetSelectFileCommand(CardFile file, SMContext? context = null)
	{
		CommandApdu commandApdu = new CommandApdu(CLA.PLAIN, INS.SELECT_FILE, (byte)file.Type, 12, file.Id);
		return (context != null) ? commandApdu.Encrypt(context) : commandApdu;
	}

	internal static CommandApdu ReadSelectedFileCommand(int offset, SMContext? context)
	{
		CommandApdu commandApdu = new CommandApdu(CLA.PLAIN, INS.READ_FILE, (offset & 0xFF00) >> 8, offset & 0xFF, Array.Empty<byte>(), (context != null) ? 231 : 255);
		return (context != null) ? commandApdu.Encrypt(context) : commandApdu;
	}

	internal static CommandApdu GetSelectApplicationCommand(byte[] aid, SMContext? context)
	{
		CommandApdu commandApdu = new CommandApdu(CLA.PLAIN, INS.SELECT_FILE, 4, 12, aid);
		return (context != null) ? commandApdu.Encrypt(context) : commandApdu;
	}

	internal static CommandApdu GetResetRetryCounterCommand(SecureString pin, SMContext context)
	{
		return new CommandApdu(CLA.PLAIN, INS.RESET_RETRY_COUNTER, 2, 3, pin.ToBytes()).Encrypt(context);
	}

	internal static CommandApdu GetChangeReferenceDataCommand(SecureString newPin, SMContext context)
	{
		return new CommandApdu(CLA.PLAIN, INS.CHANGE_REFERENCE_DATA, 1, 0, newPin.ToBytes()).Encrypt(context);
	}

	internal static CommandApdu GetVerifyCommand(byte[] pin, PasswordType passwordType, SMContext context)
	{
		return new CommandApdu(CLA.PLAIN, INS.VERIFY, 0, (byte)passwordType, pin).Encrypt(context);
	}

	internal static CommandApdu GetMSESetATCommand(PaceInfo paceInfo, Certificate? certificate, PasswordType passwordType, SMContext? context)
	{
		byte[] encoded = new DataObject(128, paceInfo.OID.GetEncoded().Skip(2).ToArray()).GetEncoded();
		byte[] encoded2 = new DataObject(131, new byte[1] { (byte)passwordType }).GetEncoded();
		byte[] first;
		if (passwordType == PasswordType.PIN && certificate != null && paceInfo.ParameterId != null)
		{
			byte[] chatOID = certificate.ChatOID;
			byte[] chatDiscretionaryData = certificate.ChatDiscretionaryData;
			byte[] encoded3 = new DataObject(132, paceInfo.ParameterId.Value.ToByteArray()).GetEncoded();
			byte[] encoded4 = new DataObject(32588, chatOID.Concat(chatDiscretionaryData).ToArray()).GetEncoded();
			first = encoded.Concat(encoded2).Concat(encoded4).Concat(encoded3)
				.ToArray();
			byte[] certRelativeAuth = certificate.CertRelativeAuth;
			first = first.Concat(certRelativeAuth).ToArray();
		}
		else
		{
			first = encoded.Concat(encoded2).ToArray();
		}
		CommandApdu commandApdu = new CommandApdu(CLA.PLAIN, INS.MANAGE_SEC_ENV, 193, 164, first);
		if (context != null)
		{
			return commandApdu.Encrypt(context);
		}
		return commandApdu;
	}

	internal static CommandApdu GetNonceCommand(SMContext? context)
	{
		DataObject dataObject = new DataObject(124, Array.Empty<byte>());
		CommandApdu commandApdu = new CommandApdu(CLA.COMMAND_CHAINING, INS.GENERAL_AUTH, 0, 0, dataObject.GetEncoded(), 0);
		return (context != null) ? commandApdu.Encrypt(context, chaining: true) : commandApdu;
	}

	internal static CommandApdu GetMapCommand(byte[] publicKey, SMContext? context)
	{
		DataObject data = new DataObject(129, publicKey);
		DataObject dataObject = new DataObject(124, data);
		CommandApdu commandApdu = new CommandApdu(CLA.COMMAND_CHAINING, INS.GENERAL_AUTH, 0, 0, dataObject.GetEncoded(), 0);
		return (context != null) ? commandApdu.Encrypt(context, chaining: true) : commandApdu;
	}

	internal static CommandApdu GetPairAgreementCommand(byte[] publicKey, SMContext? context)
	{
		DataObject data = new DataObject(131, publicKey);
		DataObject dataObject = new DataObject(124, data);
		CommandApdu commandApdu = new CommandApdu(CLA.COMMAND_CHAINING, INS.GENERAL_AUTH, 0, 0, dataObject.GetEncoded(), 0);
		return (context != null) ? commandApdu.Encrypt(context, chaining: true) : commandApdu;
	}

	internal static CommandApdu GetAuthCommand(byte[] terminalKey, SMContext? context)
	{
		DataObject data = new DataObject(133, terminalKey);
		DataObject dataObject = new DataObject(124, data);
		CommandApdu commandApdu = new CommandApdu(CLA.PLAIN, INS.GENERAL_AUTH, 0, 0, dataObject.GetEncoded(), 0);
		return (context != null) ? commandApdu.Encrypt(context) : commandApdu;
	}

	internal static CommandApdu GetSetDSTCommand(byte[] car, SMContext context)
	{
		DataObject dataObject = new DataObject(131, car);
		return new CommandApdu(CLA.PLAIN, INS.MANAGE_SEC_ENV, 129, 182, dataObject.GetEncoded()).Encrypt(context);
	}

	internal static CommandApdu[] GetPSOVerifyCertificateCommand(Certificate certificate, SMContext context)
	{
		byte[] data = certificate.Body.Concat(certificate.Signature).ToArray();
		return new CommandApdu(CLA.PLAIN, INS.PERFORM_SEC_OP, 0, 190, data).EncryptMulti(context);
	}

	internal static CommandApdu GetMSESetATCommand(byte[] publicKey, byte[] taInfoOID, byte[] cardHolderReference, SMContext context)
	{
		byte[] encoded = new DataObject(128, taInfoOID).GetEncoded();
		byte[] encoded2 = new DataObject(131, cardHolderReference).GetEncoded();
		byte[] encoded3 = new DataObject(145, publicKey).GetEncoded();
		byte[] data = encoded.Concat(encoded2).Concat(encoded3).ToArray();
		return new CommandApdu(CLA.PLAIN, INS.MANAGE_SEC_ENV, 129, 164, data).Encrypt(context);
	}

	internal static CommandApdu GetChallengeCommand(SMContext context)
	{
		return new CommandApdu(CLA.PLAIN, INS.CHALLENGE, 0, 0, Array.Empty<byte>(), 8).Encrypt(context);
	}

	internal static CommandApdu GetExternalAuthenticate(byte[] signedData, SMContext context)
	{
		return new CommandApdu(CLA.PLAIN, INS.EXTERNAL_AUTHENTICATE, 0, 0, signedData).Encrypt(context);
	}
}
