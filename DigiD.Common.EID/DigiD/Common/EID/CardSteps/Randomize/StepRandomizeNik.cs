using System;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.Cards;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Interfaces.Api;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.Models.Network.Requests;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Responses;
using DigiD.Common.NFC.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;

namespace DigiD.Common.EID.CardSteps.Randomize;

internal class StepRandomizeNik : BaseSecureStep, IStep
{
	public StepRandomizeNik(ISecureCardOperation operation)
		: base(operation)
	{
	}

	public async Task<bool> Execute()
	{
		Card card = EIDSession.Card;
		if (card is eNIK card2)
		{
			int index = card2.TACommands.Count - 1;
			ResponseApdu latestResponse = null;
			foreach (string commandString in card2.PCACommands)
			{
				index++;
				latestResponse = await CommandApduBuilder.SendAPDU(command: new CommandApdu(Convert.FromBase64String(commandString)), header: $"APDUCommand {index}", context: null);
				if (latestResponse.SW != 36864)
				{
					break;
				}
			}
			var requestData = new
			{
				counter = index,
				apdu = ((latestResponse != null) ? Convert.ToBase64String(latestResponse.Bytes) : null)
			};
			EIDBaseRequest data = new EIDBaseRequest(requestData);
			INIKApi api = ((IApp)Application.Current).ServiceProvider.GetRequiredService<INIKApi>();
			BaseResponse response = await api.Randomize(data);
			ArgumentNullException.ThrowIfNull(base.Operation.GAP, "Operation.GAP");
			base.Operation.GAP.ApiResult = response.ApiResult;
			base.Operation.GAP.SMContext = null;
			return response.ApiResult == ApiResult.Ok;
		}
		return false;
	}
}
