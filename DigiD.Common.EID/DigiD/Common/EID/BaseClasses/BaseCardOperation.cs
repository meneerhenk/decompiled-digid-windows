using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DigiD.Common.EID.Exceptions;
using DigiD.Common.EID.Interfaces;
using DigiD.Common.Models.Nfc;
using DigiD.Common.NFC.Helpers;

namespace DigiD.Common.EID.BaseClasses;

public class BaseCardOperation : ICardOperation
{
	private bool _isInitialized;

	public List<IStep> Steps { get; } = new List<IStep>();

	internal virtual Task Init()
	{
		_isInitialized = true;
		return Task.CompletedTask;
	}

	public virtual async Task<bool> Execute()
	{
		if (!_isInitialized)
		{
			await Init();
		}
		foreach (IStep step in Steps)
		{
			Debugger.WriteLine($"{step.GetType()}: Started");
			try
			{
				if (!(await step.Execute()))
				{
					Debugger.WriteLine($"{step.GetType()}: Failed");
					return false;
				}
			}
			catch (CardLostException)
			{
				throw;
			}
			catch (TimeoutException)
			{
				throw;
			}
			catch (CardNotSupportedException)
			{
				throw;
			}
			catch (Exception ex4)
			{
				Debugger.WriteLine(ex4.ToString());
				return false;
			}
			StepCompleted(step);
			Debugger.WriteLine($"{step.GetType()}: Completed");
		}
		return true;
	}

	public virtual void StepCompleted(IStep stepNumber)
	{
	}
}
