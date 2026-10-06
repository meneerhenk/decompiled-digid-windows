using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DigiD.Common.EID.Cards;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Models.CardFiles;
using DigiD.Common.Models.Helpers;
using DigiD.Common.NFC.Enums;
using DigiD.Common.NFC.Helpers;

namespace DigiD.Common.EID.Models;

public class Card
{
	internal static readonly List<Card> AvailableCards;

	public DocumentType DocumentType { get; set; }

	public string RDADocumentType => (DocumentType == DocumentType.DrivingLicense) ? "DRIVING_LICENCE" : "TRAVEL_DOCUMENT";

	public required byte[] PolymorphicAID { get; init; }

	public required byte[] CardAID { get; init; }

	public int KeyLength { get; init; }

	public required string MessageDigestAlgorithm { get; init; }

	public int CANLength { get; init; }

	public required string SignatureAlgorithm { get; init; }

	public EFDir? EF_Dir { get; set; }

	public EFCardAccess? EF_CardAccess { get; set; }

	public EF_SOd? EF_SOd { get; set; }

	public EFCOM? EFCOM { get; set; }

	public Dictionary<int, File> DataGroups { get; } = new Dictionary<int, File>();

	internal int ChangePINSteps { get; set; }

	internal int RandomizeSteps { get; set; }

	internal int ResumeSteps { get; set; }

	internal int StatusSteps { get; set; }

	internal virtual Task<bool> ReadFiles(SMContext? context)
	{
		return Task.FromResult(result: true);
	}

	public bool Validate()
	{
		if (EF_SOd == null)
		{
			return false;
		}
		foreach (KeyValuePair<int, File> item in DataGroups.OrderBy<KeyValuePair<int, File>, int>((KeyValuePair<int, File> x) => x.Key))
		{
			if (item.Value.Bytes != null)
			{
				byte[] array = AesHelper.CalculateHash(item.Value.Bytes, MessageDigestAlgorithm, KeyLength);
				if (!((ReadOnlySpan<byte>)EF_SOd.Hashes[item.Key]).SequenceEqual((ReadOnlySpan<byte>)array))
				{
					return false;
				}
				Debugger.WriteLine($"DG{item.Key}\r\nStored:     {EF_SOd.Hashes[item.Key].ToHexString()}\r\nCalculated: {array.ToHexString()}");
			}
		}
		return true;
	}

	static Card()
	{
		int num = 2;
		List<Card> list = new List<Card>(num);
		CollectionsMarshal.SetCount(list, num);
		Span<Card> span = CollectionsMarshal.AsSpan(list);
		span[0] = new DrivingLicense
		{
			CardAID = new byte[11]
			{
				160, 0, 0, 4, 86, 69, 68, 76, 45, 48,
				49
			},
			PolymorphicAID = new byte[8] { 160, 0, 0, 7, 115, 80, 67, 65 },
			DocumentType = DocumentType.DrivingLicense,
			KeyLength = 32,
			MessageDigestAlgorithm = "SHA-256",
			SignatureAlgorithm = "SHA384withECDSA",
			CANLength = 10,
			ChangePINSteps = 17,
			RandomizeSteps = 32,
			ResumeSteps = 23,
			StatusSteps = 7
		};
		span[1] = new eNIK
		{
			CardAID = new byte[7] { 160, 0, 0, 2, 71, 16, 1 },
			PolymorphicAID = new byte[14]
			{
				160, 0, 0, 7, 136, 80, 67, 65, 45, 101,
				77, 82, 84, 68
			},
			DocumentType = DocumentType.IDCard,
			KeyLength = 32,
			MessageDigestAlgorithm = "SHA-256",
			SignatureAlgorithm = "SHA384withECDSA",
			CANLength = 6,
			ChangePINSteps = 17,
			RandomizeSteps = 27,
			ResumeSteps = 15,
			StatusSteps = 9
		};
		AvailableCards = list;
	}
}
