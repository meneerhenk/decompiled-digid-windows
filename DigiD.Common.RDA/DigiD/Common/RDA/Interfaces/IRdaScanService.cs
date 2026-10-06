using System;
using System.Threading.Tasks;
using DigiD.Common.NFC.Enums;
using DigiD.Common.RDA.Enums;
using DigiD.Common.SessionModels;

namespace DigiD.Common.RDA.Interfaces;

public interface IRdaScanService
{
	void Initialize(Func<RdaStatus, Task> statusChanged, Action<float> progressChanged, RdaSession session);

	Task StartScanning(DocumentType documentType);
}
