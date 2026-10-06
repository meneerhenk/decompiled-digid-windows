using System;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.Cards;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Interfaces.Api;
using DigiD.Common.EID.Models.Network.Requests;
using DigiD.Common.EID.Models.Network.Responses;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Helpers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace DigiD.Common.EID.CardSteps.CAv2;

internal class StepSendFilesToServer : BaseSecureStep, IStep
{
	internal StepSendFilesToServer(ISecureCardOperation operation)
		: base(operation)
	{
	}

	public async Task<bool> Execute()
	{
		ArgumentNullException.ThrowIfNull(EIDSession.Card, "EIDSession.Card");
		ArgumentNullException.ThrowIfNull(base.Operation.GAP, "Operation.GAP");
		eNIK card = (eNIK)EIDSession.Card;
		var requestData = new
		{
			efCvca = card.CVCA?.Base64Encoded,
			dg14 = card.DataGroups[14].Base64Encoded,
			efSOd = card.EF_SOd?.Base64Encoded,
			paceIcc = base.Operation.GAP.Pace?.CardAgreedPublicKey?.Q.XCoord.GetEncoded().ToBase64()
		};
		EIDBaseRequest data = new EIDBaseRequest(requestData);
		INIKApi api = ((IApp)Application.Current).ServiceProvider.GetRequiredService<INIKApi>();
		TerminalAuthenticationCommandResponses response = await api.PrepareEAC(data);
		if (response.ApiResult != ApiResult.Ok)
		{
			return false;
		}
		base.Operation.GAP.ApiResult = response.ApiResult;
		TerminalAuthenticationCommandResponsesData data2 = response.Data;
		if (data2 != null && data2.EphemeralKey != null)
		{
			card.TACommands = response.Data.Commands;
			card.CardAuthenticationPublicKey = (ECPublicKeyParameters)PublicKeyFactory.CreateKey(Convert.FromBase64String(response.Data.EphemeralKey));
			return true;
		}
		return false;
	}
}
