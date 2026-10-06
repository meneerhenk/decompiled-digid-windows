using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Windows.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Enums;
using DigiD.Common.NFC.Enums;
using DigiD.Common.RDA.ViewModels;
using DigiD.Common.Resources;
using LocalizationResourceManager.Maui;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using WinRT;
using WinRT.DigiD_Common_RDAVtableClasses;

namespace DigiD.Common.RDA.Pages;

[XamlFilePath("Pages\\DG078.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Common_RDA_ViewModels_DG078ViewModelWinRTTypeDetails))]
public class DG078 : BasePage<DG078ViewModel>
{
	public DG078()
		: base((DG078ViewModel?)null)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG078).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG078)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 15, 18);
		DynamicResource dynamicResource = new DynamicResource("LabelHeader");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 22, 17);
		TranslateExtension translateExtension = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 23, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 20, 14);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 28, 31);
		string dG078_Text_Part = CommonResources.DG078_Text_Part1;
		VisualDiagnostics.RegisterSourceInfo(dG078_Text_Part, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 28, 68);
		Span span = new Span();
		VisualDiagnostics.RegisterSourceInfo(span, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 28, 26);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 29, 31);
		string dG078_Text_Part2 = CommonResources.DG078_Text_Part2;
		VisualDiagnostics.RegisterSourceInfo(dG078_Text_Part2, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 29, 65);
		Span span2 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span2, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 29, 26);
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension3, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 30, 31);
		string dG078_Text_Part3 = CommonResources.DG078_Text_Part3;
		VisualDiagnostics.RegisterSourceInfo(dG078_Text_Part3, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 30, 68);
		Span span3 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span3, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 30, 26);
		FormattedString formattedString = new FormattedString();
		VisualDiagnostics.RegisterSourceInfo(formattedString, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 27, 22);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 25, 14);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 36, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 42, 17);
		DocumentType documentType = DocumentType.DrivingLicense;
		VisualDiagnostics.RegisterSourceInfo(documentType, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 43, 17);
		TranslateExtension translateExtension2 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension2, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 44, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 38, 14);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 50, 17);
		DocumentType documentType2 = DocumentType.IDCard;
		VisualDiagnostics.RegisterSourceInfo(documentType2, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 51, 17);
		TranslateExtension translateExtension3 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension3, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 52, 17);
		BorderedButton borderedButton2 = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton2, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 46, 14);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 58, 17);
		DocumentType documentType3 = DocumentType.Passport;
		VisualDiagnostics.RegisterSourceInfo(documentType3, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 59, 17);
		TranslateExtension translateExtension4 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension4, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 60, 17);
		BorderedButton borderedButton3 = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton3, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 54, 14);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 64, 17);
		string dG078_OtherDocument = CommonResources.DG078_OtherDocument;
		VisualDiagnostics.RegisterSourceInfo(dG078_OtherDocument, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 67, 17);
		LinkLabel linkLabel = new LinkLabel();
		VisualDiagnostics.RegisterSourceInfo(linkLabel, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 62, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 16, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 15, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		formattedString.transientNamescope = nameScope;
		span.transientNamescope = nameScope;
		span2.transientNamescope = nameScope;
		span3.transientNamescope = nameScope;
		image.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		borderedButton2.transientNamescope = nameScope;
		borderedButton3.transientNamescope = nameScope;
		linkLabel.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto)));
		grid.SetValue(Grid.RowSpacingProperty, 20.0);
		label.SetValue(Grid.RowProperty, 0);
		((IDynamicResourceHandler)label).SetDynamicResource(VisualElement.StyleProperty, dynamicResource.Key);
		translateExtension.Text = "DG078_Title";
		BindingBase bindingBase = ((IMarkupExtension<BindingBase>)translateExtension).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 23, 17);
		}
		label.SetBinding(Label.TextProperty, bindingBase);
		grid.Children.Add(label);
		label2.SetValue(Grid.RowProperty, 1);
		staticResourceExtension.Key = "SpanRegular";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[6] { span, formattedString, label2, grid, contentView, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(28, 31)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 28, 31);
		}
		span.SetValue(Span.StyleProperty, obj);
		span.SetValue(Span.TextProperty, dG078_Text_Part);
		formattedString.Spans.Add(span);
		staticResourceExtension2.Key = "SpanBold";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[6] { span2, formattedString, label2, grid, contentView, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(29, 31)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 29, 31);
		}
		span2.SetValue(Span.StyleProperty, obj2);
		span2.SetValue(Span.TextProperty, dG078_Text_Part2);
		formattedString.Spans.Add(span2);
		staticResourceExtension3.Key = "SpanRegular";
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[6] { span3, formattedString, label2, grid, contentView, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(30, 31)));
		object obj3 = ((IMarkupExtension)staticResourceExtension3).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 30, 31);
		}
		span3.SetValue(Span.StyleProperty, obj3);
		span3.SetValue(Span.TextProperty, dG078_Text_Part3);
		formattedString.Spans.Add(span3);
		label2.SetValue(Label.FormattedTextProperty, formattedString);
		grid.Children.Add(label2);
		image.SetValue(Grid.RowProperty, 2);
		image.SetValue(Image.SourceProperty, ImageSource.FromFile("afbeelding_document_controle.png"));
		grid.Children.Add(image);
		borderedButton.SetValue(Grid.RowProperty, 3);
		borderedButton.SetValue(Element.AutomationIdProperty, "btnDrivingLicense");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension.Path = "NextCommand";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 42, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase2);
		borderedButton.SetValue(Button.CommandParameterProperty, documentType);
		translateExtension2.Text = "DrivingLicense";
		BindingBase bindingBase3 = ((IMarkupExtension<BindingBase>)translateExtension2).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 44, 17);
		}
		borderedButton.SetBinding(Button.TextProperty, bindingBase3);
		grid.Children.Add(borderedButton);
		borderedButton2.SetValue(Grid.RowProperty, 4);
		borderedButton2.SetValue(Element.AutomationIdProperty, "btnIDCard");
		borderedButton2.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension2.Path = "NextCommand";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 50, 17);
		}
		borderedButton2.SetBinding(Button.CommandProperty, bindingBase4);
		borderedButton2.SetValue(Button.CommandParameterProperty, documentType2);
		translateExtension3.Text = "IDCard";
		BindingBase bindingBase5 = ((IMarkupExtension<BindingBase>)translateExtension3).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 52, 17);
		}
		borderedButton2.SetBinding(Button.TextProperty, bindingBase5);
		grid.Children.Add(borderedButton2);
		borderedButton3.SetValue(Grid.RowProperty, 5);
		borderedButton3.SetValue(Element.AutomationIdProperty, "btnPassport");
		borderedButton3.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension3.Path = "NextCommand";
		BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 58, 17);
		}
		borderedButton3.SetBinding(Button.CommandProperty, bindingBase6);
		borderedButton3.SetValue(Button.CommandParameterProperty, documentType3);
		translateExtension4.Text = "Passport";
		BindingBase bindingBase7 = ((IMarkupExtension<BindingBase>)translateExtension4).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase7, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 60, 17);
		}
		borderedButton3.SetBinding(Button.TextProperty, bindingBase7);
		grid.Children.Add(borderedButton3);
		linkLabel.SetValue(Grid.RowProperty, 6);
		bindingExtension4.Path = "OpenBottomSheetCommand";
		BindingBase bindingBase8 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase8, new Uri("Pages\\DG078.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 64, 17);
		}
		linkLabel.SetBinding(LinkLabel.CommandProperty, bindingBase8);
		linkLabel.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
		linkLabel.SetValue(LinkLabel.IsButtonStyleProperty, true);
		linkLabel.SetValue(LinkLabel.TextProperty, dG078_OtherDocument);
		grid.Children.Add(linkLabel);
		contentView.SetValue(ContentView.ContentProperty, grid);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG078ViewModel, ICommand> setter = null;
			return new TypedBinding<DG078ViewModel, ICommand>((DG078ViewModel source) => ((ICommand value, bool success))(value: source.NextCommand, success: true), setter, new Tuple<Func<DG078ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG078ViewModel, object>, string>((DG078ViewModel source) => source, "NextCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG078ViewModel, ICommand> setter = null;
			return new TypedBinding<DG078ViewModel, ICommand>((DG078ViewModel source) => ((ICommand value, bool success))(value: source.NextCommand, success: true), setter, new Tuple<Func<DG078ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG078ViewModel, object>, string>((DG078ViewModel source) => source, "NextCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG078ViewModel, ICommand> setter = null;
			return new TypedBinding<DG078ViewModel, ICommand>((DG078ViewModel source) => ((ICommand value, bool success))(value: source.NextCommand, success: true), setter, new Tuple<Func<DG078ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG078ViewModel, object>, string>((DG078ViewModel source) => source, "NextCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DG078ViewModel, ICommand> setter = null;
			return new TypedBinding<DG078ViewModel, ICommand>((DG078ViewModel source) => ((ICommand value, bool success))(value: source.OpenBottomSheetCommand, success: true), setter, new Tuple<Func<DG078ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG078ViewModel, object>, string>((DG078ViewModel source) => source, "OpenBottomSheetCommand")
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
		this.LoadFromXaml(typeof(DG078));
	}
}
