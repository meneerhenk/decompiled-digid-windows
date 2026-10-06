using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using DigiD.Common.Enums;
using DigiD.Common.Models;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Responses;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using DigiD.Mobile.Interfaces;

namespace DigiD.Mobile.Services.KeyAttestation;

internal class KeyAttestationService(IMobileSettings mobileSettings, ISigningService signingService) : IAttestationService
{
	private const string KEY_CONTAINER_PREFIX = "DigiD_Key_";

	public static bool IsSupported => false;

	public void ProcessResponse(BaseResponse response, KeyAttestationRequestModel keyAttestModel)
	{
		if (response.ErrorMessage == "key_attestation_failed" || response.ApiResult != ApiResult.Ok)
		{
			DeleteKey(keyAttestModel.KeyID);
			mobileSettings.KeyAttestationResult = KeyAttestationResult.Failed;
			AppSession.IsKeyAttestationFailed = true;
		}
		else
		{
			mobileSettings.SubAttestationKeyId = keyAttestModel.KeyID;
			mobileSettings.KeyAttestationResult = KeyAttestationResult.Success;
			signingService.RemoveKeyPair();
		}
	}

	public async Task<KeyAttestationRequestModel?> Attest(byte[] challenge)
	{
		try
		{
			await Task.Delay(0);
			string keyId = $"{"DigiD_Key_"}{Guid.NewGuid()}";
			X509Certificate2 certRequest = CreateCertificateRequest(keyId, challenge);
			if (certRequest == null)
			{
				return null;
			}
			byte[] certBytes = ExportCertificate(certRequest);
			return new KeyAttestationRequestModel
			{
				KeyID = keyId,
				iOSResult = certBytes
			};
		}
		catch (Exception)
		{
			return null;
		}
	}

	public async Task<byte[]?> Sign(string challenge, string keyId)
	{
		await Task.Delay(0);
		try
		{
			byte[] challengeBytes = Convert.FromBase64String(challenge);
			using RSACng rsa = OpenOrCreateKey(keyId);
			return rsa?.SignData(challengeBytes, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
		}
		catch (Exception)
		{
			return null;
		}
	}

	public void DeleteKey(string keyId)
	{
		try
		{
			if (CngKey.Exists(keyId, CngProvider.MicrosoftPlatformCryptoProvider))
			{
				CngKey cngKey = CngKey.Open(keyId, CngProvider.MicrosoftPlatformCryptoProvider);
				cngKey.Delete();
			}
			if (CngKey.Exists(keyId, CngProvider.MicrosoftSoftwareKeyStorageProvider))
			{
				CngKey cngKey2 = CngKey.Open(keyId, CngProvider.MicrosoftSoftwareKeyStorageProvider);
				cngKey2.Delete();
			}
		}
		catch (Exception)
		{
		}
	}

	public byte[]? ExportPubicKey(string keyId)
	{
		try
		{
			using RSACng rSACng = OpenOrCreateKey(keyId);
			return rSACng?.ExportRSAPublicKey();
		}
		catch (Exception)
		{
			return null;
		}
	}

	private static X509Certificate2? CreateCertificateRequest(string keyId, byte[] challenge)
	{
		try
		{
			CngKey cngKey = CreateTpmKey(keyId);
			using RSA key = ((cngKey != null) ? new RSACng(cngKey) : RSA.Create(2048));
			X500DistinguishedName subjectName = new X500DistinguishedName("CN=DigiD-" + keyId);
			CertificateRequest certificateRequest = new CertificateRequest(subjectName, key, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
			certificateRequest.CertificateExtensions.Add(new X509Extension(new Oid("1.2.3.4.5.6.7.8.1"), challenge, critical: false));
			return certificateRequest.CreateSelfSigned(DateTimeOffset.UtcNow.AddDays(-1.0), DateTimeOffset.UtcNow.AddYears(2));
		}
		catch (Exception)
		{
			return null;
		}
	}

	private static CngKey? CreateTpmKey(string keyId)
	{
		try
		{
			CngKeyCreationParameters cngKeyCreationParameters = new CngKeyCreationParameters
			{
				Provider = CngProvider.MicrosoftPlatformCryptoProvider,
				KeyCreationOptions = CngKeyCreationOptions.OverwriteExistingKey,
				KeyUsage = CngKeyUsages.Signing
			};
			CngProperty item = new CngProperty("PCP_PLATFORM_TYPE", BitConverter.GetBytes(1), CngPropertyOptions.None);
			cngKeyCreationParameters.Parameters.Add(item);
			return CngKey.Create(CngAlgorithm.Rsa, keyId, cngKeyCreationParameters);
		}
		catch (Exception)
		{
			try
			{
				CngKeyCreationParameters creationParameters = new CngKeyCreationParameters
				{
					Provider = CngProvider.MicrosoftSoftwareKeyStorageProvider,
					KeyCreationOptions = CngKeyCreationOptions.OverwriteExistingKey,
					KeyUsage = CngKeyUsages.Signing
				};
				return CngKey.Create(CngAlgorithm.Rsa, keyId, creationParameters);
			}
			catch
			{
				return null;
			}
		}
	}

	private static RSACng? OpenOrCreateKey(string keyId)
	{
		try
		{
			if (CngKey.Exists(keyId, CngProvider.MicrosoftPlatformCryptoProvider))
			{
				CngKey key = CngKey.Open(keyId, CngProvider.MicrosoftPlatformCryptoProvider);
				return new RSACng(key);
			}
			if (CngKey.Exists(keyId, CngProvider.MicrosoftSoftwareKeyStorageProvider))
			{
				CngKey key2 = CngKey.Open(keyId, CngProvider.MicrosoftSoftwareKeyStorageProvider);
				return new RSACng(key2);
			}
			CngKey cngKey = CreateTpmKey(keyId);
			return (cngKey != null) ? new RSACng(cngKey) : null;
		}
		catch (Exception)
		{
			return null;
		}
	}

	private static byte[]? ExportCertificate(X509Certificate2 certificate)
	{
		try
		{
			return certificate.Export(X509ContentType.Cert);
		}
		catch (Exception)
		{
			return null;
		}
	}
}
