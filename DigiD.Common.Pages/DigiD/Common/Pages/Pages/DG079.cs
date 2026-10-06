using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Windows.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Pages.ViewModels;
using DigiD.Common.Resources;
using LocalizationResourceManager.Maui;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Graphics;

namespace DigiD.Common.Pages.Pages;

[XamlFilePath("Pages\\DG079.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
public class DG079 : BasePage<DG079ViewModel>
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label Label;

	public DG079()
		: base((DG079ViewModel?)null)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("Label")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG079).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG079)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 13, 18);
		DynamicResource dynamicResource = new DynamicResource("LabelHeader");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 20, 17);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 21, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 18, 14);
		TranslateBindingExtension translateBindingExtension = new TranslateBindingExtension();
		VisualDiagnostics.RegisterSourceInfo(translateBindingExtension, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 24, 42);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 24, 18);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 25, 24);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 25, 69);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 25, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 26, 24);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 26, 24);
		TranslateBindingExtension translateBindingExtension2 = new TranslateBindingExtension();
		VisualDiagnostics.RegisterSourceInfo(translateBindingExtension2, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 26, 120);
		Label label4 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label4, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 26, 18);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 27, 24);
		TranslateExtension translateExtension = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 27, 63);
		Label label5 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label5, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 27, 18);
		TranslateExtension translateExtension2 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension2, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 28, 24);
		Label label6 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label6, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 28, 18);
		StackLayout stackLayout = new StackLayout();
		VisualDiagnostics.RegisterSourceInfo(stackLayout, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 23, 14);
		BindingExtension bindingExtension6 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 31, 33);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 31, 14);
		string alg_SecurityNotification = CommonResources.Alg_SecurityNotification;
		VisualDiagnostics.RegisterSourceInfo(alg_SecurityNotification, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 54, 34);
		BindingExtension bindingExtension7 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension7, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 54, 26);
		ReferenceExtension referenceExtension = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 55, 46);
		BindingExtension bindingExtension8 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension8, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 55, 26);
		MultiBinding multiBinding = new MultiBinding();
		VisualDiagnostics.RegisterSourceInfo(multiBinding, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 53, 22);
		Image image2 = new Image();
		VisualDiagnostics.RegisterSourceInfo(image2, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 42, 22);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 47, 25);
		TranslateExtension translateExtension3 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension3, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 48, 25);
		Label label7 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label7, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 43, 22);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 38, 18);
		Border border = new Border();
		VisualDiagnostics.RegisterSourceInfo(border, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 33, 14);
		BindingExtension bindingExtension9 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension9, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 64, 17);
		TranslateExtension translateExtension4 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension4, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 65, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 60, 14);
		Grid grid2 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid2, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 14, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 13, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 1, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid2.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		stackLayout.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		label4.transientNamescope = nameScope;
		label5.transientNamescope = nameScope;
		label6.transientNamescope = nameScope;
		image.transientNamescope = nameScope;
		border.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		image2.transientNamescope = nameScope;
		label7.transientNamescope = nameScope;
		nameScope.RegisterName("Label", label7);
		Label label8 = label7;
		if (label8.StyleId == null)
		{
			string text = (label8.StyleId = "Label");
		}
		borderedButton.transientNamescope = nameScope;
		Label = label7;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid2.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid2.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto)));
		grid2.SetValue(Grid.RowSpacingProperty, 20.0);
		label.SetValue(Grid.RowProperty, 0);
		((IDynamicResourceHandler)label).SetDynamicResource(VisualElement.StyleProperty, dynamicResource.Key);
		bindingExtension.Path = "HeaderText";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 21, 17);
		}
		label.SetBinding(Label.TextProperty, bindingBase);
		grid2.Children.Add(label);
		stackLayout.SetValue(Grid.RowProperty, 1);
		stackLayout.SetValue(StackBase.SpacingProperty, 0.0);
		label2.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 0.0, 20.0));
		translateBindingExtension.TranslateFormat = "DG079_Text1";
		translateBindingExtension.Path = "CurrentDocumentType";
		BindingBase bindingBase2 = ((IMarkupExtension<BindingBase>)translateBindingExtension).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 24, 42);
		}
		label2.SetBinding(Label.TextProperty, bindingBase2);
		stackLayout.Children.Add(label2);
		bindingExtension2.Path = "DriversLicenseSelected";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 25, 24);
		}
		label3.SetBinding(VisualElement.IsVisibleProperty, bindingBase3);
		bindingExtension3.Path = "DG079_Text2";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 25, 69);
		}
		label3.SetBinding(Label.TextProperty, bindingBase4);
		stackLayout.Children.Add(label3);
		staticResourceExtension.Key = "BooleanInvertConverter";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[6] { bindingExtension4, label4, stackLayout, grid2, contentView, this }, typeof(BindingExtension).GetProperty("Converter"), new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(26, 24)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 26, 24);
		}
		bindingExtension4.Converter = (IValueConverter)obj;
		bindingExtension4.Path = "DriversLicenseSelected";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 26, 24);
		}
		label4.SetBinding(VisualElement.IsVisibleProperty, bindingBase5);
		translateBindingExtension2.TranslateFormat = "DG079_Text3";
		translateBindingExtension2.Path = "CurrentDocumentType";
		BindingBase bindingBase6 = ((IMarkupExtension<BindingBase>)translateBindingExtension2).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 26, 120);
		}
		label4.SetBinding(Label.TextProperty, bindingBase6);
		stackLayout.Children.Add(label4);
		bindingExtension5.Path = "PassportSelected";
		BindingBase bindingBase7 = CreateTypedBindingFrom_bindingExtension5(bindingExtension5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase7, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 27, 24);
		}
		label5.SetBinding(VisualElement.IsVisibleProperty, bindingBase7);
		translateExtension.Text = "DG079_Text4";
		BindingBase bindingBase8 = ((IMarkupExtension<BindingBase>)translateExtension).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase8, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 27, 63);
		}
		label5.SetBinding(Label.TextProperty, bindingBase8);
		stackLayout.Children.Add(label5);
		translateExtension2.Text = "DG079_Text5";
		BindingBase bindingBase9 = ((IMarkupExtension<BindingBase>)translateExtension2).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase9) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase9, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 28, 24);
		}
		label6.SetBinding(Label.TextProperty, bindingBase9);
		stackLayout.Children.Add(label6);
		grid2.Children.Add(stackLayout);
		image.SetValue(Grid.RowProperty, 2);
		bindingExtension6.Path = "ImageSource";
		BindingBase bindingBase10 = CreateTypedBindingFrom_bindingExtension6(bindingExtension6);
		if (VisualDiagnostics.GetSourceInfo(bindingBase10) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase10, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 31, 33);
		}
		image.SetBinding(Image.SourceProperty, bindingBase10);
		grid2.Children.Add(image);
		border.SetValue(Grid.RowProperty, 3);
		border.SetValue(Border.PaddingProperty, new Thickness(10.0));
		border.SetValue(VisualElement.BackgroundColorProperty, new Color(0.88235295f, 79f / 85f, 73f / 85f, 1f));
		border.SetValue(Border.StrokeShapeProperty, new StrokeShapeTypeConverter().ConvertFromInvariantString("RoundRectangle 4") as IShape);
		multiBinding.StringFormat = "{0} {1}";
		bindingExtension7.Source = alg_SecurityNotification;
		BindingBase bindingBase11 = CreateTypedBindingFrom_bindingExtension7(bindingExtension7);
		if (VisualDiagnostics.GetSourceInfo(bindingBase11) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase11, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 54, 26);
		}
		multiBinding.Bindings.Add(bindingBase11);
		bindingExtension8.Path = "Text";
		referenceExtension.Name = "Label";
		Label label9 = label7;
		if (VisualDiagnostics.GetSourceInfo(label9) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(label9, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 55, 46);
		}
		bindingExtension8.Source = label9;
		Binding binding = new Binding(bindingExtension8.Path, bindingExtension8.Mode, bindingExtension8.Converter, bindingExtension8.ConverterParameter, bindingExtension8.StringFormat, bindingExtension8.Source)
		{
			UpdateSourceEventName = bindingExtension8.UpdateSourceEventName,
			FallbackValue = bindingExtension8.FallbackValue,
			TargetNullValue = bindingExtension8.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 55, 26);
		}
		multiBinding.Bindings.Add(binding);
		border.SetBinding(SemanticProperties.DescriptionProperty, multiBinding);
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Auto), new ColumnDefinition(GridLength.Star)));
		grid.SetValue(Grid.ColumnSpacingProperty, 10.0);
		image2.SetValue(Grid.ColumnProperty, 0);
		image2.SetValue(Image.SourceProperty, ImageSource.FromFile("green_shield.png"));
		grid.Children.Add(image2);
		label7.SetValue(Grid.ColumnProperty, 1);
		label7.SetValue(SemanticProperties.HeadingLevelProperty, SemanticHeadingLevel.None);
		staticResourceExtension2.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[6] { label7, grid, border, grid2, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(47, 25)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 47, 25);
		}
		label7.SetValue(VisualElement.StyleProperty, obj2);
		translateExtension3.Text = "DG079_Text6";
		BindingBase bindingBase12 = ((IMarkupExtension<BindingBase>)translateExtension3).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase12) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase12, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 48, 25);
		}
		label7.SetBinding(Label.TextProperty, bindingBase12);
		label7.SetValue(Label.TextColorProperty, new Color(19f / 85f, 0.5294118f, 4f / 85f, 1f));
		label7.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid.Children.Add(label7);
		border.SetValue(Border.ContentProperty, grid);
		grid2.Children.Add(border);
		borderedButton.SetValue(Grid.RowProperty, 4);
		borderedButton.SetValue(Element.AutomationIdProperty, "btnNext");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension9.Path = "NextCommand";
		BindingBase bindingBase13 = CreateTypedBindingFrom_bindingExtension8(bindingExtension9);
		if (VisualDiagnostics.GetSourceInfo(bindingBase13) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase13, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 64, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase13);
		translateExtension4.Text = "DG079_ButtonText";
		BindingBase bindingBase14 = ((IMarkupExtension<BindingBase>)translateExtension4).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase14) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase14, new Uri("Pages\\DG079.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 65, 17);
		}
		borderedButton.SetBinding(Button.TextProperty, bindingBase14);
		grid2.Children.Add(borderedButton);
		contentView.SetValue(ContentView.ContentProperty, grid2);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG079ViewModel, string> setter = delegate(DG079ViewModel source, string? value)
			{
				source.HeaderText = value;
			};
			return new TypedBinding<DG079ViewModel, string>((DG079ViewModel source) => (value: source.HeaderText, success: true), setter, new Tuple<Func<DG079ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG079ViewModel, object>, string>((DG079ViewModel source) => source, "HeaderText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG079ViewModel, bool> setter = null;
			return new TypedBinding<DG079ViewModel, bool>((DG079ViewModel source) => (value: source.DriversLicenseSelected, success: true), setter, new Tuple<Func<DG079ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG079ViewModel, object>, string>((DG079ViewModel source) => source, "DriversLicenseSelected")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG079ViewModel, string> setter = delegate(DG079ViewModel source, string? value)
			{
				source.DG079_Text2 = value;
			};
			return new TypedBinding<DG079ViewModel, string>((DG079ViewModel source) => (value: source.DG079_Text2, success: true), setter, new Tuple<Func<DG079ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG079ViewModel, object>, string>((DG079ViewModel source) => source, "DG079_Text2")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DG079ViewModel, bool> setter = null;
			return new TypedBinding<DG079ViewModel, bool>((DG079ViewModel source) => (value: source.DriversLicenseSelected, success: true), setter, new Tuple<Func<DG079ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG079ViewModel, object>, string>((DG079ViewModel source) => source, "DriversLicenseSelected")
			})
			{
				Converter = extension.Converter
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<DG079ViewModel, bool> setter = null;
			return new TypedBinding<DG079ViewModel, bool>((DG079ViewModel source) => (value: source.PassportSelected, success: true), setter, new Tuple<Func<DG079ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG079ViewModel, object>, string>((DG079ViewModel source) => source, "PassportSelected")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension6(BindingExtension extension)
		{
			Action<DG079ViewModel, string> setter = delegate(DG079ViewModel source, string? value)
			{
				source.ImageSource = value;
			};
			return new TypedBinding<DG079ViewModel, string>((DG079ViewModel source) => (value: source.ImageSource, success: true), setter, new Tuple<Func<DG079ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG079ViewModel, object>, string>((DG079ViewModel source) => source, "ImageSource")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension7(BindingExtension extension)
		{
			Action<DG079ViewModel, DG079ViewModel> setter = null;
			return new TypedBinding<DG079ViewModel, DG079ViewModel>((DG079ViewModel source) => (value: source, success: true), setter, new Tuple<Func<DG079ViewModel, object>, string>[0])
			{
				Source = extension.Source
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension8(BindingExtension extension)
		{
			Action<DG079ViewModel, ICommand> setter = null;
			return new TypedBinding<DG079ViewModel, ICommand>((DG079ViewModel source) => ((ICommand value, bool success))(value: source.NextCommand, success: true), setter, new Tuple<Func<DG079ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG079ViewModel, object>, string>((DG079ViewModel source) => source, "NextCommand")
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
	[MemberNotNull("Label")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(DG079));
		Label = this.FindByName<Label>("Label");
	}
}
