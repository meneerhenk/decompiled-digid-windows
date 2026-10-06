using System;
using System.Threading.Tasks;
using DigiD.Common.Interfaces;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Pages;
using DigiD.Mobile.ViewModels;

namespace DigiD.Mobile.Services;

public class QrCodeScannerService(INavigationService navigationService) : IQRCodeScannerService
{
	public async Task<Uri?> StartScanner()
	{
		TaskCompletionSource<Uri?> tcs = new TaskCompletionSource<Uri>();
		await navigationService.PushModalAsync<DG040, DG040ViewModel>(delegate(DG040ViewModel vm)
		{
			vm.Initialize(async delegate(Uri? data)
			{
				await navigationService.PopCurrentModalPage();
				tcs.SetResult(data);
			});
		});
		return await tcs.Task;
	}
}
