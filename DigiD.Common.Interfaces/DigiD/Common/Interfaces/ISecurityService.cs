using System.Net.Http;

namespace DigiD.Common.Interfaces;

public interface ISecurityService
{
	bool IsDebuggerAttached { get; }

	bool IsRunningOnVirtualDevice { get; }

	HttpMessageHandler GetFakeHandler();
}
