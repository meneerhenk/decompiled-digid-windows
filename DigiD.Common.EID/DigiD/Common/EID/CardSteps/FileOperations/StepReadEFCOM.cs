using System;
using System.Threading.Tasks;
using DigiD.Common.EID.BaseClasses;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.Models.CardFiles;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Models.Helpers;
using DigiD.Common.NFC.Enums;
using DigiD.Common.NFC.Helpers;

namespace DigiD.Common.EID.CardSteps.FileOperations;

internal class StepReadEFCOM : BaseSecureStep, IStep
{
	private readonly Gap _operation;

	internal StepReadEFCOM(Gap operation)
		: base(operation)
	{
		_operation = operation;
	}

	public async Task<bool> Execute()
	{
		ArgumentNullException.ThrowIfNull(EIDSession.Card, "EIDSession.Card");
		if (EIDSession.Card.EFCOM != null)
		{
			return true;
		}
		string fileId = ((EIDSession.Card.DocumentType == DocumentType.DrivingLicense) ? "00-1E" : "01-1E");
		EFCOM file = await SelectAndReadFile.Execute<EFCOM>(new CardFile(P1.CHILD_EF, fileId.ToBytes()), _operation.SMContext);
		Debugger.DumpInfo("EFCOM", file?.Bytes);
		EIDSession.Card.EFCOM = file;
		return true;
	}
}
