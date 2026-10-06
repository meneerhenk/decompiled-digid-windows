using System;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Xml;
using DigiD.Common.Interfaces;

namespace DigiD.Common.Models;

public class App2AppRequest
{
	public string? Icon { get; set; }

	public string ReturnUrl { get; set; } = null;

	public string Destination { get; private set; } = null;

	public string? Host { get; set; }

	public required string SAMLRequest { get; set; }

	public string? RelayState { get; set; }

	public string? SigAlg { get; set; }

	public string? Signature { get; set; }

	public DateTimeOffset IssueInstant { get; set; }

	public bool IsValid(ICrashService crashService)
	{
		if (string.IsNullOrEmpty(SAMLRequest))
		{
			return false;
		}
		try
		{
			Encoding uTF = Encoding.UTF8;
			byte[] array = Convert.FromBase64String(SAMLRequest);
			string xml;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using MemoryStream stream = new MemoryStream(array);
				try
				{
					using (DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress))
					{
						deflateStream.CopyTo(memoryStream, array.Length);
						deflateStream.Close();
					}
					xml = uTF.GetString(memoryStream.ToArray());
				}
				catch (Exception ex)
				{
					if ((!(ex is InvalidDataException) && !(ex is IOException)) || 1 == 0)
					{
						return false;
					}
					xml = uTF.GetString(array);
				}
			}
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(xml);
			Destination = xmlDocument.DocumentElement?.Attributes["Destination"]?.Value ?? "No Destination";
			if (DateTimeOffset.TryParse(xmlDocument.DocumentElement?.Attributes["IssueInstant"]?.Value, out var result))
			{
				IssueInstant = result;
			}
			return !string.IsNullOrEmpty(Destination);
		}
		catch
		{
			return false;
		}
	}
}
