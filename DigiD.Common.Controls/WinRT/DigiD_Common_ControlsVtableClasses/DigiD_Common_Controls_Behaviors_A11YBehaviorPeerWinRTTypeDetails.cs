using System.Runtime.InteropServices;
using ABI.Microsoft.UI.Xaml.Automation.Peers;
using ABI.Microsoft.UI.Xaml.Automation.Provider;

namespace WinRT.DigiD_Common_ControlsVtableClasses;

internal sealed class DigiD_Common_Controls_Behaviors_A11YBehaviorPeerWinRTTypeDetails : IWinRTExposedTypeDetails
{
	public ComWrappers.ComInterfaceEntry[] GetExposedInterfaces()
	{
		return new ComWrappers.ComInterfaceEntry[2]
		{
			new ComWrappers.ComInterfaceEntry
			{
				IID = IAutomationPeerOverridesMethods.IID,
				Vtable = IAutomationPeerOverridesMethods.AbiToProjectionVftablePtr
			},
			new ComWrappers.ComInterfaceEntry
			{
				IID = IInvokeProviderMethods.IID,
				Vtable = IInvokeProviderMethods.AbiToProjectionVftablePtr
			}
		};
	}
}
