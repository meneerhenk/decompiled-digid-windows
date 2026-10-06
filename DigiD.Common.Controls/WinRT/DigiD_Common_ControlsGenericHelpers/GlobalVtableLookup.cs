using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ABI.System.Collections;
using ABI.System.ComponentModel;
using ABI.System.Windows.Input;

namespace WinRT.DigiD_Common_ControlsGenericHelpers;

internal static class GlobalVtableLookup
{
	[ModuleInitializer]
	internal static void InitializeGlobalVtableLookup()
	{
		ComWrappersSupport.RegisterTypeComInterfaceEntriesLookup(LookupVtableEntries);
		ComWrappersSupport.RegisterTypeRuntimeClassNameLookup(LookupRuntimeClassName);
	}

	private static ComWrappers.ComInterfaceEntry[] LookupVtableEntries(Type type)
	{
		string text = type.ToString();
		if (text == "Microsoft.Maui.Controls.TapGestureRecognizer" || text == "Microsoft.Maui.Controls.BindableObject")
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
		if (text == "Microsoft.Maui.Controls.StackLayout")
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
		if (text == "Microsoft.Maui.Controls.Command`1[System.Object]" || text == "Microsoft.Maui.Controls.Command")
		{
			return new ComWrappers.ComInterfaceEntry[1]
			{
				new ComWrappers.ComInterfaceEntry
				{
					IID = ICommandMethods.IID,
					Vtable = ICommandMethods.AbiToProjectionVftablePtr
				}
			};
		}
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

	private static string LookupRuntimeClassName(Type type)
	{
		string text = type.ToString();
		if (text == "Microsoft.Maui.Controls.TapGestureRecognizer" || text == "Microsoft.Maui.Controls.StackLayout" || text == "Microsoft.Maui.Controls.BindableObject")
		{
			return "Microsoft.UI.Xaml.Data.INotifyPropertyChanged";
		}
		if (text == "Microsoft.Maui.Controls.Command`1[System.Object]" || text == "Microsoft.Maui.Controls.Command")
		{
			return "Microsoft.UI.Xaml.Input.ICommand";
		}
		if (text == "System.Collections.ObjectModel.ReadOnlyCollection`1[Microsoft.Maui.IView]")
		{
			return "Microsoft.UI.Xaml.Interop.IBindableVector";
		}
		return null;
	}
}
