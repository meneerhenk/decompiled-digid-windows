using System;
using System.Threading.Tasks;
using DigiD.Common.Models;

namespace DigiD.Mobile.Interfaces;

public interface IIncomingDataService
{
	Task HandleIncomingData(Uri uri);

	Task ProcessData(SessionData data, bool activation, string? koppelCode);

	Task ScanCompletedAsync(Uri uri, string? koppelCode);

	QrScanResult? ProcessUriData(Uri uri);
}
