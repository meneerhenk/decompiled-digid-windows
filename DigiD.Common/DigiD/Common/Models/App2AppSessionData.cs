using System;

namespace DigiD.Common.Models;

public class App2AppSessionData : SessionData
{
	public App2AppRequest Data { get; }

	public App2AppSessionData(App2AppRequest data)
	{
		Data = data ?? throw new ArgumentNullException("data");
		base.Host = data.Host;
		base.Identifier = "digid-app-auth";
	}
}
