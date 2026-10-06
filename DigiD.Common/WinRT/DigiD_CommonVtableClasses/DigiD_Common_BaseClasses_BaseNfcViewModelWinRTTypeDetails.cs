using System.Runtime.InteropServices;
using ABI.System.ComponentModel;

namespace WinRT.DigiD_CommonVtableClasses;

internal sealed class DigiD_Common_BaseClasses_BaseNfcViewModelWinRTTypeDetails : IWinRTExposedTypeDetails
{
	public ComWrappers.ComInterfaceEntry[] GetExposedInterfaces()
	{
		return new ComWrappers.ComInterfaceEntry[1]
		{
			new ComWrappers.ComInterfaceEntry
			{
				IID = INotifyPropertyChangedMethods.IID,
				Vtable = INotifyPropertyChangedMethods.AbiToProjectionVftablePtr
			}
		};
	}
}
