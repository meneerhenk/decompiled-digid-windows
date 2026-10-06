using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.Cards;
using DigiD.Common.EID.Enums;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.NFC.Models;

namespace DigiD.Common.EID.CardSteps.TA.RDW;

internal class StepMseSetDst : BaseSecureStep, IStep
{
	public StepMseSetDst(ISecureCardOperation operation, CertificateType certificateType)
	{
		_003CcertificateType_003EP = certificateType;
		base._002Ector(operation);
	}

	public async Task<bool> Execute()
	{
		byte[] car = null;
		Certificate cert = null;
		if (_003CcertificateType_003EP == CertificateType.DVCACertificate)
		{
			ISecureCardOperation operation = base.Operation;
			if (operation is TerminalAuthenticationRdw ta)
			{
				Certificate linkCert = ta.LinkCerts.FirstOrDefault();
				car = ((linkCert != null) ? linkCert.CardAuthReference : ta.DvCert?.CardAuthReference);
				cert = ta.LinkCerts.FirstOrDefault() ?? ta.DvCert;
			}
		}
		else
		{
			Card card = EIDSession.Card;
			if (card is DrivingLicense card2)
			{
				car = card2.ATCertificate?.CardAuthReference;
				cert = card2.ATCertificate;
			}
		}
		ArgumentNullException.ThrowIfNull(car, "car");
		ArgumentNullException.ThrowIfNull(cert, "cert");
		ArgumentNullException.ThrowIfNull(base.Operation.GAP?.SMContext, "Operation.GAP?.SMContext");
		if ((await CommandApduBuilder.SendAPDU(command: CommandApduBuilder.GetSetDSTCommand(car, base.Operation.GAP.SMContext), header: "TA MSESetDST - " + Encoding.UTF8.GetString(car), context: base.Operation.GAP.SMContext)).SW == 36864)
		{
			CommandApdu[] commands = CommandApduBuilder.GetPSOVerifyCertificateCommand(cert, base.Operation.GAP.SMContext);
			bool success = true;
			int x = 1;
			CommandApdu[] array = commands;
			for (int i = 0; i < array.Length; i++)
			{
				if ((await CommandApduBuilder.SendAPDU(command: array[i], header: $"TA PSOVerifyCertificate part {x++}", context: null)).SW != 36864)
				{
					success = false;
					break;
				}
			}
			base.Operation.GAP.SMContext.IncrementSSC();
			if (((TerminalAuthenticationRdw)base.Operation).LinkCerts.Count > 0)
			{
				((TerminalAuthenticationRdw)base.Operation).LinkCerts.RemoveAt(0);
				return await Execute().ConfigureAwait(continueOnCapturedContext: false);
			}
			return success;
		}
		return false;
	}
}
