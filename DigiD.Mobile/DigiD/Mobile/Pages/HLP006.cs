using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Windows.Input;
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

[XamlFilePath("Pages\\HLP006.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class HLP006 : BasePage<HLP006ViewModel>
{
	public HLP006()
		: base((HLP006ViewModel?)null)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(HLP006).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(HLP006)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\HLP006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\HLP006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 20);
		string hLP06_Titel = DigiDAppResources.HLP06_Titel;
		VisualDiagnostics.RegisterSourceInfo(hLP06_Titel, new Uri("Pages\\HLP006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 57);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\HLP006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 14);
		string hLP06_Intro = DigiDAppResources.HLP06_Intro;
		VisualDiagnostics.RegisterSourceInfo(hLP06_Intro, new Uri("Pages\\HLP006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 20);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\HLP006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\HLP006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 17);
		string hLP06_NieuweCode = DigiDAppResources.HLP06_NieuweCode;
		VisualDiagnostics.RegisterSourceInfo(hLP06_NieuweCode, new Uri("Pages\\HLP006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 17);
		LinkLabel linkLabel = new LinkLabel();
		VisualDiagnostics.RegisterSourceInfo(linkLabel, new Uri("Pages\\HLP006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 14);
		string hLP06_InfoOverslaan = DigiDAppResources.HLP06_InfoOverslaan;
		VisualDiagnostics.RegisterSourceInfo(hLP06_InfoOverslaan, new Uri("Pages\\HLP006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 20);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\HLP006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 14);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\HLP006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 17);
		string hLP06_LinkOverslaan = DigiDAppResources.HLP06_LinkOverslaan;
		VisualDiagnostics.RegisterSourceInfo(hLP06_LinkOverslaan, new Uri("Pages\\HLP006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 17);
		LinkLabel linkLabel2 = new LinkLabel();
		VisualDiagnostics.RegisterSourceInfo(linkLabel2, new Uri("Pages\\HLP006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 14);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\HLP006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\HLP006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\HLP006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		linkLabel.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		linkLabel2.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		verticalStackLayout.SetValue(View.MarginProperty, new Thickness(20.0));
		verticalStackLayout.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 20.0);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, verticalStackLayout, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(17, 20)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\HLP006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 20);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, hLP06_Titel);
		verticalStackLayout.Children.Add(label);
		label2.SetValue(Label.TextProperty, hLP06_Intro);
		verticalStackLayout.Children.Add(label2);
		linkLabel.SetValue(Element.AutomationIdProperty, "NewCodeLink");
		bindingExtension.Path = "NewCodeCommand";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\HLP006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 17);
		}
		linkLabel.SetBinding(LinkLabel.CommandProperty, bindingBase);
		linkLabel.SetValue(LinkLabel.TextProperty, hLP06_NieuweCode);
		verticalStackLayout.Children.Add(linkLabel);
		label3.SetValue(Label.TextProperty, hLP06_InfoOverslaan);
		verticalStackLayout.Children.Add(label3);
		linkLabel2.SetValue(Element.AutomationIdProperty, "SkipLink");
		bindingExtension2.Path = "SkipCommand";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\HLP006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 17);
		}
		linkLabel2.SetBinding(LinkLabel.CommandProperty, bindingBase2);
		linkLabel2.SetValue(LinkLabel.TextProperty, hLP06_LinkOverslaan);
		verticalStackLayout.Children.Add(linkLabel2);
		contentView.SetValue(ContentView.ContentProperty, verticalStackLayout);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<HLP006ViewModel, ICommand> setter = null;
			return new TypedBinding<HLP006ViewModel, ICommand>((HLP006ViewModel source) => ((ICommand value, bool success))(value: source.NewCodeCommand, success: true), setter, new Tuple<Func<HLP006ViewModel, object>, string>[1]
			{
				new Tuple<Func<HLP006ViewModel, object>, string>((HLP006ViewModel source) => source, "NewCodeCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<HLP006ViewModel, ICommand> setter = null;
			return new TypedBinding<HLP006ViewModel, ICommand>((HLP006ViewModel source) => ((ICommand value, bool success))(value: source.SkipCommand, success: true), setter, new Tuple<Func<HLP006ViewModel, object>, string>[1]
			{
				new Tuple<Func<HLP006ViewModel, object>, string>((HLP006ViewModel source) => source, "SkipCommand")
			});
		}
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
		this.LoadFromXaml(typeof(HLP006));
	}
}
