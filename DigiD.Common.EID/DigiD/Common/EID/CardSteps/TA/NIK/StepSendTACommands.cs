using System;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.Cards;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Interfaces.Api;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.Models.Network.Requests;
using DigiD.Common.EID.Models.Network.Responses;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.NFC.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;

namespace DigiD.Common.EID.CardSteps.TA.NIK;

internal class StepSendTACommands : BaseSecureStep, IStep
{
	public StepSendTACommands(ISecureCardOperation operation)
		: base(operation)
	{
	}

	public async Task<bool> Execute()
	{
		int index = -1;
		ResponseApdu latestResponse = null;
		Card card = EIDSession.Card;
		if (!(card is eNIK card2))
		{
			return false;
		}
		if (card2.TACommands.Count == 0)
		{
			return false;
		}
		foreach (string commandString in card2.TACommands)
		{
			index++;
			byte[] bytes = Convert.FromBase64String(commandString);
			latestResponse = await CommandApduBuilder.SendAPDU(command: new CommandApdu(bytes)
			{
				IsSecureMessage = true
			}, header: $"APDUCommand {index}", context: null);
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
		INIKApi api = ((IApp)Application.Current).ServiceProvider.GetRequiredService<INIKApi>();
		EIDBaseRequest data = new EIDBaseRequest(requestData);
		PcaCommandsResponse response = await api.PreparePCA(data);
		if (response.ApiResult != ApiResult.Ok)
		{
			return false;
		}
		ArgumentNullException.ThrowIfNull(base.Operation.GAP, "Operation.GAP");
		base.Operation.GAP.ApiResult = response.ApiResult;
		if (response.Data != null)
		{
			card2.PCACommands = response.Data.APDUCommandos;
			return true;
		}
		return false;
	}
}
