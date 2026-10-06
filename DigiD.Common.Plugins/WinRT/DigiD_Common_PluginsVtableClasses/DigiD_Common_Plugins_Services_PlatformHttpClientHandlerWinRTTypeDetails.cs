using System.Runtime.InteropServices;
using ABI.System;

namespace WinRT.DigiD_Common_PluginsVtableClasses;

internal sealed class DigiD_Common_Plugins_Services_PlatformHttpClientHandlerWinRTTypeDetails : IWinRTExposedTypeDetails
{
	public ComWrappers.ComInterfaceEntry[] GetExposedInterfaces()
	{
		return new ComWrappers.ComInterfaceEntry[1]
		{
			new ComWrappers.ComInterfaceEntry
			{
				IID = IDisposableMethods.IID,
				Vtable = IDisposableMethods.AbiToProjectionVftablePtr
			}
		};
	}
}
