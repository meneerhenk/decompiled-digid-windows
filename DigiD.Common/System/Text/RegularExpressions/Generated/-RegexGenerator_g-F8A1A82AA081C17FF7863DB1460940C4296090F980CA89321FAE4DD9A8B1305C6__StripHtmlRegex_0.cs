using System.CodeDom.Compiler;

namespace System.Text.RegularExpressions.Generated;

[GeneratedCode("System.Text.RegularExpressions.Generator", "10.0.14.42308")]
internal sealed class _003CRegexGenerator_g_003EF8A1A82AA081C17FF7863DB1460940C4296090F980CA89321FAE4DD9A8B1305C6__StripHtmlRegex_0 : Regex
{
	private sealed class RunnerFactory : RegexRunnerFactory
	{
		private sealed class Runner : RegexRunner
		{
			protected override void Scan(ReadOnlySpan<char> inputSpan)
			{
				while (TryFindNextPossibleStartingPosition(inputSpan) && !TryMatchAtCurrentPosition(inputSpan) && runtextpos != inputSpan.Length)
				{
					runtextpos++;
					if (_003CRegexGenerator_g_003EF8A1A82AA081C17FF7863DB1460940C4296090F980CA89321FAE4DD9A8B1305C6__Utilities.s_hasTimeout)
					{
						CheckTimeout();
					}
				}
			}

			private bool TryFindNextPossibleStartingPosition(ReadOnlySpan<char> inputSpan)
			{
				int num = runtextpos;
				if (num <= inputSpan.Length - 2)
				{
					int num2 = inputSpan.Slice(num).IndexOf('<');
					if (num2 >= 0)
					{
						runtextpos = num + num2;
						return true;
					}
				}
				runtextpos = inputSpan.Length;
				return false;
			}

			private bool TryMatchAtCurrentPosition(ReadOnlySpan<char> inputSpan)
			{
				int num = runtextpos;
				int start = num;
				ReadOnlySpan<char> readOnlySpan = inputSpan.Slice(num);
				if (readOnlySpan.IsEmpty || readOnlySpan[0] != '<')
				{
					return false;
				}
				int num2 = readOnlySpan.Slice(1).IndexOf('>');
				if (num2 < 0)
				{
					num2 = readOnlySpan.Length - 1;
				}
				readOnlySpan = readOnlySpan.Slice(num2);
				num += num2;
				if ((uint)readOnlySpan.Length < 2u || readOnlySpan[1] != '>')
				{
					return false;
				}
				Capture(0, start, runtextpos = num + 2);
				return true;
			}
		}

		protected override RegexRunner CreateInstance()
		{
			return new Runner();
		}
	}

	internal static readonly _003CRegexGenerator_g_003EF8A1A82AA081C17FF7863DB1460940C4296090F980CA89321FAE4DD9A8B1305C6__StripHtmlRegex_0 Instance = new _003CRegexGenerator_g_003EF8A1A82AA081C17FF7863DB1460940C4296090F980CA89321FAE4DD9A8B1305C6__StripHtmlRegex_0();

	private _003CRegexGenerator_g_003EF8A1A82AA081C17FF7863DB1460940C4296090F980CA89321FAE4DD9A8B1305C6__StripHtmlRegex_0()
	{
		pattern = "<[^>]*>";
		roptions = RegexOptions.None;
		Regex.ValidateMatchTimeout(_003CRegexGenerator_g_003EF8A1A82AA081C17FF7863DB1460940C4296090F980CA89321FAE4DD9A8B1305C6__Utilities.s_defaultTimeout);
		internalMatchTimeout = _003CRegexGenerator_g_003EF8A1A82AA081C17FF7863DB1460940C4296090F980CA89321FAE4DD9A8B1305C6__Utilities.s_defaultTimeout;
		factory = new RunnerFactory();
		capsize = 1;
	}
}
