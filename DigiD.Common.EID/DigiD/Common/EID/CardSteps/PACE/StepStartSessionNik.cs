using System;
using System.Threading.Tasks;
using DigiD.Common.EID.Enums;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Interfaces.Api;
using DigiD.Common.EID.Models.Network.Requests;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Responses;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;

namespace DigiD.Common.EID.CardSteps.PACE;

internal class StepStartSessionNik : IStep
{
	private readonly Gap _gap;

	internal StepStartSessionNik(Gap gap)
	{
		_gap = gap;
	}

	public async Task<bool> Execute()
	{
		if (_gap.SessionData == null)
		{
			return true;
		}
		ArgumentNullException.ThrowIfNull(EIDSession.Card, "EIDSession.Card");
		var requestData = new
		{
			userConsentType = ((_gap.UserConsent == UserConsent.PP) ? "PP" : "PIP"),
			documentType = Convert.ToBase64String(EIDSession.Card.CardAID)
		};
		EIDBaseRequest data = new EIDBaseRequest(requestData);
		INIKApi api = ((IApp)Application.Current).ServiceProvider.GetRequiredService<INIKApi>();
		BaseResponse response = await api.StartSession(data);
		_gap.ApiResult = response.ApiResult;
		return response.ApiResult == ApiResult.Ok;
	}
}
