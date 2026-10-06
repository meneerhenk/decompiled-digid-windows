using System;
using System.Threading.Tasks;

namespace DigiD.Mobile.Interfaces;

public interface IQRCodeScannerService
{
	Task<Uri?> StartScanner();
}
