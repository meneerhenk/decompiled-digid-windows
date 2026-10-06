using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Helpers;
using WinRT;
using WinRT.DigiD_Common_PluginsVtableClasses;

namespace DigiD.Common.Plugins.Services;

[WinRTRuntimeClassName("Windows.Foundation.IClosable")]
[WinRTExposedType(typeof(DigiD_Common_Plugins_Services_PlatformHttpClientHandlerWinRTTypeDetails))]
public class PlatformHttpClientHandler : DelegatingHandler
{
	private readonly ISslPinningService pinningService;

	public PlatformHttpClientHandler(ISslPinningService pinningService)
	{
		this.pinningService = pinningService;
		base.InnerHandler = new SocketsHttpHandler
		{
			ConnectCallback = HttpService.ConnectIPv4Async,
			AutomaticDecompression = (DecompressionMethods.GZip | DecompressionMethods.Deflate),
			MaxAutomaticRedirections = 10,
			PooledConnectionLifetime = TimeSpan.FromMinutes(5L),
			UseProxy = false,
			SslOptions = new SslClientAuthenticationOptions
			{
				RemoteCertificateValidationCallback = CheckServerCertificate
			}
		};
	}

	protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
	{
		try
		{
			return await base.SendAsync(request, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		catch (HttpRequestException ex)
		{
			HttpRequestException ex2 = ex;
			Exception innerException = ex2.InnerException;
			bool flag;
			if (innerException != null)
			{
				int hResult = innerException.HResult;
				if (hResult == -2147012721 || hResult == -2146697202)
				{
					flag = true;
					goto IL_00f1;
				}
			}
			flag = false;
			goto IL_00f1;
			IL_00f1:
			if (flag)
			{
				throw new WebException(ex2.InnerException.Message, WebExceptionStatus.TrustFailure);
			}
			throw;
		}
	}

	private static List<X509Certificate> ExtractCertificates(X509Chain? chain)
	{
		if (chain == null)
		{
			return new List<X509Certificate>();
		}
		X509ChainElementCollection chainElements = chain.ChainElements;
		return chainElements.Select((X509ChainElement certificate) => certificate.Certificate).Cast<X509Certificate>().ToList();
	}

	private bool CheckServerCertificate(object? sender, X509Certificate? certificate, X509Chain? chain, SslPolicyErrors sslPolicyErrors)
	{
		if (certificate == null)
		{
			return false;
		}
		string requestHost = (sender as SslStream)?.TargetHostName;
		List<X509Certificate> certificates = ExtractCertificates(chain);
		return AsyncUtil.RunSync(async () => await pinningService.ValidateCertificate(requestHost, certificates));
	}
}
