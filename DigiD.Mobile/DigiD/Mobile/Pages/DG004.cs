using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Windows.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
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

[XamlFilePath("Pages\\DG004.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG004 : BasePage<DG004ViewModel>
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private PinTilesCodeEntryView SmsEntry;

	public DG004()
		: base((DG004ViewModel?)null)
	{
		InitializeComponent();
	}

	protected override void OnBindingContextChanged()
	{
		base.OnBindingContextChanged();
		if (base.BindingContext != null)
		{
			base.BindingContext.ChangeFocus += delegate
			{
				SmsEntry.Focus();
			};
		}
	}

	protected override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);
		if (!((IApp)Application.Current).A11YService.IsInVoiceOverMode)
		{
			SmsEntry.Focus();
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("SmsEntry")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG004).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG004)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 17);
		string dG004_Titel = DigiDAppResources.DG004_Titel;
		VisualDiagnostics.RegisterSourceInfo(dG004_Titel, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 17);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 17);
		CustomErrorLabel customErrorLabel = new CustomErrorLabel();
		VisualDiagnostics.RegisterSourceInfo(customErrorLabel, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 14);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 17);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 17);
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension3, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 31);
		string dG004_Intro = DigiDAppResources.DG004_Intro;
		VisualDiagnostics.RegisterSourceInfo(dG004_Intro, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 68);
		Span span = new Span();
		VisualDiagnostics.RegisterSourceInfo(span, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 26);
		StaticResourceExtension staticResourceExtension4 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension4, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 31);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 65);
		Span span2 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span2, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 26);
		StaticResourceExtension staticResourceExtension5 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension5, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 31);
		Span span3 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span3, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 26);
		FormattedString formattedString = new FormattedString();
		VisualDiagnostics.RegisterSourceInfo(formattedString, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 22);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 14);
		OnIdiomExtension onIdiomExtension = new OnIdiomExtension();
		VisualDiagnostics.RegisterSourceInfo(onIdiomExtension, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 17);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 48, 17);
		OnIdiomExtension onIdiomExtension2 = new OnIdiomExtension();
		VisualDiagnostics.RegisterSourceInfo(onIdiomExtension2, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 48, 17);
		BindingExtension bindingExtension6 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 49, 17);
		PinTilesCodeEntryView pinTilesCodeEntryView = new PinTilesCodeEntryView();
		VisualDiagnostics.RegisterSourceInfo(pinTilesCodeEntryView, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 42, 14);
		BindingExtension bindingExtension7 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension7, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 56, 17);
		string dG004_NoSMSReceived_Button = DigiDAppResources.DG004_NoSMSReceived_Button;
		VisualDiagnostics.RegisterSourceInfo(dG004_NoSMSReceived_Button, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 57, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 51, 14);
		BindingExtension bindingExtension8 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension8, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 63, 17);
		BindingExtension bindingExtension9 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension9, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 64, 17);
		string alg_Next = CommonResources.Alg_Next;
		VisualDiagnostics.RegisterSourceInfo(alg_Next, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 65, 17);
		BorderedButton borderedButton2 = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton2, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 59, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		customErrorLabel.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		formattedString.transientNamescope = nameScope;
		span.transientNamescope = nameScope;
		span2.transientNamescope = nameScope;
		span3.transientNamescope = nameScope;
		pinTilesCodeEntryView.transientNamescope = nameScope;
		nameScope.RegisterName("SmsEntry", pinTilesCodeEntryView);
		PinTilesCodeEntryView pinTilesCodeEntryView2 = pinTilesCodeEntryView;
		if (pinTilesCodeEntryView2.StyleId == null)
		{
			string text = (pinTilesCodeEntryView2.StyleId = "SmsEntry");
		}
		borderedButton.transientNamescope = nameScope;
		borderedButton2.transientNamescope = nameScope;
		SmsEntry = pinTilesCodeEntryView;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star)));
		grid.SetValue(Grid.RowSpacingProperty, 20.0);
		label.SetValue(Grid.RowProperty, 0);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, grid, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(20, 17)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, dG004_Titel);
		grid.Children.Add(label);
		customErrorLabel.SetValue(Grid.RowProperty, 1);
		bindingExtension.Path = "ErrorMessage";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 17);
		}
		customErrorLabel.SetBinding(CustomErrorLabel.ErrorTextProperty, bindingBase);
		bindingExtension2.Path = "IsError";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 17);
		}
		customErrorLabel.SetBinding(VisualElement.IsVisibleProperty, bindingBase2);
		grid.Children.Add(customErrorLabel);
		label2.SetValue(Grid.RowProperty, 1);
		label2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
		staticResourceExtension2.Key = "BooleanInvertConverter";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[5] { bindingExtension3, label2, grid, contentView, this }, typeof(BindingExtension).GetProperty("Converter"), new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(31, 17)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 17);
		}
		bindingExtension3.Converter = (IValueConverter)obj2;
		bindingExtension3.Path = "IsError";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 17);
		}
		label2.SetBinding(VisualElement.IsVisibleProperty, bindingBase3);
		label2.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Start);
		staticResourceExtension3.Key = "SpanRegular";
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[6] { span, formattedString, label2, grid, contentView, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(35, 31)));
		object obj3 = ((IMarkupExtension)staticResourceExtension3).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 31);
		}
		span.SetValue(Span.StyleProperty, obj3);
		span.SetValue(Span.TextProperty, dG004_Intro);
		formattedString.Spans.Add(span);
		staticResourceExtension4.Key = "SpanBold";
		XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service4 = new SimpleValueTargetProvider(new object[6] { span2, formattedString, label2, grid, contentView, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider4.Add(typeof(IReferenceProvider), service4);
		xamlServiceProvider4.Add(typeof(IProvideValueTarget), service4);
		xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(36, 31)));
		object obj4 = ((IMarkupExtension)staticResourceExtension4).ProvideValue((IServiceProvider)xamlServiceProvider4);
		if (VisualDiagnostics.GetSourceInfo(obj4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj4, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 31);
		}
		span2.SetValue(Span.StyleProperty, obj4);
		bindingExtension4.Path = "PhoneNumber";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 65);
		}
		span2.SetBinding(Span.TextProperty, bindingBase4);
		formattedString.Spans.Add(span2);
		staticResourceExtension5.Key = "SpanRegular";
		XamlServiceProvider xamlServiceProvider5 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service5 = new SimpleValueTargetProvider(new object[6] { span3, formattedString, label2, grid, contentView, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider5.Add(typeof(IReferenceProvider), service5);
		xamlServiceProvider5.Add(typeof(IProvideValueTarget), service5);
		xamlServiceProvider5.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(37, 31)));
		object obj5 = ((IMarkupExtension)staticResourceExtension5).ProvideValue((IServiceProvider)xamlServiceProvider5);
		if (VisualDiagnostics.GetSourceInfo(obj5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj5, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 31);
		}
		span3.SetValue(Span.StyleProperty, obj5);
		span3.SetValue(Span.TextProperty, ".");
		formattedString.Spans.Add(span3);
		label2.SetValue(Label.FormattedTextProperty, formattedString);
		grid.Children.Add(label2);
		pinTilesCodeEntryView.SetValue(Grid.RowProperty, 2);
		pinTilesCodeEntryView.SetValue(Element.AutomationIdProperty, "SmsCodeEntry");
		pinTilesCodeEntryView.SetValue(PinTilesCodeEntryView.CodeTypeProperty, CodeType.SMS);
		onIdiomExtension.Default = "Done";
		onIdiomExtension.Desktop = "Go";
		XamlServiceProvider xamlServiceProvider6 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service6 = new SimpleValueTargetProvider(new object[4] { pinTilesCodeEntryView, grid, contentView, this }, PinTilesCodeEntryView.ReturnTypeProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider6.Add(typeof(IReferenceProvider), service6);
		xamlServiceProvider6.Add(typeof(IProvideValueTarget), service6);
		xamlServiceProvider6.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(47, 17)));
		object obj6 = ((IMarkupExtension)onIdiomExtension).ProvideValue((IServiceProvider)xamlServiceProvider6);
		if (VisualDiagnostics.GetSourceInfo(obj6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj6, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 17);
		}
		pinTilesCodeEntryView.SetValue(PinTilesCodeEntryView.ReturnTypeProperty, obj6);
		bindingExtension5.Path = "ValidateCodeCommand";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension5(bindingExtension5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 48, 17);
		}
		onIdiomExtension2.Desktop = bindingBase5;
		XamlServiceProvider xamlServiceProvider7 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service7 = new SimpleValueTargetProvider(new object[4] { pinTilesCodeEntryView, grid, contentView, this }, PinTilesCodeEntryView.ReturnCommandProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider7.Add(typeof(IReferenceProvider), service7);
		xamlServiceProvider7.Add(typeof(IProvideValueTarget), service7);
		xamlServiceProvider7.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(48, 17)));
		object obj7 = ((IMarkupExtension)onIdiomExtension2).ProvideValue((IServiceProvider)xamlServiceProvider7);
		if (VisualDiagnostics.GetSourceInfo(obj7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj7, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 48, 17);
		}
		pinTilesCodeEntryView.SetValue(PinTilesCodeEntryView.ReturnCommandProperty, obj7);
		bindingExtension6.Path = "SmsCode";
		BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension6(bindingExtension6);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 49, 17);
		}
		pinTilesCodeEntryView.SetBinding(PinTilesCodeEntryView.TextProperty, bindingBase6);
		grid.Children.Add(pinTilesCodeEntryView);
		borderedButton.SetValue(Grid.RowProperty, 3);
		borderedButton.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 0.0, -5.0));
		borderedButton.SetValue(Element.AutomationIdProperty, "NoSmsReceivedButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension7.Path = "NoSmsReceivedCommand";
		BindingBase bindingBase7 = CreateTypedBindingFrom_bindingExtension7(bindingExtension7);
		if (VisualDiagnostics.GetSourceInfo(bindingBase7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase7, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 56, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase7);
		borderedButton.SetValue(Button.TextProperty, dG004_NoSMSReceived_Button);
		grid.Children.Add(borderedButton);
		borderedButton2.SetValue(Grid.RowProperty, 4);
		borderedButton2.SetValue(Element.AutomationIdProperty, "NextButton");
		borderedButton2.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension8.Path = "ValidateCodeCommand";
		BindingBase bindingBase8 = CreateTypedBindingFrom_bindingExtension8(bindingExtension8);
		if (VisualDiagnostics.GetSourceInfo(bindingBase8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase8, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 63, 17);
		}
		borderedButton2.SetBinding(Button.CommandProperty, bindingBase8);
		bindingExtension9.Path = "IsValid";
		BindingBase bindingBase9 = CreateTypedBindingFrom_bindingExtension9(bindingExtension9);
		if (VisualDiagnostics.GetSourceInfo(bindingBase9) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase9, new Uri("Pages\\DG004.xaml;assembly=DigiD.Mobile", UriKind.Relative), 64, 17);
		}
		borderedButton2.SetBinding(VisualElement.IsEnabledProperty, bindingBase9);
		borderedButton2.SetValue(Button.TextProperty, alg_Next);
		borderedButton2.SetValue(View.VerticalOptionsProperty, LayoutOptions.End);
		grid.Children.Add(borderedButton2);
		contentView.SetValue(ContentView.ContentProperty, grid);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG004ViewModel, string> setter = delegate(DG004ViewModel source, string? value)
			{
				source.ErrorMessage = value;
			};
			return new TypedBinding<DG004ViewModel, string>((DG004ViewModel source) => (value: source.ErrorMessage, success: true), setter, new Tuple<Func<DG004ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG004ViewModel, object>, string>((DG004ViewModel source) => source, "ErrorMessage")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG004ViewModel, bool> setter = delegate(DG004ViewModel source, bool value)
			{
				source.IsError = value;
			};
			return new TypedBinding<DG004ViewModel, bool>((DG004ViewModel source) => (value: source.IsError, success: true), setter, new Tuple<Func<DG004ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG004ViewModel, object>, string>((DG004ViewModel source) => source, "IsError")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG004ViewModel, bool> setter = delegate(DG004ViewModel source, bool value)
			{
				source.IsError = value;
			};
			return new TypedBinding<DG004ViewModel, bool>((DG004ViewModel source) => (value: source.IsError, success: true), setter, new Tuple<Func<DG004ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG004ViewModel, object>, string>((DG004ViewModel source) => source, "IsError")
			})
			{
				Converter = extension.Converter
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DG004ViewModel, string> setter = delegate(DG004ViewModel source, string? value)
			{
				source.PhoneNumber = value;
			};
			return new TypedBinding<DG004ViewModel, string>((DG004ViewModel source) => (value: source.PhoneNumber, success: true), setter, new Tuple<Func<DG004ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG004ViewModel, object>, string>((DG004ViewModel source) => source, "PhoneNumber")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<DG004ViewModel, ICommand> setter = null;
			return new TypedBinding<DG004ViewModel, ICommand>((DG004ViewModel source) => ((ICommand value, bool success))(value: source.ValidateCodeCommand, success: true), setter, new Tuple<Func<DG004ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG004ViewModel, object>, string>((DG004ViewModel source) => source, "ValidateCodeCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension6(BindingExtension extension)
		{
			Action<DG004ViewModel, string> setter = delegate(DG004ViewModel source, string? value)
			{
				source.SmsCode = value;
			};
			return new TypedBinding<DG004ViewModel, string>((DG004ViewModel source) => (value: source.SmsCode, success: true), setter, new Tuple<Func<DG004ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG004ViewModel, object>, string>((DG004ViewModel source) => source, "SmsCode")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension7(BindingExtension extension)
		{
			Action<DG004ViewModel, ICommand> setter = null;
			return new TypedBinding<DG004ViewModel, ICommand>((DG004ViewModel source) => ((ICommand value, bool success))(value: source.NoSmsReceivedCommand, success: true), setter, new Tuple<Func<DG004ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG004ViewModel, object>, string>((DG004ViewModel source) => source, "NoSmsReceivedCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension8(BindingExtension extension)
		{
			Action<DG004ViewModel, ICommand> setter = null;
			return new TypedBinding<DG004ViewModel, ICommand>((DG004ViewModel source) => ((ICommand value, bool success))(value: source.ValidateCodeCommand, success: true), setter, new Tuple<Func<DG004ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG004ViewModel, object>, string>((DG004ViewModel source) => source, "ValidateCodeCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension9(BindingExtension extension)
		{
			Action<DG004ViewModel, bool> setter = null;
			return new TypedBinding<DG004ViewModel, bool>((DG004ViewModel source) => (value: source.IsValid, success: true), setter, new Tuple<Func<DG004ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG004ViewModel, object>, string>((DG004ViewModel source) => source, "IsValid")
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
	[MemberNotNull("SmsEntry")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(DG004));
		SmsEntry = this.FindByName<PinTilesCodeEntryView>("SmsEntry");
	}
}
