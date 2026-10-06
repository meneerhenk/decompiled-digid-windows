using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Interfaces.Api;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.Models.Network.Requests;
using DigiD.Common.EID.Models.Network.Responses;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace DigiD.Common.EID.CardSteps.TA.RDW;

internal class StepSendPcaInfo : BaseSecureStep, IStep
{
	public StepSendPcaInfo(ISecureCardOperation operation)
		: base(operation)
	{
	}

	public async Task<bool> Execute()
	{
		ArgumentNullException.ThrowIfNull(base.Operation.GAP?.Pace?.Car, "Operation.GAP?.Pace?.Car");
		ArgumentNullException.ThrowIfNull(base.Operation.GAP?.Pace?.CardAgreedPublicKey, "Operation.GAP?.Pace?.CardAgreedPublicKey");
		ArgumentNullException.ThrowIfNull(EIDSession.Card?.EF_CardAccess?.Bytes, "EIDSession.Card?.EF_CardAccess?.Bytes");
		var msgData = new
		{
			car = Convert.ToBase64String(base.Operation.GAP.Pace.Car),
			idpicc = Convert.ToBase64String(base.Operation.GAP.Pace.CardAgreedPublicKey.Q.XCoord.GetEncoded()),
			efCardAccess = Convert.ToBase64String(EIDSession.Card.EF_CardAccess.Bytes)
		};
		EIDBaseRequest requestData = new EIDBaseRequest(msgData);
		IRDWApi api = ((IApp)Application.Current).ServiceProvider.GetRequiredService<IRDWApi>();
		PcaInfoServerResponse response = await api.SendPCAInfo(requestData);
		base.Operation.GAP.ApiResult = response.ApiResult;
		if (response.ApiResult == ApiResult.Ok)
		{
			((TerminalAuthenticationRdw)base.Operation).PublicKey = (ECPublicKeyParameters)PublicKeyFactory.CreateKey(response.InfoResponse.EphemeralKey);
			((TerminalAuthenticationRdw)base.Operation).DvCert = new Certificate(response.InfoResponse.DvCertificate);
			((TerminalAuthenticationRdw)base.Operation).LinkCerts = response.InfoResponse.LinkCertificates?.Select((byte[] x) => new Certificate(x)).ToList() ?? new List<Certificate>();
			return true;
		}
		return false;
	}
}
