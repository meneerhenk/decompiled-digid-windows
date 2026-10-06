using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using DigiD.Mobile.DigiD_Mobile_XamlTypeInfo;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Markup;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.WinUI;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IApplicationOverrides")]
[WinRTExposedType(typeof(DigiD_Mobile_WinUI_AppWinRTTypeDetails))]
public class App : MauiWinUIApplication, IXamlMetadataProvider
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2605")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2605")]
	private XamlMetaDataProvider __appProvider;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2605")]
	[DebuggerNonUserCode]
	private XamlMetaDataProvider _AppProvider
	{
		get
		{
			if (__appProvider == null)
			{
				__appProvider = new XamlMetaDataProvider();
			}
			return __appProvider;
		}
	}

	public App()
	{
		InitializeComponent();
	}

	protected override MauiApp CreateMauiApp()
	{
		return MauiProgram.CreateMauiApp();
	}

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2605")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri resourceLocator = new Uri("ms-appx:///Platforms/Windows/App.xaml");
			Microsoft.UI.Xaml.Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2605")]
	[DebuggerNonUserCode]
	public IXamlType GetXamlType(Type type)
	{
		return _AppProvider.GetXamlType(type);
	}

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2605")]
	[DebuggerNonUserCode]
	public IXamlType GetXamlType(string fullName)
	{
		return _AppProvider.GetXamlType(fullName);
	}

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2605")]
	[DebuggerNonUserCode]
	public XmlnsDefinition[] GetXmlnsDefinitions()
	{
		return _AppProvider.GetXmlnsDefinitions();
	}
}
