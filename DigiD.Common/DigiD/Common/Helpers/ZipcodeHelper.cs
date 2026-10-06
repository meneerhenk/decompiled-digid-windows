using System.CodeDom.Compiler;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;

namespace DigiD.Common.Helpers;

public static class ZipcodeHelper
{
	public static bool IsValidZipcode(this string zipcode)
	{
		return !string.IsNullOrEmpty(zipcode) && ZipcodeRegex().IsMatch(zipcode);
	}

	[GeneratedRegex("^[1-9][0-9]{3}[A-Za-z]{2}$")]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "10.0.14.42308")]
	private static Regex ZipcodeRegex()
	{
		return _003CRegexGenerator_g_003EF8A1A82AA081C17FF7863DB1460940C4296090F980CA89321FAE4DD9A8B1305C6__ZipcodeRegex_2.Instance;
	}
}
