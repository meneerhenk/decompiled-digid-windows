using System.Runtime.InteropServices;
using ABI.Microsoft.UI.Xaml.Markup;

namespace WinRT.DigiD_MobileVtableClasses;

internal sealed class DigiD_Mobile_DigiD_Mobile_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails : IWinRTExposedTypeDetails
{
	public ComWrappers.ComInterfaceEntry[] GetExposedInterfaces()
	{
		return new ComWrappers.ComInterfaceEntry[1]
		{
			new ComWrappers.ComInterfaceEntry
			{
				IID = IXamlMetadataProviderMethods.IID,
				Vtable = IXamlMetadataProviderMethods.AbiToProjectionVftablePtr
			}
		};
	}
}
