using System;
using System.Globalization;
using System.Threading.Tasks;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Enums;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.NFC.Enums;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Pages;
using Microsoft.Maui.Devices;

namespace DigiD.Mobile.ViewModels;

public class DG067BViewModel : BaseLoginConfirmViewModel
{
	public DG067BViewModel(IAlertService alertService, IGeneralApi generalApi, IMobileSettings mobileSettings, IEIDApi eIdApi, IAuthenticationApi authenticationApi, IDialogService dialogService, IEmailService emailService, ISessionService sessionService, IApp2AppService app2AppService, IAuthenticationService authenticationService, IAppService appService, IRemoteNotificationService remoteNotificationService, IConfirmService confirmService, IMatomoService matomoService, IDeviceLockService deviceLockService, ISignerService signerService)
		: base(alertService, generalApi, mobileSettings, eIdApi, authenticationApi, dialogService, emailService, sessionService, app2AppService, authenticationService, appService, remoteNotificationService, confirmService, AlertMessageType.FM077, matomoService, deviceLockService, signerService)
	{
		base.ButtonText = DigiDAppResources.DG067_Knop;
		ArgumentNullException.ThrowIfNull(HttpSession.WidSessionResponse?.Action, "HttpSession.WidSessionResponse?.Action");
		switch (HttpSession.WidSessionResponse.Action)
		{
		case "activate_driving_licence":
			base.PageId = "DG067B";
			base.ImageSource = "digid_afbeelding_activeren_rijbewijs.png";
			base.HeaderText = DigiDAppResources.DG067B_Title;
			base.MessageText = string.Format(CultureInfo.InvariantCulture, DigiDAppResources.DG067B_Message, DocumentType.DrivingLicense.Translate().ToLowerInvariant());
			base.ButtonText = DigiDAppResources.DG067B_ButtonText;
			break;
		case "activate_identity_card":
			base.PageId = "DG067B";
			base.ImageSource = "digid_afbeelding_activeren_idkaart.png";
			base.HeaderText = DigiDAppResources.DG067B_Title;
			base.MessageText = string.Format(CultureInfo.InvariantCulture, DigiDAppResources.DG067B_Message, DocumentType.IDCard.Translate().ToLowerInvariant());
			base.ButtonText = DigiDAppResources.DG067B_ButtonText;
			break;
		case "reactivate_driving_license":
		case "reactivate_identity_card":
		{
			DocumentType documentType = ((HttpSession.WidSessionResponse.Action == "reactivate_driving_license") ? DocumentType.DrivingLicense : DocumentType.IDCard);
			base.HeaderText = ((DeviceInfo.Idiom == DeviceIdiom.Desktop) ? DesktopAppResources.DA037_Header : string.Format(CultureInfo.InvariantCulture, CommonResources.x_WIDReactivateConfirmHeader, documentType.Translate().ToLowerInvariant()));
			base.MessageText = string.Format(CultureInfo.InvariantCulture, (DeviceInfo.Idiom == DeviceIdiom.Desktop) ? DesktopAppResources.DA037_Message : CommonResources.x_WIDReactivateConfirmMessage, documentType.Translate().ToLowerInvariant());
			CardHelper.SetCard(documentType);
			break;
		}
		default:
			base.HeaderText = DigiDAppResources.DG067_Titel;
			SetActionText(HttpSession.WidSessionResponse.Action);
			break;
		}
	}

	protected override Task ContinueNfc(ConfirmResponse? response = null)
	{
		ArgumentNullException.ThrowIfNull(HttpSession.WidSessionResponse?.Action, "HttpSession.WidSessionResponse?.Action");
		NfcScannerModel nfcScannerModel = new NfcScannerModel(PinEntryType.Authentication);
		NfcScannerModel nfcScannerModel2 = nfcScannerModel;
		string action = HttpSession.WidSessionResponse.Action;
		bool isActivation = ((action == "activate_driving_licence" || action == "activate_identity_card") ? true : false);
		nfcScannerModel2.IsActivation = isActivation;
		nfcScannerModel.EIDSessionResponse = HttpSession.WidSessionResponse;
		nfcScannerModel.NeedAppDeactivation = response?.NeedDeactivation ?? false;
		NfcScannerModel model = nfcScannerModel;
		if (model.IsActivation)
		{
			EIDSession.ActivationState = EIDActivationState.ReadCardState;
			CardHelper.SetCard((HttpSession.WidSessionResponse.Action == "activate_driving_licence") ? DocumentType.DrivingLicense : DocumentType.IDCard);
			return base.NavigationService.NavigateAsync<DG085, DG085ViewModel>(delegate(DG085ViewModel vm)
			{
				vm.Initialize(model, null);
			});
		}
		return base.NavigationService.NavigateAsync<DG051, DG051ViewModel>(delegate(DG051ViewModel vm)
		{
			vm.Initialize(model);
		});
	}
}
