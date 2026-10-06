using System.Security.Cryptography.X509Certificates;

namespace DigiD.Mobile.Helpers;

internal static class CertificateHelper
{
	internal static bool ValidateChain(X509Certificate2 leaf, X509Certificate2Collection intermediates, X509Certificate2Collection roots)
	{
		using X509Chain x509Chain = new X509Chain();
		x509Chain.ChainPolicy.ExtraStore.AddRange(intermediates);
		x509Chain.ChainPolicy.CustomTrustStore.Clear();
		x509Chain.ChainPolicy.TrustMode = X509ChainTrustMode.CustomRootTrust;
		x509Chain.ChainPolicy.CustomTrustStore.AddRange(roots);
		x509Chain.ChainPolicy.RevocationMode = X509RevocationMode.NoCheck;
		return x509Chain.Build(leaf) || IsOnlyExpiredRoot(x509Chain);
	}

	private static bool IsOnlyExpiredRoot(X509Chain chain)
	{
		if (chain.ChainElements.Count == 0)
		{
			return false;
		}
		for (int i = 0; i < chain.ChainElements.Count - 1; i++)
		{
			if (chain.ChainElements[i].ChainElementStatus.Length != 0)
			{
				return false;
			}
		}
		X509ChainElementCollection chainElements = chain.ChainElements;
		X509ChainElement x509ChainElement = chainElements[chainElements.Count - 1];
		if (x509ChainElement.ChainElementStatus.Length != 1)
		{
			return false;
		}
		return x509ChainElement.ChainElementStatus[0].Status == X509ChainStatusFlags.NotTimeValid;
	}
}
