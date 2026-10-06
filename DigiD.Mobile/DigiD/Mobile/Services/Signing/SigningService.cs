using System;
using System.Formats.Asn1;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using DigiD.Common.Helpers;
using DigiD.Mobile.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Storage;

namespace DigiD.Mobile.Services.Signing;

internal class SigningService(ILogger<SigningService> logger) : ISigningService
{
	private const string KEY_NAME = "DigiD_Signing_Key";

	private const string CURVE_NAME = "prime256v1";

	private readonly CngProvider Provider = CngProvider.MicrosoftPlatformCryptoProvider;

	public bool HardwareSupport => CheckTpm20Support();

	private static CngProperty CreateUserOnlySecurityProperty()
	{
		SecurityIdentifier securityIdentifier = WindowsIdentity.GetCurrent().User ?? throw new InvalidOperationException("Cannot determine current user SID");
		RawAcl rawAcl = new RawAcl(GenericAcl.AclRevision, 1);
		rawAcl.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessAllowed, 2031619, securityIdentifier, isCallback: false, null));
		RawSecurityDescriptor rawSecurityDescriptor = new RawSecurityDescriptor(ControlFlags.DiscretionaryAclPresent, securityIdentifier, null, null, rawAcl);
		byte[] array = new byte[rawSecurityDescriptor.BinaryLength];
		rawSecurityDescriptor.GetBinaryForm(array, 0);
		return new CngProperty("Security Descr", array, (CngPropertyOptions)4);
	}

	private bool CheckTpm20Support()
	{
		try
		{
			if (!Provider.Equals(CngProvider.MicrosoftPlatformCryptoProvider))
			{
				return false;
			}
			try
			{
				using (CngKey.Create(CngAlgorithm.ECDsaP256, null, new CngKeyCreationParameters
				{
					Provider = Provider,
					KeyCreationOptions = CngKeyCreationOptions.None
				}))
				{
					return true;
				}
			}
			catch
			{
				return false;
			}
		}
		catch
		{
			return false;
		}
	}

	public bool GenerateKeyPair()
	{
		try
		{
			if (CngKey.Exists("DigiD_Signing_Key", Provider))
			{
				RemoveKeyPair();
			}
			CngKeyCreationParameters cngKeyCreationParameters = new CngKeyCreationParameters
			{
				Provider = Provider,
				KeyCreationOptions = CngKeyCreationOptions.None,
				KeyUsage = CngKeyUsages.Signing,
				ExportPolicy = CngExportPolicies.None
			};
			cngKeyCreationParameters.Parameters.Add(CreateUserOnlySecurityProperty());
			using (CngKey.Create(CngAlgorithm.ECDsaP256, "DigiD_Signing_Key", cngKeyCreationParameters))
			{
				if (!CngKey.Exists("DigiD_Signing_Key", Provider))
				{
					if (logger.IsEnabled(LogLevel.Debug))
					{
						logger.LogDebug("Key creation verification failed");
					}
					return false;
				}
				if (logger.IsEnabled(LogLevel.Debug))
				{
					logger.LogDebug("EC key pair created successfully with curve: {Curve}", "prime256v1");
				}
				SecureStorage.Default.SetAsync("KeyName", "DigiD_Signing_Key");
				return true;
			}
		}
		catch (Exception exception)
		{
			logger.LogError(exception, "Failed to generate key pair");
			return false;
		}
	}

	public byte[]? ExportPublicKey()
	{
		try
		{
			if (!CngKey.Exists("DigiD_Signing_Key", Provider))
			{
				logger.LogDebug("Key pair does not exist");
				return null;
			}
			using CngKey key = CngKey.Open("DigiD_Signing_Key", Provider);
			using ECDsaCng eCDsaCng = new ECDsaCng(key);
			byte[] array = eCDsaCng.ExportSubjectPublicKeyInfo();
			int bytesRead;
			PublicKey publicKey = PublicKey.CreateFromSubjectPublicKeyInfo(array, out bytesRead);
			ECParameters eCParameters = eCDsaCng.ExportParameters(includePrivateParameters: false);
			if (logger.IsEnabled(LogLevel.Debug))
			{
				logger.LogDebug("Public key exported successfully");
				logger.LogDebug("Algorithm: {Algorithm} ({AlgorithmValue})", publicKey.Oid.FriendlyName, publicKey.Oid.Value);
				logger.LogDebug("Key size: {KeySize} bits", eCDsaCng.KeySize);
				logger.LogDebug("Curve: {Curve}", eCParameters.Curve.Oid.FriendlyName);
				logger.LogDebug("Public key length: {PublicKeyLength} bytes", array.Length);
				logger.LogDebug("Bytes read: {BytesRead}", bytesRead);
			}
			return publicKey.EncodedKeyValue.RawData;
		}
		catch (Exception exception)
		{
			logger.LogError(exception, "Failed to export public key");
			return null;
		}
	}

	public byte[]? Sign(string data)
	{
		try
		{
			if (string.IsNullOrEmpty(data))
			{
				logger.LogDebug("Data to sign is null or empty");
				return null;
			}
			if (!CngKey.Exists("DigiD_Signing_Key", Provider))
			{
				logger.LogDebug("Key pair does not exist");
				return null;
			}
			using CngKey key = CngKey.Open("DigiD_Signing_Key", Provider);
			using ECDsaCng eCDsaCng = new ECDsaCng(key);
			byte[] ieee1363Signature = eCDsaCng.SignHash(data.Hash());
			byte[] array = ConvertIeee1363ToDer(ieee1363Signature);
			if (logger.IsEnabled(LogLevel.Debug))
			{
				logger.LogDebug("Data signed successfully, signature length: {Length} bytes", array.Length);
				logger.LogDebug("Signature starts with: {SignatureStart}", Convert.ToHexString(array.Take(8).ToArray()));
			}
			return array;
		}
		catch (Exception exception)
		{
			logger.LogError(exception, "Failed to sign data");
			return null;
		}
	}

	private static byte[] ConvertIeee1363ToDer(byte[] ieee1363Signature)
	{
		int num = ieee1363Signature.Length / 2;
		Span<byte> span = ieee1363Signature.AsSpan(0, num);
		Span<byte> span2 = ieee1363Signature.AsSpan(num, num);
		AsnWriter asnWriter = new AsnWriter(AsnEncodingRules.DER);
		using (asnWriter.PushSequence())
		{
			asnWriter.WriteIntegerUnsigned(span);
			asnWriter.WriteIntegerUnsigned(span2);
		}
		return asnWriter.Encode();
	}

	public bool RemoveKeyPair()
	{
		try
		{
			if (!CngKey.Exists("DigiD_Signing_Key", Provider))
			{
				logger.LogDebug("Key pair does not exist");
				return true;
			}
			using CngKey cngKey = CngKey.Open("DigiD_Signing_Key", Provider);
			cngKey.Delete();
			if (CngKey.Exists("DigiD_Signing_Key", Provider))
			{
				logger.LogDebug("Key removal verification failed");
				return false;
			}
			logger.LogDebug("Key pair removed successfully");
			return true;
		}
		catch (Exception exception)
		{
			logger.LogError(exception, "Failed to remove key pair");
			return false;
		}
	}
}
