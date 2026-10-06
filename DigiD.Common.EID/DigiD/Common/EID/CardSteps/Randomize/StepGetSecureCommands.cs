using System;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.CardSteps.CAv2;
using DigiD.Common.EID.Cards;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Interfaces.Api;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.Models.CardFiles;
using DigiD.Common.EID.Models.Network.Requests;
using DigiD.Common.EID.Models.Network.Responses;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;

namespace DigiD.Common.EID.CardSteps.Randomize;

internal class StepGetSecureCommands : BaseSecureStep, IStep
{
	public StepGetSecureCommands(ISecureCardOperation operation)
		: base(operation)
	{
	}

	public async Task<bool> Execute()
	{
		Card card = EIDSession.Card;
		DrivingLicense card2 = card as DrivingLicense;
		int num;
		if (card2 != null)
		{
			ChipAuthenticationRdw cA = card2.CA;
			if (cA != null && cA.Ricc != null && cA.Ticc != null)
			{
				EFCardSecurity cardSecurity = card2.CardSecurity;
				if (cardSecurity != null)
				{
					num = ((cardSecurity.Bytes != null) ? 1 : 0);
					goto IL_006d;
				}
			}
		}
		num = 0;
		goto IL_006d;
		IL_006d:
		if (num != 0)
		{
			string efCardSecurity = Convert.ToBase64String(card2.CardSecurity.Bytes);
			string pcaApplicationID = Convert.ToBase64String(card2.PolymorphicAID);
			var msgData = new
			{
				efCardSecurity = efCardSecurity,
				pcaApplicationId = pcaApplicationID,
				rpicc = Convert.ToBase64String(card2.CA.Ricc),
				tpicc = Convert.ToBase64String(card2.CA.Ticc)
			};
			EIDBaseRequest requestData = new EIDBaseRequest(msgData);
			IRDWApi api = ((IApp)Application.Current).ServiceProvider.GetRequiredService<IRDWApi>();
			SetupSecureMessagingResponse response = await api.SetupSecureChannel(requestData);
			ArgumentNullException.ThrowIfNull(base.Operation.GAP, "Operation.GAP");
			base.Operation.GAP.ApiResult = response.ApiResult;
			if (response != null && response.ApiResult == ApiResult.Ok && response.Data != null)
			{
				EIDSession.CommandAPDUs = response.Data.Commands;
				return true;
			}
		}
		return false;
	}
}
