using System;
using System.Collections.Generic;

namespace DigiD.Common.Interfaces;

public interface ICrashService
{
	void TrackError(Exception ex, Dictionary<string, string>? props = null);

	void Init();
}
