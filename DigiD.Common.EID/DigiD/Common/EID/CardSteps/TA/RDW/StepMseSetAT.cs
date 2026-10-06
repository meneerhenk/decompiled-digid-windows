using System;
using System.Linq;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.Cards;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.NFC.Models;

namespace DigiD.Common.EID.CardSteps.TA.RDW;

internal class StepMseSetAT : BaseSecureStep, IStep
{
	public StepMseSetAT(ISecureCardOperation operation)
		: base(operation)
	{
	}

	public async Task<bool> Execute()
	{
		Card card = EIDSession.Card;
		DrivingLicense card2 = card as DrivingLicense;
		if (card2 != null && card2.ATCertificate != null)
		{
			ArgumentNullException.ThrowIfNull(base.Operation.GAP?.SMContext, "Operation.GAP?.SMContext");
			ISecureCardOperation operation = base.Operation;
			TerminalAuthenticationRdw taRdw = operation as TerminalAuthenticationRdw;
			if (taRdw != null && taRdw.PublicKey != null)
			{
				byte[] pkPCD = taRdw.PublicKey.Q.GetEncoded(compressed: true).Skip(1).ToArray();
				byte[] taOID = card2.ATCertificate.PublicKeyOID;
				CommandApdu command = CommandApduBuilder.GetMSESetATCommand(pkPCD, taOID, card2.ATCertificate.CardHolderReference, base.Operation.GAP.SMContext);
				return (await CommandApduBuilder.SendAPDU("MSESetAT", command, base.Operation.GAP.SMContext)).SW == 36864;
			}
		}
		return false;
	}
}
