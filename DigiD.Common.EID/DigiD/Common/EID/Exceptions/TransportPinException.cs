using System;

namespace DigiD.Common.EID.Exceptions;

public class TransportPinException : Exception
{
	public TransportPinException()
		: base("Transport PIN needs to be changed")
	{
	}
}
