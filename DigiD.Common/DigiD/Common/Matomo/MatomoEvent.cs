using System;
using System.Collections.Generic;
using DigiD.Common.SessionModels;

namespace DigiD.Common.Matomo;

public class MatomoEvent
{
	public int SiteID { get; set; }

	public Guid Uuid { get; }

	public DateTimeOffset Date { get; set; }

	public required string Url { get; set; }

	public string? ActionName { get; set; }

	public required string Language { get; set; }

	public bool IsNewSession { get; set; }

	public string? EventCategory { get; set; }

	public string? EventAction { get; set; }

	public string? EventName { get; set; }

	public string? EventValue { get; set; }

	public int SessionsCount { get; }

	public DateTimeOffset LastVisit { get; }

	public DateTimeOffset FirstVisit { get; }

	public Dictionary<string, string[]> PageCustomVar { get; } = new Dictionary<string, string[]>();

	public MatomoEvent(MatomoSession session)
	{
		Date = DateTime.Now;
		Uuid = session.SessionId;
		SessionsCount = session.SessionsCount;
		LastVisit = session.LastVisit;
		FirstVisit = session.FirstVisit;
		if (HttpSession.IsApp2AppSession)
		{
			PageCustomVar.Add("1", new string[2] { "App2App", "1" });
		}
	}
}
