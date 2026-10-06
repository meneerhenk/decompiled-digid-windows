using System;
using System.Linq;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.Cards;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.Models.CardFiles;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.NFC.Enums;
using DigiD.Common.NFC.Models;

namespace DigiD.Common.EID.CardSteps.CAv2;

internal class StepMseSetAT : BaseSecureStep, IStep
{
	public StepMseSetAT(ISecureCardOperation operation)
		: base(operation)
	{
	}

	public async Task<bool> Execute()
	{
		ArgumentNullException.ThrowIfNull(EIDSession.Card, "EIDSession.Card");
		byte[] oid = null;
		byte[] keyReference = null;
		switch (EIDSession.Card.DocumentType)
		{
		case DocumentType.DrivingLicense:
		{
			Card card = EIDSession.Card;
			DrivingLicense card2 = card as DrivingLicense;
			if (card2 != null && card2.CardSecurity != null)
			{
				oid = card2.CardSecurity.OID.GetEncoded().Skip(2).ToArray();
				keyReference = card2.CardSecurity.KeyReference;
			}
			break;
		}
		case DocumentType.IDCard:
		{
			File file = EIDSession.Card.DataGroups[14];
			DG14 dg14 = file as DG14;
			if (dg14 != null && dg14.ChipAuthenticationInfo != null)
			{
				oid = dg14.ChipAuthenticationInfo.OID.GetEncoded().Skip(2).ToArray();
				keyReference = dg14.ChipAuthenticationInfo.KeyId;
			}
			break;
		}
		default:
			throw new NotImplementedException();
		}
		ArgumentNullException.ThrowIfNull(base.Operation.GAP?.SMContext, "Operation.GAP?.SMContext");
		ArgumentNullException.ThrowIfNull(oid, "oid");
		CommandApdu command = CommandApduBuilder.GetMSESetATCommand(oid, keyReference, base.Operation.GAP.SMContext);
		return (await CommandApduBuilder.SendAPDU("CA Set AT", command, base.Operation.GAP.SMContext)).SW == 36864;
	}
}
