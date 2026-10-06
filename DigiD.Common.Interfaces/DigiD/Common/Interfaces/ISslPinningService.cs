using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace DigiD.Common.Interfaces;

public interface ISslPinningService
{
	Task<bool> ValidateCertificate(string? domain, List<X509Certificate> certificates);

	Task<bool> SslPinningCheck();
}
