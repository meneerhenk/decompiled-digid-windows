using System;

namespace DigiD.Common.NFC.Exceptions;

public class CardException : Exception
{
	public CardException(string message)
		: base(message)
	{
	}
}
