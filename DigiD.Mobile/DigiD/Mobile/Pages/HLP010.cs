using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Windows.Input;
using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Converters;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Helpers;
using DigiD.Common.Resources;
using DigiD.Mobile.Converters;
using DigiD.Mobile.Models;
using DigiD.Mobile.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Converters;
using Microsoft.Maui.Devices;
using Microsoft.Maui.Graphics;
using SkiaSharp.Extended.UI.Controls;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.Pages;

[XamlFilePath("Pages\\HLP010.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class HLP010 : BasePopup<HLP010ViewModel>
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private BasePopup<HLP010ViewModel> Popup;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Border popup;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private IndicatorView indicatorView;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private CarouselView carouselView;

	public HLP010(HLP010ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
		SetSize();
		base.SizeChanged += delegate
		{
			SetSize();
		};
	}

	private void SetSize()
	{
		bool flag = DeviceDisplay.MainDisplayInfo.Orientation == DisplayOrientation.Landscape;
		double widthRequest = (flag ? (DisplayHelper.Width * 0.7) : DisplayHelper.Width) - (double)(base.Padding * 2);
		popup.WidthRequest = widthRequest;
		popup.HeightRequest = DisplayHelper.Height * ((flag || DeviceInfo.Idiom == DeviceIdiom.Tablet) ? 0.9 : 0.7) - (double)(base.Padding * 2);
		carouselView.WidthRequest = popup.WidthRequest - (double)(base.Padding * 2) - 20.0;
		carouselView.HeightRequest = -1.0;
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("Popup")]
	[MemberNotNull("popup")]
	[MemberNotNull("indicatorView")]
	[MemberNotNull("carouselView")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(HLP010).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(HLP010)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 5);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 5);
		OnPlatformExtension onPlatformExtension = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 5);
		IsStringNotNullOrEmptyConverter isStringNotNullOrEmptyConverter = new IsStringNotNullOrEmptyConverter();
		VisualDiagnostics.RegisterSourceInfo(isStringNotNullOrEmptyConverter, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 10);
		ItemsViewScrolledEventArgsConverter itemsViewScrolledEventArgsConverter = new ItemsViewScrolledEventArgsConverter();
		VisualDiagnostics.RegisterSourceInfo(itemsViewScrolledEventArgsConverter, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 10);
		OnPlatformExtension onPlatformExtension2 = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension2, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 9);
		DynamicResource dynamicResource = new DynamicResource("AppPageBackground");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 9);
		ColumnDefinition columnDefinition = new ColumnDefinition();
		VisualDiagnostics.RegisterSourceInfo(columnDefinition, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 18);
		ColumnDefinition columnDefinition2 = new ColumnDefinition();
		VisualDiagnostics.RegisterSourceInfo(columnDefinition2, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 38, 18);
		RowDefinition rowDefinition = new RowDefinition();
		VisualDiagnostics.RegisterSourceInfo(rowDefinition, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 41, 18);
		RowDefinition rowDefinition2 = new RowDefinition();
		VisualDiagnostics.RegisterSourceInfo(rowDefinition2, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 42, 18);
		RowDefinition rowDefinition3 = new RowDefinition();
		VisualDiagnostics.RegisterSourceInfo(rowDefinition3, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 18);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 50, 17);
		string alg_CloseButton = CommonResources.Alg_CloseButton;
		VisualDiagnostics.RegisterSourceInfo(alg_CloseButton, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 52, 17);
		DynamicResource dynamicResource2 = new DynamicResource("iconSluiten");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource2, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 53, 17);
		ImageButton imageButton = new ImageButton();
		VisualDiagnostics.RegisterSourceInfo(imageButton, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 14);
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension3, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 62, 17);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 63, 17);
		OnPlatformExtension onPlatformExtension3 = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension3, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 63, 17);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 65, 17);
		StaticResourceExtension staticResourceExtension4 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension4, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 66, 17);
		IndicatorView indicatorView = new IndicatorView();
		VisualDiagnostics.RegisterSourceInfo(indicatorView, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 55, 14);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 75, 17);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 77, 17);
		DataTemplate dataTemplate = new DataTemplate();
		VisualDiagnostics.RegisterSourceInfo(dataTemplate, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 81, 22);
		ReferenceExtension referenceExtension = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 144, 25);
		BindingExtension bindingExtension6 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 144, 25);
		BindingExtension bindingExtension7 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension7, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 145, 25);
		StaticResourceExtension staticResourceExtension5 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension5, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 146, 25);
		EventToCommandBehavior eventToCommandBehavior = new EventToCommandBehavior();
		VisualDiagnostics.RegisterSourceInfo(eventToCommandBehavior, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 143, 22);
		CarouselView carouselView = new CarouselView();
		VisualDiagnostics.RegisterSourceInfo(carouselView, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 69, 14);
		BindingExtension bindingExtension8 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension8, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 157, 17);
		BindingExtension bindingExtension9 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension9, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 158, 17);
		string alg_Previous = CommonResources.Alg_Previous;
		VisualDiagnostics.RegisterSourceInfo(alg_Previous, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 160, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 151, 14);
		BindingExtension bindingExtension10 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension10, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 169, 17);
		BindingExtension bindingExtension11 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension11, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 170, 17);
		BorderedButton borderedButton2 = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton2, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 164, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 10);
		Border border = new Border();
		VisualDiagnostics.RegisterSourceInfo(border, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 6);
		HLP010 __root = this;
		VisualDiagnostics.RegisterSourceInfo(__root, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope iNameScope = NameScope.GetNameScope(__root) ?? new NameScope();
		NameScope.SetNameScope(__root, iNameScope);
		iNameScope.RegisterName("Popup", __root);
		HLP010 hLP = __root;
		if (hLP.StyleId == null)
		{
			string text = (hLP.StyleId = "Popup");
		}
		border.transientNamescope = iNameScope;
		iNameScope.RegisterName("popup", border);
		Border border2 = border;
		if (border2.StyleId == null)
		{
			string text = (border2.StyleId = "popup");
		}
		grid.transientNamescope = iNameScope;
		imageButton.transientNamescope = iNameScope;
		indicatorView.transientNamescope = iNameScope;
		iNameScope.RegisterName("indicatorView", indicatorView);
		IndicatorView indicatorView2 = indicatorView;
		if (indicatorView2.StyleId == null)
		{
			string text = (indicatorView2.StyleId = "indicatorView");
		}
		carouselView.transientNamescope = iNameScope;
		iNameScope.RegisterName("carouselView", carouselView);
		CarouselView carouselView2 = carouselView;
		if (carouselView2.StyleId == null)
		{
			string text = (carouselView2.StyleId = "carouselView");
		}
		borderedButton.transientNamescope = iNameScope;
		borderedButton2.transientNamescope = iNameScope;
		Popup = __root;
		popup = border;
		this.indicatorView = indicatorView;
		this.carouselView = carouselView;
		staticResourceExtension.Key = "Black30Transparent";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(__root);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[2] { onPlatformExtension, __root }, typeof(OnPlatformExtension).GetProperty("Android"), new INameScope[1] { iNameScope }, __root);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(16, 5)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 5);
		}
		onPlatformExtension.Android = obj;
		staticResourceExtension2.Key = "Black70Transparent";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(__root);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[2] { onPlatformExtension, __root }, typeof(OnPlatformExtension).GetProperty("iOS"), new INameScope[1] { iNameScope }, __root);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(16, 5)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 5);
		}
		onPlatformExtension.iOS = obj2;
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(__root);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[1] { __root }, VisualElement.BackgroundColorProperty, new INameScope[1] { iNameScope }, __root);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(16, 5)));
		object obj3 = ((IMarkupExtension)onPlatformExtension).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 5);
		}
		__root.SetValue(VisualElement.BackgroundColorProperty, obj3);
		__root.SetValue(ContentPage.SafeAreaEdgesProperty, (SafeAreaEdges)new SafeAreaEdgesTypeConverter().ConvertFromInvariantString("All"));
		ICommunityToolkitValueConverter communityToolkitValueConverter = ((IMarkupExtension<ICommunityToolkitValueConverter>)isStringNotNullOrEmptyConverter).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(communityToolkitValueConverter) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(communityToolkitValueConverter, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 10);
		}
		ResourceDictionary resources = __root.Resources;
		resources["IsStringNotNullOrEmptyConverter"] = communityToolkitValueConverter;
		ICommunityToolkitValueConverter communityToolkitValueConverter2 = ((IMarkupExtension<ICommunityToolkitValueConverter>)itemsViewScrolledEventArgsConverter).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(communityToolkitValueConverter2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(communityToolkitValueConverter2, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 10);
		}
		resources["ItemsViewScrolledEventArgsConverter"] = communityToolkitValueConverter2;
		onPlatformExtension2.Android = "0,0,0,0";
		onPlatformExtension2.iOS = "0,20,0,0";
		XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider(__root);
		SimpleValueTargetProvider service4 = new SimpleValueTargetProvider(new object[2] { border, __root }, View.MarginProperty, new INameScope[1] { iNameScope }, __root);
		xamlServiceProvider4.Add(typeof(IReferenceProvider), service4);
		xamlServiceProvider4.Add(typeof(IProvideValueTarget), service4);
		xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(26, 9)));
		object obj4 = ((IMarkupExtension)onPlatformExtension2).ProvideValue((IServiceProvider)xamlServiceProvider4);
		if (VisualDiagnostics.GetSourceInfo(obj4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj4, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 9);
		}
		border.SetValue(View.MarginProperty, obj4);
		((IDynamicResourceHandler)border).SetDynamicResource(VisualElement.BackgroundColorProperty, dynamicResource.Key);
		border.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
		border.SetValue(Border.StrokeShapeProperty, new StrokeShapeTypeConverter().ConvertFromInvariantString("RoundRectangle 8") as IShape);
		border.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		grid.SetValue(Microsoft.Maui.Controls.Layout.PaddingProperty, new Thickness(0.0, 0.0, 0.0, 20.0));
		grid.SetValue(Grid.ColumnSpacingProperty, 20.0);
		grid.SetValue(Grid.RowSpacingProperty, 20.0);
		columnDefinition.SetValue(ColumnDefinition.WidthProperty, GridLength.Star);
		ColumnDefinitionCollection columnDefinitionCollection = (ColumnDefinitionCollection)grid.GetValue(Grid.ColumnDefinitionsProperty);
		columnDefinitionCollection.Add(columnDefinition);
		columnDefinition2.SetValue(ColumnDefinition.WidthProperty, GridLength.Star);
		columnDefinitionCollection.Add(columnDefinition2);
		rowDefinition.SetValue(RowDefinition.HeightProperty, GridLength.Auto);
		RowDefinitionCollection rowDefinitionCollection = (RowDefinitionCollection)grid.GetValue(Grid.RowDefinitionsProperty);
		rowDefinitionCollection.Add(rowDefinition);
		rowDefinition2.SetValue(RowDefinition.HeightProperty, GridLength.Star);
		rowDefinitionCollection.Add(rowDefinition2);
		rowDefinition3.SetValue(RowDefinition.HeightProperty, GridLength.Auto);
		rowDefinitionCollection.Add(rowDefinition3);
		imageButton.SetValue(Grid.RowProperty, 0);
		imageButton.SetValue(Grid.ColumnProperty, 1);
		imageButton.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 0.0, -10.0));
		imageButton.SetValue(Element.AutomationIdProperty, "CloseButton");
		bindingExtension.Path = "CloseCommand";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 50, 17);
		}
		imageButton.SetBinding(ImageButton.CommandProperty, bindingBase);
		imageButton.SetValue(View.HorizontalOptionsProperty, LayoutOptions.End);
		imageButton.SetValue(SemanticProperties.DescriptionProperty, alg_CloseButton);
		((IDynamicResourceHandler)imageButton).SetDynamicResource(ImageButton.SourceProperty, dynamicResource2.Key);
		grid.Children.Add(imageButton);
		indicatorView.SetValue(Grid.RowProperty, 0);
		indicatorView.SetValue(Grid.ColumnProperty, 0);
		indicatorView.SetValue(Grid.ColumnSpanProperty, 2);
		indicatorView.SetValue(Element.AutomationIdProperty, "IndicatorView");
		indicatorView.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
		staticResourceExtension3.Key = "PrimaryColorTransparent";
		XamlServiceProvider xamlServiceProvider5 = new XamlServiceProvider(__root);
		SimpleValueTargetProvider service5 = new SimpleValueTargetProvider(new object[4] { indicatorView, grid, border, __root }, IndicatorView.IndicatorColorProperty, new INameScope[1] { iNameScope }, __root);
		xamlServiceProvider5.Add(typeof(IReferenceProvider), service5);
		xamlServiceProvider5.Add(typeof(IProvideValueTarget), service5);
		xamlServiceProvider5.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(62, 17)));
		object obj5 = ((IMarkupExtension)staticResourceExtension3).ProvideValue((IServiceProvider)xamlServiceProvider5);
		if (VisualDiagnostics.GetSourceInfo(obj5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj5, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 62, 17);
		}
		indicatorView.SetValue(IndicatorView.IndicatorColorProperty, obj5);
		bindingExtension2.Path = "IndicatorVisible";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 63, 17);
		}
		onPlatformExtension3.Android = bindingBase2;
		onPlatformExtension3.iOS = "True";
		XamlServiceProvider xamlServiceProvider6 = new XamlServiceProvider(__root);
		SimpleValueTargetProvider service6 = new SimpleValueTargetProvider(new object[4] { indicatorView, grid, border, __root }, VisualElement.IsVisibleProperty, new INameScope[1] { iNameScope }, __root);
		xamlServiceProvider6.Add(typeof(IReferenceProvider), service6);
		xamlServiceProvider6.Add(typeof(IProvideValueTarget), service6);
		xamlServiceProvider6.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(63, 17)));
		object obj6 = ((IMarkupExtension)onPlatformExtension3).ProvideValue((IServiceProvider)xamlServiceProvider6);
		if (VisualDiagnostics.GetSourceInfo(obj6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj6, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 63, 17);
		}
		indicatorView.SetValue(VisualElement.IsVisibleProperty, obj6);
		bindingExtension3.Path = "CurrentIndex";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 65, 17);
		}
		indicatorView.SetBinding(IndicatorView.PositionProperty, bindingBase3);
		staticResourceExtension4.Key = "PrimaryColor";
		XamlServiceProvider xamlServiceProvider7 = new XamlServiceProvider(__root);
		SimpleValueTargetProvider service7 = new SimpleValueTargetProvider(new object[4] { indicatorView, grid, border, __root }, IndicatorView.SelectedIndicatorColorProperty, new INameScope[1] { iNameScope }, __root);
		xamlServiceProvider7.Add(typeof(IReferenceProvider), service7);
		xamlServiceProvider7.Add(typeof(IProvideValueTarget), service7);
		xamlServiceProvider7.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(66, 17)));
		object obj7 = ((IMarkupExtension)staticResourceExtension4).ProvideValue((IServiceProvider)xamlServiceProvider7);
		if (VisualDiagnostics.GetSourceInfo(obj7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj7, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 66, 17);
		}
		indicatorView.SetValue(IndicatorView.SelectedIndicatorColorProperty, obj7);
		indicatorView.SetValue(VisualElement.ZIndexProperty, 5);
		grid.Children.Add(indicatorView);
		carouselView.SetValue(Grid.RowProperty, 1);
		carouselView.SetValue(Grid.ColumnProperty, 0);
		carouselView.SetValue(Grid.ColumnSpanProperty, 2);
		XamlServiceProvider xamlServiceProvider8 = new XamlServiceProvider(__root);
		SimpleValueTargetProvider service8 = new SimpleValueTargetProvider(new object[4] { carouselView, grid, border, __root }, typeof(CarouselView).GetProperty("IndicatorView"), new INameScope[1] { iNameScope }, __root);
		xamlServiceProvider8.Add(typeof(IReferenceProvider), service8);
		xamlServiceProvider8.Add(typeof(IProvideValueTarget), service8);
		carouselView.IndicatorView = ((IExtendedTypeConverter)new ReferenceTypeConverter()).ConvertFromInvariantString("indicatorView", (IServiceProvider)xamlServiceProvider8) as IndicatorView;
		bindingExtension4.Path = "Items";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 75, 17);
		}
		carouselView.SetBinding(ItemsView.ItemsSourceProperty, bindingBase4);
		carouselView.SetValue(CarouselView.LoopProperty, false);
		bindingExtension5.Path = "CurrentIndex";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension5(bindingExtension5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 77, 17);
		}
		carouselView.SetBinding(CarouselView.PositionProperty, bindingBase5);
		carouselView.SetValue(ItemsView.VerticalScrollBarVisibilityProperty, ScrollBarVisibility.Always);
		carouselView.SetValue(VisualElement.ZIndexProperty, 5);
		dataTemplate.LoadTemplate = delegate
		{
			RowDefinition rowDefinition4 = new RowDefinition();
			VisualDiagnostics.RegisterSourceInfo(rowDefinition4, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 88, 38);
			RowDefinition rowDefinition5 = new RowDefinition();
			VisualDiagnostics.RegisterSourceInfo(rowDefinition5, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 89, 38);
			RowDefinition rowDefinition6 = new RowDefinition();
			VisualDiagnostics.RegisterSourceInfo(rowDefinition6, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 90, 38);
			RowDefinition rowDefinition7 = new RowDefinition();
			VisualDiagnostics.RegisterSourceInfo(rowDefinition7, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 91, 38);
			StaticResourceExtension staticResourceExtension6 = new StaticResourceExtension();
			VisualDiagnostics.RegisterSourceInfo(staticResourceExtension6, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 96, 37);
			BindingExtension bindingExtension12 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension12, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 97, 37);
			Label label = new Label();
			VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 93, 34);
			BindingExtension bindingExtension13 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension13, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 102, 37);
			Label label2 = new Label();
			VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 100, 34);
			StaticResourceExtension staticResourceExtension7 = new StaticResourceExtension();
			VisualDiagnostics.RegisterSourceInfo(staticResourceExtension7, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 108, 37);
			BindingExtension bindingExtension14 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension14, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 108, 37);
			StaticResourceExtension staticResourceExtension8 = new StaticResourceExtension();
			VisualDiagnostics.RegisterSourceInfo(staticResourceExtension8, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 109, 37);
			BindingExtension bindingExtension15 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension15, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 110, 37);
			BindingExtension bindingExtension16 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension16, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 113, 63);
			TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
			VisualDiagnostics.RegisterSourceInfo(tapGestureRecognizer, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 113, 42);
			Label label3 = new Label();
			VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 105, 34);
			BindingExtension bindingExtension17 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension17, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 120, 37);
			BindingExtension bindingExtension18 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension18, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 121, 37);
			BindingExtension bindingExtension19 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension19, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 122, 37);
			BindingExtension bindingExtension20 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension20, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 123, 37);
			Image image = new Image();
			VisualDiagnostics.RegisterSourceInfo(image, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 117, 34);
			BindingExtension bindingExtension21 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension21, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 128, 37);
			BindingExtension bindingExtension22 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension22, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 130, 37);
			BindingExtension bindingExtension23 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension23, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 131, 37);
			ReferenceExtension referenceExtension2 = new ReferenceExtension();
			VisualDiagnostics.RegisterSourceInfo(referenceExtension2, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 132, 37);
			BindingExtension bindingExtension24 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension24, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 132, 37);
			ReferenceExtension referenceExtension3 = new ReferenceExtension();
			VisualDiagnostics.RegisterSourceInfo(referenceExtension3, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 133, 37);
			BindingExtension bindingExtension25 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension25, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 133, 37);
			BindingExtension bindingExtension26 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension26, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 134, 37);
			BindingExtension bindingExtension27 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension27, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 135, 37);
			BindingExtension bindingExtension28 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension28, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 136, 37);
			CustomAnimationView customAnimationView = new CustomAnimationView();
			VisualDiagnostics.RegisterSourceInfo(customAnimationView, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 126, 34);
			Grid grid2 = new Grid();
			VisualDiagnostics.RegisterSourceInfo(grid2, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 83, 30);
			ScrollView scrollView = new ScrollView();
			VisualDiagnostics.RegisterSourceInfo(scrollView, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 82, 26);
			INameScope nameScope = new NameScope();
			NameScope.SetNameScope(scrollView, nameScope);
			grid2.transientNamescope = nameScope;
			nameScope.RegisterName("container", grid2);
			Grid grid3 = grid2;
			if (grid3.StyleId == null)
			{
				string text6 = (grid3.StyleId = "container");
			}
			label.transientNamescope = nameScope;
			label2.transientNamescope = nameScope;
			label3.transientNamescope = nameScope;
			tapGestureRecognizer.transientNamescope = nameScope;
			image.transientNamescope = nameScope;
			customAnimationView.transientNamescope = nameScope;
			scrollView.SetValue(ScrollView.HorizontalScrollBarVisibilityProperty, ScrollBarVisibility.Never);
			scrollView.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
			grid2.SetValue(AutomationProperties.ExcludedWithChildrenProperty, false);
			grid2.SetValue(Grid.RowSpacingProperty, 20.0);
			rowDefinition4.SetValue(RowDefinition.HeightProperty, GridLength.Auto);
			RowDefinitionCollection rowDefinitionCollection2 = (RowDefinitionCollection)grid2.GetValue(Grid.RowDefinitionsProperty);
			rowDefinitionCollection2.Add(rowDefinition4);
			rowDefinition5.SetValue(RowDefinition.HeightProperty, GridLength.Auto);
			rowDefinitionCollection2.Add(rowDefinition5);
			rowDefinition6.SetValue(RowDefinition.HeightProperty, GridLength.Auto);
			rowDefinitionCollection2.Add(rowDefinition6);
			rowDefinition7.SetValue(RowDefinition.HeightProperty, GridLength.Star);
			rowDefinitionCollection2.Add(rowDefinition7);
			label.SetValue(Grid.RowProperty, 0);
			label.SetValue(View.MarginProperty, new Thickness(0.0, 10.0, 0.0, 0.0));
			staticResourceExtension6.Key = "LabelHeader";
			XamlServiceProvider xamlServiceProvider10 = new XamlServiceProvider(this);
			SimpleValueTargetProvider service10 = new SimpleValueTargetProvider(new object[8] { label, grid2, scrollView, dataTemplate, carouselView, grid, border, __root }, VisualElement.StyleProperty, new INameScope[2] { nameScope, iNameScope }, this);
			xamlServiceProvider10.Add(typeof(IReferenceProvider), service10);
			xamlServiceProvider10.Add(typeof(IProvideValueTarget), service10);
			xamlServiceProvider10.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(96, 37)));
			object obj9 = ((IMarkupExtension)staticResourceExtension6).ProvideValue((IServiceProvider)xamlServiceProvider10);
			if (VisualDiagnostics.GetSourceInfo(obj9) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(obj9, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 96, 37);
			}
			label.SetValue(VisualElement.StyleProperty, obj9);
			bindingExtension12.Path = "TitleText";
			BindingBase bindingBase11 = CreateTypedBindingFrom_bindingExtension11(bindingExtension12);
			if (VisualDiagnostics.GetSourceInfo(bindingBase11) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase11, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 97, 37);
			}
			label.SetBinding(Label.TextProperty, bindingBase11);
			label.SetValue(VisualElement.ZIndexProperty, 10);
			grid2.Children.Add(label);
			label2.SetValue(Grid.RowProperty, 1);
			bindingExtension13.Path = "BodyText";
			BindingBase bindingBase12 = CreateTypedBindingFrom_bindingExtension12(bindingExtension13);
			if (VisualDiagnostics.GetSourceInfo(bindingBase12) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase12, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 102, 37);
			}
			label2.SetBinding(Label.TextProperty, bindingBase12);
			label2.SetValue(VisualElement.ZIndexProperty, 10);
			grid2.Children.Add(label2);
			label3.SetValue(Grid.RowProperty, 2);
			label3.SetValue(View.MarginProperty, new Thickness(0.0, -10.0, 0.0, 0.0));
			staticResourceExtension7.Key = "IsStringNotNullOrEmptyConverter";
			XamlServiceProvider xamlServiceProvider11 = new XamlServiceProvider(this);
			SimpleValueTargetProvider service11 = new SimpleValueTargetProvider(new object[9] { bindingExtension14, label3, grid2, scrollView, dataTemplate, carouselView, grid, border, __root }, typeof(BindingExtension).GetProperty("Converter"), new INameScope[2] { nameScope, iNameScope }, this);
			xamlServiceProvider11.Add(typeof(IReferenceProvider), service11);
			xamlServiceProvider11.Add(typeof(IProvideValueTarget), service11);
			xamlServiceProvider11.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(108, 37)));
			object obj10 = ((IMarkupExtension)staticResourceExtension7).ProvideValue((IServiceProvider)xamlServiceProvider11);
			if (VisualDiagnostics.GetSourceInfo(obj10) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(obj10, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 108, 37);
			}
			bindingExtension14.Converter = (IValueConverter)obj10;
			bindingExtension14.Path = "LinkText";
			BindingBase bindingBase13 = CreateTypedBindingFrom_bindingExtension13(bindingExtension14);
			if (VisualDiagnostics.GetSourceInfo(bindingBase13) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase13, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 108, 37);
			}
			label3.SetBinding(VisualElement.IsVisibleProperty, bindingBase13);
			staticResourceExtension8.Key = "LabelAsLinkStyle";
			XamlServiceProvider xamlServiceProvider12 = new XamlServiceProvider(this);
			SimpleValueTargetProvider service12 = new SimpleValueTargetProvider(new object[8] { label3, grid2, scrollView, dataTemplate, carouselView, grid, border, __root }, VisualElement.StyleProperty, new INameScope[2] { nameScope, iNameScope }, this);
			xamlServiceProvider12.Add(typeof(IReferenceProvider), service12);
			xamlServiceProvider12.Add(typeof(IProvideValueTarget), service12);
			xamlServiceProvider12.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(109, 37)));
			object obj11 = ((IMarkupExtension)staticResourceExtension8).ProvideValue((IServiceProvider)xamlServiceProvider12);
			if (VisualDiagnostics.GetSourceInfo(obj11) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(obj11, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 109, 37);
			}
			label3.SetValue(VisualElement.StyleProperty, obj11);
			bindingExtension15.Path = "LinkText";
			BindingBase bindingBase14 = CreateTypedBindingFrom_bindingExtension14(bindingExtension15);
			if (VisualDiagnostics.GetSourceInfo(bindingBase14) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase14, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 110, 37);
			}
			label3.SetBinding(Label.TextProperty, bindingBase14);
			label3.SetValue(VisualElement.ZIndexProperty, 10);
			bindingExtension16.Path = "Command";
			BindingBase bindingBase15 = CreateTypedBindingFrom_bindingExtension15(bindingExtension16);
			if (VisualDiagnostics.GetSourceInfo(bindingBase15) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase15, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 113, 63);
			}
			tapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, bindingBase15);
			label3.GestureRecognizers.Add(tapGestureRecognizer);
			grid2.Children.Add(label3);
			image.SetValue(Grid.RowProperty, 3);
			image.SetValue(View.MarginProperty, new Thickness(0.0, -20.0, 0.0, 0.0));
			bindingExtension17.Path = "IsInAccessibleTree";
			BindingBase bindingBase16 = CreateTypedBindingFrom_bindingExtension16(bindingExtension17);
			if (VisualDiagnostics.GetSourceInfo(bindingBase16) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase16, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 120, 37);
			}
			image.SetBinding(AutomationProperties.IsInAccessibleTreeProperty, bindingBase16);
			bindingExtension18.Path = "IsImage";
			BindingBase bindingBase17 = CreateTypedBindingFrom_bindingExtension17(bindingExtension18);
			if (VisualDiagnostics.GetSourceInfo(bindingBase17) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase17, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 121, 37);
			}
			image.SetBinding(VisualElement.IsVisibleProperty, bindingBase17);
			bindingExtension19.Path = "AlternateText";
			BindingBase bindingBase18 = CreateTypedBindingFrom_bindingExtension18(bindingExtension19);
			if (VisualDiagnostics.GetSourceInfo(bindingBase18) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase18, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 122, 37);
			}
			image.SetBinding(SemanticProperties.DescriptionProperty, bindingBase18);
			bindingExtension20.Path = "Source";
			BindingBase bindingBase19 = CreateTypedBindingFrom_bindingExtension19(bindingExtension20);
			if (VisualDiagnostics.GetSourceInfo(bindingBase19) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase19, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 123, 37);
			}
			image.SetBinding(Image.SourceProperty, bindingBase19);
			image.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
			grid2.Children.Add(image);
			customAnimationView.SetValue(Grid.RowProperty, 3);
			bindingExtension21.Path = "IsInAccessibleTree";
			BindingBase bindingBase20 = CreateTypedBindingFrom_bindingExtension20(bindingExtension21);
			if (VisualDiagnostics.GetSourceInfo(bindingBase20) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase20, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 128, 37);
			}
			customAnimationView.SetBinding(AutomationProperties.IsInAccessibleTreeProperty, bindingBase20);
			customAnimationView.SetValue(VisualElement.HeightRequestProperty, 200.0);
			bindingExtension22.Path = "IsImage";
			BindingBase bindingBase21 = CreateTypedBindingFrom_bindingExtension21(bindingExtension22);
			if (VisualDiagnostics.GetSourceInfo(bindingBase21) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase21, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 130, 37);
			}
			customAnimationView.SetBinding(CustomAnimationView.HideAnimationProperty, bindingBase21);
			bindingExtension23.Path = "IsPlaying";
			BindingBase bindingBase22 = CreateTypedBindingFrom_bindingExtension22(bindingExtension23);
			if (VisualDiagnostics.GetSourceInfo(bindingBase22) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase22, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 131, 37);
			}
			customAnimationView.SetBinding(SKAnimatedSurfaceView.IsAnimationEnabledProperty, bindingBase22);
			referenceExtension2.Name = "container";
			Grid grid4 = grid2;
			if (VisualDiagnostics.GetSourceInfo(grid4) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(grid4, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 132, 37);
			}
			bindingExtension24.Source = grid4;
			bindingExtension24.Path = "WidthRequest";
			Binding binding2 = new Binding(bindingExtension24.Path, bindingExtension24.Mode, bindingExtension24.Converter, bindingExtension24.ConverterParameter, bindingExtension24.StringFormat, bindingExtension24.Source)
			{
				UpdateSourceEventName = bindingExtension24.UpdateSourceEventName,
				FallbackValue = bindingExtension24.FallbackValue,
				TargetNullValue = bindingExtension24.TargetNullValue
			};
			if (VisualDiagnostics.GetSourceInfo(binding2) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(binding2, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 132, 37);
			}
			customAnimationView.SetBinding(VisualElement.MaximumWidthRequestProperty, binding2);
			referenceExtension3.Name = "container";
			Grid grid5 = grid2;
			if (VisualDiagnostics.GetSourceInfo(grid5) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(grid5, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 133, 37);
			}
			bindingExtension25.Source = grid5;
			bindingExtension25.Path = "WidthRequest";
			Binding binding3 = new Binding(bindingExtension25.Path, bindingExtension25.Mode, bindingExtension25.Converter, bindingExtension25.ConverterParameter, bindingExtension25.StringFormat, bindingExtension25.Source)
			{
				UpdateSourceEventName = bindingExtension25.UpdateSourceEventName,
				FallbackValue = bindingExtension25.FallbackValue,
				TargetNullValue = bindingExtension25.TargetNullValue
			};
			if (VisualDiagnostics.GetSourceInfo(binding3) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(binding3, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 133, 37);
			}
			customAnimationView.SetBinding(VisualElement.MinimumWidthRequestProperty, binding3);
			bindingExtension26.Path = "Progress";
			BindingBase bindingBase23 = CreateTypedBindingFrom_bindingExtension25(bindingExtension26);
			if (VisualDiagnostics.GetSourceInfo(bindingBase23) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase23, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 134, 37);
			}
			customAnimationView.SetBinding(SKLottieView.ProgressProperty, bindingBase23);
			bindingExtension27.Path = "AlternateText";
			BindingBase bindingBase24 = CreateTypedBindingFrom_bindingExtension26(bindingExtension27);
			if (VisualDiagnostics.GetSourceInfo(bindingBase24) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase24, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 135, 37);
			}
			customAnimationView.SetBinding(SemanticProperties.DescriptionProperty, bindingBase24);
			bindingExtension28.Path = "AnimationSource";
			BindingBase bindingBase25 = CreateTypedBindingFrom_bindingExtension27(bindingExtension28);
			if (VisualDiagnostics.GetSourceInfo(bindingBase25) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase25, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 136, 37);
			}
			customAnimationView.SetBinding(SKLottieView.SourceProperty, bindingBase25);
			customAnimationView.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
			grid2.Children.Add(customAnimationView);
			scrollView.Content = grid2;
			return scrollView;
		};
		carouselView.SetValue(ItemsView.ItemTemplateProperty, dataTemplate);
		referenceExtension.Name = "Popup";
		HLP010 hLP2 = __root;
		if (VisualDiagnostics.GetSourceInfo(hLP2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(hLP2, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 144, 25);
		}
		bindingExtension6.Source = hLP2;
		bindingExtension6.Path = "BindingContext";
		Binding binding = new Binding(bindingExtension6.Path, bindingExtension6.Mode, bindingExtension6.Converter, bindingExtension6.ConverterParameter, bindingExtension6.StringFormat, bindingExtension6.Source)
		{
			UpdateSourceEventName = bindingExtension6.UpdateSourceEventName,
			FallbackValue = bindingExtension6.FallbackValue,
			TargetNullValue = bindingExtension6.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 144, 25);
		}
		eventToCommandBehavior.SetBinding(BindableObject.BindingContextProperty, binding);
		bindingExtension7.Path = "ScrollCommand";
		BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension28(bindingExtension7);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 145, 25);
		}
		eventToCommandBehavior.SetBinding(EventToCommandBehavior.CommandProperty, bindingBase6);
		staticResourceExtension5.Key = "ItemsViewScrolledEventArgsConverter";
		XamlServiceProvider xamlServiceProvider9 = new XamlServiceProvider(__root);
		SimpleValueTargetProvider service9 = new SimpleValueTargetProvider(new object[5] { eventToCommandBehavior, carouselView, grid, border, __root }, EventToCommandBehavior.EventArgsConverterProperty, new INameScope[1] { iNameScope }, __root);
		xamlServiceProvider9.Add(typeof(IReferenceProvider), service9);
		xamlServiceProvider9.Add(typeof(IProvideValueTarget), service9);
		xamlServiceProvider9.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(146, 25)));
		object obj8 = ((IMarkupExtension)staticResourceExtension5).ProvideValue((IServiceProvider)xamlServiceProvider9);
		if (VisualDiagnostics.GetSourceInfo(obj8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj8, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 146, 25);
		}
		eventToCommandBehavior.SetValue(EventToCommandBehavior.EventArgsConverterProperty, obj8);
		eventToCommandBehavior.SetValue(EventToCommandBehavior.EventNameProperty, "Scrolled");
		((IList<Behavior>)carouselView.GetValue(VisualElement.BehaviorsProperty)).Add(eventToCommandBehavior);
		grid.Children.Add(carouselView);
		borderedButton.SetValue(Grid.RowProperty, 2);
		borderedButton.SetValue(Grid.ColumnProperty, 0);
		borderedButton.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 0.0, -5.0));
		borderedButton.SetValue(Element.AutomationIdProperty, "PreviousButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension8.Path = "PreviousCommand";
		BindingBase bindingBase7 = CreateTypedBindingFrom_bindingExtension29(bindingExtension8);
		if (VisualDiagnostics.GetSourceInfo(bindingBase7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase7, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 157, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase7);
		bindingExtension9.Path = "PreviousEnabled";
		BindingBase bindingBase8 = CreateTypedBindingFrom_bindingExtension30(bindingExtension9);
		if (VisualDiagnostics.GetSourceInfo(bindingBase8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase8, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 158, 17);
		}
		borderedButton.SetBinding(VisualElement.IsEnabledProperty, bindingBase8);
		borderedButton.SetValue(VisualElement.MinimumHeightRequestProperty, 48.0);
		borderedButton.SetValue(Button.TextProperty, alg_Previous);
		borderedButton.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
		borderedButton.SetValue(VisualElement.ZIndexProperty, 10);
		grid.Children.Add(borderedButton);
		borderedButton2.SetValue(Grid.RowProperty, 2);
		borderedButton2.SetValue(Grid.ColumnProperty, 1);
		borderedButton2.SetValue(Element.AutomationIdProperty, "NextButton");
		borderedButton2.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension10.Path = "NextCommand";
		BindingBase bindingBase9 = CreateTypedBindingFrom_bindingExtension31(bindingExtension10);
		if (VisualDiagnostics.GetSourceInfo(bindingBase9) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase9, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 169, 17);
		}
		borderedButton2.SetBinding(Button.CommandProperty, bindingBase9);
		bindingExtension11.Path = "NextButtonText";
		BindingBase bindingBase10 = CreateTypedBindingFrom_bindingExtension32(bindingExtension11);
		if (VisualDiagnostics.GetSourceInfo(bindingBase10) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase10, new Uri("Pages\\HLP010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 170, 17);
		}
		borderedButton2.SetBinding(Button.TextProperty, bindingBase10);
		borderedButton2.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
		borderedButton2.SetValue(VisualElement.ZIndexProperty, 10);
		grid.Children.Add(borderedButton2);
		border.SetValue(Border.ContentProperty, grid);
		__root.SetValue(ContentPage.ContentProperty, border);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<HLP010ViewModel, ICommand> setter = null;
			return new TypedBinding<HLP010ViewModel, ICommand>((HLP010ViewModel source) => ((ICommand value, bool success))(value: source.CloseCommand, success: true), setter, new Tuple<Func<HLP010ViewModel, object>, string>[1]
			{
				new Tuple<Func<HLP010ViewModel, object>, string>((HLP010ViewModel source) => source, "CloseCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension11(BindingExtension extension)
		{
			Action<CarouselViewItemModel, string> setter = delegate(CarouselViewItemModel source, string? value)
			{
				source.TitleText = value;
			};
			return new TypedBinding<CarouselViewItemModel, string>((CarouselViewItemModel source) => (value: source.TitleText, success: true), setter, new Tuple<Func<CarouselViewItemModel, object>, string>[1]
			{
				new Tuple<Func<CarouselViewItemModel, object>, string>((CarouselViewItemModel source) => source, "TitleText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension12(BindingExtension extension)
		{
			Action<CarouselViewItemModel, string> setter = delegate(CarouselViewItemModel source, string? value)
			{
				source.BodyText = value;
			};
			return new TypedBinding<CarouselViewItemModel, string>((CarouselViewItemModel source) => (value: source.BodyText, success: true), setter, new Tuple<Func<CarouselViewItemModel, object>, string>[1]
			{
				new Tuple<Func<CarouselViewItemModel, object>, string>((CarouselViewItemModel source) => source, "BodyText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension13(BindingExtension extension)
		{
			Action<CarouselViewItemModel, string> setter = delegate(CarouselViewItemModel source, string? value)
			{
				source.LinkText = value;
			};
			return new TypedBinding<CarouselViewItemModel, string>((CarouselViewItemModel source) => (value: source.LinkText, success: true), setter, new Tuple<Func<CarouselViewItemModel, object>, string>[1]
			{
				new Tuple<Func<CarouselViewItemModel, object>, string>((CarouselViewItemModel source) => source, "LinkText")
			})
			{
				Converter = extension.Converter
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension14(BindingExtension extension)
		{
			Action<CarouselViewItemModel, string> setter = delegate(CarouselViewItemModel source, string? value)
			{
				source.LinkText = value;
			};
			return new TypedBinding<CarouselViewItemModel, string>((CarouselViewItemModel source) => (value: source.LinkText, success: true), setter, new Tuple<Func<CarouselViewItemModel, object>, string>[1]
			{
				new Tuple<Func<CarouselViewItemModel, object>, string>((CarouselViewItemModel source) => source, "LinkText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension15(BindingExtension extension)
		{
			Action<CarouselViewItemModel, ICommand> setter = delegate(CarouselViewItemModel source, ICommand? value)
			{
				source.Command = value;
			};
			return new TypedBinding<CarouselViewItemModel, ICommand>((CarouselViewItemModel source) => (value: source.Command, success: true), setter, new Tuple<Func<CarouselViewItemModel, object>, string>[1]
			{
				new Tuple<Func<CarouselViewItemModel, object>, string>((CarouselViewItemModel source) => source, "Command")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension16(BindingExtension extension)
		{
			Action<CarouselViewItemModel, bool> setter = null;
			return new TypedBinding<CarouselViewItemModel, bool>((CarouselViewItemModel source) => (value: source.IsInAccessibleTree, success: true), setter, new Tuple<Func<CarouselViewItemModel, object>, string>[1]
			{
				new Tuple<Func<CarouselViewItemModel, object>, string>((CarouselViewItemModel source) => source, "IsInAccessibleTree")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension17(BindingExtension extension)
		{
			Action<CarouselViewItemModel, bool> setter = null;
			return new TypedBinding<CarouselViewItemModel, bool>((CarouselViewItemModel source) => (value: source.IsImage, success: true), setter, new Tuple<Func<CarouselViewItemModel, object>, string>[1]
			{
				new Tuple<Func<CarouselViewItemModel, object>, string>((CarouselViewItemModel source) => source, "IsImage")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension18(BindingExtension extension)
		{
			Action<CarouselViewItemModel, string> setter = delegate(CarouselViewItemModel source, string? value)
			{
				source.AlternateText = value;
			};
			return new TypedBinding<CarouselViewItemModel, string>((CarouselViewItemModel source) => (value: source.AlternateText, success: true), setter, new Tuple<Func<CarouselViewItemModel, object>, string>[1]
			{
				new Tuple<Func<CarouselViewItemModel, object>, string>((CarouselViewItemModel source) => source, "AlternateText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension19(BindingExtension extension)
		{
			Action<CarouselViewItemModel, string> setter = delegate(CarouselViewItemModel source, string? value)
			{
				source.Source = value;
			};
			return new TypedBinding<CarouselViewItemModel, string>((CarouselViewItemModel source) => (value: source.Source, success: true), setter, new Tuple<Func<CarouselViewItemModel, object>, string>[1]
			{
				new Tuple<Func<CarouselViewItemModel, object>, string>((CarouselViewItemModel source) => source, "Source")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<HLP010ViewModel, bool> setter = null;
			return new TypedBinding<HLP010ViewModel, bool>((HLP010ViewModel source) => (value: source.IndicatorVisible, success: true), setter, new Tuple<Func<HLP010ViewModel, object>, string>[1]
			{
				new Tuple<Func<HLP010ViewModel, object>, string>((HLP010ViewModel source) => source, "IndicatorVisible")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension20(BindingExtension extension)
		{
			Action<CarouselViewItemModel, bool> setter = null;
			return new TypedBinding<CarouselViewItemModel, bool>((CarouselViewItemModel source) => (value: source.IsInAccessibleTree, success: true), setter, new Tuple<Func<CarouselViewItemModel, object>, string>[1]
			{
				new Tuple<Func<CarouselViewItemModel, object>, string>((CarouselViewItemModel source) => source, "IsInAccessibleTree")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension21(BindingExtension extension)
		{
			Action<CarouselViewItemModel, bool> setter = null;
			return new TypedBinding<CarouselViewItemModel, bool>((CarouselViewItemModel source) => (value: source.IsImage, success: true), setter, new Tuple<Func<CarouselViewItemModel, object>, string>[1]
			{
				new Tuple<Func<CarouselViewItemModel, object>, string>((CarouselViewItemModel source) => source, "IsImage")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension22(BindingExtension extension)
		{
			Action<CarouselViewItemModel, bool> setter = delegate(CarouselViewItemModel source, bool value)
			{
				source.IsPlaying = value;
			};
			return new TypedBinding<CarouselViewItemModel, bool>((CarouselViewItemModel source) => (value: source.IsPlaying, success: true), setter, new Tuple<Func<CarouselViewItemModel, object>, string>[1]
			{
				new Tuple<Func<CarouselViewItemModel, object>, string>((CarouselViewItemModel source) => source, "IsPlaying")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension25(BindingExtension extension)
		{
			Action<CarouselViewItemModel, TimeSpan> setter = delegate(CarouselViewItemModel source, TimeSpan value)
			{
				source.Progress = value;
			};
			return new TypedBinding<CarouselViewItemModel, TimeSpan>((CarouselViewItemModel source) => (value: source.Progress, success: true), setter, new Tuple<Func<CarouselViewItemModel, object>, string>[1]
			{
				new Tuple<Func<CarouselViewItemModel, object>, string>((CarouselViewItemModel source) => source, "Progress")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension26(BindingExtension extension)
		{
			Action<CarouselViewItemModel, string> setter = delegate(CarouselViewItemModel source, string? value)
			{
				source.AlternateText = value;
			};
			return new TypedBinding<CarouselViewItemModel, string>((CarouselViewItemModel source) => (value: source.AlternateText, success: true), setter, new Tuple<Func<CarouselViewItemModel, object>, string>[1]
			{
				new Tuple<Func<CarouselViewItemModel, object>, string>((CarouselViewItemModel source) => source, "AlternateText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension27(BindingExtension extension)
		{
			Action<CarouselViewItemModel, SKFileLottieImageSource> setter = null;
			return new TypedBinding<CarouselViewItemModel, SKFileLottieImageSource>((CarouselViewItemModel source) => (value: source.AnimationSource, success: true), setter, new Tuple<Func<CarouselViewItemModel, object>, string>[1]
			{
				new Tuple<Func<CarouselViewItemModel, object>, string>((CarouselViewItemModel source) => source, "AnimationSource")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension28(BindingExtension extension)
		{
			Action<HLP010ViewModel, ICommand> setter = null;
			return new TypedBinding<HLP010ViewModel, ICommand>((HLP010ViewModel source) => ((ICommand value, bool success))(value: source.ScrollCommand, success: true), setter, new Tuple<Func<HLP010ViewModel, object>, string>[1]
			{
				new Tuple<Func<HLP010ViewModel, object>, string>((HLP010ViewModel source) => source, "ScrollCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension29(BindingExtension extension)
		{
			Action<HLP010ViewModel, ICommand> setter = null;
			return new TypedBinding<HLP010ViewModel, ICommand>((HLP010ViewModel source) => ((ICommand value, bool success))(value: source.PreviousCommand, success: true), setter, new Tuple<Func<HLP010ViewModel, object>, string>[1]
			{
				new Tuple<Func<HLP010ViewModel, object>, string>((HLP010ViewModel source) => source, "PreviousCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<HLP010ViewModel, int> setter = delegate(HLP010ViewModel source, int value)
			{
				source.CurrentIndex = value;
			};
			return new TypedBinding<HLP010ViewModel, int>((HLP010ViewModel source) => (value: source.CurrentIndex, success: true), setter, new Tuple<Func<HLP010ViewModel, object>, string>[1]
			{
				new Tuple<Func<HLP010ViewModel, object>, string>((HLP010ViewModel source) => source, "CurrentIndex")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension30(BindingExtension extension)
		{
			Action<HLP010ViewModel, bool> setter = null;
			return new TypedBinding<HLP010ViewModel, bool>((HLP010ViewModel source) => (value: source.PreviousEnabled, success: true), setter, new Tuple<Func<HLP010ViewModel, object>, string>[1]
			{
				new Tuple<Func<HLP010ViewModel, object>, string>((HLP010ViewModel source) => source, "PreviousEnabled")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension31(BindingExtension extension)
		{
			Action<HLP010ViewModel, ICommand> setter = null;
			return new TypedBinding<HLP010ViewModel, ICommand>((HLP010ViewModel source) => ((ICommand value, bool success))(value: source.NextCommand, success: true), setter, new Tuple<Func<HLP010ViewModel, object>, string>[1]
			{
				new Tuple<Func<HLP010ViewModel, object>, string>((HLP010ViewModel source) => source, "NextCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension32(BindingExtension extension)
		{
			Action<HLP010ViewModel, string> setter = null;
			return new TypedBinding<HLP010ViewModel, string>((HLP010ViewModel source) => (value: source.NextButtonText, success: true), setter, new Tuple<Func<HLP010ViewModel, object>, string>[1]
			{
				new Tuple<Func<HLP010ViewModel, object>, string>((HLP010ViewModel source) => source, "NextButtonText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<HLP010ViewModel, List<CarouselViewItemModel>> setter = delegate(HLP010ViewModel source, List<CarouselViewItemModel> value)
			{
				source.Items = value;
			};
			return new TypedBinding<HLP010ViewModel, List<CarouselViewItemModel>>((HLP010ViewModel source) => (value: source.Items, success: true), setter, new Tuple<Func<HLP010ViewModel, object>, string>[1]
			{
				new Tuple<Func<HLP010ViewModel, object>, string>((HLP010ViewModel source) => source, "Items")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<HLP010ViewModel, int> setter = delegate(HLP010ViewModel source, int value)
			{
				source.CurrentIndex = value;
			};
			return new TypedBinding<HLP010ViewModel, int>((HLP010ViewModel source) => (value: source.CurrentIndex, success: true), setter, new Tuple<Func<HLP010ViewModel, object>, string>[1]
			{
				new Tuple<Func<HLP010ViewModel, object>, string>((HLP010ViewModel source) => source, "CurrentIndex")
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
	[MemberNotNull("Popup")]
	[MemberNotNull("popup")]
	[MemberNotNull("indicatorView")]
	[MemberNotNull("carouselView")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(HLP010));
		Popup = this.FindByName<BasePopup<HLP010ViewModel>>("Popup");
		popup = this.FindByName<Border>("popup");
		indicatorView = this.FindByName<IndicatorView>("indicatorView");
		carouselView = this.FindByName<CarouselView>("carouselView");
	}
}
