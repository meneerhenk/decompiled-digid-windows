using System;
using DigiD.Common.Models.Helpers;

namespace DigiD.Common.Models;

public class ObfuscatedString
{
	private readonly byte[] _key;

	private readonly byte[] _value;

	public ObfuscatedString(string key, string value)
	{
		_key = Convert.FromBase64String(key);
		_value = Convert.FromBase64String(value);
	}

	public override string ToString()
	{
		return _value.DeObfuscate(_key);
	}
}
