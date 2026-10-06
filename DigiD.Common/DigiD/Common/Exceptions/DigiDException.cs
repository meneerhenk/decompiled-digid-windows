using System;

namespace DigiD.Common.Exceptions;

public class DigiDException : Exception
{
	public DigiDException(string message)
		: base(message)
	{
	}
}
