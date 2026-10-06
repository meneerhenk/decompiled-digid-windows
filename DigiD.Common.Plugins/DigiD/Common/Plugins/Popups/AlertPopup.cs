using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Interfaces;
using DigiD.Common.Plugins.ViewModels;
using DigiD.Common.Resources;
using LocalizationResourceManager.Maui;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Graphics;
using Syncfusion.Maui.ProgressBar;

namespace DigiD.Common.Plugins.Popups;

[XamlFilePath("Popups\\AlertPopup.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
public class AlertPopup : BasePopup<AlertPopupViewModel>
{
	private readonly IA11YService a11YService;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private ScrollView popupScrollView;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Grid popupGrid;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Border popupBorder;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Grid popup;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private VerticalStackLayout popupContent;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private ImageButton CloseButton;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label AlertPopupTitle;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label AlertMessage;

	public AlertPopup(IA11YService a11YService)
		: base((AlertPopupViewModel?)null)
	{
		this.a11YService = a11YService;
		InitializeComponent();
		SetSize();
		base.SizeChanged += delegate
		{
			SetSize();
		};
	}

	private void SetSize()
	{
		int num = 400;
		double horizontalThickness = popupScrollView.Padding.HorizontalThickness;
		popupBorder.WidthRequest = (double)num - horizontalThickness * 2.0;
		popup.WidthRequest = popupBorder.WidthRequest - popupBorder.Padding.HorizontalThickness;
		popupContent.WidthRequest = popup.WidthRequest;
	}

	private async void AlertPopup_OnLoaded(object? sender, EventArgs e)
	{
		try
		{
			if (a11YService.IsInVoiceOverMode && !CloseButton.IsVisible)
			{
				await Task.Delay(500);
				a11YService.NotifyForNewPage(AlertPopupTitle);
			}
		}
		catch
		{
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("popupScrollView")]
	[MemberNotNull("popupGrid")]
	[MemberNotNull("popupBorder")]
	[MemberNotNull("popup")]
	[MemberNotNull("popupContent")]
	[MemberNotNull("CloseButton")]
	[MemberNotNull("AlertPopupTitle")]
	[MemberNotNull("AlertMessage")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(AlertPopup).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(AlertPopup)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 16, 5);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 16, 5);
		OnPlatformExtension onPlatformExtension = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 16, 5);
		DynamicResource dynamicResource = new DynamicResource("AppPageBackground");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 33, 17);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 41, 25);
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension3, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 42, 25);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 43, 25);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 38, 22);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 53, 29);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 55, 29);
		TranslateExtension translateExtension = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 56, 29);
		DynamicResource dynamicResource2 = new DynamicResource("ImageButtonSluiten");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource2, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 57, 29);
		ImageButton imageButton = new ImageButton();
		VisualDiagnostics.RegisterSourceInfo(imageButton, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 50, 26);
		StaticResourceExtension staticResourceExtension4 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension4, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 61, 29);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 61, 29);
		BindingExtension bindingExtension6 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 62, 29);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 59, 26);
		StaticResourceExtension staticResourceExtension5 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension5, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 65, 32);
		BindingExtension bindingExtension7 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension7, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 66, 32);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 64, 26);
		StaticResourceExtension staticResourceExtension6 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension6, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 69, 32);
		BindingExtension bindingExtension8 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension8, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 69, 32);
		BindingExtension bindingExtension9 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension9, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 70, 32);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 68, 26);
		BindingExtension bindingExtension10 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension10, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 73, 29);
		string alg_SecondsToConfirmUpdate = CommonResources.Alg_SecondsToConfirmUpdate;
		VisualDiagnostics.RegisterSourceInfo(alg_SecondsToConfirmUpdate, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 75, 29);
		BindingExtension bindingExtension11 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension11, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 75, 29);
		BindingExtension bindingExtension12 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension12, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 82, 33);
		StaticResourceExtension staticResourceExtension7 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension7, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 85, 33);
		BindingExtension bindingExtension13 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension13, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 91, 41);
		Label label4 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label4, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 89, 38);
		SfCircularProgressBar sfCircularProgressBar = new SfCircularProgressBar();
		VisualDiagnostics.RegisterSourceInfo(sfCircularProgressBar, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 77, 30);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 72, 26);
		BindingExtension bindingExtension14 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension14, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 96, 38);
		BindingExtension bindingExtension15 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension15, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 100, 33);
		BindingExtension bindingExtension16 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension16, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 101, 33);
		BindingExtension bindingExtension17 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension17, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 102, 33);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 97, 30);
		BindingExtension bindingExtension18 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension18, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 108, 33);
		BindingExtension bindingExtension19 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension19, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 109, 33);
		BindingExtension bindingExtension20 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension20, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 110, 33);
		BorderedButton borderedButton2 = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton2, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 105, 30);
		StackLayout stackLayout = new StackLayout();
		VisualDiagnostics.RegisterSourceInfo(stackLayout, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 96, 26);
		VerticalStackLayout verticalStackLayout2 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout2, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 46, 22);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 37, 18);
		Border border = new Border();
		VisualDiagnostics.RegisterSourceInfo(border, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 30, 14);
		Grid grid2 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid2, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 23, 10);
		ScrollView scrollView = new ScrollView();
		VisualDiagnostics.RegisterSourceInfo(scrollView, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 18, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		scrollView.transientNamescope = nameScope;
		nameScope.RegisterName("popupScrollView", scrollView);
		ScrollView scrollView2 = scrollView;
		if (scrollView2.StyleId == null)
		{
			string text = (scrollView2.StyleId = "popupScrollView");
		}
		grid2.transientNamescope = nameScope;
		nameScope.RegisterName("popupGrid", grid2);
		Grid grid3 = grid2;
		if (grid3.StyleId == null)
		{
			string text = (grid3.StyleId = "popupGrid");
		}
		border.transientNamescope = nameScope;
		nameScope.RegisterName("popupBorder", border);
		Border border2 = border;
		if (border2.StyleId == null)
		{
			string text = (border2.StyleId = "popupBorder");
		}
		grid.transientNamescope = nameScope;
		nameScope.RegisterName("popup", grid);
		grid3 = grid;
		if (grid3.StyleId == null)
		{
			string text = (grid3.StyleId = "popup");
		}
		label.transientNamescope = nameScope;
		verticalStackLayout2.transientNamescope = nameScope;
		nameScope.RegisterName("popupContent", verticalStackLayout2);
		VerticalStackLayout verticalStackLayout3 = verticalStackLayout2;
		if (verticalStackLayout3.StyleId == null)
		{
			string text = (verticalStackLayout3.StyleId = "popupContent");
		}
		imageButton.transientNamescope = nameScope;
		nameScope.RegisterName("CloseButton", imageButton);
		ImageButton imageButton2 = imageButton;
		if (imageButton2.StyleId == null)
		{
			string text = (imageButton2.StyleId = "CloseButton");
		}
		image.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		nameScope.RegisterName("AlertPopupTitle", label2);
		Label label5 = label2;
		if (label5.StyleId == null)
		{
			string text = (label5.StyleId = "AlertPopupTitle");
		}
		label3.transientNamescope = nameScope;
		nameScope.RegisterName("AlertMessage", label3);
		label5 = label3;
		if (label5.StyleId == null)
		{
			string text = (label5.StyleId = "AlertMessage");
		}
		verticalStackLayout.transientNamescope = nameScope;
		((Element)(object)sfCircularProgressBar).transientNamescope = nameScope;
		label4.transientNamescope = nameScope;
		stackLayout.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		borderedButton2.transientNamescope = nameScope;
		popupScrollView = scrollView;
		popupGrid = grid2;
		popupBorder = border;
		popup = grid;
		popupContent = verticalStackLayout2;
		CloseButton = imageButton;
		AlertPopupTitle = label2;
		AlertMessage = label3;
		Loaded += AlertPopup_OnLoaded;
		staticResourceExtension.Key = "Black30Transparent";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[2] { onPlatformExtension, this }, typeof(OnPlatformExtension).GetProperty("Default"), new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(16, 5)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 16, 5);
		}
		onPlatformExtension.Default = obj;
		staticResourceExtension2.Key = "Black70Transparent";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[2] { onPlatformExtension, this }, typeof(OnPlatformExtension).GetProperty("iOS"), new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(16, 5)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 16, 5);
		}
		onPlatformExtension.iOS = obj2;
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[1] { this }, VisualElement.BackgroundColorProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(16, 5)));
		object obj3 = ((IMarkupExtension)onPlatformExtension).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 16, 5);
		}
		SetValue(VisualElement.BackgroundColorProperty, obj3);
		scrollView.SetValue(ScrollView.PaddingProperty, new Thickness(20.0, 0.0));
		scrollView.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
		scrollView.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		grid2.SetValue(VisualElement.BackgroundColorProperty, Colors.Transparent);
		grid2.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Auto)));
		grid2.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
		grid2.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto)));
		grid2.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		border.SetValue(Border.PaddingProperty, new Thickness(20.0));
		((IDynamicResourceHandler)border).SetDynamicResource(VisualElement.BackgroundColorProperty, dynamicResource.Key);
		border.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
		border.SetValue(Border.StrokeShapeProperty, new StrokeShapeTypeConverter().ConvertFromInvariantString("RoundRectangle 8") as IShape);
		border.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		label.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 10.0, 0.0));
		label.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		bindingExtension.Path = "PageLabelVisible";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 41, 25);
		}
		label.SetBinding(VisualElement.IsVisibleProperty, bindingBase);
		staticResourceExtension3.Key = "DemoBarPageLabel";
		XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service4 = new SimpleValueTargetProvider(new object[6] { label, grid, border, grid2, scrollView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider4.Add(typeof(IReferenceProvider), service4);
		xamlServiceProvider4.Add(typeof(IProvideValueTarget), service4);
		xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(42, 25)));
		object obj4 = ((IMarkupExtension)staticResourceExtension3).ProvideValue((IServiceProvider)xamlServiceProvider4);
		if (VisualDiagnostics.GetSourceInfo(obj4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj4, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 42, 25);
		}
		label.SetValue(VisualElement.StyleProperty, obj4);
		bindingExtension2.Path = "PageId";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 43, 25);
		}
		label.SetBinding(Label.TextProperty, bindingBase2);
		label.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
		label.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Start);
		grid.Children.Add(label);
		verticalStackLayout2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		verticalStackLayout2.SetValue(StackBase.SpacingProperty, 20.0);
		imageButton.SetValue(Element.AutomationIdProperty, "CloseButton");
		bindingExtension3.Path = "CancelCommand";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 53, 29);
		}
		imageButton.SetBinding(ImageButton.CommandProperty, bindingBase3);
		imageButton.SetValue(View.HorizontalOptionsProperty, LayoutOptions.End);
		bindingExtension4.Path = "CloseIconVisible";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 55, 29);
		}
		imageButton.SetBinding(VisualElement.IsVisibleProperty, bindingBase4);
		translateExtension.Text = "Alg_Close";
		BindingBase bindingBase5 = ((IMarkupExtension<BindingBase>)translateExtension).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 56, 29);
		}
		imageButton.SetBinding(SemanticProperties.DescriptionProperty, bindingBase5);
		((IDynamicResourceHandler)imageButton).SetDynamicResource(ImageButton.SourceProperty, dynamicResource2.Key);
		verticalStackLayout2.Children.Add(imageButton);
		image.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		staticResourceExtension4.Key = "IsNotNullConverter";
		XamlServiceProvider xamlServiceProvider5 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service5 = new SimpleValueTargetProvider(new object[8] { bindingExtension5, image, verticalStackLayout2, grid, border, grid2, scrollView, this }, typeof(BindingExtension).GetProperty("Converter"), new INameScope[1] { nameScope }, this);
		xamlServiceProvider5.Add(typeof(IReferenceProvider), service5);
		xamlServiceProvider5.Add(typeof(IProvideValueTarget), service5);
		xamlServiceProvider5.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(61, 29)));
		object obj5 = ((IMarkupExtension)staticResourceExtension4).ProvideValue((IServiceProvider)xamlServiceProvider5);
		if (VisualDiagnostics.GetSourceInfo(obj5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj5, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 61, 29);
		}
		bindingExtension5.Converter = (IValueConverter)obj5;
		bindingExtension5.Path = "ImageSource";
		BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension5(bindingExtension5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 61, 29);
		}
		image.SetBinding(VisualElement.IsVisibleProperty, bindingBase6);
		bindingExtension6.Path = "ImageSource";
		BindingBase bindingBase7 = CreateTypedBindingFrom_bindingExtension6(bindingExtension6);
		if (VisualDiagnostics.GetSourceInfo(bindingBase7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase7, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 62, 29);
		}
		image.SetBinding(Image.SourceProperty, bindingBase7);
		verticalStackLayout2.Children.Add(image);
		staticResourceExtension5.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider6 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service6 = new SimpleValueTargetProvider(new object[7] { label2, verticalStackLayout2, grid, border, grid2, scrollView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider6.Add(typeof(IReferenceProvider), service6);
		xamlServiceProvider6.Add(typeof(IProvideValueTarget), service6);
		xamlServiceProvider6.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(65, 32)));
		object obj6 = ((IMarkupExtension)staticResourceExtension5).ProvideValue((IServiceProvider)xamlServiceProvider6);
		if (VisualDiagnostics.GetSourceInfo(obj6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj6, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 65, 32);
		}
		label2.SetValue(VisualElement.StyleProperty, obj6);
		bindingExtension7.Path = "Title";
		BindingBase bindingBase8 = CreateTypedBindingFrom_bindingExtension7(bindingExtension7);
		if (VisualDiagnostics.GetSourceInfo(bindingBase8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase8, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 66, 32);
		}
		label2.SetBinding(Label.TextProperty, bindingBase8);
		verticalStackLayout2.Children.Add(label2);
		staticResourceExtension6.Key = "IsNotNullConverter";
		XamlServiceProvider xamlServiceProvider7 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service7 = new SimpleValueTargetProvider(new object[8] { bindingExtension8, label3, verticalStackLayout2, grid, border, grid2, scrollView, this }, typeof(BindingExtension).GetProperty("Converter"), new INameScope[1] { nameScope }, this);
		xamlServiceProvider7.Add(typeof(IReferenceProvider), service7);
		xamlServiceProvider7.Add(typeof(IProvideValueTarget), service7);
		xamlServiceProvider7.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(69, 32)));
		object obj7 = ((IMarkupExtension)staticResourceExtension6).ProvideValue((IServiceProvider)xamlServiceProvider7);
		if (VisualDiagnostics.GetSourceInfo(obj7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj7, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 69, 32);
		}
		bindingExtension8.Converter = (IValueConverter)obj7;
		bindingExtension8.Path = "Message";
		BindingBase bindingBase9 = CreateTypedBindingFrom_bindingExtension8(bindingExtension8);
		if (VisualDiagnostics.GetSourceInfo(bindingBase9) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase9, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 69, 32);
		}
		label3.SetBinding(VisualElement.IsVisibleProperty, bindingBase9);
		bindingExtension9.Path = "Message";
		BindingBase bindingBase10 = CreateTypedBindingFrom_bindingExtension9(bindingExtension9);
		if (VisualDiagnostics.GetSourceInfo(bindingBase10) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase10, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 70, 32);
		}
		label3.SetBinding(Label.TextProperty, bindingBase10);
		verticalStackLayout2.Children.Add(label3);
		bindingExtension10.Path = "IsTimerVisible";
		BindingBase bindingBase11 = CreateTypedBindingFrom_bindingExtension10(bindingExtension10);
		if (VisualDiagnostics.GetSourceInfo(bindingBase11) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase11, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 73, 29);
		}
		verticalStackLayout.SetBinding(VisualElement.IsVisibleProperty, bindingBase11);
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 0.0);
		bindingExtension11.StringFormat = alg_SecondsToConfirmUpdate;
		bindingExtension11.Path = "SecondsLeft";
		BindingBase bindingBase12 = CreateTypedBindingFrom_bindingExtension11(bindingExtension11);
		if (VisualDiagnostics.GetSourceInfo(bindingBase12) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase12, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 75, 29);
		}
		verticalStackLayout.SetBinding(SemanticProperties.DescriptionProperty, bindingBase12);
		verticalStackLayout.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		((BindableObject)(object)sfCircularProgressBar).SetValue(VisualElement.BackgroundColorProperty, (object)Colors.Transparent);
		((BindableObject)(object)sfCircularProgressBar).SetValue(VisualElement.HeightRequestProperty, (object)64.0);
		((BindableObject)(object)sfCircularProgressBar).SetValue(ProgressBarBase.MaximumProperty, (object)30.0);
		((BindableObject)(object)sfCircularProgressBar).SetValue(ProgressBarBase.MinimumProperty, (object)0.0);
		bindingExtension12.Path = "SecondsUsed";
		BindingBase bindingBase13 = CreateTypedBindingFrom_bindingExtension12(bindingExtension12);
		if (VisualDiagnostics.GetSourceInfo(bindingBase13) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase13, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 82, 33);
		}
		((BindableObject)(object)sfCircularProgressBar).SetBinding(ProgressBarBase.ProgressProperty, bindingBase13);
		((BindableObject)(object)sfCircularProgressBar).SetValue(ProgressBarBase.ProgressFillProperty, (object)(new BrushTypeConverter().ConvertFromInvariantString("#FCD2AD") as Brush));
		((BindableObject)(object)sfCircularProgressBar).SetValue(SfCircularProgressBar.ProgressRadiusFactorProperty, (object)0.65);
		staticResourceExtension7.Key = "PrimaryColor";
		XamlServiceProvider xamlServiceProvider8 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service8 = new SimpleValueTargetProvider(new object[8] { sfCircularProgressBar, verticalStackLayout, verticalStackLayout2, grid, border, grid2, scrollView, this }, ProgressBarBase.TrackFillProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider8.Add(typeof(IReferenceProvider), service8);
		xamlServiceProvider8.Add(typeof(IProvideValueTarget), service8);
		xamlServiceProvider8.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(85, 33)));
		object obj8 = ((IMarkupExtension)staticResourceExtension7).ProvideValue((IServiceProvider)xamlServiceProvider8);
		if (VisualDiagnostics.GetSourceInfo(obj8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj8, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 85, 33);
		}
		((BindableObject)(object)sfCircularProgressBar).SetValue(ProgressBarBase.TrackFillProperty, obj8);
		((BindableObject)(object)sfCircularProgressBar).SetValue(SfCircularProgressBar.TrackRadiusFactorProperty, (object)0.65);
		((BindableObject)(object)sfCircularProgressBar).SetValue(VisualElement.WidthRequestProperty, (object)64.0);
		label4.SetValue(Label.HorizontalTextAlignmentProperty, TextAlignment.Center);
		bindingExtension13.Path = "SecondsLeft";
		BindingBase bindingBase14 = CreateTypedBindingFrom_bindingExtension13(bindingExtension13);
		if (VisualDiagnostics.GetSourceInfo(bindingBase14) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase14, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 91, 41);
		}
		label4.SetBinding(Label.TextProperty, bindingBase14);
		((BindableObject)(object)sfCircularProgressBar).SetValue(SfCircularProgressBar.ContentProperty, (object)label4);
		verticalStackLayout.Children.Add((IView)sfCircularProgressBar);
		verticalStackLayout2.Children.Add(verticalStackLayout);
		bindingExtension14.Path = "ButtonsVisible";
		BindingBase bindingBase15 = CreateTypedBindingFrom_bindingExtension14(bindingExtension14);
		if (VisualDiagnostics.GetSourceInfo(bindingBase15) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase15, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 96, 38);
		}
		stackLayout.SetBinding(VisualElement.IsVisibleProperty, bindingBase15);
		stackLayout.SetValue(StackBase.SpacingProperty, 15.0);
		borderedButton.SetValue(Element.AutomationIdProperty, "CancelButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension15.Path = "CancelCommand";
		BindingBase bindingBase16 = CreateTypedBindingFrom_bindingExtension15(bindingExtension15);
		if (VisualDiagnostics.GetSourceInfo(bindingBase16) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase16, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 100, 33);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase16);
		bindingExtension16.Path = "CancelButtonVisible";
		BindingBase bindingBase17 = CreateTypedBindingFrom_bindingExtension16(bindingExtension16);
		if (VisualDiagnostics.GetSourceInfo(bindingBase17) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase17, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 101, 33);
		}
		borderedButton.SetBinding(VisualElement.IsVisibleProperty, bindingBase17);
		bindingExtension17.Path = "CancelButtonText";
		BindingBase bindingBase18 = CreateTypedBindingFrom_bindingExtension17(bindingExtension17);
		if (VisualDiagnostics.GetSourceInfo(bindingBase18) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase18, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 102, 33);
		}
		borderedButton.SetBinding(Button.TextProperty, bindingBase18);
		borderedButton.SetValue(View.VerticalOptionsProperty, LayoutOptions.End);
		stackLayout.Children.Add(borderedButton);
		borderedButton2.SetValue(Element.AutomationIdProperty, "AcceptButton");
		borderedButton2.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension18.Path = "AcceptCommand";
		BindingBase bindingBase19 = CreateTypedBindingFrom_bindingExtension18(bindingExtension18);
		if (VisualDiagnostics.GetSourceInfo(bindingBase19) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase19, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 108, 33);
		}
		borderedButton2.SetBinding(Button.CommandProperty, bindingBase19);
		bindingExtension19.Path = "PrimaryButtonVisible";
		BindingBase bindingBase20 = CreateTypedBindingFrom_bindingExtension19(bindingExtension19);
		if (VisualDiagnostics.GetSourceInfo(bindingBase20) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase20, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 109, 33);
		}
		borderedButton2.SetBinding(VisualElement.IsVisibleProperty, bindingBase20);
		bindingExtension20.Path = "AcceptButtonText";
		BindingBase bindingBase21 = CreateTypedBindingFrom_bindingExtension20(bindingExtension20);
		if (VisualDiagnostics.GetSourceInfo(bindingBase21) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase21, new Uri("Popups\\AlertPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 110, 33);
		}
		borderedButton2.SetBinding(Button.TextProperty, bindingBase21);
		borderedButton2.SetValue(View.VerticalOptionsProperty, LayoutOptions.End);
		stackLayout.Children.Add(borderedButton2);
		verticalStackLayout2.Children.Add(stackLayout);
		grid.Children.Add(verticalStackLayout2);
		border.SetValue(Border.ContentProperty, grid);
		grid2.Children.Add(border);
		scrollView.Content = grid2;
		SetValue(ContentPage.ContentProperty, scrollView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<AlertPopupViewModel, bool> setter = delegate(AlertPopupViewModel source, bool value)
			{
				source.PageLabelVisible = value;
			};
			return new TypedBinding<AlertPopupViewModel, bool>((AlertPopupViewModel source) => (value: source.PageLabelVisible, success: true), setter, new Tuple<Func<AlertPopupViewModel, object>, string>[1]
			{
				new Tuple<Func<AlertPopupViewModel, object>, string>((AlertPopupViewModel source) => source, "PageLabelVisible")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension10(BindingExtension extension)
		{
			Action<AlertPopupViewModel, bool> setter = delegate(AlertPopupViewModel source, bool value)
			{
				source.IsTimerVisible = value;
			};
			return new TypedBinding<AlertPopupViewModel, bool>((AlertPopupViewModel source) => (value: source.IsTimerVisible, success: true), setter, new Tuple<Func<AlertPopupViewModel, object>, string>[1]
			{
				new Tuple<Func<AlertPopupViewModel, object>, string>((AlertPopupViewModel source) => source, "IsTimerVisible")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension11(BindingExtension extension)
		{
			Action<AlertPopupViewModel, int> setter = delegate(AlertPopupViewModel source, int value)
			{
				source.SecondsLeft = value;
			};
			return new TypedBinding<AlertPopupViewModel, int>((AlertPopupViewModel source) => (value: source.SecondsLeft, success: true), setter, new Tuple<Func<AlertPopupViewModel, object>, string>[1]
			{
				new Tuple<Func<AlertPopupViewModel, object>, string>((AlertPopupViewModel source) => source, "SecondsLeft")
			})
			{
				StringFormat = extension.StringFormat
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension12(BindingExtension extension)
		{
			Action<AlertPopupViewModel, int> setter = delegate(AlertPopupViewModel source, int value)
			{
				source.SecondsUsed = value;
			};
			return new TypedBinding<AlertPopupViewModel, int>((AlertPopupViewModel source) => (value: source.SecondsUsed, success: true), setter, new Tuple<Func<AlertPopupViewModel, object>, string>[1]
			{
				new Tuple<Func<AlertPopupViewModel, object>, string>((AlertPopupViewModel source) => source, "SecondsUsed")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension13(BindingExtension extension)
		{
			Action<AlertPopupViewModel, int> setter = delegate(AlertPopupViewModel source, int value)
			{
				source.SecondsLeft = value;
			};
			return new TypedBinding<AlertPopupViewModel, int>((AlertPopupViewModel source) => (value: source.SecondsLeft, success: true), setter, new Tuple<Func<AlertPopupViewModel, object>, string>[1]
			{
				new Tuple<Func<AlertPopupViewModel, object>, string>((AlertPopupViewModel source) => source, "SecondsLeft")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension14(BindingExtension extension)
		{
			Action<AlertPopupViewModel, bool> setter = null;
			return new TypedBinding<AlertPopupViewModel, bool>((AlertPopupViewModel source) => (value: source.ButtonsVisible, success: true), setter, new Tuple<Func<AlertPopupViewModel, object>, string>[1]
			{
				new Tuple<Func<AlertPopupViewModel, object>, string>((AlertPopupViewModel source) => source, "ButtonsVisible")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension15(BindingExtension extension)
		{
			Action<AlertPopupViewModel, ICommand> setter = null;
			return new TypedBinding<AlertPopupViewModel, ICommand>((AlertPopupViewModel source) => ((ICommand value, bool success))(value: source.CancelCommand, success: true), setter, new Tuple<Func<AlertPopupViewModel, object>, string>[1]
			{
				new Tuple<Func<AlertPopupViewModel, object>, string>((AlertPopupViewModel source) => source, "CancelCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension16(BindingExtension extension)
		{
			Action<AlertPopupViewModel, bool> setter = delegate(AlertPopupViewModel source, bool value)
			{
				source.CancelButtonVisible = value;
			};
			return new TypedBinding<AlertPopupViewModel, bool>((AlertPopupViewModel source) => (value: source.CancelButtonVisible, success: true), setter, new Tuple<Func<AlertPopupViewModel, object>, string>[1]
			{
				new Tuple<Func<AlertPopupViewModel, object>, string>((AlertPopupViewModel source) => source, "CancelButtonVisible")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension17(BindingExtension extension)
		{
			Action<AlertPopupViewModel, string> setter = delegate(AlertPopupViewModel source, string? value)
			{
				source.CancelButtonText = value;
			};
			return new TypedBinding<AlertPopupViewModel, string>((AlertPopupViewModel source) => (value: source.CancelButtonText, success: true), setter, new Tuple<Func<AlertPopupViewModel, object>, string>[1]
			{
				new Tuple<Func<AlertPopupViewModel, object>, string>((AlertPopupViewModel source) => source, "CancelButtonText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension18(BindingExtension extension)
		{
			Action<AlertPopupViewModel, ICommand> setter = null;
			return new TypedBinding<AlertPopupViewModel, ICommand>((AlertPopupViewModel source) => ((ICommand value, bool success))(value: source.AcceptCommand, success: true), setter, new Tuple<Func<AlertPopupViewModel, object>, string>[1]
			{
				new Tuple<Func<AlertPopupViewModel, object>, string>((AlertPopupViewModel source) => source, "AcceptCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension19(BindingExtension extension)
		{
			Action<AlertPopupViewModel, bool> setter = delegate(AlertPopupViewModel source, bool value)
			{
				source.PrimaryButtonVisible = value;
			};
			return new TypedBinding<AlertPopupViewModel, bool>((AlertPopupViewModel source) => (value: source.PrimaryButtonVisible, success: true), setter, new Tuple<Func<AlertPopupViewModel, object>, string>[1]
			{
				new Tuple<Func<AlertPopupViewModel, object>, string>((AlertPopupViewModel source) => source, "PrimaryButtonVisible")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<AlertPopupViewModel, string> setter = delegate(AlertPopupViewModel source, string value)
			{
				source.PageId = value;
			};
			return new TypedBinding<AlertPopupViewModel, string>((AlertPopupViewModel source) => (value: source.PageId, success: true), setter, new Tuple<Func<AlertPopupViewModel, object>, string>[1]
			{
				new Tuple<Func<AlertPopupViewModel, object>, string>((AlertPopupViewModel source) => source, "PageId")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension20(BindingExtension extension)
		{
			Action<AlertPopupViewModel, string> setter = delegate(AlertPopupViewModel source, string? value)
			{
				source.AcceptButtonText = value;
			};
			return new TypedBinding<AlertPopupViewModel, string>((AlertPopupViewModel source) => (value: source.AcceptButtonText, success: true), setter, new Tuple<Func<AlertPopupViewModel, object>, string>[1]
			{
				new Tuple<Func<AlertPopupViewModel, object>, string>((AlertPopupViewModel source) => source, "AcceptButtonText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<AlertPopupViewModel, ICommand> setter = null;
			return new TypedBinding<AlertPopupViewModel, ICommand>((AlertPopupViewModel source) => ((ICommand value, bool success))(value: source.CancelCommand, success: true), setter, new Tuple<Func<AlertPopupViewModel, object>, string>[1]
			{
				new Tuple<Func<AlertPopupViewModel, object>, string>((AlertPopupViewModel source) => source, "CancelCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<AlertPopupViewModel, bool> setter = delegate(AlertPopupViewModel source, bool value)
			{
				source.CloseIconVisible = value;
			};
			return new TypedBinding<AlertPopupViewModel, bool>((AlertPopupViewModel source) => (value: source.CloseIconVisible, success: true), setter, new Tuple<Func<AlertPopupViewModel, object>, string>[1]
			{
				new Tuple<Func<AlertPopupViewModel, object>, string>((AlertPopupViewModel source) => source, "CloseIconVisible")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<AlertPopupViewModel, string> setter = delegate(AlertPopupViewModel source, string? value)
			{
				source.ImageSource = value;
			};
			return new TypedBinding<AlertPopupViewModel, string>((AlertPopupViewModel source) => (value: source.ImageSource, success: true), setter, new Tuple<Func<AlertPopupViewModel, object>, string>[1]
			{
				new Tuple<Func<AlertPopupViewModel, object>, string>((AlertPopupViewModel source) => source, "ImageSource")
			})
			{
				Converter = extension.Converter
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension6(BindingExtension extension)
		{
			Action<AlertPopupViewModel, string> setter = delegate(AlertPopupViewModel source, string? value)
			{
				source.ImageSource = value;
			};
			return new TypedBinding<AlertPopupViewModel, string>((AlertPopupViewModel source) => (value: source.ImageSource, success: true), setter, new Tuple<Func<AlertPopupViewModel, object>, string>[1]
			{
				new Tuple<Func<AlertPopupViewModel, object>, string>((AlertPopupViewModel source) => source, "ImageSource")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension7(BindingExtension extension)
		{
			Action<AlertPopupViewModel, string> setter = delegate(AlertPopupViewModel source, string? value)
			{
				source.Title = value;
			};
			return new TypedBinding<AlertPopupViewModel, string>((AlertPopupViewModel source) => (value: source.Title, success: true), setter, new Tuple<Func<AlertPopupViewModel, object>, string>[1]
			{
				new Tuple<Func<AlertPopupViewModel, object>, string>((AlertPopupViewModel source) => source, "Title")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension8(BindingExtension extension)
		{
			Action<AlertPopupViewModel, string> setter = delegate(AlertPopupViewModel source, string? value)
			{
				source.Message = value;
			};
			return new TypedBinding<AlertPopupViewModel, string>((AlertPopupViewModel source) => (value: source.Message, success: true), setter, new Tuple<Func<AlertPopupViewModel, object>, string>[1]
			{
				new Tuple<Func<AlertPopupViewModel, object>, string>((AlertPopupViewModel source) => source, "Message")
			})
			{
				Converter = extension.Converter
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension9(BindingExtension extension)
		{
			Action<AlertPopupViewModel, string> setter = delegate(AlertPopupViewModel source, string? value)
			{
				source.Message = value;
			};
			return new TypedBinding<AlertPopupViewModel, string>((AlertPopupViewModel source) => (value: source.Message, success: true), setter, new Tuple<Func<AlertPopupViewModel, object>, string>[1]
			{
				new Tuple<Func<AlertPopupViewModel, object>, string>((AlertPopupViewModel source) => source, "Message")
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
	[MemberNotNull("popupScrollView")]
	[MemberNotNull("popupGrid")]
	[MemberNotNull("popupBorder")]
	[MemberNotNull("popup")]
	[MemberNotNull("popupContent")]
	[MemberNotNull("CloseButton")]
	[MemberNotNull("AlertPopupTitle")]
	[MemberNotNull("AlertMessage")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(AlertPopup));
		popupScrollView = this.FindByName<ScrollView>("popupScrollView");
		popupGrid = this.FindByName<Grid>("popupGrid");
		popupBorder = this.FindByName<Border>("popupBorder");
		popup = this.FindByName<Grid>("popup");
		popupContent = this.FindByName<VerticalStackLayout>("popupContent");
		CloseButton = this.FindByName<ImageButton>("CloseButton");
		AlertPopupTitle = this.FindByName<Label>("AlertPopupTitle");
		AlertMessage = this.FindByName<Label>("AlertMessage");
	}
}
