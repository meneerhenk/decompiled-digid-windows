using System.Runtime.InteropServices;
using ABI.System.Collections;
using ABI.System.ComponentModel;

namespace WinRT.DigiD_MobileVtableClasses;

internal sealed class DigiD_Mobile_Controls_MenuSwitchControlWinRTTypeDetails : IWinRTExposedTypeDetails
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
				IID = IEnumerableMethods.IID,
				Vtable = IEnumerableMethods.AbiToProjectionVftablePtr
			}
		};
	}
}
