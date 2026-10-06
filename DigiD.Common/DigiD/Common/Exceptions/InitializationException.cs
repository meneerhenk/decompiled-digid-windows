using System;

namespace DigiD.Common.Exceptions;

public class InitializationException : Exception
{
	public InitializationException(string message)
		: base(message)
	{
	}
}
