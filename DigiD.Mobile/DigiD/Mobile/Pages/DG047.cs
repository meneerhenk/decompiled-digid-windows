using System;
using System.CodeDom.Compiler;
using System.Reflection;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Settings;
using DigiD.Mobile.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.Pages;

[XamlFilePath("Pages\\DG047.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG047 : BasePage<DG047ViewModel>
{
	public DG047(DG047ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG047).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG047)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG047.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		LanguageSelectView languageSelectView = new LanguageSelectView();
		VisualDiagnostics.RegisterSourceInfo(languageSelectView, new Uri("Pages\\DG047.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 14);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\DG047.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG047.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG047.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope value = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, value);
		contentView.transientNamescope = value;
		verticalStackLayout.transientNamescope = value;
		languageSelectView.transientNamescope = value;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		verticalStackLayout.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 0.0);
		verticalStackLayout.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
		verticalStackLayout.Children.Add(languageSelectView);
		contentView.SetValue(ContentView.ContentProperty, verticalStackLayout);
		SetValue(ContentPage.ContentProperty, contentView);
		static string? getPathForType(Type type)
		{
			Assembly assembly = type.Assembly;
			foreach (XamlResourceIdAttribute customAttribute in assembly.GetCustomAttributes<XamlResourceIdAttribute>())
			{
				if (customAttribute.Type == type)
				{
					return customAttribute.Path;
				}
			}
			return null;
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(DG047));
	}
}
