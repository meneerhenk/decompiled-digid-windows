using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BerTlv;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.Cards;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.NFC.Enums;
using DigiD.Common.NFC.Models;
using Org.BouncyCastle.Crypto.Parameters;

namespace DigiD.Common.EID.CardSteps.CAv2;

internal class StepGeneralAuthenticate : BaseSecureStep, IStep
{
	private ECPublicKeyParameters? _pk;

	public StepGeneralAuthenticate(ISecureCardOperation operation, ECPublicKeyParameters? pk = null)
	{
		_pk = pk;
		base._002Ector(operation);
	}

	public async Task<bool> Execute()
	{
		ArgumentNullException.ThrowIfNull(EIDSession.Card, "EIDSession.Card");
		ArgumentNullException.ThrowIfNull(base.Operation.GAP?.SMContext, "Operation.GAP?.SMContext");
		if (_pk == null)
		{
			_pk = ((eNIK)EIDSession.Card).CardAuthenticationPublicKey;
		}
		ArgumentNullException.ThrowIfNull(_pk, "_pk");
		CommandApdu command = CommandApduBuilder.GetGeneralAuthenticate(_pk.Q.GetEncoded(), base.Operation.GAP.SMContext);
		ResponseApdu response = await CommandApduBuilder.SendAPDU("CA General Authenticate", command, base.Operation.GAP.SMContext);
		if (response.SW != 36864)
		{
			return false;
		}
		if (EIDSession.Card.DocumentType == DocumentType.DrivingLicense)
		{
			ICollection<Tlv> tlvs = Tlv.ParseTlv(response.Data);
			List<Tlv> data = tlvs.First().Children.ToList();
			ISecureCardOperation operation = base.Operation;
			if (operation is ChipAuthenticationRdw op)
			{
				op.Ricc = data[0].Value;
				op.Ticc = data[1].Value;
			}
		}
		return true;
	}
}
