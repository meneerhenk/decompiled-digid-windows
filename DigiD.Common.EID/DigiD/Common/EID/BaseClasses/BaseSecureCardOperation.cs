using System;
using DigiD.Common.EID.CardSteps;
using DigiD.Common.EID.Interfaces;

namespace DigiD.Common.EID.BaseClasses;

public class BaseSecureCardOperation : BaseCardOperation, ISecureCardOperation
{
	private readonly Action<float>? _progressChangedAction;

	internal int TotalSteps;

	private int _currentIndex = 1;

	public Gap? GAP { get; set; }

	public BaseSecureCardOperation(Action<float>? progressChangedAction = null)
	{
		_progressChangedAction = progressChangedAction;
	}

	public BaseSecureCardOperation(Gap operation)
	{
		GAP = operation;
	}

	public override void StepCompleted(IStep stepNumber)
	{
		ChangeProgress();
	}

	internal void ChangeProgress()
	{
		_progressChangedAction?.Invoke((float)_currentIndex / (float)TotalSteps);
		_currentIndex++;
	}
}
