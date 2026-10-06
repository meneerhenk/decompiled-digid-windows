using System;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using DigiD.Mobile.Interfaces;

namespace DigiD.Mobile.ViewModels;

public class DG067AViewModel : BaseLoginConfirmViewModel
{
	public DG067AViewModel(IAlertService alertService, IGeneralApi generalApi, IMobileSettings mobileSettings, IEIDApi eIdApi, IAuthenticationApi authenticationApi, IDialogService dialogService, IEmailService emailService, ISessionService sessionService, IApp2AppService app2AppService, IAuthenticationService authenticationService, IAppService appService, IRemoteNotificationService remoteNotificationService, IConfirmService confirmService, IMatomoService matomoService, IDeviceLockService deviceLockService, ISignerService signerService)
		: base(alertService, generalApi, mobileSettings, eIdApi, authenticationApi, dialogService, emailService, sessionService, app2AppService, authenticationService, appService, remoteNotificationService, confirmService, AlertMessageType.FM077, matomoService, deviceLockService, signerService)
	{
		base.PageId = "DG067A";
		base.HeaderText = DigiDAppResources.DG067_Titel;
		ArgumentNullException.ThrowIfNull(HttpSession.WebSessionInfoResponse?.Action, "HttpSession.WebSessionInfoResponse?.Action");
		SetActionText(HttpSession.WebSessionInfoResponse.Action);
	}
}
