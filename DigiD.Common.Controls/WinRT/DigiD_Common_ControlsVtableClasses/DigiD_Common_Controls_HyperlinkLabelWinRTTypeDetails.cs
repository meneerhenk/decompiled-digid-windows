using System.Runtime.InteropServices;
using ABI.System.ComponentModel;

namespace WinRT.DigiD_Common_ControlsVtableClasses;

internal sealed class DigiD_Common_Controls_HyperlinkLabelWinRTTypeDetails : IWinRTExposedTypeDetails
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
