using System.Runtime.InteropServices;
using ABI.System;
using ABI.System.ComponentModel;

namespace WinRT.DigiD_Common_ControlsVtableClasses;

internal sealed class DigiD_Common_Controls_CustomAnimationViewWinRTTypeDetails : IWinRTExposedTypeDetails
{
	public ComWrappers.ComInterfaceEntry[] GetExposedInterfaces()
	{
		return new ComWrappers.ComInterfaceEntry[2]
		{
			new ComWrappers.ComInterfaceEntry
			{
				IID = INotifyPropertyChangedMethods.IID,
				Vtable = INotifyPropertyChangedMethods.AbiToProjectionVftablePtr
			},
			new ComWrappers.ComInterfaceEntry
			{
				IID = IDisposableMethods.IID,
				Vtable = IDisposableMethods.AbiToProjectionVftablePtr
			}
		};
	}
}
