using DigiD.Common.Interfaces;

namespace DigiD.Common.Plugins.Services;

public static class AppRating
{
	private static IAppRating? _defaultImplementation;

	public static IAppRating Default => _defaultImplementation ?? (_defaultImplementation = new AppRatingImplementation());

	internal static void SetDefault(IAppRating? implementation)
	{
		_defaultImplementation = implementation;
	}
}
