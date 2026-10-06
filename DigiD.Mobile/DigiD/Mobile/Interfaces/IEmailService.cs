using System;
using System.Threading.Tasks;

namespace DigiD.Mobile.Interfaces;

public interface IEmailService
{
	Task Manage(Func<Task> completeTask, bool isAuthentication = false);
}
