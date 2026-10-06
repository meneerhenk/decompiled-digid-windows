using System;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Nfc;
using DigiD.Common.NFC.Helpers;
using DigiD.Common.NFC.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;

namespace DigiD.Common.EID.CardSteps.Randomize;

internal class StepSendSecureCommandsToPca : BaseSecureStep, IStep
{
	public StepSendSecureCommandsToPca(ISecureCardOperation operation)
		: base(operation)
	{
	}

	public async Task<bool> Execute()
	{
		int index = -1;
		EIDSession.ResponseAPDUs.Clear();
		if (EIDSession.CommandAPDUs == null)
		{
			ArgumentNullException.ThrowIfNull(EIDSession.CommandAPDUs, "EIDSession.CommandAPDUs");
		}
		string[] commandAPDUs = EIDSession.CommandAPDUs;
		foreach (string apdu in commandAPDUs)
		{
			byte[] bytes = Convert.FromBase64String(apdu);
			index++;
			Console.WriteLine($"Index: {index}: {apdu}");
			if (!CommandApduBuilder.ValidateAPDU(bytes, index))
			{
				continue;
			}
			TransceiveResult result = await ((IApp)Application.Current).ServiceProvider.GetRequiredService<INfcService>().SendApduAsync(bytes);
			CommandApdu request = new CommandApdu(bytes);
			Debugger.DumpInfo("SERVER COMMAND", request);
			if (result.Success)
			{
				ResponseApdu responseApdu = new ResponseApdu(result.Data);
				Debugger.DumpInfo("SERVER RESPONSE", responseApdu);
				if (responseApdu.SW == 36864)
				{
					EIDSession.ResponseAPDUs.Add(responseApdu.Bytes);
					continue;
				}
				Debugger.WriteLine($"Received an incorrect response from PCA: {responseApdu.SW}");
			}
		}
		return true;
	}
}
