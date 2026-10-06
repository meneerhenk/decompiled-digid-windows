using System;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Models;
using DigiD.Common.NFC.Enums;
using DigiD.Common.NFC.Models;

namespace DigiD.Common.EID.CardSteps.BAC;

public class StepGeneralAuthenticate(Gap gap, BacOperation operation) : IStep
{
	private const int EIC_LENGTH = 32;

	private const int RND_LENGTH = 8;

	private const int KIC_LENGTH = 16;

	public async Task<bool> Execute()
	{
		ArgumentNullException.ThrowIfNull(operation.RND_IC, "operation.RND_IC");
		ArgumentNullException.ThrowIfNull(operation.KEnc, "operation.KEnc");
		ArgumentNullException.ThrowIfNull(operation.KMac, "operation.KMac");
		byte[] rndIfd = RandomNumberGenerator.GetBytes(8);
		byte[] kIfd = RandomNumberGenerator.GetBytes(16);
		byte[] s = rndIfd.Concat(operation.RND_IC).Concat(kIfd).ToArray();
		byte[] eIfd = CryptoDesHelper.TripleDesProvider(s, operation.KEnc, encrypt: true);
		byte[] mIfd = CryptoDesHelper.ComputeMacTDes(eIfd, operation.KMac);
		byte[] cmd_data = eIfd.Concat(mIfd).ToArray();
		CommandApdu cmd = new CommandApdu(CLA.PLAIN, INS.EXTERNAL_AUTHENTICATE, 0, 0, cmd_data, 40);
		ResponseApdu response = await CommandApduBuilder.SendAPDU("GA BAC", cmd, null);
		if (response.SW == 36864)
		{
			byte[] eIc = response.Data.Take(32).ToArray();
			byte[] sIc = CryptoDesHelper.TripleDesProvider(eIc, operation.KEnc, encrypt: false);
			byte[] rndIc_Resp = sIc.Take(8).ToArray();
			byte[] rndIfd_Resp = sIc.Skip(rndIc_Resp.Length).Take(8).ToArray();
			byte[] kIc = sIc.Skip(16).Take(16).ToArray();
			if (rndIfd.SequenceEqual(rndIfd_Resp))
			{
				byte[] kSeed = ByteHelper.Xor(kIfd, kIc);
				byte[] ksEnc = CryptoDesHelper.ComputeKey(kSeed, BacOperation.ENC_C);
				byte[] ksMac = CryptoDesHelper.ComputeKey(kSeed, BacOperation.MAC_C);
				byte[] ssc = rndIc_Resp.Skip(4).Concat(rndIfd_Resp.Skip(4)).ToArray();
				SMContext smContext = new SMContext(ksEnc, ksMac, ssc);
				gap.SMContext = smContext;
				return true;
			}
		}
		return false;
	}
}
