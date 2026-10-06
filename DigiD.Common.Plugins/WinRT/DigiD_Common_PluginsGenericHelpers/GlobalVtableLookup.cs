using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ABI.System;

namespace WinRT.DigiD_Common_PluginsGenericHelpers;

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
		default:
			if (!(text == "System.Net.Sockets.NetworkStream"))
			{
				return null;
			}
			goto case "System.Threading.Tasks.Task`1[System.Threading.Tasks.Task]";
		case "System.Threading.Tasks.Task`1[System.Threading.Tasks.Task]":
		case "System.Net.Http.HttpResponseMessage":
		case "System.Net.Http.HttpClientHandler":
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
		default:
			if (!(text == "System.Net.Sockets.NetworkStream"))
			{
				return null;
			}
			goto case "System.Threading.Tasks.Task`1[System.Threading.Tasks.Task]";
		case "System.Threading.Tasks.Task`1[System.Threading.Tasks.Task]":
		case "System.Net.Http.HttpResponseMessage":
		case "System.Net.Http.HttpClientHandler":
			return "Windows.Foundation.IClosable";
		}
	}
}
