using System;
using System.Threading.Tasks;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Responses;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Mobile.Pages;

namespace DigiD.Mobile.ViewModels;

public class DG055ViewModel : BaseNfcCheckVIewModel
{
	private readonly IRdaService rdaService;

	public string ImageSource { get; }

	public DG055ViewModel(IRdaService rdaService, INfcService nfcService)
		: base(nfcService)
	{
		this.rdaService = rdaService;
		base.CloseButtonVisible = AppSession.IsAuthenticated;
		base.HeaderText = DigiDAppResources.DG055_Titel2;
		if (HttpSession.WillIDCheckExpire)
		{
			base.ButtonText = DigiDAppResources.DG055_Knop2;
			string arg = HttpSession.SubExpiryDate?.ToString("d", DigiDAppResources.Culture);
			if (HttpSession.SubExpiryDate <= DateTime.Now.Date)
			{
				base.MessageText = DigiDAppResources.DG055_Intro2;
			}
			else
			{
				base.MessageText = string.Format(DigiDAppResources.DG055_Intro3, arg);
			}
			ImageSource = "icon_warning.png";
		}
		else
		{
			base.HeaderText = DigiDAppResources.DG055_Titel;
			base.MessageText = DigiDAppResources.DG055_Intro;
			base.ButtonText = DigiDAppResources.DG055_Knop;
			ImageSource = "icon_done.png";
		}
	}

	protected override async Task Next()
	{
		base.DialogService.Show();
		await rdaService.InitSession();
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
		return base.NavigationService.PopToAsync<DG044>();
	}

	private async Task RdaComplete(RdaResult result)
	{
		if (result != RdaResult.AuthenticationFailed)
		{
			await base.NavigationService.PopToAsync<DG044>();
		}
		else
		{
			await base.NavigationService.NavigateAsync<DG025>();
		}
	}
}
