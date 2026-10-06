using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Windows.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Pages.ViewModels;
using LocalizationResourceManager.Maui;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Graphics;
using WinRT;
using WinRT.DigiD_Common_PagesVtableClasses;

namespace DigiD.Common.Pages.Pages;

[XamlFilePath("Pages\\DG084.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Common_Pages_Pages_DG084WinRTTypeDetails))]
public class DG084 : BasePage<DG084ViewModel>
{
	public DG084()
		: base((DG084ViewModel?)null)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG084).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG084)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate noScrollViewTemplate = TemplateSelector.NoScrollViewTemplate;
		VisualDiagnostics.RegisterSourceInfo(noScrollViewTemplate, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 13, 18);
		OnPlatformExtension onPlatformExtension = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 18, 25);
		DynamicResource dynamicResource = new DynamicResource("LabelHeader");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 20, 28);
		TranslateExtension translateExtension = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 20, 66);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 20, 22);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 22, 28);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 22, 22);
		DynamicResource dynamicResource2 = new DynamicResource("LabelBold");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource2, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 23, 28);
		TranslateExtension translateExtension2 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension2, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 23, 64);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 23, 22);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 24, 28);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 24, 22);
		BoxView boxView = new BoxView();
		VisualDiagnostics.RegisterSourceInfo(boxView, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 25, 22);
		OnPlatformExtension onPlatformExtension2 = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension2, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 30, 28);
		Image image2 = new Image();
		VisualDiagnostics.RegisterSourceInfo(image2, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 30, 22);
		DynamicResource dynamicResource3 = new DynamicResource("LabelBold");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource3, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 31, 28);
		TranslateExtension translateExtension3 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension3, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 31, 64);
		Label label4 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label4, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 31, 22);
		TranslateExtension translateExtension4 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension4, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 32, 28);
		Label label5 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label5, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 32, 22);
		BoxView boxView2 = new BoxView();
		VisualDiagnostics.RegisterSourceInfo(boxView2, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 33, 22);
		Image image3 = new Image();
		VisualDiagnostics.RegisterSourceInfo(image3, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 38, 22);
		DynamicResource dynamicResource4 = new DynamicResource("LabelBold");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource4, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 39, 28);
		TranslateExtension translateExtension5 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension5, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 39, 64);
		Label label6 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label6, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 39, 22);
		TranslateExtension translateExtension6 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension6, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 40, 28);
		Label label7 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label7, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 40, 22);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 42, 42);
		BoxView boxView3 = new BoxView();
		VisualDiagnostics.RegisterSourceInfo(boxView3, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 43, 26);
		Image image4 = new Image();
		VisualDiagnostics.RegisterSourceInfo(image4, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 48, 26);
		DynamicResource dynamicResource5 = new DynamicResource("LabelBold");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource5, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 49, 32);
		TranslateExtension translateExtension7 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension7, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 49, 68);
		Label label8 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label8, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 49, 26);
		TranslateExtension translateExtension8 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension8, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 50, 32);
		Label label9 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label9, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 50, 26);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 42, 22);
		VerticalStackLayout verticalStackLayout2 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout2, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 19, 18);
		ScrollView scrollView = new ScrollView();
		VisualDiagnostics.RegisterSourceInfo(scrollView, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 18, 14);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 60, 21);
		TranslateExtension translateExtension9 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension9, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 61, 21);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 57, 18);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 66, 21);
		TranslateExtension translateExtension10 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension10, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 67, 21);
		BorderedButton borderedButton2 = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton2, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 63, 18);
		VerticalStackLayout verticalStackLayout3 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout3, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 56, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 14, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 13, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		scrollView.transientNamescope = nameScope;
		verticalStackLayout2.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		image.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		boxView.transientNamescope = nameScope;
		image2.transientNamescope = nameScope;
		label4.transientNamescope = nameScope;
		label5.transientNamescope = nameScope;
		boxView2.transientNamescope = nameScope;
		image3.transientNamescope = nameScope;
		label6.transientNamescope = nameScope;
		label7.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		boxView3.transientNamescope = nameScope;
		image4.transientNamescope = nameScope;
		label8.transientNamescope = nameScope;
		label9.transientNamescope = nameScope;
		verticalStackLayout3.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		borderedButton2.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, noScrollViewTemplate);
		grid.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Auto)));
		grid.SetValue(Grid.RowSpacingProperty, 20.0);
		onPlatformExtension.Android = "True";
		onPlatformExtension.iOS = "False";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { scrollView, grid, contentView, this }, AutomationProperties.IsInAccessibleTreeProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(18, 25)));
		object obj = ((IMarkupExtension)onPlatformExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 18, 25);
		}
		scrollView.SetValue(AutomationProperties.IsInAccessibleTreeProperty, obj);
		verticalStackLayout2.SetValue(StackBase.SpacingProperty, 10.0);
		((IDynamicResourceHandler)label).SetDynamicResource(VisualElement.StyleProperty, dynamicResource.Key);
		translateExtension.Text = "DG084_Title";
		BindingBase bindingBase = ((IMarkupExtension<BindingBase>)translateExtension).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 20, 66);
		}
		label.SetBinding(Label.TextProperty, bindingBase);
		verticalStackLayout2.Children.Add(label);
		bindingExtension.Path = "Tip1ImageSource";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 22, 28);
		}
		image.SetBinding(Image.SourceProperty, bindingBase2);
		verticalStackLayout2.Children.Add(image);
		((IDynamicResourceHandler)label2).SetDynamicResource(VisualElement.StyleProperty, dynamicResource2.Key);
		translateExtension2.Text = "DG084_Tip1_Header";
		BindingBase bindingBase3 = ((IMarkupExtension<BindingBase>)translateExtension2).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 23, 64);
		}
		label2.SetBinding(Label.TextProperty, bindingBase3);
		verticalStackLayout2.Children.Add(label2);
		bindingExtension2.Path = "Tip1Text.Localized";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 24, 28);
		}
		label3.SetBinding(Label.TextProperty, bindingBase4);
		verticalStackLayout2.Children.Add(label3);
		boxView.SetValue(View.MarginProperty, new Thickness(0.0, 32.0));
		boxView.SetValue(VisualElement.HeightRequestProperty, 1.0);
		boxView.SetValue(BoxView.ColorProperty, new Color(78f / 85f, 78f / 85f, 78f / 85f, 1f));
		verticalStackLayout2.Children.Add(boxView);
		onPlatformExtension2.Android = "digid_afbeelding_dg084_tip2_android";
		onPlatformExtension2.iOS = "digid_afbeelding_dg084_tip2_ios";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[6] { image2, verticalStackLayout2, scrollView, grid, contentView, this }, Image.SourceProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(30, 28)));
		object obj2 = ((IMarkupExtension)onPlatformExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 30, 28);
		}
		image2.SetValue(Image.SourceProperty, obj2);
		verticalStackLayout2.Children.Add(image2);
		((IDynamicResourceHandler)label4).SetDynamicResource(VisualElement.StyleProperty, dynamicResource3.Key);
		translateExtension3.Text = "DG084_Tip2_Header";
		BindingBase bindingBase5 = ((IMarkupExtension<BindingBase>)translateExtension3).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 31, 64);
		}
		label4.SetBinding(Label.TextProperty, bindingBase5);
		verticalStackLayout2.Children.Add(label4);
		translateExtension4.Text = "DG084_Tip2_Text";
		BindingBase bindingBase6 = ((IMarkupExtension<BindingBase>)translateExtension4).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 32, 28);
		}
		label5.SetBinding(Label.TextProperty, bindingBase6);
		verticalStackLayout2.Children.Add(label5);
		boxView2.SetValue(View.MarginProperty, new Thickness(0.0, 32.0));
		boxView2.SetValue(VisualElement.HeightRequestProperty, 1.0);
		boxView2.SetValue(BoxView.ColorProperty, new Color(78f / 85f, 78f / 85f, 78f / 85f, 1f));
		verticalStackLayout2.Children.Add(boxView2);
		image3.SetValue(Image.SourceProperty, ImageSource.FromFile("digid_afbeelding_dg084_tip3.png"));
		verticalStackLayout2.Children.Add(image3);
		((IDynamicResourceHandler)label6).SetDynamicResource(VisualElement.StyleProperty, dynamicResource4.Key);
		translateExtension5.Text = "DG084_Tip3_Header";
		BindingBase bindingBase7 = ((IMarkupExtension<BindingBase>)translateExtension5).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase7, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 39, 64);
		}
		label6.SetBinding(Label.TextProperty, bindingBase7);
		verticalStackLayout2.Children.Add(label6);
		translateExtension6.Text = "DG084_Tip3_Text";
		BindingBase bindingBase8 = ((IMarkupExtension<BindingBase>)translateExtension6).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase8, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 40, 28);
		}
		label7.SetBinding(Label.TextProperty, bindingBase8);
		verticalStackLayout2.Children.Add(label7);
		bindingExtension3.Path = "DeviceService.IsPowerSaveMode";
		BindingBase bindingBase9 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase9) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase9, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 42, 42);
		}
		verticalStackLayout.SetBinding(VisualElement.IsVisibleProperty, bindingBase9);
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 10.0);
		boxView3.SetValue(View.MarginProperty, new Thickness(0.0, 32.0));
		boxView3.SetValue(VisualElement.HeightRequestProperty, 1.0);
		boxView3.SetValue(BoxView.ColorProperty, new Color(78f / 85f, 78f / 85f, 78f / 85f, 1f));
		verticalStackLayout.Children.Add(boxView3);
		image4.SetValue(Image.SourceProperty, ImageSource.FromFile("afbeelding_phone_battery_save_mode_off.png"));
		verticalStackLayout.Children.Add(image4);
		((IDynamicResourceHandler)label8).SetDynamicResource(VisualElement.StyleProperty, dynamicResource5.Key);
		translateExtension7.Text = "DG084_Tip4_Header";
		BindingBase bindingBase10 = ((IMarkupExtension<BindingBase>)translateExtension7).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase10) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase10, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 49, 68);
		}
		label8.SetBinding(Label.TextProperty, bindingBase10);
		verticalStackLayout.Children.Add(label8);
		translateExtension8.Text = "DG084_Tip4_Text";
		BindingBase bindingBase11 = ((IMarkupExtension<BindingBase>)translateExtension8).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase11) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase11, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 50, 32);
		}
		label9.SetBinding(Label.TextProperty, bindingBase11);
		verticalStackLayout.Children.Add(label9);
		verticalStackLayout2.Children.Add(verticalStackLayout);
		scrollView.Content = verticalStackLayout2;
		grid.Children.Add(scrollView);
		verticalStackLayout3.SetValue(Grid.RowProperty, 1);
		verticalStackLayout3.SetValue(StackBase.SpacingProperty, 15.0);
		borderedButton.SetValue(Element.AutomationIdProperty, "btnSkip");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension4.Path = "SkipCommand";
		BindingBase bindingBase12 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase12) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase12, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 60, 21);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase12);
		translateExtension9.Text = "DG084_Button1_Text";
		BindingBase bindingBase13 = ((IMarkupExtension<BindingBase>)translateExtension9).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase13) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase13, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 61, 21);
		}
		borderedButton.SetBinding(Button.TextProperty, bindingBase13);
		verticalStackLayout3.Children.Add(borderedButton);
		borderedButton2.SetValue(Element.AutomationIdProperty, "btnTryAgain");
		borderedButton2.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension5.Path = "TryAgainCommand";
		BindingBase bindingBase14 = CreateTypedBindingFrom_bindingExtension5(bindingExtension5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase14) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase14, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 66, 21);
		}
		borderedButton2.SetBinding(Button.CommandProperty, bindingBase14);
		translateExtension10.Text = "DG084_Button2_Text";
		BindingBase bindingBase15 = ((IMarkupExtension<BindingBase>)translateExtension10).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase15) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase15, new Uri("Pages\\DG084.xaml;assembly=DigiD.Common.Pages", UriKind.Relative), 67, 21);
		}
		borderedButton2.SetBinding(Button.TextProperty, bindingBase15);
		verticalStackLayout3.Children.Add(borderedButton2);
		grid.Children.Add(verticalStackLayout3);
		contentView.SetValue(ContentView.ContentProperty, grid);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG084ViewModel, ImageSource> setter = delegate(DG084ViewModel source, ImageSource value)
			{
				source.Tip1ImageSource = value;
			};
			return new TypedBinding<DG084ViewModel, ImageSource>((DG084ViewModel source) => (value: source.Tip1ImageSource, success: true), setter, new Tuple<Func<DG084ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG084ViewModel, object>, string>((DG084ViewModel source) => source, "Tip1ImageSource")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG084ViewModel, string> setter = null;
			return new TypedBinding<DG084ViewModel, string>((DG084ViewModel source) => (value: source.Tip1Text.Localized, success: true), setter, new Tuple<Func<DG084ViewModel, object>, string>[2]
			{
				new Tuple<Func<DG084ViewModel, object>, string>((DG084ViewModel source) => source, "Tip1Text"),
				new Tuple<Func<DG084ViewModel, object>, string>((DG084ViewModel source) => source.Tip1Text, "Localized")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG084ViewModel, bool> setter = null;
			return new TypedBinding<DG084ViewModel, bool>((DG084ViewModel source) => (value: source.DeviceService.IsPowerSaveMode, success: true), setter, new Tuple<Func<DG084ViewModel, object>, string>[2]
			{
				new Tuple<Func<DG084ViewModel, object>, string>((DG084ViewModel source) => source, "DeviceService"),
				new Tuple<Func<DG084ViewModel, object>, string>((DG084ViewModel source) => source.DeviceService, "IsPowerSaveMode")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DG084ViewModel, ICommand> setter = null;
			return new TypedBinding<DG084ViewModel, ICommand>((DG084ViewModel source) => ((ICommand value, bool success))(value: source.SkipCommand, success: true), setter, new Tuple<Func<DG084ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG084ViewModel, object>, string>((DG084ViewModel source) => source, "SkipCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<DG084ViewModel, ICommand> setter = null;
			return new TypedBinding<DG084ViewModel, ICommand>((DG084ViewModel source) => ((ICommand value, bool success))(value: source.TryAgainCommand, success: true), setter, new Tuple<Func<DG084ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG084ViewModel, object>, string>((DG084ViewModel source) => source, "TryAgainCommand")
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
		this.LoadFromXaml(typeof(DG084));
	}
}
