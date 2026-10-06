using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;

namespace DigiD.Common.EID.CardSteps.BAC;

public class StepCalculateKSeed : IStep
{
	private readonly BacOperation _operation;

	public StepCalculateKSeed(BacOperation operation)
	{
		_operation = operation;
	}

	public Task<bool> Execute()
	{
		byte[] source = SHA1.HashData(_operation.Mrz.ToBytes());
		byte[] array = source.Take(16).ToArray();
		_operation.KSeed = array;
		return Task.FromResult(array.Length != 0);
	}
}
