using System.Collections.Generic;

namespace DigiD.Common.Helpers;

public static class DictionaryHelper
{
	public static string? GetValue(this Dictionary<string, string> dictionary, string key)
	{
		string value;
		return dictionary.TryGetValue(key, out value) ? value : null;
	}
}
