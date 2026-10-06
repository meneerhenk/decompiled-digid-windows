using System;
using System.CodeDom.Compiler;
using System.Reflection;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Resources;
using DigiD.Mobile.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.Pages;

[XamlFilePath("Pages\\HLP003.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class HLP003 : BasePage<HLP003ViewModel>
{
	public HLP003(HLP003ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(HLP003).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(HLP003)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\HLP003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\HLP003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 17);
		string hLP03_Titel = DigiDAppResources.HLP03_Titel;
		VisualDiagnostics.RegisterSourceInfo(hLP03_Titel, new Uri("Pages\\HLP003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\HLP003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 14);
		string hLP03_Info = DigiDAppResources.HLP03_Info;
		VisualDiagnostics.RegisterSourceInfo(hLP03_Info, new Uri("Pages\\HLP003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 20);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\HLP003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 14);
		string hLP03_Info2 = DigiDAppResources.HLP03_Info1;
		VisualDiagnostics.RegisterSourceInfo(hLP03_Info2, new Uri("Pages\\HLP003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 20);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\HLP003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 14);
		string hLP03_Info3 = DigiDAppResources.HLP03_Info2;
		VisualDiagnostics.RegisterSourceInfo(hLP03_Info3, new Uri("Pages\\HLP003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 20);
		Label label4 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label4, new Uri("Pages\\HLP003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 14);
		string hLP03_Info4 = DigiDAppResources.HLP03_Info3;
		VisualDiagnostics.RegisterSourceInfo(hLP03_Info4, new Uri("Pages\\HLP003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 34);
		Label label5 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label5, new Uri("Pages\\HLP003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 14);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\HLP003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\HLP003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\HLP003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		label4.transientNamescope = nameScope;
		label5.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		verticalStackLayout.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		verticalStackLayout.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 0.0);
		label.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 0.0, 20.0));
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, verticalStackLayout, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(19, 17)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\HLP003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, hLP03_Titel);
		verticalStackLayout.Children.Add(label);
		label2.SetValue(Label.TextProperty, hLP03_Info);
		verticalStackLayout.Children.Add(label2);
		label3.SetValue(Label.TextProperty, hLP03_Info2);
		verticalStackLayout.Children.Add(label3);
		label4.SetValue(Label.TextProperty, hLP03_Info3);
		verticalStackLayout.Children.Add(label4);
		label5.SetValue(View.MarginProperty, new Thickness(0.0, 20.0));
		label5.SetValue(Label.TextProperty, hLP03_Info4);
		verticalStackLayout.Children.Add(label5);
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
		this.LoadFromXaml(typeof(HLP003));
	}
}
