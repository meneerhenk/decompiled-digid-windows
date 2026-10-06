using System;
using System.Threading.Tasks;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;

namespace DigiD.Common.EID.CardSteps.BAC;

public class StepCalculateBasicAccessKeys(BacOperation operation) : IStep
{
	public Task<bool> Execute()
	{
		ArgumentNullException.ThrowIfNull(operation.KSeed, "operation.KSeed");
		operation.KEnc = CryptoDesHelper.ComputeKey(operation.KSeed, BacOperation.ENC_C);
		operation.KMac = CryptoDesHelper.ComputeKey(operation.KSeed, BacOperation.MAC_C);
		return Task.FromResult(result: true);
	}
}
