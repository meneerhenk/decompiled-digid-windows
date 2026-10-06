using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Windows.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Enums;
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

[XamlFilePath("Pages\\HLP007.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class HLP007 : BasePage<HLP007ViewModel>
{
	public HLP007(HLP007ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(HLP007).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(HLP007)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\HLP007.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\HLP007.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 20);
		string hLP07_Titel = DigiDAppResources.HLP07_Titel;
		VisualDiagnostics.RegisterSourceInfo(hLP07_Titel, new Uri("Pages\\HLP007.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 57);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\HLP007.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 14);
		string hLP07_Intro = DigiDAppResources.HLP07_Intro;
		VisualDiagnostics.RegisterSourceInfo(hLP07_Intro, new Uri("Pages\\HLP007.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 20);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\HLP007.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 14);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\HLP007.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 17);
		string hLP07_SubDitApparaat = DigiDAppResources.HLP07_SubDitApparaat;
		VisualDiagnostics.RegisterSourceInfo(hLP07_SubDitApparaat, new Uri("Pages\\HLP007.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 17);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\HLP007.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 14);
		string hLP07_DitApparaat = DigiDAppResources.HLP07_DitApparaat;
		VisualDiagnostics.RegisterSourceInfo(hLP07_DitApparaat, new Uri("Pages\\HLP007.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 20);
		Label label4 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label4, new Uri("Pages\\HLP007.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 14);
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension3, new Uri("Pages\\HLP007.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 17);
		string hLP07_SubAnderApparaat = DigiDAppResources.HLP07_SubAnderApparaat;
		VisualDiagnostics.RegisterSourceInfo(hLP07_SubAnderApparaat, new Uri("Pages\\HLP007.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 17);
		Label label5 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label5, new Uri("Pages\\HLP007.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 14);
		string hLP07_AnderApparaat = DigiDAppResources.HLP07_AnderApparaat;
		VisualDiagnostics.RegisterSourceInfo(hLP07_AnderApparaat, new Uri("Pages\\HLP007.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 20);
		Label label6 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label6, new Uri("Pages\\HLP007.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 14);
		string hLP07_InfoFilmpje = DigiDAppResources.HLP07_InfoFilmpje;
		VisualDiagnostics.RegisterSourceInfo(hLP07_InfoFilmpje, new Uri("Pages\\HLP007.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 20);
		Label label7 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label7, new Uri("Pages\\HLP007.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\HLP007.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 17);
		string hLP07_LinkFilmpje = DigiDAppResources.HLP07_LinkFilmpje;
		VisualDiagnostics.RegisterSourceInfo(hLP07_LinkFilmpje, new Uri("Pages\\HLP007.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\HLP007.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 14);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\HLP007.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\HLP007.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\HLP007.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		label4.transientNamescope = nameScope;
		label5.transientNamescope = nameScope;
		label6.transientNamescope = nameScope;
		label7.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		verticalStackLayout.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
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
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\HLP007.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 20);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, hLP07_Titel);
		verticalStackLayout.Children.Add(label);
		label2.SetValue(Label.TextProperty, hLP07_Intro);
		verticalStackLayout.Children.Add(label2);
		label3.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 0.0, -20.0));
		staticResourceExtension2.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[4] { label3, verticalStackLayout, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(21, 17)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\HLP007.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 17);
		}
		label3.SetValue(VisualElement.StyleProperty, obj2);
		label3.SetValue(Label.TextProperty, hLP07_SubDitApparaat);
		verticalStackLayout.Children.Add(label3);
		label4.SetValue(Label.TextProperty, hLP07_DitApparaat);
		verticalStackLayout.Children.Add(label4);
		label5.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 0.0, -20.0));
		staticResourceExtension3.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[4] { label5, verticalStackLayout, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(26, 17)));
		object obj3 = ((IMarkupExtension)staticResourceExtension3).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Pages\\HLP007.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 17);
		}
		label5.SetValue(VisualElement.StyleProperty, obj3);
		label5.SetValue(Label.TextProperty, hLP07_SubAnderApparaat);
		verticalStackLayout.Children.Add(label5);
		label6.SetValue(Label.TextProperty, hLP07_AnderApparaat);
		verticalStackLayout.Children.Add(label6);
		label7.SetValue(Label.TextProperty, hLP07_InfoFilmpje);
		verticalStackLayout.Children.Add(label7);
		borderedButton.SetValue(Element.AutomationIdProperty, "MovieLink");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension.Path = "OpenAnimationCommand";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\HLP007.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase);
		borderedButton.SetValue(BorderedButton.IsExternProperty, true);
		borderedButton.SetValue(Button.TextProperty, hLP07_LinkFilmpje);
		verticalStackLayout.Children.Add(borderedButton);
		contentView.SetValue(ContentView.ContentProperty, verticalStackLayout);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<HLP007ViewModel, ICommand> setter = null;
			return new TypedBinding<HLP007ViewModel, ICommand>((HLP007ViewModel source) => ((ICommand value, bool success))(value: source.OpenAnimationCommand, success: true), setter, new Tuple<Func<HLP007ViewModel, object>, string>[1]
			{
				new Tuple<Func<HLP007ViewModel, object>, string>((HLP007ViewModel source) => source, "OpenAnimationCommand")
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
		this.LoadFromXaml(typeof(HLP007));
	}
}
