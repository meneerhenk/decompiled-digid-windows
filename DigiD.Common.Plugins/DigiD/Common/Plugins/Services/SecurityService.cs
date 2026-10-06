using System.Diagnostics;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using DigiD.Common.Interfaces;

namespace DigiD.Common.Plugins.Services;

public class SecurityService : ISecurityService
{
	public bool IsDebuggerAttached => Debugger.IsAttached;

	public bool IsRunningOnVirtualDevice { get; }

	public HttpMessageHandler GetFakeHandler()
	{
		return new HttpClientHandler
		{
			ServerCertificateCustomValidationCallback = (HttpRequestMessage _, X509Certificate2? _, X509Chain? _, SslPolicyErrors _) => false
		};
	}
}
