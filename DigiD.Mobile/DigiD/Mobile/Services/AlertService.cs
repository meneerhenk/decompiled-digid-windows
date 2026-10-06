using System;
using System.Threading.Tasks;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.NFC.Enums;
using DigiD.Common.Plugins.Popups;
using DigiD.Common.Plugins.ViewModels;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Mobile.Interfaces;

namespace DigiD.Mobile.Services;

internal class AlertService(IConfigurationService configurationService, INavigationService navigationService, IPopupService popupService) : IAlertService
{
	public async Task<bool?> DisplayAlert(AlertMessageType type, TimeSpan? autoHideDelay = null)
	{
		string accept = CommonResources.Alg_Ok;
		string cancel = null;
		bool invert = false;
		string title;
		string message;
		switch (type)
		{
		case AlertMessageType.FM003:
			title = CommonResources.FM003_Titel;
			message = string.Format(CommonResources.FM003_Body, HttpSession.WidSessionResponse?.WebService ?? HttpSession.WebSessionInfoResponse?.WebService);
			break;
		case AlertMessageType.FM005:
			await navigationService.PushModalAsync<AlertPopup, AlertPopupViewModel>(delegate(AlertPopupViewModel vm)
			{
				vm.Initialize(type, CommonResources.FM005_Titel, CommonResources.FM005_007_Body);
			}, animate: false);
			return true;
		case AlertMessageType.FM010:
			title = CommonResources.FM010_Titel;
			message = CommonResources.FM010_Body;
			break;
		case AlertMessageType.FM016:
			title = DigiDAppResources.FM016_Title;
			message = DigiDAppResources.FM016_Message;
			break;
		case AlertMessageType.FM013:
			title = CommonResources.FM013_Titel;
			message = CommonResources.FM013_Body;
			break;
		case AlertMessageType.FM017:
			title = CommonResources.FM017_Titel;
			message = CommonResources.FM017_Body;
			break;
		case AlertMessageType.FM018:
			title = CommonResources.FM018_Titel;
			message = CommonResources.FM018_Body;
			break;
		case AlertMessageType.FM022:
			title = CommonResources.FM022_Titel;
			message = CommonResources.FM022_Body;
			break;
		case AlertMessageType.FM023:
			title = CommonResources.FM023_Titel;
			message = CommonResources.FM023_Body;
			break;
		case AlertMessageType.FM024:
			title = CommonResources.FM024_Titel;
			message = CommonResources.FM024_Body;
			break;
		case AlertMessageType.FM025:
			title = CommonResources.FM025_Titel;
			message = CommonResources.FM025_Body;
			break;
		case AlertMessageType.FM026:
			title = CommonResources.FM026_Titel;
			message = CommonResources.FM026_Body;
			break;
		case AlertMessageType.FM027:
			title = CommonResources.FM027_Titel;
			message = CommonResources.FM027_Body;
			break;
		case AlertMessageType.FM028:
			title = CommonResources.FM028_Titel;
			message = CommonResources.FM028_Body;
			break;
		case AlertMessageType.FM030:
			title = CommonResources.FM030_Titel;
			message = CommonResources.FM030_Body;
			break;
		case AlertMessageType.FM039:
			title = CommonResources.FM039_Titel;
			message = CommonResources.FM039_Body;
			break;
		case AlertMessageType.FM033:
			title = CommonResources.FM033_Titel;
			message = CommonResources.FM033_Body;
			accept = CommonResources.Alg_No;
			cancel = CommonResources.Alg_Yes;
			invert = true;
			break;
		case AlertMessageType.FM038:
			title = CommonResources.FM038_Titel;
			message = CommonResources.FM038_Body;
			break;
		case AlertMessageType.FM043:
			title = CommonResources.FM043_Titel;
			message = CommonResources.FM043_Body;
			break;
		case AlertMessageType.FM045:
			title = CommonResources.FM045_Titel;
			message = CommonResources.FM045_Body;
			break;
		case AlertMessageType.FM046:
			title = CommonResources.FM046_Titel;
			message = CommonResources.FM046_Body;
			break;
		case AlertMessageType.FM047:
			title = CommonResources.FM047_Titel;
			message = CommonResources.FM047_Body;
			break;
		case AlertMessageType.FM050:
			title = CommonResources.FM050_Titel;
			message = CommonResources.FM050_Body;
			break;
		case AlertMessageType.FM054:
			title = CommonResources.FM054_Titel;
			message = CommonResources.FM054_Body;
			accept = CommonResources.Alg_Yes;
			cancel = CommonResources.Alg_No;
			invert = true;
			break;
		case AlertMessageType.FM055:
			title = CommonResources.FM055_Titel;
			message = CommonResources.FM055_Body;
			accept = CommonResources.Alg_Yes;
			cancel = CommonResources.Alg_No;
			invert = true;
			break;
		case AlertMessageType.FM056:
			title = CommonResources.FM056_Titel;
			message = CommonResources.FM056_Body;
			accept = CommonResources.Alg_Yes;
			cancel = CommonResources.Alg_No;
			invert = true;
			break;
		case AlertMessageType.FM057:
			title = CommonResources.FM057_Titel;
			message = CommonResources.FM057_Body;
			break;
		case AlertMessageType.FM058:
			title = CommonResources.FM058_Titel;
			message = CommonResources.FM058_Body;
			accept = CommonResources.Alg_Yes;
			cancel = CommonResources.Alg_No;
			invert = true;
			break;
		case AlertMessageType.FM059:
			title = CommonResources.FM059_Titel;
			message = CommonResources.FM059_Body;
			accept = CommonResources.Alg_Yes;
			cancel = CommonResources.Alg_No;
			invert = true;
			break;
		case AlertMessageType.FM061:
			title = CommonResources.FM061_Titel;
			message = CommonResources.FM061_Body;
			break;
		case AlertMessageType.FM062:
			title = CommonResources.FM062_Titel;
			message = CommonResources.FM062_Body;
			break;
		case AlertMessageType.FM063:
			title = CommonResources.FM063_Titel;
			message = CommonResources.FM063_Body;
			break;
		case AlertMessageType.FM064:
			title = CommonResources.FM064_Titel;
			message = CommonResources.FM064_Body;
			break;
		case AlertMessageType.FM066:
			title = CommonResources.FM066_Titel;
			message = CommonResources.FM066_Body;
			accept = CommonResources.Alg_Yes;
			cancel = CommonResources.Alg_No;
			invert = true;
			break;
		case AlertMessageType.FM068:
			title = CommonResources.FM068_Titel;
			message = CommonResources.FM068_Body;
			accept = CommonResources.Alg_Yes;
			cancel = CommonResources.Alg_No;
			invert = true;
			break;
		case AlertMessageType.FM070:
			title = CommonResources.FM070_Titel;
			message = CommonResources.FM070_Body;
			break;
		case AlertMessageType.FM072:
			title = CommonResources.FM072_Titel;
			message = CommonResources.FM072_Body;
			break;
		case AlertMessageType.FM073:
			title = CommonResources.FM073_Titel;
			message = CommonResources.FM073_Body;
			accept = CommonResources.FM073_EN;
			cancel = CommonResources.FM073_NL;
			break;
		case AlertMessageType.FM074:
			title = CommonResources.FM074_Titel;
			message = CommonResources.FM074_Body;
			accept = CommonResources.Alg_Yes;
			cancel = CommonResources.Alg_No;
			invert = true;
			break;
		case AlertMessageType.FM075:
			title = CommonResources.FM075_Titel;
			message = string.Format(CommonResources.FM075_Body, configurationService.Configuration.MaxPinChangePerDay);
			break;
		case AlertMessageType.FM076:
			title = CommonResources.FM076_Titel;
			message = CommonResources.FM076_Body;
			accept = CommonResources.FM076_Knop;
			break;
		case AlertMessageType.FM077:
			title = CommonResources.FM077_Titel;
			message = CommonResources.FM077_Body;
			break;
		case AlertMessageType.FM079:
			title = CommonResources.FM079_Titel;
			message = CommonResources.FM079_Body;
			break;
		case AlertMessageType.FM081:
			title = CommonResources.FM081_Titel;
			message = CommonResources.FM081_Body;
			break;
		case AlertMessageType.FM082:
			title = CommonResources.FM082_Titel;
			message = CommonResources.FM082_Body;
			break;
		case AlertMessageType.FM084:
			title = CommonResources.FM084_Titel;
			message = ((EIDSession.Card.DocumentType == DocumentType.DrivingLicense) ? CommonResources.FM084_Melding_DriversLicense : CommonResources.FM084_Melding_IDCard);
			break;
		case AlertMessageType.FM085:
			title = CommonResources.FM085_Titel;
			message = string.Format(CommonResources.FM085_Body, EIDSession.Card.DocumentType.Translate().ToLowerInvariant());
			break;
		case AlertMessageType.FM086:
			title = CommonResources.FM086_Titel;
			message = string.Format(CommonResources.FM086_Body, EIDSession.Card.DocumentType.Translate().ToLowerInvariant());
			break;
		case AlertMessageType.FM103:
			title = DigiDAppResources.FM103_Titel;
			message = DigiDAppResources.FM103_Body;
			accept = DigiDAppResources.FM103_Accept;
			cancel = DigiDAppResources.FM103_Cancel;
			break;
		case AlertMessageType.FM099:
			title = CommonResources.FM099_Titel;
			message = string.Format(CommonResources.FM099_Body, configurationService.Configuration.LetterRequestDelay);
			accept = CommonResources.Alg_Yes;
			cancel = CommonResources.Alg_No;
			break;
		case AlertMessageType.FM100:
			title = CommonResources.FM100_Titel;
			message = CommonResources.FM100_Body;
			break;
		case AlertMessageType.FM101:
		{
			TaskCompletionSource<bool?> tcs = new TaskCompletionSource<bool?>();
			await navigationService.PushModalAsync<AlertPopup, AlertPopupViewModel>(delegate(AlertPopupViewModel viewModel)
			{
				viewModel.Initialize(type, CommonResources.FM101_Titel, CommonResources.FM101_Body, CommonResources.FM101_ButtonSettings, CommonResources.FM101_ButtonClose, invertCallToAction: true, async delegate(bool? res)
				{
					tcs.SetResult(res);
					await navigationService.PopCurrentModalPage(animate: false);
				});
			}, animate: false);
			return await tcs.Task;
		}
		case AlertMessageType.FM102:
			title = CommonResources.FM102_Titel;
			message = CommonResources.FM102_Body;
			accept = CommonResources.Alg_Yes;
			cancel = CommonResources.Alg_No;
			invert = true;
			break;
		case AlertMessageType.FM104:
			title = CommonResources.FM104_Titel;
			message = CommonResources.FM104_Body;
			break;
		case AlertMessageType.TBD01:
			title = CommonResources.x_ActivationConfirmPendingHeader;
			message = string.Format(CommonResources.x_ActivationConfirmPendingMessage, configurationService.Configuration.LetterRequestDelay);
			accept = CommonResources.x_ActivationConfirmPendingMessageButton;
			cancel = CommonResources.x_ActivationConfirmPendingCancel;
			break;
		default:
			return false;
		}
		return await popupService.DisplayAlert(title, message, accept, cancel, invert, type, autoHideDelay);
	}
}
