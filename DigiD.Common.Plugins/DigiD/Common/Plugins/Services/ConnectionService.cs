using System.Threading.Tasks;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Plugins.Popups;
using DigiD.Common.Plugins.ViewModels;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using Microsoft.Maui.Networking;

namespace DigiD.Common.Plugins.Services;

internal class ConnectionService(INavigationService navigationService, IGeneralApi generalApi, IDialogService dialogService) : IConnectionService
{
	private bool connectionPopupVisible;

	public void StartMonitor(bool resume = false)
	{
		Connectivity.Current.ConnectivityChanged += CurrentOnConnectivityChanged;
		if (resume)
		{
			CheckNetworkConnection();
		}
	}

	public void StopMonitor()
	{
		Connectivity.Current.ConnectivityChanged -= CurrentOnConnectivityChanged;
	}

	private void CurrentOnConnectivityChanged(object? sender, ConnectivityChangedEventArgs e)
	{
		CheckNetworkConnection();
	}

	public async Task<bool> CheckNetworkConnection()
	{
		if (connectionPopupVisible)
		{
			await navigationService.PopCurrentModalPage(animate: false);
			connectionPopupVisible = false;
		}
		if (!AppSession.IsAppVisible)
		{
			return true;
		}
		if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
		{
			await ShowPopup(AlertMessageType.FM005, retry: false);
		}
		else
		{
			switch ((await generalApi.DoHealthCheck()).ApiResult)
			{
			case ApiResult.Nok:
			case ApiResult.BadConnection:
				await ShowPopup(AlertMessageType.FM007);
				break;
			case ApiResult.TrafficMetered:
				await ShowPopup(AlertMessageType.FM100);
				break;
			case ApiResult.Maintenance:
				await ShowPopup(AlertMessageType.FM104);
				break;
			case ApiResult.HostNotReachable:
				await ShowPopup(AlertMessageType.FM106);
				break;
			case ApiResult.Ok:
				return true;
			}
		}
		return false;
	}

	private async Task ShowPopup(AlertMessageType type, bool retry = true)
	{
		string message = string.Empty;
		string title = string.Empty;
		switch (type)
		{
		case AlertMessageType.FM005:
			title = CommonResources.FM005_Titel;
			message = CommonResources.FM005_007_Body;
			break;
		case AlertMessageType.FM007:
			title = CommonResources.FM007_Title;
			message = CommonResources.FM005_007_Body;
			break;
		case AlertMessageType.FM100:
			title = CommonResources.FM100_Titel;
			message = CommonResources.FM100_Body;
			break;
		case AlertMessageType.FM104:
			title = CommonResources.FM104_Titel;
			message = CommonResources.FM104_Body;
			break;
		case AlertMessageType.FM106:
			title = CommonResources.FM002C_Titel;
			message = CommonResources.FM002C_Body;
			break;
		}
		connectionPopupVisible = true;
		await dialogService.Hide();
		await Task.Delay(100);
		if (retry)
		{
			await navigationService.PushModalAsync<AlertPopup, AlertPopupViewModel>(delegate(AlertPopupViewModel viewModel)
			{
				viewModel.Initialize(type, title, message, CommonResources.Alg_TryAgain, null, invertCallToAction: false, async delegate
				{
					dialogService.Show();
					connectionPopupVisible = false;
					await navigationService.PopCurrentModalPage(animate: false);
					await CheckNetworkConnection();
					await dialogService.Hide();
				});
			}, animate: false);
		}
		else
		{
			await navigationService.PushModalAsync<AlertPopup, AlertPopupViewModel>(delegate(AlertPopupViewModel viewModel)
			{
				viewModel.Initialize(type, title, message);
			}, animate: false);
		}
	}
}
