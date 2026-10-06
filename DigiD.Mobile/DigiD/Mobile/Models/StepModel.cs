using DigiD.Common.Controls.Models;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.SessionModels;
using LocalizationResourceManager.Maui;

namespace DigiD.Mobile.Models;

public class StepModel : BaseStepModel, IStepModel
{
	public bool IsCompleted => State < AppSession.ActivationState;

	public AppActivationState State { get; set; }

	public bool IsActive => AppSession.ActivationState == State;

	public override bool HasSkipped => State == AppActivationState.ScanId && AppSession.RDASkipped;

	public bool SubTextVisible => !IsCompleted;

	public StepModel(string title, string text, params object[] args)
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
