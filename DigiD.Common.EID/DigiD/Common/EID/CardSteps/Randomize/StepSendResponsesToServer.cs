using System;
using System.Linq;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Interfaces.Api;
using DigiD.Common.EID.Models.Network.Requests;
using DigiD.Common.EID.Models.Network.Responses;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;

namespace DigiD.Common.EID.CardSteps.Randomize;

internal class StepSendResponsesToServer : BaseSecureStep, IStep
{
	public StepSendResponsesToServer(ISecureCardOperation operation)
		: base(operation)
	{
	}

	public async Task<bool> Execute()
	{
		EIDBaseRequest requestData = new EIDBaseRequest(new
		{
			apduResponses = EIDSession.ResponseAPDUs.Select(Convert.ToBase64String).ToArray()
		});
		IRDWApi api = ((IApp)Application.Current).ServiceProvider.GetRequiredService<IRDWApi>();
		SendSecureCommandsResponse response = await api.SendCommands(requestData);
		ArgumentNullException.ThrowIfNull(base.Operation.GAP, "Operation.GAP");
		base.Operation.GAP.ApiResult = response.ApiResult;
		int num;
		if (response != null && response.ApiResult == ApiResult.Ok)
		{
			SendCommandsResult data = response.Data;
			if (data != null)
			{
				num = ((data.Result != null) ? 1 : 0);
				goto IL_0159;
			}
		}
		num = 0;
		goto IL_0159;
		IL_0159:
		if (num != 0)
		{
			return response.Data.Result.Equals("OK", StringComparison.InvariantCultureIgnoreCase);
		}
		return false;
	}
}
