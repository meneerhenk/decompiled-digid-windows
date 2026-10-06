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

[XamlFilePath("Pages\\FM011.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class FM011 : BasePage<FM011ViewModel>
{
	public FM011()
		: base((FM011ViewModel?)null)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(FM011).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(FM011)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 20);
		string fM011_Titel = CommonResources.FM011_Titel;
		VisualDiagnostics.RegisterSourceInfo(fM011_Titel, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 57);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 14);
		string fM011_Intro = CommonResources.FM011_Intro;
		VisualDiagnostics.RegisterSourceInfo(fM011_Intro, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 20);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 20);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 14);
		string fM011_LangstNietGebruikt = CommonResources.FM011_LangstNietGebruikt;
		VisualDiagnostics.RegisterSourceInfo(fM011_LangstNietGebruikt, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 20);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 20);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 14);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 17);
		string fM011_Knop = CommonResources.FM011_Knop;
		VisualDiagnostics.RegisterSourceInfo(fM011_Knop, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 14);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 20);
		string fM011_Subtitel = CommonResources.FM011_Subtitel;
		VisualDiagnostics.RegisterSourceInfo(fM011_Subtitel, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 55);
		Label label4 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label4, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 14);
		string fM011_Deactiveren = CommonResources.FM011_Deactiveren;
		VisualDiagnostics.RegisterSourceInfo(fM011_Deactiveren, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 39);
		Label label5 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label5, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 14);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 17);
		string fM011_MijnDigiDLink = CommonResources.FM011_MijnDigiDLink;
		VisualDiagnostics.RegisterSourceInfo(fM011_MijnDigiDLink, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 38, 17);
		BorderedButton borderedButton2 = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton2, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 14);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		label4.transientNamescope = nameScope;
		label5.transientNamescope = nameScope;
		borderedButton2.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		verticalStackLayout.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		verticalStackLayout.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 10.0);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, verticalStackLayout, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(18, 20)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 20);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, fM011_Titel);
		verticalStackLayout.Children.Add(label);
		bindingExtension.StringFormat = fM011_Intro;
		bindingExtension.Path = "MaxAmount";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 20);
		}
		label2.SetBinding(Label.TextProperty, bindingBase);
		verticalStackLayout.Children.Add(label2);
		bindingExtension2.StringFormat = fM011_LangstNietGebruikt;
		bindingExtension2.Path = "DeviceName";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 20);
		}
		label3.SetBinding(Label.TextProperty, bindingBase2);
		verticalStackLayout.Children.Add(label3);
		borderedButton.SetValue(Element.AutomationIdProperty, "ConfirmButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension3.Path = "ConfirmCommand";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase3);
		borderedButton.SetValue(Button.TextProperty, fM011_Knop);
		verticalStackLayout.Children.Add(borderedButton);
		staticResourceExtension2.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[4] { label4, verticalStackLayout, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(30, 20)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 20);
		}
		label4.SetValue(VisualElement.StyleProperty, obj2);
		label4.SetValue(Label.TextProperty, fM011_Subtitel);
		verticalStackLayout.Children.Add(label4);
		label5.SetValue(View.MarginProperty, new Thickness(0.0, -10.0, 0.0, 0.0));
		label5.SetValue(Label.TextProperty, fM011_Deactiveren);
		verticalStackLayout.Children.Add(label5);
		borderedButton2.SetValue(Element.AutomationIdProperty, "CancelButton");
		borderedButton2.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension4.Path = "CancelCommand";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\FM011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 17);
		}
		borderedButton2.SetBinding(Button.CommandProperty, bindingBase4);
		borderedButton2.SetValue(Button.TextProperty, fM011_MijnDigiDLink);
		verticalStackLayout.Children.Add(borderedButton2);
		contentView.SetValue(ContentView.ContentProperty, verticalStackLayout);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<FM011ViewModel, int> setter = delegate(FM011ViewModel source, int value)
			{
				source.MaxAmount = value;
			};
			return new TypedBinding<FM011ViewModel, int>((FM011ViewModel source) => (value: source.MaxAmount, success: true), setter, new Tuple<Func<FM011ViewModel, object>, string>[1]
			{
				new Tuple<Func<FM011ViewModel, object>, string>((FM011ViewModel source) => source, "MaxAmount")
			})
			{
				StringFormat = extension.StringFormat
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<FM011ViewModel, string> setter = delegate(FM011ViewModel source, string? value)
			{
				source.DeviceName = value;
			};
			return new TypedBinding<FM011ViewModel, string>((FM011ViewModel source) => (value: source.DeviceName, success: true), setter, new Tuple<Func<FM011ViewModel, object>, string>[1]
			{
				new Tuple<Func<FM011ViewModel, object>, string>((FM011ViewModel source) => source, "DeviceName")
			})
			{
				StringFormat = extension.StringFormat
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<FM011ViewModel, ICommand> setter = null;
			return new TypedBinding<FM011ViewModel, ICommand>((FM011ViewModel source) => ((ICommand value, bool success))(value: source.ConfirmCommand, success: true), setter, new Tuple<Func<FM011ViewModel, object>, string>[1]
			{
				new Tuple<Func<FM011ViewModel, object>, string>((FM011ViewModel source) => source, "ConfirmCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<FM011ViewModel, ICommand> setter = null;
			return new TypedBinding<FM011ViewModel, ICommand>((FM011ViewModel source) => ((ICommand value, bool success))(value: source.CancelCommand, success: true), setter, new Tuple<Func<FM011ViewModel, object>, string>[1]
			{
				new Tuple<Func<FM011ViewModel, object>, string>((FM011ViewModel source) => source, "CancelCommand")
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
		this.LoadFromXaml(typeof(FM011));
	}
}
