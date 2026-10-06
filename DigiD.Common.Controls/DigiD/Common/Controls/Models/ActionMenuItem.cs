using System;
using System.Threading.Tasks;

namespace DigiD.Common.Controls.Models;

public class ActionMenuItem : MenuItem
{
	public ActionMenuItem(string automationTestId, string title, string icon, Func<Task> itemSelectedCommand, bool chevronVisible = true, bool isExternalLink = false)
		: base(automationTestId, title, icon, itemSelectedCommand, isExternalLink)
	{
		base.IsChevronVisible = chevronVisible;
	}
}
