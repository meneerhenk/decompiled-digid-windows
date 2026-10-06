using System;
using System.Threading.Tasks;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Models.Responses;
using DigiD.Common.NFC.Enums;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Mobile.Helpers;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Pages;

namespace DigiD.Mobile.Services;

public class ConfirmService(IAppService appService, IToastService toastService, INavigationService navigationService, IMatomoService matomoService) : IConfirmService
{
	public async Task<bool> SetSuccessMessage(AuthenticationSessionResponse response)
	{
		if (response.WebService != null)
		{
			bool isEHASession = HttpSession.WebSessionInfoResponse is PendingSessionResponse;
			matomoService.TrackAction("Dienst", "Inloggen" + (isEHASession ? " (EHA)" : ""), "Succesvol");
			await toastService.ShowSuccess(string.Format(CommonResources.FM095_Body, response.WebService), null, popToRoot: false);
			Preferences.NumberOfSuccessfulLogins++;
		}
		else if (response.Action != null)
		{
			switch (response.Action)
			{
			case "change_password":
				matomoService.TrackAction("Mijn DigiD", "Wijzigen wachtwoord", "Succesvol");
				await toastService.ShowSuccess(DigiDAppResources.HLP12_WachtwoordSucces, null, popToRoot: false);
				break;
			case "change_phone_number":
				matomoService.TrackAction("Mijn DigiD", "Wijzigen telefoonnummer", "Succesvol");
				await toastService.ShowSuccess(DigiDAppResources.HLP12_TelnummerSucces, null, popToRoot: false);
				break;
			case "activate_sms_authenticator":
				matomoService.TrackAction("Mijn DigiD", "Activeren SMS", "Succesvol");
				await toastService.ShowSuccess(DigiDAppResources.HLP12_SMSSucces, null, popToRoot: false);
				break;
			case "add_email":
				matomoService.TrackAction("Mijn DigiD", "Toevoegen e-mail", "Succesvol");
				await toastService.ShowSuccess(DigiDAppResources.HLP12_EmailToevSucces, null, popToRoot: false);
				break;
			case "change_email":
				matomoService.TrackAction("Mijn DigiD", "Wijzigen e-mail", "Succesvol");
				await toastService.ShowSuccess(DigiDAppResources.HLP12_EmailWijzigSucces, null, popToRoot: false);
				break;
			case "remove_email":
				matomoService.TrackAction("Mijn DigiD", "Verwijderen e-mail", "Succesvol");
				await toastService.ShowSuccess(DigiDAppResources.HLP12_EmailVerwSucces, null, popToRoot: false);
				break;
			case "cancel_account":
				matomoService.TrackAction("Mijn DigiD", "Opheffen DigiD", "Succesvol");
				await toastService.ShowSuccess(DigiDAppResources.HLP12_OpheffenSucces, null, popToRoot: false);
				appService.Reset();
				navigationService.SetRoot<DG001>();
				return false;
			case "deactivate_app":
				matomoService.TrackAction("Mijn DigiD", "Deactiveren app", "Succesvol");
				await toastService.ShowSuccess(DigiDAppResources.HLP12_DeactiverenSucces, null, popToRoot: false);
				break;
			case "activate_with_app":
				matomoService.TrackAction("App", "Activeren met andere app", "Succesvol");
				await toastService.ShowSuccess(CommonResources.FM078);
				break;
			case "revoke_driving_license":
				matomoService.TrackAction("Mijn DigiD", "Opheffen inlogfunctie rijbewijs", "Succesvol");
				await toastService.ShowSuccess(string.Format(CommonResources.x_WIDRetractSuccessMessage, DocumentType.DrivingLicense.Translate().ToLowerInvariant()), null, popToRoot: false);
				break;
			case "revoke_identity_card":
				matomoService.TrackAction("Mijn DigiD", "Opheffen inlogfunctie ID", "Succesvol");
				await toastService.ShowSuccess(string.Format(CommonResources.x_WIDRetractSuccessMessage, DocumentType.IDCard.Translate().ToLowerInvariant()), null, popToRoot: false);
				break;
			case "reactivate_driving_license":
				matomoService.TrackAction("Mijn DigiD", "Deblokkeren inlogfunctie rijbewijs", "Succesvol");
				await toastService.ShowSuccess(string.Format(CommonResources.x_WIDReActivationSuccessMessage, DocumentType.DrivingLicense.Translate().ToLowerInvariant()), null, popToRoot: false);
				break;
			case "reactivate_identity_card":
				matomoService.TrackAction("Mijn DigiD", "Deblokkeren inlogfunctie ID", "Succesvol");
				await toastService.ShowSuccess(string.Format(CommonResources.x_WIDReActivationSuccessMessage, DocumentType.IDCard.Translate().ToLowerInvariant()), null, popToRoot: false);
				break;
			default:
				throw new NotImplementedException();
			}
		}
		return true;
	}
}
