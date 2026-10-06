using System;
using DigiD.Common.Models.Enums;

namespace DigiD.Common.Models.Helpers;

public static class ConvertHelpers
{
	public static LoginLevel ToLoginLevel(this int value)
	{
		return value switch
		{
			10 => LoginLevel.Basis, 
			20 => LoginLevel.Midden, 
			25 => LoginLevel.Substantieel, 
			30 => LoginLevel.Hoog, 
			_ => LoginLevel.Unknown, 
		};
	}

	public static DateTime FromUnixTime(this long unixTime)
	{
		return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(unixTime);
	}

	public static long ToUnixTime(this DateTimeOffset date)
	{
		DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
		return Convert.ToInt64((date - dateTime).TotalSeconds);
	}

	public static long ToUnixTimeMs(this DateTimeOffset date)
	{
		DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
		return Convert.ToInt64((date - dateTime).TotalMilliseconds);
	}

	public static int ToInt(this LoginLevel value)
	{
		return value switch
		{
			LoginLevel.Basis => 10, 
			LoginLevel.Midden => 20, 
			LoginLevel.Substantieel => 25, 
			LoginLevel.Hoog => 30, 
			_ => 20, 
		};
	}
}
