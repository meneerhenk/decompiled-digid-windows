using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Input;
using CommunityToolkit.Maui.Layouts;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Resources;
using DigiD.Mobile.Controls;
using DigiD.Mobile.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.Pages;

[XamlFilePath("Pages\\DG057.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG057 : BasePage<DG057ViewModel>
{
	public DG057(DG057ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG057).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG057)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 14, 18);
		DynamicResource dynamicResource = new DynamicResource("TabBackgroundColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 17);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 21);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 21);
		string dG057_Knop_App = DigiDAppResources.DG057_Knop_App;
		VisualDiagnostics.RegisterSourceInfo(dG057_Knop_App, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 21);
		CustomTabButton customTabButton = new CustomTabButton();
		VisualDiagnostics.RegisterSourceInfo(customTabButton, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 18);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 21);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 21);
		string dG057_Knop_WID = DigiDAppResources.DG057_Knop_WID;
		VisualDiagnostics.RegisterSourceInfo(dG057_Knop_WID, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 38, 21);
		CustomTabButton customTabButton2 = new CustomTabButton();
		VisualDiagnostics.RegisterSourceInfo(customTabButton2, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 18);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 14);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 41, 47);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 32);
		string dG057_Titel_App = DigiDAppResources.DG057_Titel_App;
		VisualDiagnostics.RegisterSourceInfo(dG057_Titel_App, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 69);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 26);
		string dG057_Intro_App = DigiDAppResources.DG057_Intro_App;
		VisualDiagnostics.RegisterSourceInfo(dG057_Intro_App, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 49, 32);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 49, 26);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 50, 26);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 22);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 60, 32);
		string dG057_Titel_WID = DigiDAppResources.DG057_Titel_WID;
		VisualDiagnostics.RegisterSourceInfo(dG057_Titel_WID, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 60, 69);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 60, 26);
		string dG057_Intro_WID = DigiDAppResources.DG057_Intro_WID;
		VisualDiagnostics.RegisterSourceInfo(dG057_Intro_WID, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 62, 32);
		Label label4 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label4, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 62, 26);
		string dG057_WID_Document = DigiDAppResources.DG057_WID_Document;
		VisualDiagnostics.RegisterSourceInfo(dG057_WID_Document, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 65, 29);
		Image image2 = new Image();
		VisualDiagnostics.RegisterSourceInfo(image2, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 63, 26);
		VerticalStackLayout verticalStackLayout2 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout2, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 56, 22);
		VerticalStackLayout verticalStackLayout3 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout3, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 41, 14);
		BindingExtension bindingExtension6 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 76, 17);
		string alg_Next = CommonResources.Alg_Next;
		VisualDiagnostics.RegisterSourceInfo(alg_Next, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 77, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 71, 14);
		Grid grid2 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid2, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 15, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 14, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid2.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		customTabButton.transientNamescope = nameScope;
		customTabButton2.transientNamescope = nameScope;
		verticalStackLayout3.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		image.transientNamescope = nameScope;
		verticalStackLayout2.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		label4.transientNamescope = nameScope;
		image2.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid2.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Auto)));
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		((IDynamicResourceHandler)grid).SetDynamicResource(VisualElement.BackgroundColorProperty, dynamicResource.Key);
		grid.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Star)));
		customTabButton.SetValue(Grid.ColumnProperty, 0);
		customTabButton.SetValue(Element.AutomationIdProperty, "TabAppButton");
		bindingExtension.Path = "TabAppButtonType";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 21);
		}
		customTabButton.SetBinding(BorderedButton.ButtonTypeProperty, bindingBase);
		bindingExtension2.Path = "TabSelectedCommand";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 21);
		}
		customTabButton.SetBinding(Button.CommandProperty, bindingBase2);
		customTabButton.SetValue(Button.CommandParameterProperty, "App");
		customTabButton.NumberOfTabs = 2;
		customTabButton.TabIndex = 1;
		customTabButton.SetValue(Button.TextProperty, dG057_Knop_App);
		grid.Children.Add(customTabButton);
		customTabButton2.SetValue(Grid.ColumnProperty, 1);
		customTabButton2.SetValue(Element.AutomationIdProperty, "TabCardButton");
		bindingExtension3.Path = "TabCardButtonType";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 21);
		}
		customTabButton2.SetBinding(BorderedButton.ButtonTypeProperty, bindingBase3);
		bindingExtension4.Path = "TabSelectedCommand";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 21);
		}
		customTabButton2.SetBinding(Button.CommandProperty, bindingBase4);
		customTabButton2.SetValue(Button.CommandParameterProperty, "Card");
		customTabButton2.NumberOfTabs = 2;
		customTabButton2.TabIndex = 2;
		customTabButton2.SetValue(Button.TextProperty, dG057_Knop_WID);
		grid.Children.Add(customTabButton2);
		grid2.Children.Add(grid);
		verticalStackLayout3.SetValue(Grid.RowProperty, 1);
		bindingExtension5.Path = "SelectedTab";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension5(bindingExtension5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 41, 47);
		}
		verticalStackLayout3.SetBinding(StateContainer.CurrentStateProperty, bindingBase5);
		verticalStackLayout.SetValue(Microsoft.Maui.Controls.Layout.PaddingProperty, new Thickness(20.0));
		verticalStackLayout.SetValue(StateView.StateKeyProperty, "App");
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 20.0);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[6] { label, verticalStackLayout, verticalStackLayout3, grid2, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(47, 32)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 32);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, dG057_Titel_App);
		verticalStackLayout.Children.Add(label);
		label2.SetValue(Label.TextProperty, dG057_Intro_App);
		verticalStackLayout.Children.Add(label2);
		image.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		image.SetValue(Image.SourceProperty, ImageSource.FromFile("digid_afbeelding_pincode_wijzigen_app.png"));
		image.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		verticalStackLayout.Children.Add(image);
		IList<View> list = (IList<View>)verticalStackLayout3.GetValue(StateContainer.StateViewsProperty);
		list.Add(verticalStackLayout);
		verticalStackLayout2.SetValue(Microsoft.Maui.Controls.Layout.PaddingProperty, new Thickness(20.0));
		verticalStackLayout2.SetValue(StateView.StateKeyProperty, "Card");
		verticalStackLayout2.SetValue(StackBase.SpacingProperty, 20.0);
		staticResourceExtension2.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[6] { label3, verticalStackLayout2, verticalStackLayout3, grid2, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(60, 32)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 60, 32);
		}
		label3.SetValue(VisualElement.StyleProperty, obj2);
		label3.SetValue(Label.TextProperty, dG057_Titel_WID);
		verticalStackLayout2.Children.Add(label3);
		label4.SetValue(Label.TextProperty, dG057_Intro_WID);
		verticalStackLayout2.Children.Add(label4);
		image2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		image2.SetValue(Image.SourceProperty, dG057_WID_Document);
		image2.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		verticalStackLayout2.Children.Add(image2);
		list.Add(verticalStackLayout2);
		grid2.Children.Add(verticalStackLayout3);
		borderedButton.SetValue(Grid.RowProperty, 2);
		borderedButton.SetValue(View.MarginProperty, new Thickness(20.0));
		borderedButton.SetValue(Element.AutomationIdProperty, "NextButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension6.Path = "NextCommand";
		BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension6(bindingExtension6);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DG057.xaml;assembly=DigiD.Mobile", UriKind.Relative), 76, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase6);
		borderedButton.SetValue(Button.TextProperty, alg_Next);
		borderedButton.SetValue(VisualElement.ZIndexProperty, 10);
		grid2.Children.Add(borderedButton);
		contentView.SetValue(ContentView.ContentProperty, grid2);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG057ViewModel, ButtonType> setter = null;
			return new TypedBinding<DG057ViewModel, ButtonType>((DG057ViewModel source) => (value: source.TabAppButtonType, success: true), setter, new Tuple<Func<DG057ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG057ViewModel, object>, string>((DG057ViewModel source) => source, "TabAppButtonType")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG057ViewModel, ICommand> setter = null;
			return new TypedBinding<DG057ViewModel, ICommand>((DG057ViewModel source) => ((ICommand value, bool success))(value: source.TabSelectedCommand, success: true), setter, new Tuple<Func<DG057ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG057ViewModel, object>, string>((DG057ViewModel source) => source, "TabSelectedCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG057ViewModel, ButtonType> setter = null;
			return new TypedBinding<DG057ViewModel, ButtonType>((DG057ViewModel source) => (value: source.TabCardButtonType, success: true), setter, new Tuple<Func<DG057ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG057ViewModel, object>, string>((DG057ViewModel source) => source, "TabCardButtonType")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DG057ViewModel, ICommand> setter = null;
			return new TypedBinding<DG057ViewModel, ICommand>((DG057ViewModel source) => ((ICommand value, bool success))(value: source.TabSelectedCommand, success: true), setter, new Tuple<Func<DG057ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG057ViewModel, object>, string>((DG057ViewModel source) => source, "TabSelectedCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<DG057ViewModel, string> setter = delegate(DG057ViewModel source, string value)
			{
				source.SelectedTab = value;
			};
			return new TypedBinding<DG057ViewModel, string>((DG057ViewModel source) => (value: source.SelectedTab, success: true), setter, new Tuple<Func<DG057ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG057ViewModel, object>, string>((DG057ViewModel source) => source, "SelectedTab")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension6(BindingExtension extension)
		{
			Action<DG057ViewModel, ICommand> setter = null;
			return new TypedBinding<DG057ViewModel, ICommand>((DG057ViewModel source) => ((ICommand value, bool success))(value: source.NextCommand, success: true), setter, new Tuple<Func<DG057ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG057ViewModel, object>, string>((DG057ViewModel source) => source, "NextCommand")
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
		this.LoadFromXaml(typeof(DG057));
	}
}
