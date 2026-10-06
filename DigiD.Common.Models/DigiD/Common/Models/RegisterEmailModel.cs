using System;
using System.Threading.Tasks;

namespace DigiD.Common.Models;

public class RegisterEmailModel
{
	public Func<bool, Task> NextAction { get; set; }

	public Func<Task>? AbortAction { get; set; }

	public string? EmailAddress { get; set; }

	public bool Verified { get; set; }

	public RegisterEmailModel(Func<bool, Task> nextAction, Func<Task>? abortAction = null, string? emailAddress = null)
	{
		NextAction = nextAction;
		AbortAction = abortAction;
		EmailAddress = emailAddress;
	}
}
