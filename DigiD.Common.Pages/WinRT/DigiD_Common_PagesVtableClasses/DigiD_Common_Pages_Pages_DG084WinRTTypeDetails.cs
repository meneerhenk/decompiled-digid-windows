using System.Runtime.InteropServices;
using ABI.System.ComponentModel;

namespace WinRT.DigiD_Common_PagesVtableClasses;

internal sealed class DigiD_Common_Pages_Pages_DG084WinRTTypeDetails : IWinRTExposedTypeDetails
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
