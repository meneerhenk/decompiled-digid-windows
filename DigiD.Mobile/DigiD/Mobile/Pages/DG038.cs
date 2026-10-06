using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Windows.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Resources;
using DigiD.Mobile.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Graphics;
using Syncfusion.Maui.ProgressBar;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.Pages;

[XamlFilePath("Pages\\DG038.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG038 : BasePage<DG038ViewModel>
{
	public DG038(DG038ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG038).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG038)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 18);
		string dG038_SemanticDescription = DigiDAppResources.DG038_SemanticDescription;
		VisualDiagnostics.RegisterSourceInfo(dG038_SemanticDescription, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 17);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 17);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 17);
		string dG038_Titel = DigiDAppResources.DG038_Titel;
		VisualDiagnostics.RegisterSourceInfo(dG038_Titel, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 14);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 17);
		string dG038_Intro = DigiDAppResources.DG038_Intro;
		VisualDiagnostics.RegisterSourceInfo(dG038_Intro, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 17);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 14);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 50);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 25);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 38, 22);
		DynamicResource dynamicResource = new DynamicResource("AfnemerOverlay");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 25);
		Image image2 = new Image();
		VisualDiagnostics.RegisterSourceInfo(image2, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 22);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 18);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 53, 21);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 49, 18);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 55, 38);
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension3, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 58, 25);
		string dG038_Timeout = DigiDAppResources.DG038_Timeout;
		VisualDiagnostics.RegisterSourceInfo(dG038_Timeout, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 59, 25);
		Label label4 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label4, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 56, 22);
		BindingExtension bindingExtension6 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 68, 29);
		StaticResourceExtension staticResourceExtension4 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension4, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 71, 29);
		SfCircularProgressBar sfCircularProgressBar = new SfCircularProgressBar();
		VisualDiagnostics.RegisterSourceInfo(sfCircularProgressBar, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 63, 26);
		BindingExtension bindingExtension7 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension7, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 79, 29);
		Label label5 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label5, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 75, 26);
		Grid grid2 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid2, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 62, 22);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 55, 18);
		VerticalStackLayout verticalStackLayout2 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout2, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 14);
		DynamicResource dynamicResource2 = new DynamicResource("Gray1");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource2, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 88, 17);
		BindingExtension bindingExtension8 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension8, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 89, 17);
		DynamicResource dynamicResource3 = new DynamicResource("Gray3");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource3, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 90, 17);
		AppThemeBindingExtension appThemeBindingExtension = new AppThemeBindingExtension();
		VisualDiagnostics.RegisterSourceInfo(appThemeBindingExtension, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 93, 44);
		Image image3 = new Image();
		VisualDiagnostics.RegisterSourceInfo(image3, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 93, 22);
		string dG038_EHA_Bericht = DigiDAppResources.DG038_EHA_Bericht;
		VisualDiagnostics.RegisterSourceInfo(dG038_EHA_Bericht, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 96, 25);
		AppThemeBindingExtension appThemeBindingExtension2 = new AppThemeBindingExtension();
		VisualDiagnostics.RegisterSourceInfo(appThemeBindingExtension2, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 97, 25);
		Label label6 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label6, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 94, 22);
		BindingExtension bindingExtension9 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension9, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 102, 25);
		ImageButton imageButton = new ImageButton();
		VisualDiagnostics.RegisterSourceInfo(imageButton, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 100, 22);
		Grid grid3 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid3, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 92, 18);
		Border border = new Border();
		VisualDiagnostics.RegisterSourceInfo(border, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 85, 14);
		StaticResourceExtension staticResourceExtension5 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension5, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 110, 17);
		StaticResourceExtension staticResourceExtension6 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension6, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 112, 17);
		BindingExtension bindingExtension10 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension10, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 112, 17);
		Image image4 = new Image();
		VisualDiagnostics.RegisterSourceInfo(image4, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 113, 18);
		BindingExtension bindingExtension11 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension11, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 121, 21);
		Label label7 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label7, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 119, 18);
		Grid grid4 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid4, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 107, 14);
		BindingExtension bindingExtension12 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension12, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 132, 17);
		string alg_Cancel = CommonResources.Alg_Cancel;
		VisualDiagnostics.RegisterSourceInfo(alg_Cancel, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 133, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 127, 14);
		BindingExtension bindingExtension13 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension13, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 139, 17);
		BindingExtension bindingExtension14 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension14, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 140, 17);
		string dG038_Knop = DigiDAppResources.DG038_Knop;
		VisualDiagnostics.RegisterSourceInfo(dG038_Knop, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 141, 17);
		BorderedButton borderedButton2 = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton2, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 135, 14);
		Grid grid5 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid5, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 14, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid5.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		verticalStackLayout2.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		image.transientNamescope = nameScope;
		image2.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		label4.transientNamescope = nameScope;
		grid2.transientNamescope = nameScope;
		sfCircularProgressBar.transientNamescope = nameScope;
		label5.transientNamescope = nameScope;
		border.transientNamescope = nameScope;
		grid3.transientNamescope = nameScope;
		image3.transientNamescope = nameScope;
		label6.transientNamescope = nameScope;
		imageButton.transientNamescope = nameScope;
		grid4.transientNamescope = nameScope;
		image4.transientNamescope = nameScope;
		label7.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		borderedButton2.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid5.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid5.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid5.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto)));
		grid5.SetValue(Grid.RowSpacingProperty, 20.0);
		label.SetValue(Grid.RowProperty, 0);
		bindingExtension.StringFormat = dG038_SemanticDescription;
		bindingExtension.Path = "CustomerName";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 17);
		}
		label.SetBinding(SemanticProperties.DescriptionProperty, bindingBase);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, grid5, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(22, 17)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, dG038_Titel);
		grid5.Children.Add(label);
		label2.SetValue(Grid.RowProperty, 1);
		staticResourceExtension2.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[4] { label2, grid5, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(27, 17)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 17);
		}
		label2.SetValue(VisualElement.StyleProperty, obj2);
		label2.SetValue(Label.TextProperty, dG038_Intro);
		grid5.Children.Add(label2);
		verticalStackLayout2.SetValue(Grid.RowProperty, 2);
		verticalStackLayout2.SetValue(View.MarginProperty, new Thickness(20.0));
		verticalStackLayout2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		verticalStackLayout2.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Fill);
		verticalStackLayout2.SetValue(StackBase.SpacingProperty, 20.0);
		verticalStackLayout2.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		grid.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
		bindingExtension2.Path = "AppIconVisible";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 50);
		}
		grid.SetBinding(VisualElement.IsVisibleProperty, bindingBase2);
		image.SetValue(VisualElement.HeightRequestProperty, 80.0);
		bindingExtension3.Path = "AppIcon";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 25);
		}
		image.SetBinding(Image.SourceProperty, bindingBase3);
		image.SetValue(VisualElement.WidthRequestProperty, 80.0);
		grid.Children.Add(image);
		image2.SetValue(VisualElement.HeightRequestProperty, 81.0);
		((IDynamicResourceHandler)image2).SetDynamicResource(Image.SourceProperty, dynamicResource.Key);
		image2.SetValue(VisualElement.WidthRequestProperty, 81.0);
		grid.Children.Add(image2);
		verticalStackLayout2.Children.Add(grid);
		label3.SetValue(Label.FontSizeProperty, 32.0);
		label3.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Fill);
		label3.SetValue(Label.HorizontalTextAlignmentProperty, TextAlignment.Center);
		bindingExtension4.Path = "CustomerName";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 53, 21);
		}
		label3.SetBinding(Label.TextProperty, bindingBase4);
		verticalStackLayout2.Children.Add(label3);
		bindingExtension5.Path = "IsTimerVisible";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension5(bindingExtension5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 55, 38);
		}
		verticalStackLayout.SetBinding(VisualElement.IsVisibleProperty, bindingBase5);
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 0.0);
		label4.SetValue(Label.HorizontalTextAlignmentProperty, TextAlignment.Center);
		staticResourceExtension3.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[6] { label4, verticalStackLayout, verticalStackLayout2, grid5, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(58, 25)));
		object obj3 = ((IMarkupExtension)staticResourceExtension3).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 58, 25);
		}
		label4.SetValue(VisualElement.StyleProperty, obj3);
		label4.SetValue(Label.TextProperty, dG038_Timeout);
		label4.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		verticalStackLayout.Children.Add(label4);
		sfCircularProgressBar.SetValue(VisualElement.BackgroundColorProperty, Colors.Transparent);
		sfCircularProgressBar.SetValue(VisualElement.HeightRequestProperty, 64.0);
		sfCircularProgressBar.SetValue(ProgressBarBase.MaximumProperty, 30.0);
		sfCircularProgressBar.SetValue(ProgressBarBase.MinimumProperty, 0.0);
		bindingExtension6.Path = "SecondsUsed";
		BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension6(bindingExtension6);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 68, 29);
		}
		sfCircularProgressBar.SetBinding(ProgressBarBase.ProgressProperty, bindingBase6);
		sfCircularProgressBar.SetValue(ProgressBarBase.ProgressFillProperty, new BrushTypeConverter().ConvertFromInvariantString("#FCD2AD") as Brush);
		sfCircularProgressBar.SetValue(SfCircularProgressBar.ProgressRadiusFactorProperty, 0.65);
		staticResourceExtension4.Key = "PrimaryColor";
		XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service4 = new SimpleValueTargetProvider(new object[7] { sfCircularProgressBar, grid2, verticalStackLayout, verticalStackLayout2, grid5, contentView, this }, ProgressBarBase.TrackFillProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider4.Add(typeof(IReferenceProvider), service4);
		xamlServiceProvider4.Add(typeof(IProvideValueTarget), service4);
		xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(71, 29)));
		object obj4 = ((IMarkupExtension)staticResourceExtension4).ProvideValue((IServiceProvider)xamlServiceProvider4);
		if (VisualDiagnostics.GetSourceInfo(obj4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj4, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 71, 29);
		}
		sfCircularProgressBar.SetValue(ProgressBarBase.TrackFillProperty, obj4);
		sfCircularProgressBar.SetValue(SfCircularProgressBar.TrackRadiusFactorProperty, 0.65);
		sfCircularProgressBar.SetValue(VisualElement.WidthRequestProperty, 64.0);
		grid2.Children.Add(sfCircularProgressBar);
		label5.SetValue(Element.AutomationIdProperty, "lblSecondsLeft");
		label5.SetValue(Label.FontAutoScalingEnabledProperty, false);
		label5.SetValue(Label.HorizontalTextAlignmentProperty, TextAlignment.Center);
		bindingExtension7.Path = "SecondsLeft";
		BindingBase bindingBase7 = CreateTypedBindingFrom_bindingExtension7(bindingExtension7);
		if (VisualDiagnostics.GetSourceInfo(bindingBase7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase7, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 79, 29);
		}
		label5.SetBinding(Label.TextProperty, bindingBase7);
		label5.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		grid2.Children.Add(label5);
		verticalStackLayout.Children.Add(grid2);
		verticalStackLayout2.Children.Add(verticalStackLayout);
		grid5.Children.Add(verticalStackLayout2);
		border.SetValue(Grid.RowProperty, 3);
		border.SetValue(Border.PaddingProperty, new Thickness(8.0));
		((IDynamicResourceHandler)border).SetDynamicResource(VisualElement.BackgroundColorProperty, dynamicResource2.Key);
		bindingExtension8.Path = "IsEHASession";
		BindingBase bindingBase8 = CreateTypedBindingFrom_bindingExtension8(bindingExtension8);
		if (VisualDiagnostics.GetSourceInfo(bindingBase8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase8, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 89, 17);
		}
		border.SetBinding(VisualElement.IsVisibleProperty, bindingBase8);
		((IDynamicResourceHandler)border).SetDynamicResource(Border.StrokeProperty, dynamicResource3.Key);
		border.SetValue(Border.StrokeShapeProperty, new StrokeShapeTypeConverter().ConvertFromInvariantString("RoundRectangle 4") as IShape);
		grid3.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Auto), new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
		grid3.SetValue(Grid.ColumnSpacingProperty, 10.0);
		image3.SetValue(Grid.ColumnProperty, 0);
		appThemeBindingExtension.Dark = "digid_icon_timer_dark.png";
		appThemeBindingExtension.Light = "digid_icon_timer.png";
		XamlServiceProvider xamlServiceProvider5 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service5 = new SimpleValueTargetProvider(new object[6] { image3, grid3, border, grid5, contentView, this }, Image.SourceProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider5.Add(typeof(IReferenceProvider), service5);
		xamlServiceProvider5.Add(typeof(IProvideValueTarget), service5);
		xamlServiceProvider5.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(93, 44)));
		BindingBase bindingBase9 = ((IMarkupExtension<BindingBase>)appThemeBindingExtension).ProvideValue((IServiceProvider)xamlServiceProvider5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase9) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase9, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 93, 44);
		}
		image3.SetBinding(Image.SourceProperty, bindingBase9);
		grid3.Children.Add(image3);
		label6.SetValue(Grid.ColumnProperty, 1);
		label6.SetValue(Label.TextProperty, dG038_EHA_Bericht);
		appThemeBindingExtension2.Dark = "White";
		appThemeBindingExtension2.Light = "Black";
		XamlServiceProvider xamlServiceProvider6 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service6 = new SimpleValueTargetProvider(new object[6] { label6, grid3, border, grid5, contentView, this }, Label.TextColorProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider6.Add(typeof(IReferenceProvider), service6);
		xamlServiceProvider6.Add(typeof(IProvideValueTarget), service6);
		xamlServiceProvider6.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(97, 25)));
		BindingBase bindingBase10 = ((IMarkupExtension<BindingBase>)appThemeBindingExtension2).ProvideValue((IServiceProvider)xamlServiceProvider6);
		if (VisualDiagnostics.GetSourceInfo(bindingBase10) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase10, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 97, 25);
		}
		label6.SetBinding(Label.TextColorProperty, bindingBase10);
		label6.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid3.Children.Add(label6);
		imageButton.SetValue(Grid.ColumnProperty, 2);
		bindingExtension9.Path = "OpenEHAExplanationCommand";
		BindingBase bindingBase11 = CreateTypedBindingFrom_bindingExtension9(bindingExtension9);
		if (VisualDiagnostics.GetSourceInfo(bindingBase11) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase11, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 102, 25);
		}
		imageButton.SetBinding(ImageButton.CommandProperty, bindingBase11);
		imageButton.SetValue(ImageButton.SourceProperty, ImageSource.FromFile("digid_icon_question_mark_lite.png"));
		grid3.Children.Add(imageButton);
		border.SetValue(Border.ContentProperty, grid3);
		grid5.Children.Add(border);
		grid4.SetValue(Grid.RowProperty, 4);
		grid4.SetValue(Microsoft.Maui.Controls.Layout.PaddingProperty, new Thickness(16.0));
		staticResourceExtension5.Key = "ToastWarningBackgroundColor";
		XamlServiceProvider xamlServiceProvider7 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service7 = new SimpleValueTargetProvider(new object[4] { grid4, grid5, contentView, this }, VisualElement.BackgroundColorProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider7.Add(typeof(IReferenceProvider), service7);
		xamlServiceProvider7.Add(typeof(IProvideValueTarget), service7);
		xamlServiceProvider7.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(110, 17)));
		object obj5 = ((IMarkupExtension)staticResourceExtension5).ProvideValue((IServiceProvider)xamlServiceProvider7);
		if (VisualDiagnostics.GetSourceInfo(obj5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj5, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 110, 17);
		}
		grid4.SetValue(VisualElement.BackgroundColorProperty, obj5);
		grid4.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(new GridLength(20.0, GridUnitType.Absolute)), new ColumnDefinition(GridLength.Star)));
		staticResourceExtension6.Key = "IsNotNullConverter";
		XamlServiceProvider xamlServiceProvider8 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service8 = new SimpleValueTargetProvider(new object[5] { bindingExtension10, grid4, grid5, contentView, this }, typeof(BindingExtension).GetProperty("Converter"), new INameScope[1] { nameScope }, this);
		xamlServiceProvider8.Add(typeof(IReferenceProvider), service8);
		xamlServiceProvider8.Add(typeof(IProvideValueTarget), service8);
		xamlServiceProvider8.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(112, 17)));
		object obj6 = ((IMarkupExtension)staticResourceExtension6).ProvideValue((IServiceProvider)xamlServiceProvider8);
		if (VisualDiagnostics.GetSourceInfo(obj6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj6, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 112, 17);
		}
		bindingExtension10.Converter = (IValueConverter)obj6;
		bindingExtension10.Path = "IDCheckWillExpireMessage";
		BindingBase bindingBase12 = CreateTypedBindingFrom_bindingExtension10(bindingExtension10);
		if (VisualDiagnostics.GetSourceInfo(bindingBase12) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase12, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 112, 17);
		}
		grid4.SetBinding(VisualElement.IsVisibleProperty, bindingBase12);
		image4.SetValue(Grid.ColumnProperty, 0);
		image4.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Start);
		image4.SetValue(Image.SourceProperty, ImageSource.FromFile("icon_warning.png"));
		image4.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
		grid4.Children.Add(image4);
		label7.SetValue(Grid.ColumnProperty, 1);
		bindingExtension11.Path = "IDCheckWillExpireMessage";
		BindingBase bindingBase13 = CreateTypedBindingFrom_bindingExtension11(bindingExtension11);
		if (VisualDiagnostics.GetSourceInfo(bindingBase13) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase13, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 121, 21);
		}
		label7.SetBinding(Label.TextProperty, bindingBase13);
		label7.SetValue(Label.TextColorProperty, Colors.Black);
		label7.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
		label7.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Start);
		grid4.Children.Add(label7);
		grid5.Children.Add(grid4);
		borderedButton.SetValue(Grid.RowProperty, 5);
		borderedButton.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 0.0, -5.0));
		borderedButton.SetValue(Element.AutomationIdProperty, "CancelButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension12.Path = "AbortCommand";
		BindingBase bindingBase14 = CreateTypedBindingFrom_bindingExtension12(bindingExtension12);
		if (VisualDiagnostics.GetSourceInfo(bindingBase14) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase14, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 132, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase14);
		borderedButton.SetValue(Button.TextProperty, alg_Cancel);
		grid5.Children.Add(borderedButton);
		borderedButton2.SetValue(Grid.RowProperty, 6);
		borderedButton2.SetValue(Element.AutomationIdProperty, "LoginButton");
		borderedButton2.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension13.Path = "ConfirmCommand";
		BindingBase bindingBase15 = CreateTypedBindingFrom_bindingExtension13(bindingExtension13);
		if (VisualDiagnostics.GetSourceInfo(bindingBase15) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase15, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 139, 17);
		}
		borderedButton2.SetBinding(Button.CommandProperty, bindingBase15);
		bindingExtension14.Path = "LoginButtonEnabled";
		BindingBase bindingBase16 = CreateTypedBindingFrom_bindingExtension14(bindingExtension14);
		if (VisualDiagnostics.GetSourceInfo(bindingBase16) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase16, new Uri("Pages\\DG038.xaml;assembly=DigiD.Mobile", UriKind.Relative), 140, 17);
		}
		borderedButton2.SetBinding(VisualElement.IsEnabledProperty, bindingBase16);
		borderedButton2.SetValue(Button.TextProperty, dG038_Knop);
		grid5.Children.Add(borderedButton2);
		contentView.SetValue(ContentView.ContentProperty, grid5);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG038ViewModel, string> setter = null;
			return new TypedBinding<DG038ViewModel, string>((DG038ViewModel source) => (value: source.CustomerName, success: true), setter, new Tuple<Func<DG038ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG038ViewModel, object>, string>((DG038ViewModel source) => source, "CustomerName")
			})
			{
				StringFormat = extension.StringFormat
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension10(BindingExtension extension)
		{
			Action<DG038ViewModel, string> setter = null;
			return new TypedBinding<DG038ViewModel, string>((DG038ViewModel source) => (value: source.IDCheckWillExpireMessage, success: true), setter, new Tuple<Func<DG038ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG038ViewModel, object>, string>((DG038ViewModel source) => source, "IDCheckWillExpireMessage")
			})
			{
				Converter = extension.Converter
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension11(BindingExtension extension)
		{
			Action<DG038ViewModel, string> setter = null;
			return new TypedBinding<DG038ViewModel, string>((DG038ViewModel source) => (value: source.IDCheckWillExpireMessage, success: true), setter, new Tuple<Func<DG038ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG038ViewModel, object>, string>((DG038ViewModel source) => source, "IDCheckWillExpireMessage")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension12(BindingExtension extension)
		{
			Action<DG038ViewModel, ICommand> setter = null;
			return new TypedBinding<DG038ViewModel, ICommand>((DG038ViewModel source) => ((ICommand value, bool success))(value: source.AbortCommand, success: true), setter, new Tuple<Func<DG038ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG038ViewModel, object>, string>((DG038ViewModel source) => source, "AbortCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension13(BindingExtension extension)
		{
			Action<DG038ViewModel, ICommand> setter = null;
			return new TypedBinding<DG038ViewModel, ICommand>((DG038ViewModel source) => ((ICommand value, bool success))(value: source.ConfirmCommand, success: true), setter, new Tuple<Func<DG038ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG038ViewModel, object>, string>((DG038ViewModel source) => source, "ConfirmCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension14(BindingExtension extension)
		{
			Action<DG038ViewModel, bool> setter = null;
			return new TypedBinding<DG038ViewModel, bool>((DG038ViewModel source) => (value: source.LoginButtonEnabled, success: true), setter, new Tuple<Func<DG038ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG038ViewModel, object>, string>((DG038ViewModel source) => source, "LoginButtonEnabled")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG038ViewModel, bool> setter = null;
			return new TypedBinding<DG038ViewModel, bool>((DG038ViewModel source) => (value: source.AppIconVisible, success: true), setter, new Tuple<Func<DG038ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG038ViewModel, object>, string>((DG038ViewModel source) => source, "AppIconVisible")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG038ViewModel, string> setter = delegate(DG038ViewModel source, string? value)
			{
				source.AppIcon = value;
			};
			return new TypedBinding<DG038ViewModel, string>((DG038ViewModel source) => (value: source.AppIcon, success: true), setter, new Tuple<Func<DG038ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG038ViewModel, object>, string>((DG038ViewModel source) => source, "AppIcon")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DG038ViewModel, string> setter = null;
			return new TypedBinding<DG038ViewModel, string>((DG038ViewModel source) => (value: source.CustomerName, success: true), setter, new Tuple<Func<DG038ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG038ViewModel, object>, string>((DG038ViewModel source) => source, "CustomerName")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<DG038ViewModel, bool> setter = delegate(DG038ViewModel source, bool value)
			{
				source.IsTimerVisible = value;
			};
			return new TypedBinding<DG038ViewModel, bool>((DG038ViewModel source) => (value: source.IsTimerVisible, success: true), setter, new Tuple<Func<DG038ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG038ViewModel, object>, string>((DG038ViewModel source) => source, "IsTimerVisible")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension6(BindingExtension extension)
		{
			Action<DG038ViewModel, int> setter = delegate(DG038ViewModel source, int value)
			{
				source.SecondsUsed = value;
			};
			return new TypedBinding<DG038ViewModel, int>((DG038ViewModel source) => (value: source.SecondsUsed, success: true), setter, new Tuple<Func<DG038ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG038ViewModel, object>, string>((DG038ViewModel source) => source, "SecondsUsed")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension7(BindingExtension extension)
		{
			Action<DG038ViewModel, int> setter = delegate(DG038ViewModel source, int value)
			{
				source.SecondsLeft = value;
			};
			return new TypedBinding<DG038ViewModel, int>((DG038ViewModel source) => (value: source.SecondsLeft, success: true), setter, new Tuple<Func<DG038ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG038ViewModel, object>, string>((DG038ViewModel source) => source, "SecondsLeft")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension8(BindingExtension extension)
		{
			Action<DG038ViewModel, bool> setter = delegate(DG038ViewModel source, bool value)
			{
				source.IsEHASession = value;
			};
			return new TypedBinding<DG038ViewModel, bool>((DG038ViewModel source) => (value: source.IsEHASession, success: true), setter, new Tuple<Func<DG038ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG038ViewModel, object>, string>((DG038ViewModel source) => source, "IsEHASession")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension9(BindingExtension extension)
		{
			Action<DG038ViewModel, ICommand> setter = null;
			return new TypedBinding<DG038ViewModel, ICommand>((DG038ViewModel source) => ((ICommand value, bool success))(value: source.OpenEHAExplanationCommand, success: true), setter, new Tuple<Func<DG038ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG038ViewModel, object>, string>((DG038ViewModel source) => source, "OpenEHAExplanationCommand")
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
		this.LoadFromXaml(typeof(DG038));
	}
}
