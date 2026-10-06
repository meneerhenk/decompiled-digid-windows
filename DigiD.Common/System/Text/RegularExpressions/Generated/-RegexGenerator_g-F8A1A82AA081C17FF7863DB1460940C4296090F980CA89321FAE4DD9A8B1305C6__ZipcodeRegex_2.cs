using System.CodeDom.Compiler;

namespace System.Text.RegularExpressions.Generated;

[GeneratedCode("System.Text.RegularExpressions.Generator", "10.0.14.42308")]
internal sealed class _003CRegexGenerator_g_003EF8A1A82AA081C17FF7863DB1460940C4296090F980CA89321FAE4DD9A8B1305C6__ZipcodeRegex_2 : Regex
{
	private sealed class RunnerFactory : RegexRunnerFactory
	{
		private sealed class Runner : RegexRunner
		{
			protected override void Scan(ReadOnlySpan<char> inputSpan)
			{
				if (TryFindNextPossibleStartingPosition(inputSpan) && !TryMatchAtCurrentPosition(inputSpan))
				{
					runtextpos = inputSpan.Length;
				}
			}

			private bool TryFindNextPossibleStartingPosition(ReadOnlySpan<char> inputSpan)
			{
				int num = runtextpos;
				if (num <= inputSpan.Length - 6 && num == 0)
				{
					return true;
				}
				runtextpos = inputSpan.Length;
				return false;
			}

			private bool TryMatchAtCurrentPosition(ReadOnlySpan<char> inputSpan)
			{
				int num = runtextpos;
				int start = num;
				ReadOnlySpan<char> readOnlySpan = inputSpan.Slice(num);
				if (num != 0)
				{
					return false;
				}
				if ((uint)readOnlySpan.Length < 6u || !char.IsBetween(readOnlySpan[0], '1', '9') || !char.IsAsciiDigit(readOnlySpan[1]) || !char.IsAsciiDigit(readOnlySpan[2]) || !char.IsAsciiDigit(readOnlySpan[3]) || !char.IsAsciiLetter(readOnlySpan[4]) || !char.IsAsciiLetter(readOnlySpan[5]))
				{
					return false;
				}
				if (7 < readOnlySpan.Length || (6 < readOnlySpan.Length && readOnlySpan[6] != '\n'))
				{
					return false;
				}
				Capture(0, start, runtextpos = num + 6);
				return true;
			}
		}

		protected override RegexRunner CreateInstance()
		{
			return new Runner();
		}
	}

	internal static readonly _003CRegexGenerator_g_003EF8A1A82AA081C17FF7863DB1460940C4296090F980CA89321FAE4DD9A8B1305C6__ZipcodeRegex_2 Instance = new _003CRegexGenerator_g_003EF8A1A82AA081C17FF7863DB1460940C4296090F980CA89321FAE4DD9A8B1305C6__ZipcodeRegex_2();

	private _003CRegexGenerator_g_003EF8A1A82AA081C17FF7863DB1460940C4296090F980CA89321FAE4DD9A8B1305C6__ZipcodeRegex_2()
	{
		pattern = "^[1-9][0-9]{3}[A-Za-z]{2}$";
		roptions = RegexOptions.None;
		Regex.ValidateMatchTimeout(_003CRegexGenerator_g_003EF8A1A82AA081C17FF7863DB1460940C4296090F980CA89321FAE4DD9A8B1305C6__Utilities.s_defaultTimeout);
		internalMatchTimeout = _003CRegexGenerator_g_003EF8A1A82AA081C17FF7863DB1460940C4296090F980CA89321FAE4DD9A8B1305C6__Utilities.s_defaultTimeout;
		factory = new RunnerFactory();
		capsize = 1;
	}
}
