using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using DigiD.Common.Resources.Enums;

namespace DigiD.Common.Resources;

public static class Localization
{
	private static bool _appTypeSet;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static AppType _003CAppType_003Ek__BackingField;

	public static AppType AppType
	{
		[CompilerGenerated]
		get
		{
			return _003CAppType_003Ek__BackingField;
		}
		set
		{
			if (_appTypeSet)
			{
				throw new InvalidOperationException("AppType can only be set once.");
			}
			if (value == AppType.None)
			{
				throw new InvalidEnumArgumentException("AppType", (int)_003CAppType_003Ek__BackingField, typeof(AppType));
			}
			_003CAppType_003Ek__BackingField = value;
			_appTypeSet = true;
		}
	}

	public static void SetCurrentCulture(CultureInfo value)
	{
		if (AppType == AppType.None)
		{
			throw new InvalidEnumArgumentException("AppType", (int)AppType, typeof(AppType));
		}
		CultureInfo.DefaultThreadCurrentCulture = value;
		CultureInfo.DefaultThreadCurrentUICulture = value;
		CultureInfo.CurrentUICulture = value;
		CultureInfo.CurrentCulture = value;
		Thread.CurrentThread.CurrentUICulture = value;
		Thread.CurrentThread.CurrentCulture = value;
		CommonResources.Culture = value;
		switch (AppType)
		{
		case AppType.DigiDApp:
			DigiDAppResources.Culture = value;
			break;
		case AppType.CheckID:
			CheckIDResources.Culture = value;
			break;
		case AppType.DesktopApp:
			DesktopAppResources.Culture = value;
			break;
		}
	}
}
