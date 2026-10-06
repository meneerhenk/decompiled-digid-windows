using DigiD.Common.Controls.Models;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using LocalizationResourceManager.Maui;

namespace DigiD.Mobile.Models;

public class EIDActivationStepModel : BaseStepModel, IStepModel
{
	public bool IsCompleted => State < EIDSession.ActivationState;

	public EIDActivationState State { get; set; }

	public bool IsActive => EIDSession.ActivationState == State;

	public override bool HasSkipped => State == EIDActivationState.EnterNewPin && !EIDSession.TransportPINChange;

	public bool SubTextVisible => !IsCompleted;

	public EIDActivationStepModel(string title, string text, params object[] args)
		: base(title, text, args)
	{
	}

	int IStepModel.get_Index()
	{
		return base.Index;
	}

	void IStepModel.set_Index(int value)
	{
		base.Index = value;
	}

	LocalizedString IStepModel.get_Title()
	{
		return base.Title;
	}

	LocalizedString IStepModel.get_Text()
	{
		return base.Text;
	}

	string IStepModel.get_ImageSource()
	{
		return base.ImageSource;
	}
}
