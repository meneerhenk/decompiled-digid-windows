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

[XamlFilePath("Pages\\FM032.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class FM032 : BasePage<FM032ViewModel>
{
	public FM032()
		: base((FM032ViewModel?)null)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(FM032).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(FM032)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\FM032.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\FM032.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 17);
		string fM032_Titel = CommonResources.FM032_Titel;
		VisualDiagnostics.RegisterSourceInfo(fM032_Titel, new Uri("Pages\\FM032.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\FM032.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\FM032.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 20);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\FM032.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 14);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\FM032.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 17);
		string fM032_Knop = CommonResources.FM032_Knop;
		VisualDiagnostics.RegisterSourceInfo(fM032_Knop, new Uri("Pages\\FM032.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\FM032.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 14);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\FM032.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 20);
		string fM032_Subtitel = CommonResources.FM032_Subtitel;
		VisualDiagnostics.RegisterSourceInfo(fM032_Subtitel, new Uri("Pages\\FM032.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 55);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\FM032.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 14);
		string fM032_InfoAanvraag = CommonResources.FM032_InfoAanvraag;
		VisualDiagnostics.RegisterSourceInfo(fM032_InfoAanvraag, new Uri("Pages\\FM032.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 20);
		Label label4 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label4, new Uri("Pages\\FM032.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 14);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\FM032.xaml;assembly=DigiD.Mobile", UriKind.Relative), 38, 17);
		string fM032_LinkAanvraag = CommonResources.FM032_LinkAanvraag;
		VisualDiagnostics.RegisterSourceInfo(fM032_LinkAanvraag, new Uri("Pages\\FM032.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 17);
		BorderedButton borderedButton2 = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton2, new Uri("Pages\\FM032.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 14);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\FM032.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\FM032.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\FM032.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		label4.transientNamescope = nameScope;
		borderedButton2.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		verticalStackLayout.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		verticalStackLayout.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 10.0);
		label.SetValue(View.MarginProperty, new Thickness(0.0, 20.0, 0.0, 20.0));
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, verticalStackLayout, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(19, 17)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\FM032.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, fM032_Titel);
		verticalStackLayout.Children.Add(label);
		bindingExtension.Path = "MessageText";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\FM032.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 20);
		}
		label2.SetBinding(Label.TextProperty, bindingBase);
		verticalStackLayout.Children.Add(label2);
		borderedButton.SetValue(View.MarginProperty, new Thickness(0.0, 10.0, 0.0, 20.0));
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension2.Path = "CancelCommand";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\FM032.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase2);
		borderedButton.SetValue(Button.TextProperty, fM032_Knop);
		verticalStackLayout.Children.Add(borderedButton);
		staticResourceExtension2.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[4] { label3, verticalStackLayout, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(30, 20)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\FM032.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 20);
		}
		label3.SetValue(VisualElement.StyleProperty, obj2);
		label3.SetValue(Label.TextProperty, fM032_Subtitel);
		verticalStackLayout.Children.Add(label3);
		label4.SetValue(Label.TextProperty, fM032_InfoAanvraag);
		verticalStackLayout.Children.Add(label4);
		borderedButton2.SetValue(View.MarginProperty, new Thickness(0.0, 10.0, 0.0, 0.0));
		borderedButton2.SetValue(Element.AutomationIdProperty, "ContinueButton");
		borderedButton2.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension3.Path = "ContinueCommand";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\FM032.xaml;assembly=DigiD.Mobile", UriKind.Relative), 38, 17);
		}
		borderedButton2.SetBinding(Button.CommandProperty, bindingBase3);
		borderedButton2.SetValue(Button.TextProperty, fM032_LinkAanvraag);
		verticalStackLayout.Children.Add(borderedButton2);
		contentView.SetValue(ContentView.ContentProperty, verticalStackLayout);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<FM032ViewModel, string> setter = delegate(FM032ViewModel source, string? value)
			{
				source.MessageText = value;
			};
			return new TypedBinding<FM032ViewModel, string>((FM032ViewModel source) => (value: source.MessageText, success: true), setter, new Tuple<Func<FM032ViewModel, object>, string>[1]
			{
				new Tuple<Func<FM032ViewModel, object>, string>((FM032ViewModel source) => source, "MessageText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<FM032ViewModel, ICommand> setter = null;
			return new TypedBinding<FM032ViewModel, ICommand>((FM032ViewModel source) => ((ICommand value, bool success))(value: source.CancelCommand, success: true), setter, new Tuple<Func<FM032ViewModel, object>, string>[1]
			{
				new Tuple<Func<FM032ViewModel, object>, string>((FM032ViewModel source) => source, "CancelCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<FM032ViewModel, ICommand> setter = null;
			return new TypedBinding<FM032ViewModel, ICommand>((FM032ViewModel source) => ((ICommand value, bool success))(value: source.ContinueCommand, success: true), setter, new Tuple<Func<FM032ViewModel, object>, string>[1]
			{
				new Tuple<Func<FM032ViewModel, object>, string>((FM032ViewModel source) => source, "ContinueCommand")
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
		this.LoadFromXaml(typeof(FM032));
	}
}
