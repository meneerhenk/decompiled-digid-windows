using System;

namespace DigiD.Common.Matomo;

public class MatomoSession
{
	public int SessionsCount { get; set; }

	public DateTime LastVisit { get; set; }

	public DateTime FirstVisit { get; set; }

	public Guid SessionId { get; }

	public MatomoSession()
	{
		SessionId = Guid.NewGuid();
		MatomoStorage.SessionsCount++;
		MatomoStorage.LastVisit = DateTime.Now;
		SessionsCount = MatomoStorage.SessionsCount;
		FirstVisit = MatomoStorage.FirstVisit;
		LastVisit = MatomoStorage.LastVisit;
	}
}
