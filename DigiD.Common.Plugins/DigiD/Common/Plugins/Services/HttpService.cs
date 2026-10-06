using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using DigiD.Common.Interfaces;

namespace DigiD.Common.Plugins.Services;

public class HttpService(ISslPinningService sslPinningService) : IHttpService
{
	internal static async ValueTask<Stream> ConnectIPv4Async(SocketsHttpConnectionContext context, CancellationToken cancellationToken)
	{
		Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
		{
			NoDelay = true
		};
		try
		{
			await socket.ConnectAsync(new DnsEndPoint(context.DnsEndPoint.Host, context.DnsEndPoint.Port), cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			return new NetworkStream(socket, ownsSocket: true);
		}
		catch
		{
			socket.Dispose();
			throw;
		}
	}

	public HttpMessageHandler GetNativeHandler(bool pinningEnabled = true)
	{
		return pinningEnabled ? ((HttpMessageHandler)new PlatformHttpClientHandler(sslPinningService)) : ((HttpMessageHandler)CreateDefaultSocketsHandler());
	}

	internal static SocketsHttpHandler CreateDefaultSocketsHandler()
	{
		SocketsHttpHandler socketsHttpHandler = new SocketsHttpHandler();
		socketsHttpHandler.ConnectCallback = ConnectIPv4Async;
		socketsHttpHandler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
		socketsHttpHandler.MaxAutomaticRedirections = 10;
		socketsHttpHandler.PooledConnectionLifetime = TimeSpan.FromMinutes(5L);
		socketsHttpHandler.UseProxy = false;
		return socketsHttpHandler;
	}
}
