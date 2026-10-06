using System;
using System.Linq;
using System.Threading.Tasks;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Helpers;
using DigiD.Common.Models.Nfc;
using DigiD.Common.NFC.Enums;
using DigiD.Common.NFC.Helpers;
using DigiD.Common.NFC.Models;

namespace DigiD.Common.EID.Helpers;

public static class CardHelper
{
	public static async Task<Card?> ReadCard(this INfcService service)
	{
		Card drivingLicense = Card.AvailableCards.First((Card x) => x.DocumentType == DocumentType.DrivingLicense);
		Card nik = Card.AvailableCards.First((Card x) => x.DocumentType == DocumentType.IDCard);
		Card result = null;
		if (service.SelectedAID != null)
		{
			byte[] aid = service.SelectedAID.ToBytes();
			result = (((ReadOnlySpan<byte>)aid).SequenceEqual((ReadOnlySpan<byte>)nik.CardAID) ? nik : drivingLicense);
		}
		if (result == null)
		{
			if (await SelectAID(drivingLicense))
			{
				result = drivingLicense;
			}
			else if (await SelectAID(nik))
			{
				result = nik;
			}
		}
		if (result != null)
		{
			CommandApdu cmd = new CommandApdu(CLA.PLAIN, INS.SELECT_FILE, 0, (result.DocumentType == DocumentType.IDCard) ? 12 : 0, null, 0);
			await service.SendApduAsync(cmd.Bytes);
		}
		return result;
		async Task<bool> SelectAID(Card card)
		{
			CommandApdu cmd2 = new CommandApdu(CLA.PLAIN, INS.SELECT_FILE, 4, 12, card.CardAID);
			Debugger.DumpInfo("SELECT BY AID", cmd2);
			TransceiveResult res = await service.SendApduAsync(cmd2.Bytes);
			if (res.Success)
			{
				ResponseApdu response = new ResponseApdu(res.Data);
				Debugger.DumpInfo("SELECT BY AID", response);
				return response.SW == 36864;
			}
			if (res.Exception != null)
			{
				throw res.Exception;
			}
			return false;
		}
	}

	public static void SetCard(DocumentType documentType)
	{
		EIDSession.Card = Card.AvailableCards.FirstOrDefault((Card x) => x.DocumentType == documentType);
	}
}
