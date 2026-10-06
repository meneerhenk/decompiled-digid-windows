using System.CodeDom.Compiler;

namespace System.Text.RegularExpressions.Generated;

[GeneratedCode("System.Text.RegularExpressions.Generator", "10.0.14.42308")]
internal sealed class _003CRegexGenerator_g_003EF67D0EC8C2AE65A6E7E88A34D2B97BEE634E814A5B5289ADB41109CE940307C54__EmailAddressRegex_0 : Regex
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
					if (_003CRegexGenerator_g_003EF67D0EC8C2AE65A6E7E88A34D2B97BEE634E814A5B5289ADB41109CE940307C54__Utilities.s_hasTimeout)
					{
						CheckTimeout();
					}
				}
			}

			private bool TryFindNextPossibleStartingPosition(ReadOnlySpan<char> inputSpan)
			{
				int num = runtextpos;
				if (num <= inputSpan.Length - 6)
				{
					int num2 = inputSpan.Slice(num).IndexOfAny(_003CRegexGenerator_g_003EF67D0EC8C2AE65A6E7E88A34D2B97BEE634E814A5B5289ADB41109CE940307C54__Utilities.s_ascii_FAACFFA3000000C0FFFFFF7F);
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
				int num2 = 0;
				int num3 = 0;
				int arg = 0;
				int arg2 = 0;
				int num4 = 0;
				int num5 = 0;
				int num6 = 0;
				int num7 = 0;
				int num8 = 0;
				int pos = 0;
				ReadOnlySpan<char> span = inputSpan.Slice(num);
				num2 = num;
				int num9 = span.IndexOfAnyExcept(_003CRegexGenerator_g_003EF67D0EC8C2AE65A6E7E88A34D2B97BEE634E814A5B5289ADB41109CE940307C54__Utilities.s_ascii_FAACFFA3000000C0FFFFFF7F);
				if (num9 < 0)
				{
					num9 = span.Length;
				}
				if (num9 == 0)
				{
					return false;
				}
				span = span.Slice(num9);
				num += num9;
				num3 = num;
				num2++;
				while (true)
				{
					if (runtextpos < num)
					{
						runtextpos = num;
					}
					num6 = 0;
					while (true)
					{
						_003CRegexGenerator_g_003EF67D0EC8C2AE65A6E7E88A34D2B97BEE634E814A5B5289ADB41109CE940307C54__Utilities.StackPush(ref runstack, ref pos, num);
						num6++;
						if (span.IsEmpty || span[0] != '.')
						{
							break;
						}
						int num10 = span.Slice(1).IndexOfAnyExcept(_003CRegexGenerator_g_003EF67D0EC8C2AE65A6E7E88A34D2B97BEE634E814A5B5289ADB41109CE940307C54__Utilities.s_ascii_FAACFFA3000000C0FFFFFF7F);
						if (num10 < 0)
						{
							num10 = span.Length - 1;
						}
						if (num10 == 0)
						{
							break;
						}
						span = span.Slice(num10);
						num += num10;
						num++;
						span = inputSpan.Slice(num);
					}
					while (--num6 >= 0)
					{
						num = runstack[--pos];
						span = inputSpan.Slice(num);
						if (span.IsEmpty || span[0] != '@')
						{
							continue;
						}
						num++;
						span = inputSpan.Slice(num);
						num7 = 0;
						while (true)
						{
							_003CRegexGenerator_g_003EF67D0EC8C2AE65A6E7E88A34D2B97BEE634E814A5B5289ADB41109CE940307C54__Utilities.StackPush(ref runstack, ref pos, num);
							num7++;
							char c;
							if (span.IsEmpty || ((uint)((c = span[0]) - 48) > 9u && (uint)(c - 97) > 25u))
							{
								goto IL_042c;
							}
							num++;
							span = inputSpan.Slice(num);
							num8 = 0;
							goto IL_023a;
							IL_03b8:
							_003CRegexGenerator_g_003EF67D0EC8C2AE65A6E7E88A34D2B97BEE634E814A5B5289ADB41109CE940307C54__Utilities.StackPush(ref runstack, ref pos, num8);
							if (span.IsEmpty || span[0] != '.')
							{
								goto IL_03cb;
							}
							num++;
							span = inputSpan.Slice(num);
							continue;
							IL_02f7:
							_003CRegexGenerator_g_003EF67D0EC8C2AE65A6E7E88A34D2B97BEE634E814A5B5289ADB41109CE940307C54__Utilities.StackPush(ref runstack, ref pos, arg, arg2);
							if (span.IsEmpty || ((uint)((c = span[0]) - 48) > 9u && (uint)(c - 97) > 25u))
							{
								goto IL_028c;
							}
							num++;
							span = inputSpan.Slice(num);
							if (num8 == 0)
							{
								goto IL_023a;
							}
							goto IL_03b8;
							IL_042c:
							if (--num7 < 0)
							{
								break;
							}
							num = runstack[--pos];
							span = inputSpan.Slice(num);
							if (num7 == 0)
							{
								break;
							}
							if (!span.IsEmpty && !((uint)((c = span[0]) - 48) > 9u && (uint)(c - 97) > 25u))
							{
								num++;
								span = inputSpan.Slice(num);
								num4 = num;
								int num11 = span.IndexOfAnyExcept(_003CRegexGenerator_g_003EF67D0EC8C2AE65A6E7E88A34D2B97BEE634E814A5B5289ADB41109CE940307C54__Utilities.s_asciiLettersLowerAndDigitsAndDash);
								if (num11 < 0)
								{
									num11 = span.Length;
								}
								span = span.Slice(num11);
								num += num11;
								num5 = num;
								while (true)
								{
									if (span.IsEmpty || ((uint)((c = span[0]) - 48) > 9u && (uint)(c - 97) > 25u))
									{
										if (_003CRegexGenerator_g_003EF67D0EC8C2AE65A6E7E88A34D2B97BEE634E814A5B5289ADB41109CE940307C54__Utilities.s_hasTimeout)
										{
											CheckTimeout();
										}
										if (num4 >= num5 || (num5 = inputSpan.Slice(num4, num5 - num4).LastIndexOfAny(_003CRegexGenerator_g_003EF67D0EC8C2AE65A6E7E88A34D2B97BEE634E814A5B5289ADB41109CE940307C54__Utilities.s_asciiLettersLowerAndDigits)) < 0)
										{
											break;
										}
										num5 += num4;
										num = num5;
										span = inputSpan.Slice(num);
										continue;
									}
									Capture(0, start, runtextpos = num + 1);
									return true;
								}
							}
							if (_003CRegexGenerator_g_003EF67D0EC8C2AE65A6E7E88A34D2B97BEE634E814A5B5289ADB41109CE940307C54__Utilities.s_hasTimeout)
							{
								CheckTimeout();
							}
							if (num7 == 0)
							{
								break;
							}
							goto IL_03cb;
							IL_03cb:
							num8 = runstack[--pos];
							if (_003CRegexGenerator_g_003EF67D0EC8C2AE65A6E7E88A34D2B97BEE634E814A5B5289ADB41109CE940307C54__Utilities.s_hasTimeout)
							{
								CheckTimeout();
							}
							if (_003CRegexGenerator_g_003EF67D0EC8C2AE65A6E7E88A34D2B97BEE634E814A5B5289ADB41109CE940307C54__Utilities.s_hasTimeout)
							{
								CheckTimeout();
							}
							if (num8 == 0)
							{
								goto IL_042c;
							}
							goto IL_028c;
							IL_028c:
							_003CRegexGenerator_g_003EF67D0EC8C2AE65A6E7E88A34D2B97BEE634E814A5B5289ADB41109CE940307C54__Utilities.StackPop(runstack, ref pos, out arg2, out arg);
							if (_003CRegexGenerator_g_003EF67D0EC8C2AE65A6E7E88A34D2B97BEE634E814A5B5289ADB41109CE940307C54__Utilities.s_hasTimeout)
							{
								CheckTimeout();
							}
							if (arg < arg2 && (arg2 = inputSpan.Slice(arg, arg2 - arg).LastIndexOfAny(_003CRegexGenerator_g_003EF67D0EC8C2AE65A6E7E88A34D2B97BEE634E814A5B5289ADB41109CE940307C54__Utilities.s_asciiLettersLowerAndDigits)) >= 0)
							{
								arg2 += arg;
								num = arg2;
								span = inputSpan.Slice(num);
								goto IL_02f7;
							}
							if (--num8 < 0)
							{
								goto IL_042c;
							}
							num = runstack[--pos];
							span = inputSpan.Slice(num);
							goto IL_03b8;
							IL_023a:
							_003CRegexGenerator_g_003EF67D0EC8C2AE65A6E7E88A34D2B97BEE634E814A5B5289ADB41109CE940307C54__Utilities.StackPush(ref runstack, ref pos, num);
							num8++;
							arg = num;
							int num12 = span.IndexOfAnyExcept(_003CRegexGenerator_g_003EF67D0EC8C2AE65A6E7E88A34D2B97BEE634E814A5B5289ADB41109CE940307C54__Utilities.s_asciiLettersLowerAndDigitsAndDash);
							if (num12 < 0)
							{
								num12 = span.Length;
							}
							span = span.Slice(num12);
							num += num12;
							arg2 = num;
							goto IL_02f7;
						}
					}
					if (_003CRegexGenerator_g_003EF67D0EC8C2AE65A6E7E88A34D2B97BEE634E814A5B5289ADB41109CE940307C54__Utilities.s_hasTimeout)
					{
						CheckTimeout();
					}
					if (num2 >= num3)
					{
						break;
					}
					num = --num3;
					span = inputSpan.Slice(num);
				}
				return false;
			}
		}

		protected override RegexRunner CreateInstance()
		{
			return new Runner();
		}
	}

	internal static readonly _003CRegexGenerator_g_003EF67D0EC8C2AE65A6E7E88A34D2B97BEE634E814A5B5289ADB41109CE940307C54__EmailAddressRegex_0 Instance = new _003CRegexGenerator_g_003EF67D0EC8C2AE65A6E7E88A34D2B97BEE634E814A5B5289ADB41109CE940307C54__EmailAddressRegex_0();

	private _003CRegexGenerator_g_003EF67D0EC8C2AE65A6E7E88A34D2B97BEE634E814A5B5289ADB41109CE940307C54__EmailAddressRegex_0()
	{
		pattern = "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])";
		roptions = RegexOptions.None;
		Regex.ValidateMatchTimeout(_003CRegexGenerator_g_003EF67D0EC8C2AE65A6E7E88A34D2B97BEE634E814A5B5289ADB41109CE940307C54__Utilities.s_defaultTimeout);
		internalMatchTimeout = _003CRegexGenerator_g_003EF67D0EC8C2AE65A6E7E88A34D2B97BEE634E814A5B5289ADB41109CE940307C54__Utilities.s_defaultTimeout;
		factory = new RunnerFactory();
		capsize = 1;
	}
}
