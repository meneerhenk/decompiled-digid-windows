using System.Threading.Tasks;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.NFC.Enums;
using DigiD.Common.NFC.Models;

namespace DigiD.Common.EID.CardSteps.BAC;

public class StepRequestRandomNumber(BacOperation operation) : IStep
{
	public async Task<bool> Execute()
	{
		CommandApdu cmd = new CommandApdu(CLA.PLAIN, INS.CHALLENGE, 0, 0, null, 8);
		ResponseApdu response = await CommandApduBuilder.SendAPDU("random", cmd, null);
		if (response.SW == 36864)
		{
			operation.RND_IC = response.Data;
			return true;
		}
		return false;
	}
}
