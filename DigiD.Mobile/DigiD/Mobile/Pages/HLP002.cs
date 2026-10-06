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

[XamlFilePath("Pages\\HLP002.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class HLP002 : BasePage<Hlp002ViewModel>
{
	public HLP002()
		: base((Hlp002ViewModel?)null)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(HLP002).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(HLP002)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 11, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 15, 20);
		string hLP02_Titel = DigiDAppResources.HLP02_Titel;
		VisualDiagnostics.RegisterSourceInfo(hLP02_Titel, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 15, 57);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 15, 14);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 31);
		string hLP02_Telnummer = DigiDAppResources.HLP02_Telnummer;
		VisualDiagnostics.RegisterSourceInfo(hLP02_Telnummer, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 68);
		Span span = new Span();
		VisualDiagnostics.RegisterSourceInfo(span, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 26);
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension3, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 31);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 65);
		Span span2 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span2, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 26);
		StaticResourceExtension staticResourceExtension4 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension4, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 31);
		Span span3 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span3, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 26);
		FormattedString formattedString = new FormattedString();
		VisualDiagnostics.RegisterSourceInfo(formattedString, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 22);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 14);
		StaticResourceExtension staticResourceExtension5 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension5, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 17);
		string hLP02_Telnummer_ = DigiDAppResources.HLP02_Telnummer_1;
		VisualDiagnostics.RegisterSourceInfo(hLP02_Telnummer_, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 17);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 14);
		string hLP02_InfoNummerKlopt = DigiDAppResources.HLP02_InfoNummerKlopt;
		VisualDiagnostics.RegisterSourceInfo(hLP02_InfoNummerKlopt, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 20);
		Label label4 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label4, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 14);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 17);
		string hLP02_NieuweSms = DigiDAppResources.HLP02_NieuweSms;
		VisualDiagnostics.RegisterSourceInfo(hLP02_NieuweSms, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 14);
		StaticResourceExtension staticResourceExtension6 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension6, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 44, 17);
		string hLP02_SubtitelGesprokenSms = DigiDAppResources.HLP02_SubtitelGesprokenSms;
		VisualDiagnostics.RegisterSourceInfo(hLP02_SubtitelGesprokenSms, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 17);
		Label label5 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label5, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 42, 14);
		string hLP02_InfoGesprokenSms = DigiDAppResources.HLP02_InfoGesprokenSms;
		VisualDiagnostics.RegisterSourceInfo(hLP02_InfoGesprokenSms, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 20);
		Label label6 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label6, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 14);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 52, 17);
		string hLP02_GesprokenSms = DigiDAppResources.HLP02_GesprokenSms;
		VisualDiagnostics.RegisterSourceInfo(hLP02_GesprokenSms, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 55, 17);
		BorderedButton borderedButton2 = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton2, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 49, 14);
		bool canRequestLetter = Hlp002ViewModel.CanRequestLetter;
		VisualDiagnostics.RegisterSourceInfo(canRequestLetter, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 58, 52);
		StaticResourceExtension staticResourceExtension7 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension7, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 59, 24);
		string hLP02_Telnummer_2 = DigiDAppResources.HLP02_Telnummer_2;
		VisualDiagnostics.RegisterSourceInfo(hLP02_Telnummer_2, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 59, 59);
		Label label7 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label7, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 59, 18);
		string hLP02_InfoNummerKloptNiet = DigiDAppResources.HLP02_InfoNummerKloptNiet;
		VisualDiagnostics.RegisterSourceInfo(hLP02_InfoNummerKloptNiet, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 61, 24);
		Label label8 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label8, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 61, 18);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 63, 37);
		string hLP02_Link = DigiDAppResources.HLP02_Link;
		VisualDiagnostics.RegisterSourceInfo(hLP02_Link, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 63, 80);
		LinkLabel linkLabel = new LinkLabel();
		VisualDiagnostics.RegisterSourceInfo(linkLabel, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 63, 18);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 58, 14);
		VerticalStackLayout verticalStackLayout2 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout2, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 11, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 1, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		verticalStackLayout2.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		formattedString.transientNamescope = nameScope;
		span.transientNamescope = nameScope;
		span2.transientNamescope = nameScope;
		span3.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		label4.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		label5.transientNamescope = nameScope;
		label6.transientNamescope = nameScope;
		borderedButton2.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		label7.transientNamescope = nameScope;
		label8.transientNamescope = nameScope;
		linkLabel.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		verticalStackLayout2.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		verticalStackLayout2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, verticalStackLayout2, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(15, 20)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 15, 20);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, hLP02_Titel);
		verticalStackLayout2.Children.Add(label);
		staticResourceExtension2.Key = "SpanRegular";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[6] { span, formattedString, label2, verticalStackLayout2, contentView, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(20, 31)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 31);
		}
		span.SetValue(Span.StyleProperty, obj2);
		span.SetValue(Span.TextProperty, hLP02_Telnummer);
		formattedString.Spans.Add(span);
		staticResourceExtension3.Key = "SpanBold";
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[6] { span2, formattedString, label2, verticalStackLayout2, contentView, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(21, 31)));
		object obj3 = ((IMarkupExtension)staticResourceExtension3).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 31);
		}
		span2.SetValue(Span.StyleProperty, obj3);
		bindingExtension.Path = "PhoneNumber";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 65);
		}
		span2.SetBinding(Span.TextProperty, bindingBase);
		formattedString.Spans.Add(span2);
		staticResourceExtension4.Key = "SpanRegular";
		XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service4 = new SimpleValueTargetProvider(new object[6] { span3, formattedString, label2, verticalStackLayout2, contentView, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider4.Add(typeof(IReferenceProvider), service4);
		xamlServiceProvider4.Add(typeof(IProvideValueTarget), service4);
		xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(22, 31)));
		object obj4 = ((IMarkupExtension)staticResourceExtension4).ProvideValue((IServiceProvider)xamlServiceProvider4);
		if (VisualDiagnostics.GetSourceInfo(obj4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj4, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 31);
		}
		span3.SetValue(Span.StyleProperty, obj4);
		span3.SetValue(Span.TextProperty, ".");
		formattedString.Spans.Add(span3);
		label2.SetValue(Label.FormattedTextProperty, formattedString);
		verticalStackLayout2.Children.Add(label2);
		label3.SetValue(View.MarginProperty, new Thickness(0.0, 20.0, 0.0, 0.0));
		staticResourceExtension5.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider5 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service5 = new SimpleValueTargetProvider(new object[4] { label3, verticalStackLayout2, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider5.Add(typeof(IReferenceProvider), service5);
		xamlServiceProvider5.Add(typeof(IProvideValueTarget), service5);
		xamlServiceProvider5.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(29, 17)));
		object obj5 = ((IMarkupExtension)staticResourceExtension5).ProvideValue((IServiceProvider)xamlServiceProvider5);
		if (VisualDiagnostics.GetSourceInfo(obj5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj5, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 17);
		}
		label3.SetValue(VisualElement.StyleProperty, obj5);
		label3.SetValue(Label.TextProperty, hLP02_Telnummer_);
		verticalStackLayout2.Children.Add(label3);
		label4.SetValue(Label.TextProperty, hLP02_InfoNummerKlopt);
		verticalStackLayout2.Children.Add(label4);
		borderedButton.SetValue(Element.AutomationIdProperty, "ResendSMSFalseButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension2.Path = "ResendSMSCommand";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase2);
		borderedButton.SetValue(Button.CommandParameterProperty, "0");
		borderedButton.SetValue(Button.TextProperty, hLP02_NieuweSms);
		borderedButton.SetValue(View.VerticalOptionsProperty, LayoutOptions.End);
		verticalStackLayout2.Children.Add(borderedButton);
		label5.SetValue(View.MarginProperty, new Thickness(0.0, 20.0, 0.0, 0.0));
		staticResourceExtension6.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider6 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service6 = new SimpleValueTargetProvider(new object[4] { label5, verticalStackLayout2, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider6.Add(typeof(IReferenceProvider), service6);
		xamlServiceProvider6.Add(typeof(IProvideValueTarget), service6);
		xamlServiceProvider6.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(44, 17)));
		object obj6 = ((IMarkupExtension)staticResourceExtension6).ProvideValue((IServiceProvider)xamlServiceProvider6);
		if (VisualDiagnostics.GetSourceInfo(obj6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj6, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 44, 17);
		}
		label5.SetValue(VisualElement.StyleProperty, obj6);
		label5.SetValue(Label.TextProperty, hLP02_SubtitelGesprokenSms);
		verticalStackLayout2.Children.Add(label5);
		label6.SetValue(Label.TextProperty, hLP02_InfoGesprokenSms);
		verticalStackLayout2.Children.Add(label6);
		borderedButton2.SetValue(Element.AutomationIdProperty, "ResendSMSTrueButton");
		borderedButton2.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension3.Path = "ResendSMSCommand";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 52, 17);
		}
		borderedButton2.SetBinding(Button.CommandProperty, bindingBase3);
		borderedButton2.SetValue(Button.CommandParameterProperty, "1");
		borderedButton2.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Fill);
		borderedButton2.SetValue(Button.TextProperty, hLP02_GesprokenSms);
		borderedButton2.SetValue(View.VerticalOptionsProperty, LayoutOptions.End);
		verticalStackLayout2.Children.Add(borderedButton2);
		verticalStackLayout.SetValue(View.MarginProperty, new Thickness(0.0, 20.0, 0.0, 0.0));
		verticalStackLayout.SetValue(VisualElement.IsVisibleProperty, canRequestLetter);
		staticResourceExtension7.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider7 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service7 = new SimpleValueTargetProvider(new object[5] { label7, verticalStackLayout, verticalStackLayout2, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider7.Add(typeof(IReferenceProvider), service7);
		xamlServiceProvider7.Add(typeof(IProvideValueTarget), service7);
		xamlServiceProvider7.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(59, 24)));
		object obj7 = ((IMarkupExtension)staticResourceExtension7).ProvideValue((IServiceProvider)xamlServiceProvider7);
		if (VisualDiagnostics.GetSourceInfo(obj7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj7, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 59, 24);
		}
		label7.SetValue(VisualElement.StyleProperty, obj7);
		label7.SetValue(Label.TextProperty, hLP02_Telnummer_2);
		verticalStackLayout.Children.Add(label7);
		label8.SetValue(Label.TextProperty, hLP02_InfoNummerKloptNiet);
		verticalStackLayout.Children.Add(label8);
		bindingExtension4.Path = "OpenBottomSheetCommand";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\HLP002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 63, 37);
		}
		linkLabel.SetBinding(LinkLabel.CommandProperty, bindingBase4);
		linkLabel.SetValue(LinkLabel.TextProperty, hLP02_Link);
		verticalStackLayout.Children.Add(linkLabel);
		verticalStackLayout2.Children.Add(verticalStackLayout);
		contentView.SetValue(ContentView.ContentProperty, verticalStackLayout2);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<Hlp002ViewModel, string> setter = delegate(Hlp002ViewModel source, string? value)
			{
				source.PhoneNumber = value;
			};
			return new TypedBinding<Hlp002ViewModel, string>((Hlp002ViewModel source) => (value: source.PhoneNumber, success: true), setter, new Tuple<Func<Hlp002ViewModel, object>, string>[1]
			{
				new Tuple<Func<Hlp002ViewModel, object>, string>((Hlp002ViewModel source) => source, "PhoneNumber")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<Hlp002ViewModel, ICommand> setter = null;
			return new TypedBinding<Hlp002ViewModel, ICommand>((Hlp002ViewModel source) => ((ICommand value, bool success))(value: source.ResendSMSCommand, success: true), setter, new Tuple<Func<Hlp002ViewModel, object>, string>[1]
			{
				new Tuple<Func<Hlp002ViewModel, object>, string>((Hlp002ViewModel source) => source, "ResendSMSCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<Hlp002ViewModel, ICommand> setter = null;
			return new TypedBinding<Hlp002ViewModel, ICommand>((Hlp002ViewModel source) => ((ICommand value, bool success))(value: source.ResendSMSCommand, success: true), setter, new Tuple<Func<Hlp002ViewModel, object>, string>[1]
			{
				new Tuple<Func<Hlp002ViewModel, object>, string>((Hlp002ViewModel source) => source, "ResendSMSCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<Hlp002ViewModel, ICommand> setter = null;
			return new TypedBinding<Hlp002ViewModel, ICommand>((Hlp002ViewModel source) => ((ICommand value, bool success))(value: source.OpenBottomSheetCommand, success: true), setter, new Tuple<Func<Hlp002ViewModel, object>, string>[1]
			{
				new Tuple<Func<Hlp002ViewModel, object>, string>((Hlp002ViewModel source) => source, "OpenBottomSheetCommand")
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
		this.LoadFromXaml(typeof(HLP002));
	}
}
