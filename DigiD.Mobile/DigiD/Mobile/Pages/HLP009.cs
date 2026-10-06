using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Maui.Converters;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Resources;
using DigiD.Mobile.Models;
using DigiD.Mobile.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using SkiaSharp.Extended.UI.Controls;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.Pages;

[XamlFilePath("Pages\\HLP009.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class HLP009 : BasePage<HLP009ViewModel>
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Microsoft.Maui.Controls.ScrollView Container;

	public HLP009(HLP009ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
		Microsoft.Maui.Controls.NavigationPage.SetHasNavigationBar(this, value: true);
		viewModel.ResetFocus += BindingContextOnResetFocus;
	}

	private async void BindingContextOnResetFocus(object? sender, EventArgs e)
	{
		try
		{
			VerticalStackLayout pnl = ((StackBase)Container.Content).Children[base.BindingContext.CurrentIndex] as VerticalStackLayout;
			Label headerLabel = pnl.FindByName<Label>("HeaderLabel");
			if (headerLabel != null)
			{
				await Task.Delay(200);
				headerLabel.SetSemanticFocus();
			}
		}
		catch (Exception)
		{
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("Container")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(HLP009).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(HLP009)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		DynamicResource dynamicResource = new DynamicResource("AppPageBackground");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 5);
		OnPlatformExtension onPlatformExtension = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 17);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 17);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 17);
		OnPlatformExtension onPlatformExtension2 = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension2, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 17);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 17);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 17);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 17);
		IndicatorView indicatorView = new IndicatorView();
		VisualDiagnostics.RegisterSourceInfo(indicatorView, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 14);
		OnPlatformExtension onPlatformExtension3 = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension3, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 17);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 17);
		DynamicResource dynamicResource2 = new DynamicResource("ImageButtonSluiten");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource2, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 17);
		ImageButton imageButton = new ImageButton();
		VisualDiagnostics.RegisterSourceInfo(imageButton, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 10);
		IsStringNotNullOrEmptyConverter isStringNotNullOrEmptyConverter = new IsStringNotNullOrEmptyConverter();
		VisualDiagnostics.RegisterSourceInfo(isStringNotNullOrEmptyConverter, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 44, 10);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 55, 34);
		DataTemplate dataTemplate = new DataTemplate();
		VisualDiagnostics.RegisterSourceInfo(dataTemplate, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 57, 22);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 55, 14);
		Microsoft.Maui.Controls.ScrollView scrollView = new Microsoft.Maui.Controls.ScrollView();
		VisualDiagnostics.RegisterSourceInfo(scrollView, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 51, 10);
		BindingExtension bindingExtension6 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 111, 13);
		BindingExtension bindingExtension7 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension7, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 112, 13);
		string alg_Previous = CommonResources.Alg_Previous;
		VisualDiagnostics.RegisterSourceInfo(alg_Previous, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 113, 13);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 107, 10);
		BindingExtension bindingExtension8 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension8, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 118, 13);
		BindingExtension bindingExtension9 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension9, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 119, 13);
		BorderedButton borderedButton2 = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton2, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 115, 10);
		Grid grid2 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid2, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 46, 6);
		HLP009 __root = this;
		VisualDiagnostics.RegisterSourceInfo(__root, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope iNameScope = NameScope.GetNameScope(__root) ?? new NameScope();
		NameScope.SetNameScope(__root, iNameScope);
		grid.transientNamescope = iNameScope;
		indicatorView.transientNamescope = iNameScope;
		imageButton.transientNamescope = iNameScope;
		grid2.transientNamescope = iNameScope;
		scrollView.transientNamescope = iNameScope;
		iNameScope.RegisterName("Container", scrollView);
		Microsoft.Maui.Controls.ScrollView scrollView2 = scrollView;
		if (scrollView2.StyleId == null)
		{
			string text = (scrollView2.StyleId = "Container");
		}
		verticalStackLayout.transientNamescope = iNameScope;
		borderedButton.transientNamescope = iNameScope;
		borderedButton2.transientNamescope = iNameScope;
		Container = scrollView;
		__root.SetValue(Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific.Page.ModalPresentationStyleProperty, UIModalPresentationStyle.PageSheet);
		((IDynamicResourceHandler)__root).SetDynamicResource(Microsoft.Maui.Controls.VisualElement.BackgroundColorProperty, dynamicResource.Key);
		grid.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
		indicatorView.SetValue(Grid.ColumnSpanProperty, 2);
		onPlatformExtension.Android = "-16,0,0,0";
		onPlatformExtension.iOS = "0,0,0,0";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(__root);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[3] { indicatorView, grid, __root }, View.MarginProperty, new INameScope[1] { iNameScope }, __root);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(21, 17)));
		object obj = ((IMarkupExtension)onPlatformExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 17);
		}
		indicatorView.SetValue(View.MarginProperty, obj);
		indicatorView.SetValue(Element.AutomationIdProperty, "IndicatorView");
		indicatorView.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
		staticResourceExtension.Key = "PrimaryColorTransparent";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(__root);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[3] { indicatorView, grid, __root }, IndicatorView.IndicatorColorProperty, new INameScope[1] { iNameScope }, __root);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(25, 17)));
		object obj2 = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 17);
		}
		indicatorView.SetValue(IndicatorView.IndicatorColorProperty, obj2);
		bindingExtension.Path = "IndicatorVisible";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 17);
		}
		onPlatformExtension2.Android = bindingBase;
		onPlatformExtension2.iOS = "True";
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(__root);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[3] { indicatorView, grid, __root }, Microsoft.Maui.Controls.VisualElement.IsVisibleProperty, new INameScope[1] { iNameScope }, __root);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(26, 17)));
		object obj3 = ((IMarkupExtension)onPlatformExtension2).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 17);
		}
		indicatorView.SetValue(Microsoft.Maui.Controls.VisualElement.IsVisibleProperty, obj3);
		bindingExtension2.Path = "Items";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 17);
		}
		indicatorView.SetBinding(IndicatorView.ItemsSourceProperty, bindingBase2);
		bindingExtension3.Path = "CurrentIndex";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 17);
		}
		indicatorView.SetBinding(IndicatorView.PositionProperty, bindingBase3);
		staticResourceExtension2.Key = "PrimaryColor";
		XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider(__root);
		SimpleValueTargetProvider service4 = new SimpleValueTargetProvider(new object[3] { indicatorView, grid, __root }, IndicatorView.SelectedIndicatorColorProperty, new INameScope[1] { iNameScope }, __root);
		xamlServiceProvider4.Add(typeof(IReferenceProvider), service4);
		xamlServiceProvider4.Add(typeof(IProvideValueTarget), service4);
		xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(30, 17)));
		object obj4 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider4);
		if (VisualDiagnostics.GetSourceInfo(obj4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj4, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 17);
		}
		indicatorView.SetValue(IndicatorView.SelectedIndicatorColorProperty, obj4);
		indicatorView.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		indicatorView.SetValue(Microsoft.Maui.Controls.VisualElement.ZIndexProperty, 5);
		grid.Children.Add(indicatorView);
		imageButton.SetValue(Grid.ColumnProperty, 2);
		onPlatformExtension3.Android = "0,0,10,0";
		onPlatformExtension3.iOS = "0,0,0,0";
		XamlServiceProvider xamlServiceProvider5 = new XamlServiceProvider(__root);
		SimpleValueTargetProvider service5 = new SimpleValueTargetProvider(new object[3] { imageButton, grid, __root }, View.MarginProperty, new INameScope[1] { iNameScope }, __root);
		xamlServiceProvider5.Add(typeof(IReferenceProvider), service5);
		xamlServiceProvider5.Add(typeof(IProvideValueTarget), service5);
		xamlServiceProvider5.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(36, 17)));
		object obj5 = ((IMarkupExtension)onPlatformExtension3).ProvideValue((IServiceProvider)xamlServiceProvider5);
		if (VisualDiagnostics.GetSourceInfo(obj5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj5, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 17);
		}
		imageButton.SetValue(View.MarginProperty, obj5);
		imageButton.SetValue(Element.AutomationIdProperty, "MainCloseButton");
		bindingExtension4.Path = "CloseCommand";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 17);
		}
		imageButton.SetBinding(ImageButton.CommandProperty, bindingBase4);
		((IDynamicResourceHandler)imageButton).SetDynamicResource(ImageButton.SourceProperty, dynamicResource2.Key);
		grid.Children.Add(imageButton);
		__root.SetValue(Microsoft.Maui.Controls.NavigationPage.TitleViewProperty, grid);
		ICommunityToolkitValueConverter communityToolkitValueConverter = ((IMarkupExtension<ICommunityToolkitValueConverter>)isStringNotNullOrEmptyConverter).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(communityToolkitValueConverter) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(communityToolkitValueConverter, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 44, 10);
		}
		__root.Resources["IsStringNotNullOrEmptyConverter"] = communityToolkitValueConverter;
		grid2.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid2.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto)));
		grid2.SetValue(Grid.RowSpacingProperty, 20.0);
		scrollView.SetValue(Grid.RowProperty, 0);
		scrollView.SetValue(Microsoft.Maui.Controls.VisualElement.ZIndexProperty, 5);
		bindingExtension5.Path = "Items";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension5(bindingExtension5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 55, 34);
		}
		verticalStackLayout.SetBinding(BindableLayout.ItemsSourceProperty, bindingBase5);
		dataTemplate.LoadTemplate = delegate
		{
			BindingExtension bindingExtension10 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension10, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 61, 29);
			StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension();
			VisualDiagnostics.RegisterSourceInfo(staticResourceExtension3, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 65, 33);
			BindingExtension bindingExtension11 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension11, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 66, 33);
			Label label = new Label();
			VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 63, 30);
			BindingExtension bindingExtension12 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension12, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 69, 36);
			Label label2 = new Label();
			VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 69, 30);
			StaticResourceExtension staticResourceExtension4 = new StaticResourceExtension();
			VisualDiagnostics.RegisterSourceInfo(staticResourceExtension4, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 73, 33);
			BindingExtension bindingExtension13 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension13, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 73, 33);
			StaticResourceExtension staticResourceExtension5 = new StaticResourceExtension();
			VisualDiagnostics.RegisterSourceInfo(staticResourceExtension5, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 74, 33);
			BindingExtension bindingExtension14 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension14, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 75, 33);
			BindingExtension bindingExtension15 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension15, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 78, 59);
			TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
			VisualDiagnostics.RegisterSourceInfo(tapGestureRecognizer, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 78, 38);
			Label label3 = new Label();
			VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 71, 30);
			BindingExtension bindingExtension16 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension16, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 83, 33);
			BindingExtension bindingExtension17 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension17, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 84, 33);
			BindingExtension bindingExtension18 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension18, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 86, 33);
			BindingExtension bindingExtension19 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension19, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 87, 33);
			Image image = new Image();
			VisualDiagnostics.RegisterSourceInfo(image, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 82, 30);
			BindingExtension bindingExtension20 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension20, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 91, 33);
			BindingExtension bindingExtension21 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension21, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 92, 33);
			BindingExtension bindingExtension22 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension22, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 93, 33);
			ReferenceExtension referenceExtension = new ReferenceExtension();
			VisualDiagnostics.RegisterSourceInfo(referenceExtension, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 94, 33);
			BindingExtension bindingExtension23 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension23, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 94, 33);
			ReferenceExtension referenceExtension2 = new ReferenceExtension();
			VisualDiagnostics.RegisterSourceInfo(referenceExtension2, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 96, 33);
			BindingExtension bindingExtension24 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension24, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 96, 33);
			BindingExtension bindingExtension25 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension25, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 97, 33);
			BindingExtension bindingExtension26 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension26, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 98, 33);
			BindingExtension bindingExtension27 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension27, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 99, 33);
			CustomAnimationView customAnimationView = new CustomAnimationView();
			VisualDiagnostics.RegisterSourceInfo(customAnimationView, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 90, 30);
			VerticalStackLayout verticalStackLayout2 = new VerticalStackLayout();
			VisualDiagnostics.RegisterSourceInfo(verticalStackLayout2, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 58, 26);
			INameScope nameScope = new NameScope();
			NameScope.SetNameScope(verticalStackLayout2, nameScope);
			nameScope.RegisterName("container", verticalStackLayout2);
			VerticalStackLayout verticalStackLayout3 = verticalStackLayout2;
			if (verticalStackLayout3.StyleId == null)
			{
				string text3 = (verticalStackLayout3.StyleId = "container");
			}
			label.transientNamescope = nameScope;
			nameScope.RegisterName("HeaderLabel", label);
			Label label4 = label;
			if (label4.StyleId == null)
			{
				string text3 = (label4.StyleId = "HeaderLabel");
			}
			label2.transientNamescope = nameScope;
			label3.transientNamescope = nameScope;
			tapGestureRecognizer.transientNamescope = nameScope;
			image.transientNamescope = nameScope;
			customAnimationView.transientNamescope = nameScope;
			verticalStackLayout2.SetValue(AutomationProperties.ExcludedWithChildrenProperty, false);
			bindingExtension10.Path = "IsVisible";
			BindingBase bindingBase10 = CreateTypedBindingFrom_bindingExtension9(bindingExtension10);
			if (VisualDiagnostics.GetSourceInfo(bindingBase10) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase10, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 61, 29);
			}
			verticalStackLayout2.SetBinding(Microsoft.Maui.Controls.VisualElement.IsVisibleProperty, bindingBase10);
			verticalStackLayout2.SetValue(StackBase.SpacingProperty, 20.0);
			staticResourceExtension3.Key = "LabelHeader";
			XamlServiceProvider xamlServiceProvider6 = new XamlServiceProvider(this);
			SimpleValueTargetProvider service6 = new SimpleValueTargetProvider(new object[7] { label, verticalStackLayout2, dataTemplate, verticalStackLayout, scrollView, grid2, __root }, Microsoft.Maui.Controls.VisualElement.StyleProperty, new INameScope[2] { nameScope, iNameScope }, this);
			xamlServiceProvider6.Add(typeof(IReferenceProvider), service6);
			xamlServiceProvider6.Add(typeof(IProvideValueTarget), service6);
			xamlServiceProvider6.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(65, 33)));
			object obj6 = ((IMarkupExtension)staticResourceExtension3).ProvideValue((IServiceProvider)xamlServiceProvider6);
			if (VisualDiagnostics.GetSourceInfo(obj6) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(obj6, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 65, 33);
			}
			label.SetValue(Microsoft.Maui.Controls.VisualElement.StyleProperty, obj6);
			bindingExtension11.Path = "TitleText";
			BindingBase bindingBase11 = CreateTypedBindingFrom_bindingExtension10(bindingExtension11);
			if (VisualDiagnostics.GetSourceInfo(bindingBase11) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase11, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 66, 33);
			}
			label.SetBinding(Label.TextProperty, bindingBase11);
			label.SetValue(Microsoft.Maui.Controls.VisualElement.ZIndexProperty, 10);
			verticalStackLayout2.Children.Add(label);
			bindingExtension12.Path = "BodyText";
			BindingBase bindingBase12 = CreateTypedBindingFrom_bindingExtension11(bindingExtension12);
			if (VisualDiagnostics.GetSourceInfo(bindingBase12) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase12, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 69, 36);
			}
			label2.SetBinding(Label.TextProperty, bindingBase12);
			label2.SetValue(Microsoft.Maui.Controls.VisualElement.ZIndexProperty, 10);
			verticalStackLayout2.Children.Add(label2);
			label3.SetValue(View.MarginProperty, new Thickness(0.0, -10.0, 0.0, 0.0));
			staticResourceExtension4.Key = "IsStringNotNullOrEmptyConverter";
			XamlServiceProvider xamlServiceProvider7 = new XamlServiceProvider(this);
			SimpleValueTargetProvider service7 = new SimpleValueTargetProvider(new object[8] { bindingExtension13, label3, verticalStackLayout2, dataTemplate, verticalStackLayout, scrollView, grid2, __root }, typeof(BindingExtension).GetProperty("Converter"), new INameScope[2] { nameScope, iNameScope }, this);
			xamlServiceProvider7.Add(typeof(IReferenceProvider), service7);
			xamlServiceProvider7.Add(typeof(IProvideValueTarget), service7);
			xamlServiceProvider7.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(73, 33)));
			object obj7 = ((IMarkupExtension)staticResourceExtension4).ProvideValue((IServiceProvider)xamlServiceProvider7);
			if (VisualDiagnostics.GetSourceInfo(obj7) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(obj7, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 73, 33);
			}
			bindingExtension13.Converter = (IValueConverter)obj7;
			bindingExtension13.Path = "LinkText";
			BindingBase bindingBase13 = CreateTypedBindingFrom_bindingExtension12(bindingExtension13);
			if (VisualDiagnostics.GetSourceInfo(bindingBase13) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase13, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 73, 33);
			}
			label3.SetBinding(Microsoft.Maui.Controls.VisualElement.IsVisibleProperty, bindingBase13);
			staticResourceExtension5.Key = "LabelAsLinkStyle";
			XamlServiceProvider xamlServiceProvider8 = new XamlServiceProvider(this);
			SimpleValueTargetProvider service8 = new SimpleValueTargetProvider(new object[7] { label3, verticalStackLayout2, dataTemplate, verticalStackLayout, scrollView, grid2, __root }, Microsoft.Maui.Controls.VisualElement.StyleProperty, new INameScope[2] { nameScope, iNameScope }, this);
			xamlServiceProvider8.Add(typeof(IReferenceProvider), service8);
			xamlServiceProvider8.Add(typeof(IProvideValueTarget), service8);
			xamlServiceProvider8.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(74, 33)));
			object obj8 = ((IMarkupExtension)staticResourceExtension5).ProvideValue((IServiceProvider)xamlServiceProvider8);
			if (VisualDiagnostics.GetSourceInfo(obj8) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(obj8, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 74, 33);
			}
			label3.SetValue(Microsoft.Maui.Controls.VisualElement.StyleProperty, obj8);
			bindingExtension14.Path = "LinkText";
			BindingBase bindingBase14 = CreateTypedBindingFrom_bindingExtension13(bindingExtension14);
			if (VisualDiagnostics.GetSourceInfo(bindingBase14) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase14, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 75, 33);
			}
			label3.SetBinding(Label.TextProperty, bindingBase14);
			label3.SetValue(Microsoft.Maui.Controls.VisualElement.ZIndexProperty, 10);
			bindingExtension15.Path = "Command";
			BindingBase bindingBase15 = CreateTypedBindingFrom_bindingExtension14(bindingExtension15);
			if (VisualDiagnostics.GetSourceInfo(bindingBase15) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase15, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 78, 59);
			}
			tapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, bindingBase15);
			label3.GestureRecognizers.Add(tapGestureRecognizer);
			verticalStackLayout2.Children.Add(label3);
			bindingExtension16.Path = "IsInAccessibleTree";
			BindingBase bindingBase16 = CreateTypedBindingFrom_bindingExtension15(bindingExtension16);
			if (VisualDiagnostics.GetSourceInfo(bindingBase16) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase16, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 83, 33);
			}
			image.SetBinding(AutomationProperties.IsInAccessibleTreeProperty, bindingBase16);
			bindingExtension17.Path = "IsImage";
			BindingBase bindingBase17 = CreateTypedBindingFrom_bindingExtension16(bindingExtension17);
			if (VisualDiagnostics.GetSourceInfo(bindingBase17) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase17, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 84, 33);
			}
			image.SetBinding(Microsoft.Maui.Controls.VisualElement.IsVisibleProperty, bindingBase17);
			image.SetValue(Microsoft.Maui.Controls.VisualElement.MinimumHeightRequestProperty, 200.0);
			bindingExtension18.Path = "AlternateText";
			BindingBase bindingBase18 = CreateTypedBindingFrom_bindingExtension17(bindingExtension18);
			if (VisualDiagnostics.GetSourceInfo(bindingBase18) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase18, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 86, 33);
			}
			image.SetBinding(SemanticProperties.DescriptionProperty, bindingBase18);
			bindingExtension19.Path = "Source";
			BindingBase bindingBase19 = CreateTypedBindingFrom_bindingExtension18(bindingExtension19);
			if (VisualDiagnostics.GetSourceInfo(bindingBase19) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase19, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 87, 33);
			}
			image.SetBinding(Image.SourceProperty, bindingBase19);
			image.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
			verticalStackLayout2.Children.Add(image);
			bindingExtension20.Path = "IsInAccessibleTree";
			BindingBase bindingBase20 = CreateTypedBindingFrom_bindingExtension19(bindingExtension20);
			if (VisualDiagnostics.GetSourceInfo(bindingBase20) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase20, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 91, 33);
			}
			customAnimationView.SetBinding(AutomationProperties.IsInAccessibleTreeProperty, bindingBase20);
			bindingExtension21.Path = "IsImage";
			BindingBase bindingBase21 = CreateTypedBindingFrom_bindingExtension20(bindingExtension21);
			if (VisualDiagnostics.GetSourceInfo(bindingBase21) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase21, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 92, 33);
			}
			customAnimationView.SetBinding(CustomAnimationView.HideAnimationProperty, bindingBase21);
			bindingExtension22.Path = "IsPlaying";
			BindingBase bindingBase22 = CreateTypedBindingFrom_bindingExtension21(bindingExtension22);
			if (VisualDiagnostics.GetSourceInfo(bindingBase22) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase22, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 93, 33);
			}
			customAnimationView.SetBinding(SKAnimatedSurfaceView.IsAnimationEnabledProperty, bindingBase22);
			referenceExtension.Name = "container";
			VerticalStackLayout verticalStackLayout4 = verticalStackLayout2;
			if (VisualDiagnostics.GetSourceInfo(verticalStackLayout4) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(verticalStackLayout4, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 94, 33);
			}
			bindingExtension23.Source = verticalStackLayout4;
			bindingExtension23.Path = "WidthRequest";
			Binding binding = new Binding(bindingExtension23.Path, bindingExtension23.Mode, bindingExtension23.Converter, bindingExtension23.ConverterParameter, bindingExtension23.StringFormat, bindingExtension23.Source)
			{
				UpdateSourceEventName = bindingExtension23.UpdateSourceEventName,
				FallbackValue = bindingExtension23.FallbackValue,
				TargetNullValue = bindingExtension23.TargetNullValue
			};
			if (VisualDiagnostics.GetSourceInfo(binding) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(binding, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 94, 33);
			}
			customAnimationView.SetBinding(Microsoft.Maui.Controls.VisualElement.MaximumWidthRequestProperty, binding);
			customAnimationView.SetValue(Microsoft.Maui.Controls.VisualElement.MinimumHeightRequestProperty, 200.0);
			referenceExtension2.Name = "container";
			VerticalStackLayout verticalStackLayout5 = verticalStackLayout2;
			if (VisualDiagnostics.GetSourceInfo(verticalStackLayout5) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(verticalStackLayout5, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 96, 33);
			}
			bindingExtension24.Source = verticalStackLayout5;
			bindingExtension24.Path = "WidthRequest";
			Binding binding2 = new Binding(bindingExtension24.Path, bindingExtension24.Mode, bindingExtension24.Converter, bindingExtension24.ConverterParameter, bindingExtension24.StringFormat, bindingExtension24.Source)
			{
				UpdateSourceEventName = bindingExtension24.UpdateSourceEventName,
				FallbackValue = bindingExtension24.FallbackValue,
				TargetNullValue = bindingExtension24.TargetNullValue
			};
			if (VisualDiagnostics.GetSourceInfo(binding2) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(binding2, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 96, 33);
			}
			customAnimationView.SetBinding(Microsoft.Maui.Controls.VisualElement.MinimumWidthRequestProperty, binding2);
			bindingExtension25.Path = "Progress";
			BindingBase bindingBase23 = CreateTypedBindingFrom_bindingExtension24(bindingExtension25);
			if (VisualDiagnostics.GetSourceInfo(bindingBase23) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase23, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 97, 33);
			}
			customAnimationView.SetBinding(SKLottieView.ProgressProperty, bindingBase23);
			bindingExtension26.Path = "AlternateText";
			BindingBase bindingBase24 = CreateTypedBindingFrom_bindingExtension25(bindingExtension26);
			if (VisualDiagnostics.GetSourceInfo(bindingBase24) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase24, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 98, 33);
			}
			customAnimationView.SetBinding(SemanticProperties.DescriptionProperty, bindingBase24);
			bindingExtension27.Path = "AnimationSource";
			BindingBase bindingBase25 = CreateTypedBindingFrom_bindingExtension26(bindingExtension27);
			if (VisualDiagnostics.GetSourceInfo(bindingBase25) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase25, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 99, 33);
			}
			customAnimationView.SetBinding(SKLottieView.SourceProperty, bindingBase25);
			customAnimationView.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
			verticalStackLayout2.Children.Add(customAnimationView);
			return verticalStackLayout2;
		};
		verticalStackLayout.SetValue(BindableLayout.ItemTemplateProperty, dataTemplate);
		scrollView.Content = verticalStackLayout;
		grid2.Children.Add(scrollView);
		borderedButton.SetValue(Grid.RowProperty, 1);
		borderedButton.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 0.0, -5.0));
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension6.Path = "PreviousCommand";
		BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension27(bindingExtension6);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 111, 13);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase6);
		bindingExtension7.Path = "PreviousEnabled";
		BindingBase bindingBase7 = CreateTypedBindingFrom_bindingExtension28(bindingExtension7);
		if (VisualDiagnostics.GetSourceInfo(bindingBase7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase7, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 112, 13);
		}
		borderedButton.SetBinding(Microsoft.Maui.Controls.VisualElement.IsVisibleProperty, bindingBase7);
		borderedButton.SetValue(Button.TextProperty, alg_Previous);
		grid2.Children.Add(borderedButton);
		borderedButton2.SetValue(Grid.RowProperty, 2);
		borderedButton2.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension8.Path = "NextCommand";
		BindingBase bindingBase8 = CreateTypedBindingFrom_bindingExtension29(bindingExtension8);
		if (VisualDiagnostics.GetSourceInfo(bindingBase8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase8, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 118, 13);
		}
		borderedButton2.SetBinding(Button.CommandProperty, bindingBase8);
		bindingExtension9.Path = "NextButtonText";
		BindingBase bindingBase9 = CreateTypedBindingFrom_bindingExtension30(bindingExtension9);
		if (VisualDiagnostics.GetSourceInfo(bindingBase9) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase9, new Uri("Pages\\HLP009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 119, 13);
		}
		borderedButton2.SetBinding(Button.TextProperty, bindingBase9);
		grid2.Children.Add(borderedButton2);
		__root.SetValue(ContentPage.ContentProperty, grid2);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<HLP009ViewModel, bool> setter = null;
			return new TypedBinding<HLP009ViewModel, bool>((HLP009ViewModel source) => (value: source.IndicatorVisible, success: true), setter, new Tuple<Func<HLP009ViewModel, object>, string>[1]
			{
				new Tuple<Func<HLP009ViewModel, object>, string>((HLP009ViewModel source) => source, "IndicatorVisible")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension10(BindingExtension extension)
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
		static BindingBase CreateTypedBindingFrom_bindingExtension11(BindingExtension extension)
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
		static BindingBase CreateTypedBindingFrom_bindingExtension12(BindingExtension extension)
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
		static BindingBase CreateTypedBindingFrom_bindingExtension13(BindingExtension extension)
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
		static BindingBase CreateTypedBindingFrom_bindingExtension14(BindingExtension extension)
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
		static BindingBase CreateTypedBindingFrom_bindingExtension15(BindingExtension extension)
		{
			Action<CarouselViewItemModel, bool> setter = null;
			return new TypedBinding<CarouselViewItemModel, bool>((CarouselViewItemModel source) => (value: source.IsInAccessibleTree, success: true), setter, new Tuple<Func<CarouselViewItemModel, object>, string>[1]
			{
				new Tuple<Func<CarouselViewItemModel, object>, string>((CarouselViewItemModel source) => source, "IsInAccessibleTree")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension16(BindingExtension extension)
		{
			Action<CarouselViewItemModel, bool> setter = null;
			return new TypedBinding<CarouselViewItemModel, bool>((CarouselViewItemModel source) => (value: source.IsImage, success: true), setter, new Tuple<Func<CarouselViewItemModel, object>, string>[1]
			{
				new Tuple<Func<CarouselViewItemModel, object>, string>((CarouselViewItemModel source) => source, "IsImage")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension17(BindingExtension extension)
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
		static BindingBase CreateTypedBindingFrom_bindingExtension18(BindingExtension extension)
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
		static BindingBase CreateTypedBindingFrom_bindingExtension19(BindingExtension extension)
		{
			Action<CarouselViewItemModel, bool> setter = null;
			return new TypedBinding<CarouselViewItemModel, bool>((CarouselViewItemModel source) => (value: source.IsInAccessibleTree, success: true), setter, new Tuple<Func<CarouselViewItemModel, object>, string>[1]
			{
				new Tuple<Func<CarouselViewItemModel, object>, string>((CarouselViewItemModel source) => source, "IsInAccessibleTree")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<HLP009ViewModel, List<CarouselViewItemModel>> setter = delegate(HLP009ViewModel source, List<CarouselViewItemModel> value)
			{
				source.Items = value;
			};
			return new TypedBinding<HLP009ViewModel, List<CarouselViewItemModel>>((HLP009ViewModel source) => (value: source.Items, success: true), setter, new Tuple<Func<HLP009ViewModel, object>, string>[1]
			{
				new Tuple<Func<HLP009ViewModel, object>, string>((HLP009ViewModel source) => source, "Items")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension20(BindingExtension extension)
		{
			Action<CarouselViewItemModel, bool> setter = null;
			return new TypedBinding<CarouselViewItemModel, bool>((CarouselViewItemModel source) => (value: source.IsImage, success: true), setter, new Tuple<Func<CarouselViewItemModel, object>, string>[1]
			{
				new Tuple<Func<CarouselViewItemModel, object>, string>((CarouselViewItemModel source) => source, "IsImage")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension21(BindingExtension extension)
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
		static BindingBase CreateTypedBindingFrom_bindingExtension24(BindingExtension extension)
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
		static BindingBase CreateTypedBindingFrom_bindingExtension25(BindingExtension extension)
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
		static BindingBase CreateTypedBindingFrom_bindingExtension26(BindingExtension extension)
		{
			Action<CarouselViewItemModel, SKFileLottieImageSource> setter = null;
			return new TypedBinding<CarouselViewItemModel, SKFileLottieImageSource>((CarouselViewItemModel source) => (value: source.AnimationSource, success: true), setter, new Tuple<Func<CarouselViewItemModel, object>, string>[1]
			{
				new Tuple<Func<CarouselViewItemModel, object>, string>((CarouselViewItemModel source) => source, "AnimationSource")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension27(BindingExtension extension)
		{
			Action<HLP009ViewModel, ICommand> setter = null;
			return new TypedBinding<HLP009ViewModel, ICommand>((HLP009ViewModel source) => ((ICommand value, bool success))(value: source.PreviousCommand, success: true), setter, new Tuple<Func<HLP009ViewModel, object>, string>[1]
			{
				new Tuple<Func<HLP009ViewModel, object>, string>((HLP009ViewModel source) => source, "PreviousCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension28(BindingExtension extension)
		{
			Action<HLP009ViewModel, bool> setter = null;
			return new TypedBinding<HLP009ViewModel, bool>((HLP009ViewModel source) => (value: source.PreviousEnabled, success: true), setter, new Tuple<Func<HLP009ViewModel, object>, string>[1]
			{
				new Tuple<Func<HLP009ViewModel, object>, string>((HLP009ViewModel source) => source, "PreviousEnabled")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension29(BindingExtension extension)
		{
			Action<HLP009ViewModel, ICommand> setter = null;
			return new TypedBinding<HLP009ViewModel, ICommand>((HLP009ViewModel source) => ((ICommand value, bool success))(value: source.NextCommand, success: true), setter, new Tuple<Func<HLP009ViewModel, object>, string>[1]
			{
				new Tuple<Func<HLP009ViewModel, object>, string>((HLP009ViewModel source) => source, "NextCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<HLP009ViewModel, int> setter = delegate(HLP009ViewModel source, int value)
			{
				source.CurrentIndex = value;
			};
			return new TypedBinding<HLP009ViewModel, int>((HLP009ViewModel source) => (value: source.CurrentIndex, success: true), setter, new Tuple<Func<HLP009ViewModel, object>, string>[1]
			{
				new Tuple<Func<HLP009ViewModel, object>, string>((HLP009ViewModel source) => source, "CurrentIndex")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension30(BindingExtension extension)
		{
			Action<HLP009ViewModel, string> setter = null;
			return new TypedBinding<HLP009ViewModel, string>((HLP009ViewModel source) => (value: source.NextButtonText, success: true), setter, new Tuple<Func<HLP009ViewModel, object>, string>[1]
			{
				new Tuple<Func<HLP009ViewModel, object>, string>((HLP009ViewModel source) => source, "NextButtonText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<HLP009ViewModel, ICommand> setter = null;
			return new TypedBinding<HLP009ViewModel, ICommand>((HLP009ViewModel source) => ((ICommand value, bool success))(value: source.CloseCommand, success: true), setter, new Tuple<Func<HLP009ViewModel, object>, string>[1]
			{
				new Tuple<Func<HLP009ViewModel, object>, string>((HLP009ViewModel source) => source, "CloseCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<HLP009ViewModel, List<CarouselViewItemModel>> setter = delegate(HLP009ViewModel source, List<CarouselViewItemModel> value)
			{
				source.Items = value;
			};
			return new TypedBinding<HLP009ViewModel, List<CarouselViewItemModel>>((HLP009ViewModel source) => (value: source.Items, success: true), setter, new Tuple<Func<HLP009ViewModel, object>, string>[1]
			{
				new Tuple<Func<HLP009ViewModel, object>, string>((HLP009ViewModel source) => source, "Items")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension9(BindingExtension extension)
		{
			Action<CarouselViewItemModel, bool> setter = delegate(CarouselViewItemModel source, bool value)
			{
				source.IsVisible = value;
			};
			return new TypedBinding<CarouselViewItemModel, bool>((CarouselViewItemModel source) => (value: source.IsVisible, success: true), setter, new Tuple<Func<CarouselViewItemModel, object>, string>[1]
			{
				new Tuple<Func<CarouselViewItemModel, object>, string>((CarouselViewItemModel source) => source, "IsVisible")
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
	[MemberNotNull("Container")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(HLP009));
		Container = this.FindByName<Microsoft.Maui.Controls.ScrollView>("Container");
	}
}
