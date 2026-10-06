using System;

namespace DigiD.Common.Exceptions;

public class SslException : Exception
{
	public SslException(Exception ex)
		: base("SslException", ex)
	{
	}
}
