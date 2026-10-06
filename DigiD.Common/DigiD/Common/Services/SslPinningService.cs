using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Threading.Tasks;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Settings;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace DigiD.Common.Services;

public class SslPinningService : ISslPinningService
{
	private readonly ILogger<SslPinningService> logger;

	private readonly ISecurityService securityService;

	private readonly AppConfig config;

	private readonly IGeneralPreferences preferences;

	private readonly IHttpClientFactory httpClientFactory;

	private readonly string[]? exclusions;

	private IReadOnlyList<PinEntry>? _pins;

	public SslPinningService(ILogger<SslPinningService> logger, ISecurityService securityService, AppConfig config, IGeneralPreferences preferences, IHttpClientFactory httpClientFactory)
	{
		this.logger = logger;
		this.securityService = securityService;
		this.config = config;
		this.preferences = preferences;
		this.httpClientFactory = httpClientFactory;
		if (config.SslPinningSettings != null)
		{
			exclusions = config.SslPinningSettings.Exclusions.Select((string x) => x.DeObfuscate(config.HostKey)).ToArray();
		}
	}

	public async Task<bool> ValidateCertificate(string? domain, List<X509Certificate> certificates)
	{
		ArgumentNullException.ThrowIfNull(domain, "domain");
		if (certificates.Count == 0)
		{
			if (logger.IsEnabled(LogLevel.Critical))
			{
				logger.LogCritical("Could not validate SSL for because no certificates was given");
			}
			return false;
		}
		X509Certificate leaf = certificates.FirstOrDefault();
		if (leaf == null)
		{
			return false;
		}
		if (leaf.IsExpired())
		{
			if (logger.IsEnabled(LogLevel.Critical))
			{
				logger.LogCritical("SSL pinning thumbprint is NOT valid for '{domain}' because certificate is expired", domain);
			}
			return false;
		}
		IReadOnlyList<PinEntry> pins = _pins;
		IReadOnlyList<PinEntry> readOnlyList = pins;
		if (readOnlyList == null)
		{
			readOnlyList = await GetPins();
		}
		IReadOnlyList<PinEntry> pins2 = readOnlyList;
		ArgumentNullException.ThrowIfNull(pins2, "pins");
		PinEntry domainPins = pins2.FirstOrDefault((PinEntry x) => x.HostNames.Any((string d) => d.Equals(domain, StringComparison.CurrentCultureIgnoreCase)));
		bool isValidHash = false;
		if (domainPins != null)
		{
			byte[][] pins3 = domainPins.Pins;
			foreach (byte[] pin in pins3)
			{
				if (((ReadOnlySpan<byte>)pin).SequenceEqual((ReadOnlySpan<byte>)leaf.GetCertHash(HashAlgorithmName.SHA256)))
				{
					isValidHash = true;
				}
			}
		}
		if (domainPins == null || !isValidHash)
		{
			string[]? array = exclusions;
			if (array != null && ((ReadOnlySpan<string>)array).Contains(domain))
			{
				if (logger.IsEnabled(LogLevel.Information))
				{
					logger.LogInformation("SSL Pinning ignored for {domain}", domain);
				}
				return true;
			}
			if (logger.IsEnabled(LogLevel.Critical))
			{
				logger.LogCritical("SSL pinning thumbprint is NOT valid for '{domain}' with subject {cert}, issuer {issuer}", domain, leaf.Subject, leaf.Issuer);
			}
			return false;
		}
		return true;
	}

	public async Task<bool> SslPinningCheck()
	{
		using HttpClient client = new HttpClient(securityService.GetFakeHandler());
		try
		{
			if (logger.IsEnabled(LogLevel.Information))
			{
				logger.LogInformation("SSL Pinning Check Start");
			}
			(await client.GetAsync(config.PublicFileUrl)).EnsureSuccessStatusCode();
			if (logger.IsEnabled(LogLevel.Critical))
			{
				logger.LogCritical("SSL Pinning Check Bypassed");
			}
			return false;
		}
		catch (WebException ex) when (ex.Status == WebExceptionStatus.TrustFailure)
		{
			if (logger.IsEnabled(LogLevel.Information))
			{
				logger.LogInformation("SSL Pinning Check Validated");
			}
			return true;
		}
		catch (HttpRequestException ex2) when (ex2.HttpRequestError == HttpRequestError.SecureConnectionError)
		{
			if (logger.IsEnabled(LogLevel.Information))
			{
				logger.LogInformation("SSL Pinning Check Validated");
			}
			return true;
		}
		catch (Exception ex3)
		{
			Exception ex4 = ex3;
			if (logger.IsEnabled(LogLevel.Critical))
			{
				logger.LogCritical("SSL Pinning Check Failed: {ex}", ex4);
			}
			return false;
		}
	}

	private async Task<IReadOnlyList<PinEntry>> GetPins()
	{
		try
		{
			using HttpClient client = httpClientFactory.CreateClient("HealthCheckHttpClient");
			HttpResponseMessage response = await client.GetAsync("apps/pins");
			if (response.IsSuccessStatusCode)
			{
				string token = await response.Content.ReadAsStringAsync();
				ArgumentNullException.ThrowIfNull(config.SslPinningSettings, "config.SslPinningSettings");
				ECDsa signingKey = ECDsa.Create();
				byte[] key = config.SslPinningSettings.PinningKey;
				signingKey.ImportSubjectPublicKeyInfo(key, out var _);
				TokenValidationParameters validationParameters = new TokenValidationParameters
				{
					IssuerSigningKey = new ECDsaSecurityKey(signingKey),
					RequireExpirationTime = false,
					ValidateAudience = false,
					ValidateIssuer = false
				};
				JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
				TokenValidationResult res = await handler.ValidateTokenAsync(token, validationParameters);
				JwtSecurityToken t = default(JwtSecurityToken);
				int num;
				if (res.IsValid)
				{
					SecurityToken securityToken = res.SecurityToken;
					t = securityToken as JwtSecurityToken;
					num = ((t != null) ? 1 : 0);
				}
				else
				{
					num = 0;
				}
				if (num != 0)
				{
					_pins = (from _003C_003Eh__TransparentIdentifier0 in t.Payload.Select(delegate(KeyValuePair<string, object> item)
						{
							KeyValuePair<string, object> keyValuePair = item;
							return new
							{
								item = item,
								domain = keyValuePair.Key
							};
						})
						let pins = JsonSerializer.Deserialize<byte[][]>(item.Value.ToString())
						select new PinEntry(domain, pins)).ToList();
					return _pins;
				}
			}
		}
		catch (Exception ex)
		{
			Exception e = ex;
			if (logger.IsEnabled(LogLevel.Error))
			{
				logger.LogError(e, "Get pins failed");
			}
		}
		return new List<PinEntry>();
	}
}
