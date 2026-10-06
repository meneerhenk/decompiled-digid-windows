using System;

namespace DigiD.Common.Exceptions;

public class InvalidDataException : Exception
{
	public InvalidDataException(string message)
		: base(message)
	{
	}
}
