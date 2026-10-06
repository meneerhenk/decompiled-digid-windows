using System.Threading.Tasks;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Responses;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Pages;

namespace DigiD.Mobile.ViewModels;

public class DG021ViewModel : BaseNfcCheckVIewModel
{
	private readonly IRdaService rdaService;

	private readonly IRdaApi rdaApi;

	private readonly ISessionService sessionService;

	public DG021ViewModel(IRdaService rdaService, IRdaApi rdaApi, ISessionService sessionService, INfcService nfcService)
		: base(nfcService)
	{
		this.rdaService = rdaService;
		this.rdaApi = rdaApi;
		this.sessionService = sessionService;
		base.CloseButtonVisible = true;
		base.HasBackButton = false;
	}

	protected override async Task Next()
	{
		if (HttpSession.AppSessionId == null)
		{
			await base.ToastService.ShowError(CommonResources.Alg_UnknownErrorOccurred);
			await base.NavigationService.PopToRootAsync();
			return;
		}
		HttpSession.TempSessionData = new TempSessionData(HttpSession.AppSessionId);
		await rdaService.InitSession();
		base.DialogService.Show();
		RdaSessionResponse session = await rdaService.GetRdaSessionUrl();
		await base.DialogService.Hide();
		switch (session.ApiResult)
		{
		case ApiResult.Ok:
			await rdaService.StartSession(session, RdaComplete, RdaRetry);
			break;
		case ApiResult.NoDocumentsFound:
			await base.NavigationService.NavigateAsync<DG018>();
			break;
		}
	}

	public Task RdaRetry()
	{
		return RdaComplete(RdaResult.Failed);
	}

	private async Task RdaComplete(RdaResult result)
	{
		if (result == RdaResult.AuthenticationFailed)
		{
			await base.NavigationService.NavigateAsync<DG025>();
			return;
		}
		if (result == RdaResult.Success)
		{
			HttpSession.TempSessionData?.SwitchSession();
			await base.NavigationService.NavigateAsync<DG038>();
			return;
		}
		await rdaApi.Cancel();
		await sessionService.CancelSession(byUser: false, async delegate
		{
			await base.ToastService.ShowWarning(DigiDAppResources.DG021_Failed);
		});
	}
}
