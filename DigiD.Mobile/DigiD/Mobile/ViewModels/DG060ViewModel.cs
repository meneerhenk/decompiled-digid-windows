using System.Collections.Generic;
using DigiD.Common.BaseClasses;
using DigiD.Common.Enums;
using DigiD.Common.Settings;
using DigiD.Mobile.Models;

namespace DigiD.Mobile.ViewModels;

public class DG060ViewModel : CommonBaseViewModel
{
	private readonly IMobileSettings settings;

	public List<AccordionItem> Items { get; set; } = new List<AccordionItem>();

	public bool ShowIntro => base.A11YService.IsInVoiceOverMode;

	public DG060ViewModel(IMobileSettings settings)
	{
		this.settings = settings;
		base.CloseButtonVisible = true;
		LoadQuestions();
	}

	private void LoadQuestions()
	{
		if (settings.ActivationStatus == ActivationStatus.Activated)
		{
			Items.Add(new AccordionItem("FaqLogin", "HLP11_Title_Login", "HLP11_Body_Login"));
		}
		else
		{
			Items.Add(new AccordionItem("FaqActivate", "HLP11_Title_Activate", "HLP11_Body_Activate"));
		}
		Items.Add(new AccordionItem("FaqIDcheck", "HLP11_Title_IDcheck", "HLP11_Body_IDcheck"));
		if (settings.ActivationStatus == ActivationStatus.Activated)
		{
			Items.Add(new AccordionItem("FaqForgotPincode", "HLP11_Title_ForgotPincode", "HLP11_Body_ForgotPincode"));
			return;
		}
		Items.Add(new AccordionItem("FaqNoDigiD", "HLP11_Title_NoDigiD", "HLP11_Body_NoDigiD"));
		Items.Add(new AccordionItem("FaqBTL", "HLP11_Title_BTL", "HLP11_Body_BTL"));
	}
}
