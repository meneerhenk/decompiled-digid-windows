using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Helpers;

namespace DigiD.Common.Http.Helpers;

public static class DemoHelper
{
	public static Dictionary<string, DemoSession> Sessions { get; } = new Dictionary<string, DemoSession>();

	public static DemoSession? GetSession(string? sessionId)
	{
		if (sessionId == null)
		{
			return null;
		}
		return string.IsNullOrEmpty(sessionId) ? null : Sessions[sessionId];
	}

	public static string NewSession(string? action = null, string? sessionId = null, LoginLevel? loginLevel = null)
	{
		string text = sessionId ?? Guid.NewGuid().ToString();
		if (Sessions.TryGetValue(text, out DemoSession value))
		{
			value.Action = action;
			return text;
		}
		DemoSession value2 = new DemoSession
		{
			Action = action,
			Challenge = RandomNumberGenerator.GetBytes(32).ToBase16(),
			IV = RandomNumberGenerator.GetBytes(16),
			LoginLevel = (loginLevel ?? LoginLevel.Midden)
		};
		Sessions.Add(text, value2);
		return text;
	}
}
