using System;

namespace DigiD.Common.Interfaces;

public interface IPiwikSettings
{
	int SessionsCount { get; set; }

	DateTime FirstVisit { get; set; }

	DateTime LastVisit { get; set; }

	void Save();
}
