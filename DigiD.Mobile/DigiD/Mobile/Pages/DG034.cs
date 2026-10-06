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

[XamlFilePath("Pages\\DG034.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG034 : BasePage<DG034ViewModel>
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private PinTilesCodeEntryView Entry;

	public DG034()
		: base((DG034ViewModel?)null)
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
				Entry.Focus();
			};
		}
	}

	protected override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);
		if (!((IApp)Application.Current).A11YService.IsInVoiceOverMode)
		{
			Entry.Focus();
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("Entry")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG034).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG034)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 20);
		string dG034_Titel = DigiDAppResources.DG034_Titel;
		VisualDiagnostics.RegisterSourceInfo(dG034_Titel, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 57);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 33);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 31);
		string dG034_Intro = DigiDAppResources.DG034_Intro;
		VisualDiagnostics.RegisterSourceInfo(dG034_Intro, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 68);
		Span span = new Span();
		VisualDiagnostics.RegisterSourceInfo(span, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 26);
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension3, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 31);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 65);
		Span span2 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span2, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 26);
		StaticResourceExtension staticResourceExtension4 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension4, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 31);
		string dG034_Intro_ = DigiDAppResources.DG034_Intro_1;
		VisualDiagnostics.RegisterSourceInfo(dG034_Intro_, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 68);
		Span span3 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span3, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 26);
		FormattedString formattedString = new FormattedString();
		VisualDiagnostics.RegisterSourceInfo(formattedString, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 22);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 14);
		OnIdiomExtension onIdiomExtension = new OnIdiomExtension();
		VisualDiagnostics.RegisterSourceInfo(onIdiomExtension, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 17);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 17);
		OnIdiomExtension onIdiomExtension2 = new OnIdiomExtension();
		VisualDiagnostics.RegisterSourceInfo(onIdiomExtension2, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 17);
		string initialChar = DG034ViewModel.InitialChar;
		VisualDiagnostics.RegisterSourceInfo(initialChar, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 17);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 38, 17);
		PinTilesCodeEntryView pinTilesCodeEntryView = new PinTilesCodeEntryView();
		VisualDiagnostics.RegisterSourceInfo(pinTilesCodeEntryView, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 14);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 44, 17);
		BindingExtension bindingExtension6 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 48, 21);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 18);
		BindingExtension bindingExtension7 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension7, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 52, 40);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 52, 18);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 14);
		BindingExtension bindingExtension8 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension8, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 58, 17);
		string dG034_Helplink = DigiDAppResources.DG034_Helplink;
		VisualDiagnostics.RegisterSourceInfo(dG034_Helplink, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 59, 17);
		LinkLabel linkLabel = new LinkLabel();
		VisualDiagnostics.RegisterSourceInfo(linkLabel, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 55, 14);
		BindingExtension bindingExtension9 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension9, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 65, 17);
		BindingExtension bindingExtension10 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension10, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 66, 17);
		string alg_Next = CommonResources.Alg_Next;
		VisualDiagnostics.RegisterSourceInfo(alg_Next, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 67, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 61, 14);
		Grid grid2 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid2, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid2.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		formattedString.transientNamescope = nameScope;
		span.transientNamescope = nameScope;
		span2.transientNamescope = nameScope;
		span3.transientNamescope = nameScope;
		pinTilesCodeEntryView.transientNamescope = nameScope;
		nameScope.RegisterName("Entry", pinTilesCodeEntryView);
		PinTilesCodeEntryView pinTilesCodeEntryView2 = pinTilesCodeEntryView;
		if (pinTilesCodeEntryView2.StyleId == null)
		{
			string text = (pinTilesCodeEntryView2.StyleId = "Entry");
		}
		grid.transientNamescope = nameScope;
		image.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		linkLabel.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		Entry = pinTilesCodeEntryView;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid2.SetValue(View.MarginProperty, new Thickness(20.0));
		grid2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid2.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star)));
		grid2.SetValue(Grid.RowSpacingProperty, 20.0);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, grid2, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(18, 20)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 20);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, dG034_Titel);
		grid2.Children.Add(label);
		label2.SetValue(Grid.RowProperty, 1);
		bindingExtension.Path = "MessageText";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 33);
		}
		label2.SetBinding(Label.TextProperty, bindingBase);
		staticResourceExtension2.Key = "SpanRegular";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[6] { span, formattedString, label2, grid2, contentView, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(23, 31)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 31);
		}
		span.SetValue(Span.StyleProperty, obj2);
		span.SetValue(Span.TextProperty, dG034_Intro);
		formattedString.Spans.Add(span);
		staticResourceExtension3.Key = "SpanBold";
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[6] { span2, formattedString, label2, grid2, contentView, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(24, 31)));
		object obj3 = ((IMarkupExtension)staticResourceExtension3).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 31);
		}
		span2.SetValue(Span.StyleProperty, obj3);
		bindingExtension2.Path = "MessageText";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 65);
		}
		span2.SetBinding(Span.TextProperty, bindingBase2);
		formattedString.Spans.Add(span2);
		staticResourceExtension4.Key = "SpanRegular";
		XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service4 = new SimpleValueTargetProvider(new object[6] { span3, formattedString, label2, grid2, contentView, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider4.Add(typeof(IReferenceProvider), service4);
		xamlServiceProvider4.Add(typeof(IProvideValueTarget), service4);
		xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(25, 31)));
		object obj4 = ((IMarkupExtension)staticResourceExtension4).ProvideValue((IServiceProvider)xamlServiceProvider4);
		if (VisualDiagnostics.GetSourceInfo(obj4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj4, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 31);
		}
		span3.SetValue(Span.StyleProperty, obj4);
		span3.SetValue(Span.TextProperty, dG034_Intro_);
		formattedString.Spans.Add(span3);
		label2.SetValue(Label.FormattedTextProperty, formattedString);
		grid2.Children.Add(label2);
		pinTilesCodeEntryView.SetValue(Grid.RowProperty, 2);
		pinTilesCodeEntryView.SetValue(Element.AutomationIdProperty, "EmailCodeEntry");
		pinTilesCodeEntryView.SetValue(PinTilesCodeEntryView.CodeTypeProperty, CodeType.Email);
		pinTilesCodeEntryView.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
		onIdiomExtension.Desktop = "Go";
		XamlServiceProvider xamlServiceProvider5 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service5 = new SimpleValueTargetProvider(new object[4] { pinTilesCodeEntryView, grid2, contentView, this }, PinTilesCodeEntryView.ReturnTypeProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider5.Add(typeof(IReferenceProvider), service5);
		xamlServiceProvider5.Add(typeof(IProvideValueTarget), service5);
		xamlServiceProvider5.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(35, 17)));
		object obj5 = ((IMarkupExtension)onIdiomExtension).ProvideValue((IServiceProvider)xamlServiceProvider5);
		if (VisualDiagnostics.GetSourceInfo(obj5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj5, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 17);
		}
		pinTilesCodeEntryView.SetValue(PinTilesCodeEntryView.ReturnTypeProperty, obj5);
		bindingExtension3.Path = "ValidateCodeCommand";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 17);
		}
		onIdiomExtension2.Desktop = bindingBase3;
		XamlServiceProvider xamlServiceProvider6 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service6 = new SimpleValueTargetProvider(new object[4] { pinTilesCodeEntryView, grid2, contentView, this }, PinTilesCodeEntryView.ReturnCommandProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider6.Add(typeof(IReferenceProvider), service6);
		xamlServiceProvider6.Add(typeof(IProvideValueTarget), service6);
		xamlServiceProvider6.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(36, 17)));
		object obj6 = ((IMarkupExtension)onIdiomExtension2).ProvideValue((IServiceProvider)xamlServiceProvider6);
		if (VisualDiagnostics.GetSourceInfo(obj6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj6, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 17);
		}
		pinTilesCodeEntryView.SetValue(PinTilesCodeEntryView.ReturnCommandProperty, obj6);
		pinTilesCodeEntryView.SetValue(PinTilesCodeEntryView.InitialCharProperty, initialChar);
		bindingExtension4.Path = "Code";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 38, 17);
		}
		pinTilesCodeEntryView.SetBinding(PinTilesCodeEntryView.TextProperty, bindingBase4);
		grid2.Children.Add(pinTilesCodeEntryView);
		grid.SetValue(Grid.RowProperty, 3);
		grid.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(new GridLength(20.0, GridUnitType.Absolute)), new ColumnDefinition(GridLength.Star)));
		grid.SetValue(Grid.ColumnSpacingProperty, 5.0);
		bindingExtension5.Path = "IsError";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension5(bindingExtension5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 44, 17);
		}
		grid.SetBinding(VisualElement.IsVisibleProperty, bindingBase5);
		image.SetValue(Grid.ColumnProperty, 0);
		image.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		bindingExtension6.Path = "IsError";
		BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension6(bindingExtension6);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 48, 21);
		}
		image.SetBinding(VisualElement.IsVisibleProperty, bindingBase6);
		image.SetValue(Image.SourceProperty, ImageSource.FromFile("icon_foutmelding_kritiek.png"));
		image.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
		grid.Children.Add(image);
		label3.SetValue(Grid.ColumnProperty, 1);
		bindingExtension7.Path = "ErrorMessage";
		BindingBase bindingBase7 = CreateTypedBindingFrom_bindingExtension7(bindingExtension7);
		if (VisualDiagnostics.GetSourceInfo(bindingBase7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase7, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 52, 40);
		}
		label3.SetBinding(Label.TextProperty, bindingBase7);
		grid.Children.Add(label3);
		grid2.Children.Add(grid);
		linkLabel.SetValue(Grid.RowProperty, 4);
		linkLabel.SetValue(Element.AutomationIdProperty, "NoMailReceivedLink");
		bindingExtension8.Path = "NoMailReceivedCommand";
		BindingBase bindingBase8 = CreateTypedBindingFrom_bindingExtension8(bindingExtension8);
		if (VisualDiagnostics.GetSourceInfo(bindingBase8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase8, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 58, 17);
		}
		linkLabel.SetBinding(LinkLabel.CommandProperty, bindingBase8);
		linkLabel.SetValue(LinkLabel.TextProperty, dG034_Helplink);
		grid2.Children.Add(linkLabel);
		borderedButton.SetValue(Grid.RowProperty, 5);
		borderedButton.SetValue(Element.AutomationIdProperty, "NextButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension9.Path = "ValidateCodeCommand";
		BindingBase bindingBase9 = CreateTypedBindingFrom_bindingExtension9(bindingExtension9);
		if (VisualDiagnostics.GetSourceInfo(bindingBase9) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase9, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 65, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase9);
		bindingExtension10.Path = "IsValid";
		BindingBase bindingBase10 = CreateTypedBindingFrom_bindingExtension10(bindingExtension10);
		if (VisualDiagnostics.GetSourceInfo(bindingBase10) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase10, new Uri("Pages\\DG034.xaml;assembly=DigiD.Mobile", UriKind.Relative), 66, 17);
		}
		borderedButton.SetBinding(VisualElement.IsEnabledProperty, bindingBase10);
		borderedButton.SetValue(Button.TextProperty, alg_Next);
		borderedButton.SetValue(View.VerticalOptionsProperty, LayoutOptions.End);
		grid2.Children.Add(borderedButton);
		contentView.SetValue(ContentView.ContentProperty, grid2);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG034ViewModel, string> setter = delegate(DG034ViewModel source, string? value)
			{
				source.MessageText = value;
			};
			return new TypedBinding<DG034ViewModel, string>((DG034ViewModel source) => (value: source.MessageText, success: true), setter, new Tuple<Func<DG034ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG034ViewModel, object>, string>((DG034ViewModel source) => source, "MessageText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension10(BindingExtension extension)
		{
			Action<DG034ViewModel, bool> setter = null;
			return new TypedBinding<DG034ViewModel, bool>((DG034ViewModel source) => (value: source.IsValid, success: true), setter, new Tuple<Func<DG034ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG034ViewModel, object>, string>((DG034ViewModel source) => source, "IsValid")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG034ViewModel, string> setter = delegate(DG034ViewModel source, string? value)
			{
				source.MessageText = value;
			};
			return new TypedBinding<DG034ViewModel, string>((DG034ViewModel source) => (value: source.MessageText, success: true), setter, new Tuple<Func<DG034ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG034ViewModel, object>, string>((DG034ViewModel source) => source, "MessageText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG034ViewModel, ICommand> setter = null;
			return new TypedBinding<DG034ViewModel, ICommand>((DG034ViewModel source) => ((ICommand value, bool success))(value: source.ValidateCodeCommand, success: true), setter, new Tuple<Func<DG034ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG034ViewModel, object>, string>((DG034ViewModel source) => source, "ValidateCodeCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DG034ViewModel, string> setter = delegate(DG034ViewModel source, string? value)
			{
				source.Code = value;
			};
			return new TypedBinding<DG034ViewModel, string>((DG034ViewModel source) => (value: source.Code, success: true), setter, new Tuple<Func<DG034ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG034ViewModel, object>, string>((DG034ViewModel source) => source, "Code")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<DG034ViewModel, bool> setter = delegate(DG034ViewModel source, bool value)
			{
				source.IsError = value;
			};
			return new TypedBinding<DG034ViewModel, bool>((DG034ViewModel source) => (value: source.IsError, success: true), setter, new Tuple<Func<DG034ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG034ViewModel, object>, string>((DG034ViewModel source) => source, "IsError")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension6(BindingExtension extension)
		{
			Action<DG034ViewModel, bool> setter = delegate(DG034ViewModel source, bool value)
			{
				source.IsError = value;
			};
			return new TypedBinding<DG034ViewModel, bool>((DG034ViewModel source) => (value: source.IsError, success: true), setter, new Tuple<Func<DG034ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG034ViewModel, object>, string>((DG034ViewModel source) => source, "IsError")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension7(BindingExtension extension)
		{
			Action<DG034ViewModel, string> setter = delegate(DG034ViewModel source, string? value)
			{
				source.ErrorMessage = value;
			};
			return new TypedBinding<DG034ViewModel, string>((DG034ViewModel source) => (value: source.ErrorMessage, success: true), setter, new Tuple<Func<DG034ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG034ViewModel, object>, string>((DG034ViewModel source) => source, "ErrorMessage")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension8(BindingExtension extension)
		{
			Action<DG034ViewModel, ICommand> setter = null;
			return new TypedBinding<DG034ViewModel, ICommand>((DG034ViewModel source) => ((ICommand value, bool success))(value: source.NoMailReceivedCommand, success: true), setter, new Tuple<Func<DG034ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG034ViewModel, object>, string>((DG034ViewModel source) => source, "NoMailReceivedCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension9(BindingExtension extension)
		{
			Action<DG034ViewModel, ICommand> setter = null;
			return new TypedBinding<DG034ViewModel, ICommand>((DG034ViewModel source) => ((ICommand value, bool success))(value: source.ValidateCodeCommand, success: true), setter, new Tuple<Func<DG034ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG034ViewModel, object>, string>((DG034ViewModel source) => source, "ValidateCodeCommand")
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
	[MemberNotNull("Entry")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(DG034));
		Entry = this.FindByName<PinTilesCodeEntryView>("Entry");
	}
}
