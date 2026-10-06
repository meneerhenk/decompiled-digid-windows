using System.Runtime.InteropServices;
using ABI.System.ComponentModel;

namespace WinRT.DigiD_Common_PluginsVtableClasses;

internal sealed class DigiD_Common_Plugins_ViewModels_SpinnerPopupViewModelWinRTTypeDetails : IWinRTExposedTypeDetails
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
