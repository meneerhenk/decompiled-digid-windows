using System;
using System.Threading.Tasks;
using DigiD.Common.EID.Cards;
using DigiD.Common.EID.Enums;
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

namespace DigiD.Common.EID.CardSteps.PACE;

public class StepGetATCertificateRdw(Gap gap) : IStep
{
	public async Task<bool> Execute()
	{
		ArgumentNullException.ThrowIfNull(gap.SessionData, "gap.SessionData");
		var requestData = new
		{
			userConsentType = ((gap.UserConsent == UserConsent.PP) ? "PP" : "PIP"),
			documentType = Convert.ToBase64String(EIDSession.Card.CardAID)
		};
		EIDBaseRequest data = new EIDBaseRequest(requestData);
		IRDWApi api = ((IApp)Application.Current).ServiceProvider.GetRequiredService<IRDWApi>();
		AtCertificateResponse response = await api.GetCertificates(data);
		gap.ApiResult = response.ApiResult;
		int num;
		if (response != null && response.ApiResult == ApiResult.Ok)
		{
			CertificateResponseData data2 = response.Data;
			if (data2 != null)
			{
				num = ((data2.AtCertificate != null) ? 1 : 0);
				goto IL_0164;
			}
		}
		num = 0;
		goto IL_0164;
		IL_0164:
		if (num != 0)
		{
			((DrivingLicense)EIDSession.Card).ATCertificate = new Certificate(Convert.FromBase64String(response.Data.AtCertificate));
			return true;
		}
		return false;
	}
}
