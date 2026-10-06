using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ABI.System;
using ABI.System.Collections;
using ABI.System.ComponentModel;

namespace WinRT.DigiD_MobileGenericHelpers;

internal static class GlobalVtableLookup
{
	[ModuleInitializer]
	internal static void InitializeGlobalVtableLookup()
	{
		ComWrappersSupport.RegisterTypeComInterfaceEntriesLookup(LookupVtableEntries);
		ComWrappersSupport.RegisterTypeRuntimeClassNameLookup(LookupRuntimeClassName);
	}

	private static ComWrappers.ComInterfaceEntry[] LookupVtableEntries(System.Type type)
	{
		string text = type.ToString();
		switch (text)
		{
		case "DigiD.Common.Controls.Models.ActionMenuItem":
			return new ComWrappers.ComInterfaceEntry[1]
			{
				new ComWrappers.ComInterfaceEntry
				{
					IID = INotifyPropertyChangedMethods.IID,
					Vtable = INotifyPropertyChangedMethods.AbiToProjectionVftablePtr
				}
			};
		default:
			if (!(text == "System.Threading.Tasks.Task"))
			{
				if (text == "System.Collections.ObjectModel.ReadOnlyCollection`1[Microsoft.Maui.IView]")
				{
					return new ComWrappers.ComInterfaceEntry[2]
					{
						new ComWrappers.ComInterfaceEntry
						{
							IID = IListMethods.IID,
							Vtable = IListMethods.AbiToProjectionVftablePtr
						},
						new ComWrappers.ComInterfaceEntry
						{
							IID = IEnumerableMethods.IID,
							Vtable = IEnumerableMethods.AbiToProjectionVftablePtr
						}
					};
				}
				return null;
			}
			goto case "System.Threading.Tasks.Task`1[System.Boolean]";
		case "System.Threading.Tasks.Task`1[System.Boolean]":
		case "System.Threading.Tasks.Task`1[System.Collections.Generic.IEnumerable`1[Plugin.Maui.BottomSheet.Navigation.INavigationResult]]":
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

	private static string LookupRuntimeClassName(System.Type type)
	{
		string text = type.ToString();
		switch (text)
		{
		case "DigiD.Common.Controls.Models.ActionMenuItem":
			return "Microsoft.UI.Xaml.Data.INotifyPropertyChanged";
		default:
			if (!(text == "System.Threading.Tasks.Task"))
			{
				if (text == "System.Collections.ObjectModel.ReadOnlyCollection`1[Microsoft.Maui.IView]")
				{
					return "Microsoft.UI.Xaml.Interop.IBindableVector";
				}
				return null;
			}
			goto case "System.Threading.Tasks.Task`1[System.Boolean]";
		case "System.Threading.Tasks.Task`1[System.Boolean]":
		case "System.Threading.Tasks.Task`1[System.Collections.Generic.IEnumerable`1[Plugin.Maui.BottomSheet.Navigation.INavigationResult]]":
			return "Windows.Foundation.IClosable";
		}
	}
}
