using System;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Interfaces.Api;
using DigiD.Common.EID.Models.Network.Requests;
using DigiD.Common.EID.Models.Network.Responses;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.NFC.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;

namespace DigiD.Common.EID.CardSteps.TA.RDW;

internal class StepExternalAuthentication : BaseSecureStep, IStep
{
	private readonly TerminalAuthenticationRdw _operation;

	public StepExternalAuthentication(ISecureCardOperation operation)
		: base(operation)
	{
		_operation = (TerminalAuthenticationRdw)base.Operation;
	}

	public async Task<bool> Execute()
	{
		ArgumentNullException.ThrowIfNull(_operation.Ricc, "_operation.Ricc");
		var requestData = new
		{
			challenge = Convert.ToBase64String(_operation.Ricc)
		};
		EIDBaseRequest request = new EIDBaseRequest(requestData);
		IRDWApi api = ((IApp)Application.Current).ServiceProvider.GetRequiredService<IRDWApi>();
		PcaChallengeResponse response = await api.Challenge(request);
		ArgumentNullException.ThrowIfNull(base.Operation.GAP, "Operation.GAP");
		ArgumentNullException.ThrowIfNull(base.Operation.GAP?.SMContext, "Operation.GAP?.SMContext");
		base.Operation.GAP.ApiResult = response.ApiResult;
		int num;
		if (response != null && response.ApiResult == ApiResult.Ok)
		{
			ChallengeResponseData challengeResponse = response.ChallengeResponse;
			if (challengeResponse != null)
			{
				num = ((challengeResponse.Signature != null) ? 1 : 0);
				goto IL_019d;
			}
		}
		num = 0;
		goto IL_019d;
		IL_019d:
		if (num != 0)
		{
			byte[] signatureFromServer = ByteHelper.GetSignature(Convert.FromBase64String(response.ChallengeResponse.Signature));
			CommandApdu command = CommandApduBuilder.GetExternalAuthenticate(signatureFromServer, base.Operation.GAP.SMContext);
			return (await CommandApduBuilder.SendAPDU("TA ExternalAuthentication", command, base.Operation.GAP.SMContext)).SW == 36864;
		}
		return false;
	}
}
