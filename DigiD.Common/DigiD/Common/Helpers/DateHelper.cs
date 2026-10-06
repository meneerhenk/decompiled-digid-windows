using System;
using System.Security.Cryptography.X509Certificates;

namespace DigiD.Common.Helpers;

public static class DateHelper
{
	public static int GetEpochSeconds()
	{
		return (int)(DateTime.Now - new DateTime(1970, 1, 1)).TotalSeconds;
	}

	public static bool IsExpired(this X509Certificate certificate)
	{
		X509Certificate2 x509Certificate = new X509Certificate2(certificate);
		return x509Certificate.NotAfter < DateTime.Now;
	}
}
