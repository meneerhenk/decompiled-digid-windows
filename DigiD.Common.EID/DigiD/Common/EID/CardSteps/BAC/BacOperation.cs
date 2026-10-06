using System.Security;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.CardSteps.FileOperations;
using DigiD.Common.EID.Interfaces;

namespace DigiD.Common.EID.CardSteps.BAC;

public class BacOperation : BaseCardOperation, IStep
{
	private readonly Gap _operation;

	internal static byte[] ENC_C => new byte[4] { 0, 0, 0, 1 };

	internal static byte[] MAC_C => new byte[4] { 0, 0, 0, 2 };

	public SecureString Mrz { get; protected set; }

	public byte[]? KSeed { get; set; }

	public byte[]? KEnc { get; set; }

	public byte[]? KMac { get; set; }

	public byte[]? RND_IC { get; set; }

	internal BacOperation(Gap operation, SecureString mrz)
	{
		_operation = operation;
		Mrz = mrz;
	}

	internal override async Task Init()
	{
		await base.Init();
		base.Steps.Add(new StepSelecteDLApplication(_operation));
		base.Steps.Add(new StepCalculateKSeed(this));
		base.Steps.Add(new StepCalculateBasicAccessKeys(this));
		base.Steps.Add(new StepRequestRandomNumber(this));
		base.Steps.Add(new StepGeneralAuthenticate(_operation, this));
		base.Steps.Add(new StepReadEFCOM(_operation));
	}
}
