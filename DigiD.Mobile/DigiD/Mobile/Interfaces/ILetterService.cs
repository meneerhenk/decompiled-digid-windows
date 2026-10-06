using System.Threading.Tasks;

namespace DigiD.Mobile.Interfaces;

public interface ILetterService
{
	Task Register();

	void Cancel();
}
