using System;
using System.Linq;
using System.Threading.Tasks;
using DigiD.Common.EID.Enums;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.NFC.Enums;
using DigiD.Common.NFC.Models;
using Org.BouncyCastle.Asn1;

namespace DigiD.Common.EID.CardSteps.PACE;

internal class StepMutualAuthentication(Gap gap) : IStep
{
	public async Task<bool> Execute()
	{
		ArgumentNullException.ThrowIfNull(gap.Pace?.TerminalToken, "gap.Pace?.TerminalToken");
		CommandApdu command = CommandApduBuilder.GetAuthCommand(gap.Pace.TerminalToken, gap.SMContext);
		ResponseApdu response = await CommandApduBuilder.SendAPDU("PACE MutualAuthentication", command, gap.SMContext);
		if (response.SW1 == 99)
		{
			if (!gap.PinTriesLeft.HasValue)
			{
				switch (gap.Pace.PasswordType)
				{
				case PasswordType.PIN:
					gap.PinTriesLeft = 5;
					break;
				case PasswordType.PUK:
					gap.PinTriesLeft = 10;
					break;
				}
			}
			else if (gap.PinTriesLeft == 1)
			{
				gap.IsBlocked = true;
			}
			gap.AuthenticationResult = AuthenticationResult.Failed;
		}
		else if (response.SW == 36864)
		{
			gap.AuthenticationResult = AuthenticationResult.Success;
		}
		else if (EIDSession.Card.DocumentType == DocumentType.IDCard && response.SW == 25088)
		{
			gap.ChangePinRequired = true;
			return true;
		}
		return response.SW == 36864 && ParseData(response.Data);
	}

	private bool ParseData(byte[] data)
	{
		ArgumentNullException.ThrowIfNull(gap.Pace, "gap.Pace");
		using Asn1InputStream asn1InputStream = new Asn1InputStream(data);
		Asn1Object baseUniversal = ((DerTaggedObject)asn1InputStream.ReadObject()).GetBaseUniversal(declaredExplicit: false, 17);
		Asn1Set instance = Asn1Set.GetInstance(baseUniversal);
		foreach (Asn1TaggedObject item in instance.Cast<Asn1TaggedObject>())
		{
			byte[] octets = ((DerOctetString)item.GetBaseObject()).GetOctets();
			switch (item.TagNo)
			{
			case 6:
				gap.Pace.CardAuthToken = octets;
				break;
			case 7:
				gap.Pace.Car = octets;
				break;
			}
		}
		return true;
	}
}
