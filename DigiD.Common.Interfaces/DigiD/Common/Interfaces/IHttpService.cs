using System.Net.Http;

namespace DigiD.Common.Interfaces;

public interface IHttpService
{
	HttpMessageHandler GetNativeHandler(bool pinningEnabled = true);
}
