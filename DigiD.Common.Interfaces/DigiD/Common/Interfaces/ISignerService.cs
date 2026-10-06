using System.Threading.Tasks;

namespace DigiD.Common.Interfaces;

public interface ISignerService
{
	Task<byte[]?> SignData(string challenge);

	byte[]? GetPublicKey();
}
