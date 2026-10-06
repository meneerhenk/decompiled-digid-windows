using Microsoft.Maui.ApplicationModel;

namespace DigiD.Common.Interfaces;

public interface IGeneralPreferences
{
	const string LanguageWorkaround = "es";

	string SelectedHost { get; }

	bool MatomoTrackEnabled { get; set; }

	string Language { get; set; }

	AppTheme AppTheme { get; set; }

	string InstanceId { get; }

	string MatomoId { get; }
}
