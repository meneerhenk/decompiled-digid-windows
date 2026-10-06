using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Windows.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Extensions;
using DigiD.Common.Resources;
using DigiD.Mobile.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Graphics;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;
using ZXing.Net.Maui.Controls;

namespace DigiD.Mobile.Pages;

[XamlFilePath("Pages\\DG040.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG040 : BasePage<DG040ViewModel>
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private CameraBarcodeReaderView scanner;

	public DG040()
		: base((DG040ViewModel?)null)
	{
		InitializeComponent();
	}

	private void OnContentPageUnloaded(object? sender, EventArgs? e)
	{
		scanner.Handler?.DisconnectHandler();
	}

	private void TapGestureRecognizer_Tapped(object? sender, TappedEventArgs? e)
	{
		if (e != null)
		{
			Point value = e.GetPosition(scanner).Value;
			Point point = new Point(value.X, value.Y);
			scanner.Focus(point);
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("scanner")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG040).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG040)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate noScrollViewTemplate = TemplateSelector.NoScrollViewTemplate;
		VisualDiagnostics.RegisterSourceInfo(noScrollViewTemplate, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 15, 18);
		OnIdiomExtension onIdiomExtension = new OnIdiomExtension();
		VisualDiagnostics.RegisterSourceInfo(onIdiomExtension, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 25);
		IntOrientationExtension intOrientationExtension = new IntOrientationExtension();
		VisualDiagnostics.RegisterSourceInfo(intOrientationExtension, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 25);
		OnIdiomExtension onIdiomExtension2 = new OnIdiomExtension();
		VisualDiagnostics.RegisterSourceInfo(onIdiomExtension2, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 119);
		IntOrientationExtension intOrientationExtension2 = new IntOrientationExtension();
		VisualDiagnostics.RegisterSourceInfo(intOrientationExtension2, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 119);
		ThicknessOrientationExtension thicknessOrientationExtension = new ThicknessOrientationExtension();
		VisualDiagnostics.RegisterSourceInfo(thicknessOrientationExtension, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 38);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 28);
		string dG040_Titel = DigiDAppResources.DG040_Titel;
		VisualDiagnostics.RegisterSourceInfo(dG040_Titel, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 65);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 22);
		string dG040_Intro = DigiDAppResources.DG040_Intro;
		VisualDiagnostics.RegisterSourceInfo(dG040_Intro, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 28);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 22);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 18);
		ScrollView scrollView = new ScrollView();
		VisualDiagnostics.RegisterSourceInfo(scrollView, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 14);
		OnIdiomExtension onIdiomExtension3 = new OnIdiomExtension();
		VisualDiagnostics.RegisterSourceInfo(onIdiomExtension3, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 17);
		IntOrientationExtension intOrientationExtension3 = new IntOrientationExtension();
		VisualDiagnostics.RegisterSourceInfo(intOrientationExtension3, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 17);
		OnIdiomExtension onIdiomExtension4 = new OnIdiomExtension();
		VisualDiagnostics.RegisterSourceInfo(onIdiomExtension4, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 17);
		IntOrientationExtension intOrientationExtension4 = new IntOrientationExtension();
		VisualDiagnostics.RegisterSourceInfo(intOrientationExtension4, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 17);
		OnIdiomExtension onIdiomExtension5 = new OnIdiomExtension();
		VisualDiagnostics.RegisterSourceInfo(onIdiomExtension5, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 17);
		IntOrientationExtension intOrientationExtension5 = new IntOrientationExtension();
		VisualDiagnostics.RegisterSourceInfo(intOrientationExtension5, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 17);
		OnIdiomExtension onIdiomExtension6 = new OnIdiomExtension();
		VisualDiagnostics.RegisterSourceInfo(onIdiomExtension6, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 42, 17);
		IntOrientationExtension intOrientationExtension6 = new IntOrientationExtension();
		VisualDiagnostics.RegisterSourceInfo(intOrientationExtension6, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 42, 17);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 46, 17);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 61, 21);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 62, 21);
		string alg_CameraStarted = CommonResources.Alg_CameraStarted;
		VisualDiagnostics.RegisterSourceInfo(alg_CameraStarted, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 63, 21);
		TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
		VisualDiagnostics.RegisterSourceInfo(tapGestureRecognizer, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 66, 26);
		CameraBarcodeReaderView cameraBarcodeReaderView = new CameraBarcodeReaderView();
		VisualDiagnostics.RegisterSourceInfo(cameraBarcodeReaderView, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 54, 18);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 70, 18);
		Image image2 = new Image();
		VisualDiagnostics.RegisterSourceInfo(image2, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 80, 18);
		Image image3 = new Image();
		VisualDiagnostics.RegisterSourceInfo(image3, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 91, 18);
		Image image4 = new Image();
		VisualDiagnostics.RegisterSourceInfo(image4, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 102, 18);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 14);
		Grid grid2 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid2, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 15, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid2.transientNamescope = nameScope;
		scrollView.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		cameraBarcodeReaderView.transientNamescope = nameScope;
		nameScope.RegisterName("scanner", cameraBarcodeReaderView);
		CameraBarcodeReaderView cameraBarcodeReaderView2 = cameraBarcodeReaderView;
		if (cameraBarcodeReaderView2.StyleId == null)
		{
			string text = (cameraBarcodeReaderView2.StyleId = "scanner");
		}
		tapGestureRecognizer.transientNamescope = nameScope;
		image.transientNamescope = nameScope;
		image2.transientNamescope = nameScope;
		image3.transientNamescope = nameScope;
		image4.transientNamescope = nameScope;
		scanner = cameraBarcodeReaderView;
		Unloaded += OnContentPageUnloaded;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, noScrollViewTemplate);
		grid2.SetValue(View.MarginProperty, new Thickness(0.0));
		grid2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid2.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Star)));
		grid2.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Fill);
		grid2.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(new GridLength(150.0, GridUnitType.Absolute)), new RowDefinition(GridLength.Star)));
		grid2.SetValue(Grid.RowSpacingProperty, 0.0);
		grid2.SetValue(View.VerticalOptionsProperty, LayoutOptions.Fill);
		onIdiomExtension.Phone = "2";
		onIdiomExtension.Default = "1";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[5] { intOrientationExtension, scrollView, grid2, contentView, this }, typeof(OrientationExtension<int>).GetProperty("Landscape"), new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(25, 25)));
		object obj = ((IMarkupExtension)onIdiomExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 25);
		}
		intOrientationExtension.Landscape = (int)obj;
		intOrientationExtension.Portrait = 1;
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[4] { scrollView, grid2, contentView, this }, Grid.RowSpanProperty, new INameScope[1] { nameScope }, this);
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
		xmlNamespaceResolver.Add("pages", "clr-namespace:DigiD.Common.BaseClasses;assembly=DigiD.Common");
		xmlNamespaceResolver.Add("resources", "clr-namespace:DigiD.Common.Resources;assembly=DigiD.Common.Resources");
		xmlNamespaceResolver.Add("zxing", "clr-namespace:ZXing.Net.Maui.Controls;assembly=ZXing.Net.MAUI");
		xamlServiceProvider2.Add(typeof(IXamlTypeResolver), new XamlTypeResolver(xmlNamespaceResolver, typeof(DG040).Assembly));
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(25, 25)));
		object obj2 = ((IMarkupExtension)intOrientationExtension).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 25);
		}
		scrollView.SetValue(Grid.RowSpanProperty, obj2);
		onIdiomExtension2.Phone = "1";
		onIdiomExtension2.Default = "2";
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[5] { intOrientationExtension2, scrollView, grid2, contentView, this }, typeof(OrientationExtension<int>).GetProperty("Landscape"), new INameScope[1] { nameScope }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(25, 119)));
		object obj3 = ((IMarkupExtension)onIdiomExtension2).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 119);
		}
		intOrientationExtension2.Landscape = (int)obj3;
		intOrientationExtension2.Portrait = 2;
		XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service4 = new SimpleValueTargetProvider(new object[4] { scrollView, grid2, contentView, this }, Grid.ColumnSpanProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider4.Add(typeof(IReferenceProvider), service4);
		xamlServiceProvider4.Add(typeof(IProvideValueTarget), service4);
		XmlNamespaceResolver xmlNamespaceResolver2 = new XmlNamespaceResolver();
		xmlNamespaceResolver2.Add("__f__", "http://schemas.microsoft.com/dotnet/2021/maui");
		xmlNamespaceResolver2.Add("__g__", "http://schemas.microsoft.com/dotnet/maui/global");
		xmlNamespaceResolver2.Add("", "http://schemas.microsoft.com/dotnet/2021/maui");
		xmlNamespaceResolver2.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
		xmlNamespaceResolver2.Add("controls", "clr-namespace:DigiD.Common.Controls;assembly=DigiD.Common.Controls");
		xmlNamespaceResolver2.Add("extensions", "clr-namespace:DigiD.Common.Controls.Extensions;assembly=DigiD.Common.Controls");
		xmlNamespaceResolver2.Add("local", "clr-namespace:DigiD.Mobile.ViewModels");
		xmlNamespaceResolver2.Add("pages", "clr-namespace:DigiD.Common.BaseClasses;assembly=DigiD.Common");
		xmlNamespaceResolver2.Add("resources", "clr-namespace:DigiD.Common.Resources;assembly=DigiD.Common.Resources");
		xmlNamespaceResolver2.Add("zxing", "clr-namespace:ZXing.Net.Maui.Controls;assembly=ZXing.Net.MAUI");
		xamlServiceProvider4.Add(typeof(IXamlTypeResolver), new XamlTypeResolver(xmlNamespaceResolver2, typeof(DG040).Assembly));
		xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(25, 119)));
		object obj4 = ((IMarkupExtension)intOrientationExtension2).ProvideValue((IServiceProvider)xamlServiceProvider4);
		if (VisualDiagnostics.GetSourceInfo(obj4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj4, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 119);
		}
		scrollView.SetValue(Grid.ColumnSpanProperty, obj4);
		thicknessOrientationExtension.Landscape = new Thickness(20.0, 0.0, 0.0, 0.0);
		thicknessOrientationExtension.Portrait = new Thickness(20.0);
		XamlServiceProvider xamlServiceProvider5 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service5 = new SimpleValueTargetProvider(new object[5] { verticalStackLayout, scrollView, grid2, contentView, this }, View.MarginProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider5.Add(typeof(IReferenceProvider), service5);
		xamlServiceProvider5.Add(typeof(IProvideValueTarget), service5);
		XmlNamespaceResolver xmlNamespaceResolver3 = new XmlNamespaceResolver();
		xmlNamespaceResolver3.Add("__f__", "http://schemas.microsoft.com/dotnet/2021/maui");
		xmlNamespaceResolver3.Add("__g__", "http://schemas.microsoft.com/dotnet/maui/global");
		xmlNamespaceResolver3.Add("", "http://schemas.microsoft.com/dotnet/2021/maui");
		xmlNamespaceResolver3.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
		xmlNamespaceResolver3.Add("controls", "clr-namespace:DigiD.Common.Controls;assembly=DigiD.Common.Controls");
		xmlNamespaceResolver3.Add("extensions", "clr-namespace:DigiD.Common.Controls.Extensions;assembly=DigiD.Common.Controls");
		xmlNamespaceResolver3.Add("local", "clr-namespace:DigiD.Mobile.ViewModels");
		xmlNamespaceResolver3.Add("pages", "clr-namespace:DigiD.Common.BaseClasses;assembly=DigiD.Common");
		xmlNamespaceResolver3.Add("resources", "clr-namespace:DigiD.Common.Resources;assembly=DigiD.Common.Resources");
		xmlNamespaceResolver3.Add("zxing", "clr-namespace:ZXing.Net.Maui.Controls;assembly=ZXing.Net.MAUI");
		xamlServiceProvider5.Add(typeof(IXamlTypeResolver), new XamlTypeResolver(xmlNamespaceResolver3, typeof(DG040).Assembly));
		xamlServiceProvider5.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(26, 38)));
		object obj5 = ((IMarkupExtension)thicknessOrientationExtension).ProvideValue((IServiceProvider)xamlServiceProvider5);
		if (VisualDiagnostics.GetSourceInfo(obj5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj5, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 38);
		}
		verticalStackLayout.SetValue(View.MarginProperty, obj5);
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 20.0);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider6 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service6 = new SimpleValueTargetProvider(new object[6] { label, verticalStackLayout, scrollView, grid2, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider6.Add(typeof(IReferenceProvider), service6);
		xamlServiceProvider6.Add(typeof(IProvideValueTarget), service6);
		xamlServiceProvider6.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(27, 28)));
		object obj6 = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider6);
		if (VisualDiagnostics.GetSourceInfo(obj6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj6, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 28);
		}
		label.SetValue(VisualElement.StyleProperty, obj6);
		label.SetValue(Label.TextProperty, dG040_Titel);
		verticalStackLayout.Children.Add(label);
		label2.SetValue(Label.TextProperty, dG040_Intro);
		verticalStackLayout.Children.Add(label2);
		scrollView.Content = verticalStackLayout;
		grid2.Children.Add(scrollView);
		onIdiomExtension3.Phone = "0";
		onIdiomExtension3.Default = "1";
		XamlServiceProvider xamlServiceProvider7 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service7 = new SimpleValueTargetProvider(new object[5] { intOrientationExtension3, grid, grid2, contentView, this }, typeof(OrientationExtension<int>).GetProperty("Landscape"), new INameScope[1] { nameScope }, this);
		xamlServiceProvider7.Add(typeof(IReferenceProvider), service7);
		xamlServiceProvider7.Add(typeof(IProvideValueTarget), service7);
		xamlServiceProvider7.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(33, 17)));
		object obj7 = ((IMarkupExtension)onIdiomExtension3).ProvideValue((IServiceProvider)xamlServiceProvider7);
		if (VisualDiagnostics.GetSourceInfo(obj7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj7, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 17);
		}
		intOrientationExtension3.Landscape = (int)obj7;
		intOrientationExtension3.Portrait = 1;
		XamlServiceProvider xamlServiceProvider8 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service8 = new SimpleValueTargetProvider(new object[4] { grid, grid2, contentView, this }, Grid.RowProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider8.Add(typeof(IReferenceProvider), service8);
		xamlServiceProvider8.Add(typeof(IProvideValueTarget), service8);
		XmlNamespaceResolver xmlNamespaceResolver4 = new XmlNamespaceResolver();
		xmlNamespaceResolver4.Add("__f__", "http://schemas.microsoft.com/dotnet/2021/maui");
		xmlNamespaceResolver4.Add("__g__", "http://schemas.microsoft.com/dotnet/maui/global");
		xmlNamespaceResolver4.Add("", "http://schemas.microsoft.com/dotnet/2021/maui");
		xmlNamespaceResolver4.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
		xmlNamespaceResolver4.Add("controls", "clr-namespace:DigiD.Common.Controls;assembly=DigiD.Common.Controls");
		xmlNamespaceResolver4.Add("extensions", "clr-namespace:DigiD.Common.Controls.Extensions;assembly=DigiD.Common.Controls");
		xmlNamespaceResolver4.Add("local", "clr-namespace:DigiD.Mobile.ViewModels");
		xmlNamespaceResolver4.Add("pages", "clr-namespace:DigiD.Common.BaseClasses;assembly=DigiD.Common");
		xmlNamespaceResolver4.Add("resources", "clr-namespace:DigiD.Common.Resources;assembly=DigiD.Common.Resources");
		xmlNamespaceResolver4.Add("zxing", "clr-namespace:ZXing.Net.Maui.Controls;assembly=ZXing.Net.MAUI");
		xamlServiceProvider8.Add(typeof(IXamlTypeResolver), new XamlTypeResolver(xmlNamespaceResolver4, typeof(DG040).Assembly));
		xamlServiceProvider8.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(33, 17)));
		object obj8 = ((IMarkupExtension)intOrientationExtension3).ProvideValue((IServiceProvider)xamlServiceProvider8);
		if (VisualDiagnostics.GetSourceInfo(obj8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj8, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 17);
		}
		grid.SetValue(Grid.RowProperty, obj8);
		onIdiomExtension4.Phone = "2";
		onIdiomExtension4.Default = "1";
		XamlServiceProvider xamlServiceProvider9 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service9 = new SimpleValueTargetProvider(new object[5] { intOrientationExtension4, grid, grid2, contentView, this }, typeof(OrientationExtension<int>).GetProperty("Landscape"), new INameScope[1] { nameScope }, this);
		xamlServiceProvider9.Add(typeof(IReferenceProvider), service9);
		xamlServiceProvider9.Add(typeof(IProvideValueTarget), service9);
		xamlServiceProvider9.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(36, 17)));
		object obj9 = ((IMarkupExtension)onIdiomExtension4).ProvideValue((IServiceProvider)xamlServiceProvider9);
		if (VisualDiagnostics.GetSourceInfo(obj9) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj9, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 17);
		}
		intOrientationExtension4.Landscape = (int)obj9;
		intOrientationExtension4.Portrait = 1;
		XamlServiceProvider xamlServiceProvider10 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service10 = new SimpleValueTargetProvider(new object[4] { grid, grid2, contentView, this }, Grid.RowSpanProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider10.Add(typeof(IReferenceProvider), service10);
		xamlServiceProvider10.Add(typeof(IProvideValueTarget), service10);
		XmlNamespaceResolver xmlNamespaceResolver5 = new XmlNamespaceResolver();
		xmlNamespaceResolver5.Add("__f__", "http://schemas.microsoft.com/dotnet/2021/maui");
		xmlNamespaceResolver5.Add("__g__", "http://schemas.microsoft.com/dotnet/maui/global");
		xmlNamespaceResolver5.Add("", "http://schemas.microsoft.com/dotnet/2021/maui");
		xmlNamespaceResolver5.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
		xmlNamespaceResolver5.Add("controls", "clr-namespace:DigiD.Common.Controls;assembly=DigiD.Common.Controls");
		xmlNamespaceResolver5.Add("extensions", "clr-namespace:DigiD.Common.Controls.Extensions;assembly=DigiD.Common.Controls");
		xmlNamespaceResolver5.Add("local", "clr-namespace:DigiD.Mobile.ViewModels");
		xmlNamespaceResolver5.Add("pages", "clr-namespace:DigiD.Common.BaseClasses;assembly=DigiD.Common");
		xmlNamespaceResolver5.Add("resources", "clr-namespace:DigiD.Common.Resources;assembly=DigiD.Common.Resources");
		xmlNamespaceResolver5.Add("zxing", "clr-namespace:ZXing.Net.Maui.Controls;assembly=ZXing.Net.MAUI");
		xamlServiceProvider10.Add(typeof(IXamlTypeResolver), new XamlTypeResolver(xmlNamespaceResolver5, typeof(DG040).Assembly));
		xamlServiceProvider10.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(36, 17)));
		object obj10 = ((IMarkupExtension)intOrientationExtension4).ProvideValue((IServiceProvider)xamlServiceProvider10);
		if (VisualDiagnostics.GetSourceInfo(obj10) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj10, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 17);
		}
		grid.SetValue(Grid.RowSpanProperty, obj10);
		onIdiomExtension5.Phone = "1";
		onIdiomExtension5.Default = "0";
		XamlServiceProvider xamlServiceProvider11 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service11 = new SimpleValueTargetProvider(new object[5] { intOrientationExtension5, grid, grid2, contentView, this }, typeof(OrientationExtension<int>).GetProperty("Landscape"), new INameScope[1] { nameScope }, this);
		xamlServiceProvider11.Add(typeof(IReferenceProvider), service11);
		xamlServiceProvider11.Add(typeof(IProvideValueTarget), service11);
		xamlServiceProvider11.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(39, 17)));
		object obj11 = ((IMarkupExtension)onIdiomExtension5).ProvideValue((IServiceProvider)xamlServiceProvider11);
		if (VisualDiagnostics.GetSourceInfo(obj11) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj11, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 17);
		}
		intOrientationExtension5.Landscape = (int)obj11;
		intOrientationExtension5.Portrait = 0;
		XamlServiceProvider xamlServiceProvider12 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service12 = new SimpleValueTargetProvider(new object[4] { grid, grid2, contentView, this }, Grid.ColumnProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider12.Add(typeof(IReferenceProvider), service12);
		xamlServiceProvider12.Add(typeof(IProvideValueTarget), service12);
		XmlNamespaceResolver xmlNamespaceResolver6 = new XmlNamespaceResolver();
		xmlNamespaceResolver6.Add("__f__", "http://schemas.microsoft.com/dotnet/2021/maui");
		xmlNamespaceResolver6.Add("__g__", "http://schemas.microsoft.com/dotnet/maui/global");
		xmlNamespaceResolver6.Add("", "http://schemas.microsoft.com/dotnet/2021/maui");
		xmlNamespaceResolver6.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
		xmlNamespaceResolver6.Add("controls", "clr-namespace:DigiD.Common.Controls;assembly=DigiD.Common.Controls");
		xmlNamespaceResolver6.Add("extensions", "clr-namespace:DigiD.Common.Controls.Extensions;assembly=DigiD.Common.Controls");
		xmlNamespaceResolver6.Add("local", "clr-namespace:DigiD.Mobile.ViewModels");
		xmlNamespaceResolver6.Add("pages", "clr-namespace:DigiD.Common.BaseClasses;assembly=DigiD.Common");
		xmlNamespaceResolver6.Add("resources", "clr-namespace:DigiD.Common.Resources;assembly=DigiD.Common.Resources");
		xmlNamespaceResolver6.Add("zxing", "clr-namespace:ZXing.Net.Maui.Controls;assembly=ZXing.Net.MAUI");
		xamlServiceProvider12.Add(typeof(IXamlTypeResolver), new XamlTypeResolver(xmlNamespaceResolver6, typeof(DG040).Assembly));
		xamlServiceProvider12.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(39, 17)));
		object obj12 = ((IMarkupExtension)intOrientationExtension5).ProvideValue((IServiceProvider)xamlServiceProvider12);
		if (VisualDiagnostics.GetSourceInfo(obj12) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj12, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 17);
		}
		grid.SetValue(Grid.ColumnProperty, obj12);
		onIdiomExtension6.Phone = "1";
		onIdiomExtension6.Default = "2";
		XamlServiceProvider xamlServiceProvider13 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service13 = new SimpleValueTargetProvider(new object[5] { intOrientationExtension6, grid, grid2, contentView, this }, typeof(OrientationExtension<int>).GetProperty("Landscape"), new INameScope[1] { nameScope }, this);
		xamlServiceProvider13.Add(typeof(IReferenceProvider), service13);
		xamlServiceProvider13.Add(typeof(IProvideValueTarget), service13);
		xamlServiceProvider13.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(42, 17)));
		object obj13 = ((IMarkupExtension)onIdiomExtension6).ProvideValue((IServiceProvider)xamlServiceProvider13);
		if (VisualDiagnostics.GetSourceInfo(obj13) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj13, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 42, 17);
		}
		intOrientationExtension6.Landscape = (int)obj13;
		intOrientationExtension6.Portrait = 2;
		XamlServiceProvider xamlServiceProvider14 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service14 = new SimpleValueTargetProvider(new object[4] { grid, grid2, contentView, this }, Grid.ColumnSpanProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider14.Add(typeof(IReferenceProvider), service14);
		xamlServiceProvider14.Add(typeof(IProvideValueTarget), service14);
		XmlNamespaceResolver xmlNamespaceResolver7 = new XmlNamespaceResolver();
		xmlNamespaceResolver7.Add("__f__", "http://schemas.microsoft.com/dotnet/2021/maui");
		xmlNamespaceResolver7.Add("__g__", "http://schemas.microsoft.com/dotnet/maui/global");
		xmlNamespaceResolver7.Add("", "http://schemas.microsoft.com/dotnet/2021/maui");
		xmlNamespaceResolver7.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
		xmlNamespaceResolver7.Add("controls", "clr-namespace:DigiD.Common.Controls;assembly=DigiD.Common.Controls");
		xmlNamespaceResolver7.Add("extensions", "clr-namespace:DigiD.Common.Controls.Extensions;assembly=DigiD.Common.Controls");
		xmlNamespaceResolver7.Add("local", "clr-namespace:DigiD.Mobile.ViewModels");
		xmlNamespaceResolver7.Add("pages", "clr-namespace:DigiD.Common.BaseClasses;assembly=DigiD.Common");
		xmlNamespaceResolver7.Add("resources", "clr-namespace:DigiD.Common.Resources;assembly=DigiD.Common.Resources");
		xmlNamespaceResolver7.Add("zxing", "clr-namespace:ZXing.Net.Maui.Controls;assembly=ZXing.Net.MAUI");
		xamlServiceProvider14.Add(typeof(IXamlTypeResolver), new XamlTypeResolver(xmlNamespaceResolver7, typeof(DG040).Assembly));
		xamlServiceProvider14.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(42, 17)));
		object obj14 = ((IMarkupExtension)intOrientationExtension6).ProvideValue((IServiceProvider)xamlServiceProvider14);
		if (VisualDiagnostics.GetSourceInfo(obj14) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj14, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 42, 17);
		}
		grid.SetValue(Grid.ColumnSpanProperty, obj14);
		grid.SetValue(View.MarginProperty, new Thickness(0.0));
		staticResourceExtension2.Key = "Gray9";
		XamlServiceProvider xamlServiceProvider15 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service15 = new SimpleValueTargetProvider(new object[4] { grid, grid2, contentView, this }, VisualElement.BackgroundColorProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider15.Add(typeof(IReferenceProvider), service15);
		xamlServiceProvider15.Add(typeof(IProvideValueTarget), service15);
		xamlServiceProvider15.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(46, 17)));
		object obj15 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider15);
		if (VisualDiagnostics.GetSourceInfo(obj15) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj15, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 46, 17);
		}
		grid.SetValue(VisualElement.BackgroundColorProperty, obj15);
		grid.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Auto), new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
		grid.SetValue(Grid.ColumnSpacingProperty, 0.0);
		grid.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Fill);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Auto)));
		grid.SetValue(Grid.RowSpacingProperty, 0.0);
		grid.SetValue(View.VerticalOptionsProperty, LayoutOptions.Fill);
		cameraBarcodeReaderView.SetValue(Grid.RowProperty, 0);
		cameraBarcodeReaderView.SetValue(Grid.RowSpanProperty, 3);
		cameraBarcodeReaderView.SetValue(Grid.ColumnProperty, 0);
		cameraBarcodeReaderView.SetValue(Grid.ColumnSpanProperty, 3);
		cameraBarcodeReaderView.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Fill);
		bindingExtension.Path = "IsDetecting";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 61, 21);
		}
		cameraBarcodeReaderView.SetBinding(CameraBarcodeReaderView.IsDetectingProperty, bindingBase);
		bindingExtension2.Path = "ScanCompleteCommand";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG040.xaml;assembly=DigiD.Mobile", UriKind.Relative), 62, 21);
		}
		cameraBarcodeReaderView.SetBinding(CameraBarcodeReaderView.ScanCompleteCommandProperty, bindingBase2);
		cameraBarcodeReaderView.SetValue(SemanticProperties.DescriptionProperty, alg_CameraStarted);
		cameraBarcodeReaderView.SetValue(View.VerticalOptionsProperty, LayoutOptions.Fill);
		tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped;
		cameraBarcodeReaderView.GestureRecognizers.Add(tapGestureRecognizer);
		grid.Children.Add(cameraBarcodeReaderView);
		image.SetValue(Grid.RowProperty, 0);
		image.SetValue(Grid.ColumnProperty, 0);
		image.SetValue(View.MarginProperty, new Thickness(30.0, 30.0, 0.0, 0.0));
		image.SetValue(Image.AspectProperty, Aspect.AspectFit);
		image.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		image.SetValue(VisualElement.HeightRequestProperty, 90.0);
		image.SetValue(Image.SourceProperty, ImageSource.FromFile("icon_qr_hoek.png"));
		image.SetValue(VisualElement.WidthRequestProperty, 90.0);
		grid.Children.Add(image);
		image2.SetValue(Grid.RowProperty, 0);
		image2.SetValue(Grid.ColumnProperty, 2);
		image2.SetValue(View.MarginProperty, new Thickness(0.0, 30.0, 30.0, 0.0));
		image2.SetValue(Image.AspectProperty, Aspect.AspectFit);
		image2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		image2.SetValue(VisualElement.HeightRequestProperty, 90.0);
		image2.SetValue(VisualElement.RotationProperty, 90.0);
		image2.SetValue(Image.SourceProperty, ImageSource.FromFile("icon_qr_hoek.png"));
		image2.SetValue(VisualElement.WidthRequestProperty, 90.0);
		grid.Children.Add(image2);
		image3.SetValue(Grid.RowProperty, 2);
		image3.SetValue(Grid.ColumnProperty, 2);
		image3.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 30.0, 30.0));
		image3.SetValue(Image.AspectProperty, Aspect.AspectFit);
		image3.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		image3.SetValue(VisualElement.HeightRequestProperty, 90.0);
		image3.SetValue(VisualElement.RotationProperty, 180.0);
		image3.SetValue(Image.SourceProperty, ImageSource.FromFile("icon_qr_hoek.png"));
		image3.SetValue(VisualElement.WidthRequestProperty, 90.0);
		grid.Children.Add(image3);
		image4.SetValue(Grid.RowProperty, 2);
		image4.SetValue(Grid.ColumnProperty, 0);
		image4.SetValue(View.MarginProperty, new Thickness(30.0, 0.0, 0.0, 30.0));
		image4.SetValue(Image.AspectProperty, Aspect.AspectFit);
		image4.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		image4.SetValue(VisualElement.HeightRequestProperty, 90.0);
		image4.SetValue(VisualElement.RotationProperty, 270.0);
		image4.SetValue(Image.SourceProperty, ImageSource.FromFile("icon_qr_hoek"));
		image4.SetValue(VisualElement.WidthRequestProperty, 90.0);
		grid.Children.Add(image4);
		grid2.Children.Add(grid);
		contentView.SetValue(ContentView.ContentProperty, grid2);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG040ViewModel, bool> setter = delegate(DG040ViewModel source, bool value)
			{
				source.IsDetecting = value;
			};
			return new TypedBinding<DG040ViewModel, bool>((DG040ViewModel source) => (value: source.IsDetecting, success: true), setter, new Tuple<Func<DG040ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG040ViewModel, object>, string>((DG040ViewModel source) => source, "IsDetecting")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG040ViewModel, ICommand> setter = null;
			return new TypedBinding<DG040ViewModel, ICommand>((DG040ViewModel source) => ((ICommand value, bool success))(value: source.ScanCompleteCommand, success: true), setter, new Tuple<Func<DG040ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG040ViewModel, object>, string>((DG040ViewModel source) => source, "ScanCompleteCommand")
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
	[MemberNotNull("scanner")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(DG040));
		scanner = this.FindByName<CameraBarcodeReaderView>("scanner");
	}
}
