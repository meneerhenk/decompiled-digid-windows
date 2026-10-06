using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Windows.Input;
using CommunityToolkit.Maui.Views;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Controls.Extensions;
using DigiD.Common.Helpers;
using DigiD.Common.Resources;
using DigiD.Mobile.ViewModels;
using LocalizationResourceManager.Maui;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Graphics;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.Pages;

[XamlFilePath("Pages\\DG037.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG037 : BasePage<DG037ViewModel>
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private BasePage<DG037ViewModel> page;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private SemanticOrderView SemanticOrderView;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Border LogoBorder;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Image Logo;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label InloggenLabel;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label InloggenStap1;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label InloggenStap2;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private LinkLabel MoreExplanationLink;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label KoppelcodeLabel;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label KoppelcodeTekst;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private BorderedButton VerificationCodeButton;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private ToastView toast;

	public DG037(DG037ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
		SemanticOrderView.ViewOrder = new List<View> { toast, Logo, InloggenLabel, InloggenStap1, InloggenStap2, MoreExplanationLink, KoppelcodeLabel, KoppelcodeTekst, VerificationCodeButton };
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		toast.OnAppearing();
	}

	private void FocusLogoChanged(object? sender, FocusEventArgs e)
	{
		if (sender == Logo)
		{
			if (e.IsFocused)
			{
				LogoBorder.Stroke = (ThemeHelper.IsInDarkMode ? Colors.White : Colors.Black);
			}
			else
			{
				LogoBorder.Stroke = Colors.Transparent;
			}
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("page")]
	[MemberNotNull("SemanticOrderView")]
	[MemberNotNull("LogoBorder")]
	[MemberNotNull("Logo")]
	[MemberNotNull("InloggenLabel")]
	[MemberNotNull("InloggenStap1")]
	[MemberNotNull("InloggenStap2")]
	[MemberNotNull("MoreExplanationLink")]
	[MemberNotNull("KoppelcodeLabel")]
	[MemberNotNull("KoppelcodeTekst")]
	[MemberNotNull("VerificationCodeButton")]
	[MemberNotNull("toast")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG037).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG037)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 18);
		Border border = new Border();
		VisualDiagnostics.RegisterSourceInfo(border, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 18);
		OnIdiomExtension onIdiomExtension = new OnIdiomExtension();
		VisualDiagnostics.RegisterSourceInfo(onIdiomExtension, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 21);
		BooleanOrientationExtension booleanOrientationExtension = new BooleanOrientationExtension();
		VisualDiagnostics.RegisterSourceInfo(booleanOrientationExtension, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 21);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 44, 47);
		TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
		VisualDiagnostics.RegisterSourceInfo(tapGestureRecognizer, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 44, 26);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 18);
		DynamicResource dynamicResource = new DynamicResource("digidIconLandingInloggen");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 58, 25);
		Image image2 = new Image();
		VisualDiagnostics.RegisterSourceInfo(image2, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 55, 22);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 63, 25);
		TranslateExtension translateExtension = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 64, 25);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 60, 22);
		TranslateExtension translateExtension2 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension2, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 69, 25);
		string alg_Step = CommonResources.Alg_Step;
		VisualDiagnostics.RegisterSourceInfo(alg_Step, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 72, 42);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 72, 34);
		RelativeBindingSource self = RelativeBindingSource.Self;
		VisualDiagnostics.RegisterSourceInfo(self, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 73, 54);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 73, 34);
		MultiBinding multiBinding = new MultiBinding();
		VisualDiagnostics.RegisterSourceInfo(multiBinding, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 71, 30);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 65, 22);
		TranslateExtension translateExtension3 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension3, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 82, 25);
		string alg_Step2 = CommonResources.Alg_Step;
		VisualDiagnostics.RegisterSourceInfo(alg_Step2, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 85, 42);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 85, 34);
		RelativeBindingSource self2 = RelativeBindingSource.Self;
		VisualDiagnostics.RegisterSourceInfo(self2, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 86, 54);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 86, 34);
		MultiBinding multiBinding2 = new MultiBinding();
		VisualDiagnostics.RegisterSourceInfo(multiBinding2, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 84, 30);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 78, 22);
		BindingExtension bindingExtension6 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 96, 25);
		BindingExtension bindingExtension7 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension7, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 97, 25);
		LinkLabel linkLabel = new LinkLabel();
		VisualDiagnostics.RegisterSourceInfo(linkLabel, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 91, 22);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 48, 18);
		OnIdiomExtension onIdiomExtension2 = new OnIdiomExtension();
		VisualDiagnostics.RegisterSourceInfo(onIdiomExtension2, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 106, 21);
		DynamicResource dynamicResource2 = new DynamicResource("digidIconLandingKoppelcode");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource2, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 112, 25);
		Image image3 = new Image();
		VisualDiagnostics.RegisterSourceInfo(image3, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 109, 22);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 117, 25);
		TranslateExtension translateExtension4 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension4, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 118, 25);
		Label label4 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label4, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 114, 22);
		TranslateExtension translateExtension5 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension5, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 123, 25);
		Label label5 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label5, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 119, 22);
		Grid grid2 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid2, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 101, 18);
		BindingExtension bindingExtension8 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension8, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 131, 21);
		OnIdiomExtension onIdiomExtension3 = new OnIdiomExtension();
		VisualDiagnostics.RegisterSourceInfo(onIdiomExtension3, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 132, 21);
		TranslateExtension translateExtension6 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension6, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 134, 21);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 126, 18);
		ToastView toastView = new ToastView();
		VisualDiagnostics.RegisterSourceInfo(toastView, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 137, 18);
		Grid grid3 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid3, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 14);
		SemanticOrderView semanticOrderView = new SemanticOrderView();
		VisualDiagnostics.RegisterSourceInfo(semanticOrderView, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		nameScope.RegisterName("page", this);
		if (StyleId == null)
		{
			string text = (StyleId = "page");
		}
		contentView.transientNamescope = nameScope;
		semanticOrderView.transientNamescope = nameScope;
		nameScope.RegisterName("SemanticOrderView", semanticOrderView);
		SemanticOrderView semanticOrderView2 = semanticOrderView;
		if (semanticOrderView2.StyleId == null)
		{
			string text = (semanticOrderView2.StyleId = "SemanticOrderView");
		}
		grid3.transientNamescope = nameScope;
		border.transientNamescope = nameScope;
		nameScope.RegisterName("LogoBorder", border);
		Border border2 = border;
		if (border2.StyleId == null)
		{
			string text = (border2.StyleId = "LogoBorder");
		}
		image.transientNamescope = nameScope;
		nameScope.RegisterName("Logo", image);
		Image image4 = image;
		if (image4.StyleId == null)
		{
			string text = (image4.StyleId = "Logo");
		}
		tapGestureRecognizer.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		image2.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		nameScope.RegisterName("InloggenLabel", label);
		Label label6 = label;
		if (label6.StyleId == null)
		{
			string text = (label6.StyleId = "InloggenLabel");
		}
		label2.transientNamescope = nameScope;
		nameScope.RegisterName("InloggenStap1", label2);
		label6 = label2;
		if (label6.StyleId == null)
		{
			string text = (label6.StyleId = "InloggenStap1");
		}
		label3.transientNamescope = nameScope;
		nameScope.RegisterName("InloggenStap2", label3);
		label6 = label3;
		if (label6.StyleId == null)
		{
			string text = (label6.StyleId = "InloggenStap2");
		}
		linkLabel.transientNamescope = nameScope;
		nameScope.RegisterName("MoreExplanationLink", linkLabel);
		LinkLabel linkLabel2 = linkLabel;
		if (linkLabel2.StyleId == null)
		{
			string text = (linkLabel2.StyleId = "MoreExplanationLink");
		}
		grid2.transientNamescope = nameScope;
		image3.transientNamescope = nameScope;
		label4.transientNamescope = nameScope;
		nameScope.RegisterName("KoppelcodeLabel", label4);
		label6 = label4;
		if (label6.StyleId == null)
		{
			string text = (label6.StyleId = "KoppelcodeLabel");
		}
		label5.transientNamescope = nameScope;
		nameScope.RegisterName("KoppelcodeTekst", label5);
		label6 = label5;
		if (label6.StyleId == null)
		{
			string text = (label6.StyleId = "KoppelcodeTekst");
		}
		borderedButton.transientNamescope = nameScope;
		nameScope.RegisterName("VerificationCodeButton", borderedButton);
		BorderedButton borderedButton2 = borderedButton;
		if (borderedButton2.StyleId == null)
		{
			string text = (borderedButton2.StyleId = "VerificationCodeButton");
		}
		toastView.transientNamescope = nameScope;
		nameScope.RegisterName("toast", toastView);
		ToastView toastView2 = toastView;
		if (toastView2.StyleId == null)
		{
			string text = (toastView2.StyleId = "toast");
		}
		page = this;
		SemanticOrderView = semanticOrderView;
		LogoBorder = border;
		Logo = image;
		InloggenLabel = label;
		InloggenStap1 = label2;
		InloggenStap2 = label3;
		MoreExplanationLink = linkLabel;
		KoppelcodeLabel = label4;
		KoppelcodeTekst = label5;
		VerificationCodeButton = borderedButton;
		toast = toastView;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		semanticOrderView.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid3.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid3.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid3.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto)));
		grid3.SetValue(Grid.RowSpacingProperty, 20.0);
		border.SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
		border.SetValue(Grid.RowSpanProperty, 2);
		border.SetValue(Border.StrokeThicknessProperty, 2.0);
		border.SetValue(Border.StrokeProperty, new BrushTypeConverter().ConvertFromInvariantString("Transparent") as Brush);
		grid3.Children.Add(border);
		image.SetValue(Grid.RowSpanProperty, 2);
		image.SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
		image.Focused += FocusLogoChanged;
		image.Unfocused += FocusLogoChanged;
		image.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
		booleanOrientationExtension.Portrait = true;
		onIdiomExtension.Phone = "False";
		onIdiomExtension.Tablet = "True";
		onIdiomExtension.Desktop = "True";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[6] { booleanOrientationExtension, image, grid3, semanticOrderView, contentView, this }, typeof(OrientationExtension<bool>).GetProperty("Landscape"), new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(35, 21)));
		object obj = ((IMarkupExtension)onIdiomExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 21);
		}
		booleanOrientationExtension.Landscape = (bool)obj;
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[5] { image, grid3, semanticOrderView, contentView, this }, VisualElement.IsVisibleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		XmlNamespaceResolver xmlNamespaceResolver = new XmlNamespaceResolver();
		xmlNamespaceResolver.Add("__f__", "http://schemas.microsoft.com/dotnet/2021/maui");
		xmlNamespaceResolver.Add("__g__", "http://schemas.microsoft.com/dotnet/maui/global");
		xmlNamespaceResolver.Add("", "http://schemas.microsoft.com/dotnet/2021/maui");
		xmlNamespaceResolver.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
		xmlNamespaceResolver.Add("controls", "clr-namespace:DigiD.Common.Controls;assembly=DigiD.Common.Controls");
		xmlNamespaceResolver.Add("extensions", "clr-namespace:DigiD.Common.Controls.Extensions;assembly=DigiD.Common.Controls");
		xmlNamespaceResolver.Add("local", "clr-namespace:DigiD.Mobile.ViewModels");
		xmlNamespaceResolver.Add("maui", "clr-namespace:LocalizationResourceManager.Maui;assembly=LocalizationResourceManager.Maui");
		xmlNamespaceResolver.Add("pages", "clr-namespace:DigiD.Common.BaseClasses;assembly=DigiD.Common");
		xmlNamespaceResolver.Add("resources", "clr-namespace:DigiD.Common.Resources;assembly=DigiD.Common.Resources");
		xmlNamespaceResolver.Add("views", "http://schemas.microsoft.com/dotnet/2022/maui/toolkit");
		xamlServiceProvider2.Add(typeof(IXamlTypeResolver), new XamlTypeResolver(xmlNamespaceResolver, typeof(DG037).Assembly));
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(35, 21)));
		object obj2 = ((IMarkupExtension)booleanOrientationExtension).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 21);
		}
		image.SetValue(VisualElement.IsVisibleProperty, obj2);
		image.SetValue(SemanticProperties.DescriptionProperty, "DigiD logo");
		image.SetValue(Image.SourceProperty, ImageSource.FromFile("afbeelding_digid_officiele_app.png"));
		image.SetValue(VisualElement.WidthRequestProperty, 80.0);
		bindingExtension.Path = "LogoPressedCommand";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 44, 47);
		}
		tapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, bindingBase);
		tapGestureRecognizer.SetValue(TapGestureRecognizer.NumberOfTapsRequiredProperty, 1);
		image.GestureRecognizers.Add(tapGestureRecognizer);
		grid3.Children.Add(image);
		grid.SetValue(Grid.RowProperty, 2);
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(new GridLength(32.0, GridUnitType.Absolute)), new ColumnDefinition(GridLength.Star)));
		grid.SetValue(Grid.ColumnSpacingProperty, 10.0);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto)));
		grid.SetValue(Grid.RowSpacingProperty, 0.0);
		image2.SetValue(Grid.RowSpanProperty, 4);
		image2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		((IDynamicResourceHandler)image2).SetDynamicResource(Image.SourceProperty, dynamicResource.Key);
		image2.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
		grid.Children.Add(image2);
		label.SetValue(Grid.ColumnProperty, 1);
		staticResourceExtension.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[6] { label, grid, grid3, semanticOrderView, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(63, 25)));
		object obj3 = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 63, 25);
		}
		label.SetValue(VisualElement.StyleProperty, obj3);
		translateExtension.Text = "DG037_Inloggen";
		BindingBase bindingBase2 = ((IMarkupExtension<BindingBase>)translateExtension).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 64, 25);
		}
		label.SetBinding(Label.TextProperty, bindingBase2);
		grid.Children.Add(label);
		label2.SetValue(Grid.RowProperty, 1);
		label2.SetValue(Grid.ColumnProperty, 1);
		translateExtension2.Text = "DG037_InloggenStap1";
		BindingBase bindingBase3 = ((IMarkupExtension<BindingBase>)translateExtension2).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 69, 25);
		}
		label2.SetBinding(Label.TextProperty, bindingBase3);
		multiBinding.StringFormat = "{0}, {1}";
		bindingExtension2.Source = alg_Step;
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 72, 34);
		}
		multiBinding.Bindings.Add(bindingBase4);
		bindingExtension3.Path = "Text";
		bindingExtension3.Source = self;
		Binding binding = new Binding(bindingExtension3.Path, bindingExtension3.Mode, bindingExtension3.Converter, bindingExtension3.ConverterParameter, bindingExtension3.StringFormat, bindingExtension3.Source)
		{
			UpdateSourceEventName = bindingExtension3.UpdateSourceEventName,
			FallbackValue = bindingExtension3.FallbackValue,
			TargetNullValue = bindingExtension3.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 73, 34);
		}
		multiBinding.Bindings.Add(binding);
		label2.SetBinding(SemanticProperties.DescriptionProperty, multiBinding);
		grid.Children.Add(label2);
		label3.SetValue(Grid.RowProperty, 2);
		label3.SetValue(Grid.ColumnProperty, 1);
		translateExtension3.Text = "DG037_InloggenStap2";
		BindingBase bindingBase5 = ((IMarkupExtension<BindingBase>)translateExtension3).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 82, 25);
		}
		label3.SetBinding(Label.TextProperty, bindingBase5);
		multiBinding2.StringFormat = "{0}, {1}";
		bindingExtension4.Source = alg_Step2;
		BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension3(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 85, 34);
		}
		multiBinding2.Bindings.Add(bindingBase6);
		bindingExtension5.Path = "Text";
		bindingExtension5.Source = self2;
		Binding binding2 = new Binding(bindingExtension5.Path, bindingExtension5.Mode, bindingExtension5.Converter, bindingExtension5.ConverterParameter, bindingExtension5.StringFormat, bindingExtension5.Source)
		{
			UpdateSourceEventName = bindingExtension5.UpdateSourceEventName,
			FallbackValue = bindingExtension5.FallbackValue,
			TargetNullValue = bindingExtension5.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding2, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 86, 34);
		}
		multiBinding2.Bindings.Add(binding2);
		label3.SetBinding(SemanticProperties.DescriptionProperty, multiBinding2);
		grid.Children.Add(label3);
		linkLabel.SetValue(Grid.RowProperty, 3);
		linkLabel.SetValue(Grid.ColumnProperty, 1);
		linkLabel.SetValue(Element.AutomationIdProperty, "MoreExplanationLink");
		bindingExtension6.Path = "MoreExplanationCommand";
		BindingBase bindingBase7 = CreateTypedBindingFrom_bindingExtension5(bindingExtension6);
		if (VisualDiagnostics.GetSourceInfo(bindingBase7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase7, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 96, 25);
		}
		linkLabel.SetBinding(LinkLabel.CommandProperty, bindingBase7);
		bindingExtension7.Path = "MoreExplanationText.Localized";
		BindingBase bindingBase8 = CreateTypedBindingFrom_bindingExtension6(bindingExtension7);
		if (VisualDiagnostics.GetSourceInfo(bindingBase8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase8, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 97, 25);
		}
		linkLabel.SetBinding(LinkLabel.TextProperty, bindingBase8);
		linkLabel.SetValue(VisualElement.ZIndexProperty, 10);
		grid.Children.Add(linkLabel);
		grid3.Children.Add(grid);
		grid2.SetValue(Grid.RowProperty, 3);
		grid2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid2.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(new GridLength(32.0, GridUnitType.Absolute)), new ColumnDefinition(GridLength.Star)));
		grid2.SetValue(Grid.ColumnSpacingProperty, 10.0);
		onIdiomExtension2.Desktop = "false";
		XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service4 = new SimpleValueTargetProvider(new object[5] { grid2, grid3, semanticOrderView, contentView, this }, VisualElement.IsVisibleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider4.Add(typeof(IReferenceProvider), service4);
		xamlServiceProvider4.Add(typeof(IProvideValueTarget), service4);
		xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(106, 21)));
		object obj4 = ((IMarkupExtension)onIdiomExtension2).ProvideValue((IServiceProvider)xamlServiceProvider4);
		if (VisualDiagnostics.GetSourceInfo(obj4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj4, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 106, 21);
		}
		grid2.SetValue(VisualElement.IsVisibleProperty, obj4);
		grid2.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto)));
		grid2.SetValue(Grid.RowSpacingProperty, 0.0);
		image3.SetValue(Grid.RowSpanProperty, 2);
		image3.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		((IDynamicResourceHandler)image3).SetDynamicResource(Image.SourceProperty, dynamicResource2.Key);
		image3.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
		grid2.Children.Add(image3);
		label4.SetValue(Grid.ColumnProperty, 1);
		staticResourceExtension2.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider5 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service5 = new SimpleValueTargetProvider(new object[6] { label4, grid2, grid3, semanticOrderView, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider5.Add(typeof(IReferenceProvider), service5);
		xamlServiceProvider5.Add(typeof(IProvideValueTarget), service5);
		xamlServiceProvider5.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(117, 25)));
		object obj5 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider5);
		if (VisualDiagnostics.GetSourceInfo(obj5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj5, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 117, 25);
		}
		label4.SetValue(VisualElement.StyleProperty, obj5);
		translateExtension4.Text = "DG037_Koppelcode";
		BindingBase bindingBase9 = ((IMarkupExtension<BindingBase>)translateExtension4).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase9) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase9, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 118, 25);
		}
		label4.SetBinding(Label.TextProperty, bindingBase9);
		grid2.Children.Add(label4);
		label5.SetValue(Grid.RowProperty, 1);
		label5.SetValue(Grid.ColumnProperty, 1);
		translateExtension5.Text = "DG037_KoppelcodeTekst";
		BindingBase bindingBase10 = ((IMarkupExtension<BindingBase>)translateExtension5).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase10) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase10, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 123, 25);
		}
		label5.SetBinding(Label.TextProperty, bindingBase10);
		grid2.Children.Add(label5);
		grid3.Children.Add(grid2);
		borderedButton.SetValue(Grid.RowProperty, 4);
		borderedButton.SetValue(Element.AutomationIdProperty, "VerificationCodeButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension8.Path = "OpenKoppelCodeCommand";
		BindingBase bindingBase11 = CreateTypedBindingFrom_bindingExtension7(bindingExtension8);
		if (VisualDiagnostics.GetSourceInfo(bindingBase11) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase11, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 131, 21);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase11);
		onIdiomExtension3.Desktop = "false";
		onIdiomExtension3.Default = "true";
		XamlServiceProvider xamlServiceProvider6 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service6 = new SimpleValueTargetProvider(new object[5] { borderedButton, grid3, semanticOrderView, contentView, this }, VisualElement.IsVisibleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider6.Add(typeof(IReferenceProvider), service6);
		xamlServiceProvider6.Add(typeof(IProvideValueTarget), service6);
		xamlServiceProvider6.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(132, 21)));
		object obj6 = ((IMarkupExtension)onIdiomExtension3).ProvideValue((IServiceProvider)xamlServiceProvider6);
		if (VisualDiagnostics.GetSourceInfo(obj6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj6, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 132, 21);
		}
		borderedButton.SetValue(VisualElement.IsVisibleProperty, obj6);
		translateExtension6.Text = "DG037_KoppelcodeKnop";
		BindingBase bindingBase12 = ((IMarkupExtension<BindingBase>)translateExtension6).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase12) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase12, new Uri("Pages\\DG037.xaml;assembly=DigiD.Mobile", UriKind.Relative), 134, 21);
		}
		borderedButton.SetBinding(Button.TextProperty, bindingBase12);
		borderedButton.SetValue(View.VerticalOptionsProperty, LayoutOptions.End);
		grid3.Children.Add(borderedButton);
		toastView.SetValue(Grid.RowProperty, 0);
		toastView.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
		grid3.Children.Add(toastView);
		semanticOrderView.SetValue(ContentView.ContentProperty, grid3);
		contentView.SetValue(ContentView.ContentProperty, semanticOrderView);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG037ViewModel, ICommand> setter = null;
			return new TypedBinding<DG037ViewModel, ICommand>((DG037ViewModel source) => ((ICommand value, bool success))(value: source.LogoPressedCommand, success: true), setter, new Tuple<Func<DG037ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG037ViewModel, object>, string>((DG037ViewModel source) => source, "LogoPressedCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG037ViewModel, DG037ViewModel> setter = null;
			return new TypedBinding<DG037ViewModel, DG037ViewModel>((DG037ViewModel source) => (value: source, success: true), setter, new Tuple<Func<DG037ViewModel, object>, string>[0])
			{
				Source = extension.Source
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG037ViewModel, DG037ViewModel> setter = null;
			return new TypedBinding<DG037ViewModel, DG037ViewModel>((DG037ViewModel source) => (value: source, success: true), setter, new Tuple<Func<DG037ViewModel, object>, string>[0])
			{
				Source = extension.Source
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<DG037ViewModel, ICommand> setter = null;
			return new TypedBinding<DG037ViewModel, ICommand>((DG037ViewModel source) => ((ICommand value, bool success))(value: source.MoreExplanationCommand, success: true), setter, new Tuple<Func<DG037ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG037ViewModel, object>, string>((DG037ViewModel source) => source, "MoreExplanationCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension6(BindingExtension extension)
		{
			Action<DG037ViewModel, string> setter = null;
			return new TypedBinding<DG037ViewModel, string>((DG037ViewModel source) => (value: source.MoreExplanationText.Localized, success: true), setter, new Tuple<Func<DG037ViewModel, object>, string>[2]
			{
				new Tuple<Func<DG037ViewModel, object>, string>((DG037ViewModel source) => source, "MoreExplanationText"),
				new Tuple<Func<DG037ViewModel, object>, string>((DG037ViewModel source) => source.MoreExplanationText, "Localized")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension7(BindingExtension extension)
		{
			Action<DG037ViewModel, ICommand> setter = null;
			return new TypedBinding<DG037ViewModel, ICommand>((DG037ViewModel source) => ((ICommand value, bool success))(value: source.OpenKoppelCodeCommand, success: true), setter, new Tuple<Func<DG037ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG037ViewModel, object>, string>((DG037ViewModel source) => source, "OpenKoppelCodeCommand")
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
	[MemberNotNull("page")]
	[MemberNotNull("SemanticOrderView")]
	[MemberNotNull("LogoBorder")]
	[MemberNotNull("Logo")]
	[MemberNotNull("InloggenLabel")]
	[MemberNotNull("InloggenStap1")]
	[MemberNotNull("InloggenStap2")]
	[MemberNotNull("MoreExplanationLink")]
	[MemberNotNull("KoppelcodeLabel")]
	[MemberNotNull("KoppelcodeTekst")]
	[MemberNotNull("VerificationCodeButton")]
	[MemberNotNull("toast")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(DG037));
		page = this.FindByName<BasePage<DG037ViewModel>>("page");
		SemanticOrderView = this.FindByName<SemanticOrderView>("SemanticOrderView");
		LogoBorder = this.FindByName<Border>("LogoBorder");
		Logo = this.FindByName<Image>("Logo");
		InloggenLabel = this.FindByName<Label>("InloggenLabel");
		InloggenStap1 = this.FindByName<Label>("InloggenStap1");
		InloggenStap2 = this.FindByName<Label>("InloggenStap2");
		MoreExplanationLink = this.FindByName<LinkLabel>("MoreExplanationLink");
		KoppelcodeLabel = this.FindByName<Label>("KoppelcodeLabel");
		KoppelcodeTekst = this.FindByName<Label>("KoppelcodeTekst");
		VerificationCodeButton = this.FindByName<BorderedButton>("VerificationCodeButton");
		toast = this.FindByName<ToastView>("toast");
	}
}
