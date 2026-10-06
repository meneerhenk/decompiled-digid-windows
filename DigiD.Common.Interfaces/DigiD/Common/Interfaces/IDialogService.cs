using System.Threading.Tasks;

namespace DigiD.Common.Interfaces;

public interface IDialogService
{
	void Show();

	Task Hide();
}
