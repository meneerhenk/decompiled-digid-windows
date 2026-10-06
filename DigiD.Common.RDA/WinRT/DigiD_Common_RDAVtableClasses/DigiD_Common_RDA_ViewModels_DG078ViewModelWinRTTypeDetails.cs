using System.Runtime.InteropServices;
using ABI.System.ComponentModel;

namespace WinRT.DigiD_Common_RDAVtableClasses;

internal sealed class DigiD_Common_RDA_ViewModels_DG078ViewModelWinRTTypeDetails : IWinRTExposedTypeDetails
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
