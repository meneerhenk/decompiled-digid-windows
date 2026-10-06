using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Helpers;
using DigiD.Common.Models;
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

[XamlFilePath("Pages\\DG066.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG066 : BasePage<DG066ViewModel>
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private BasePage<DG066ViewModel> Page;

	public DG066(DG066ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	private void OnLabelFocused(object? sender, FocusEventArgs e)
	{
		Color color = (ThemeHelper.IsInDarkMode ? Colors.White : Colors.Black);
		Color color2 = (ThemeHelper.IsInDarkMode ? Colors.Black : Colors.White);
		Color color3 = (ThemeHelper.IsInDarkMode ? Colors.White : Colors.Black);
		if (sender is Label label)
		{
			label.BackgroundColor = (e.IsFocused ? color : Colors.Transparent);
			label.TextColor = (e.IsFocused ? color2 : color3);
		}
	}

	private void LabelOnHandlerChanged(object? sender, EventArgs e)
	{
		Label label = sender as Label;
		if (label != null)
		{
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("Page")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG066).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG066)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 15, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 17);
		TranslateExtension translateExtension = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 14);
		TranslateExtension translateExtension2 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension2, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 67);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 17);
		DataTemplate dataTemplate = new DataTemplate();
		VisualDiagnostics.RegisterSourceInfo(dataTemplate, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 22);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 14);
		VerticalStackLayout verticalStackLayout2 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout2, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 15, 6);
		DG066 __root = this;
		VisualDiagnostics.RegisterSourceInfo(__root, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope iNameScope = NameScope.GetNameScope(__root) ?? new NameScope();
		NameScope.SetNameScope(__root, iNameScope);
		iNameScope.RegisterName("Page", __root);
		DG066 dG = __root;
		if (dG.StyleId == null)
		{
			string text = (dG.StyleId = "Page");
		}
		contentView.transientNamescope = iNameScope;
		verticalStackLayout2.transientNamescope = iNameScope;
		label.transientNamescope = iNameScope;
		label2.transientNamescope = iNameScope;
		verticalStackLayout.transientNamescope = iNameScope;
		Page = __root;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		verticalStackLayout2.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		verticalStackLayout2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		verticalStackLayout2.SetValue(StackBase.SpacingProperty, 20.0);
		label.SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(__root);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, verticalStackLayout2, contentView, __root }, VisualElement.StyleProperty, new INameScope[1] { iNameScope }, __root);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(22, 17)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		translateExtension.Text = "DG066_Titel";
		BindingBase bindingBase = ((IMarkupExtension<BindingBase>)translateExtension).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 17);
		}
		label.SetBinding(Label.TextProperty, bindingBase);
		verticalStackLayout2.Children.Add(label);
		label2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
		translateExtension2.Text = "DG066_Intro";
		BindingBase bindingBase2 = ((IMarkupExtension<BindingBase>)translateExtension2).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 67);
		}
		label2.SetBinding(Label.TextProperty, bindingBase2);
		verticalStackLayout2.Children.Add(label2);
		verticalStackLayout.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		bindingExtension.Path = "Items";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 17);
		}
		verticalStackLayout.SetBinding(BindableLayout.ItemsSourceProperty, bindingBase3);
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 20.0);
		dataTemplate.LoadTemplate = delegate
		{
			StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
			VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 33);
			BindingExtension bindingExtension2 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 44, 33);
			Label label3 = new Label();
			VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 30);
			BindingExtension bindingExtension3 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 54, 33);
			Label label4 = new Label();
			VisualDiagnostics.RegisterSourceInfo(label4, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 30);
			ReferenceExtension referenceExtension = new ReferenceExtension();
			VisualDiagnostics.RegisterSourceInfo(referenceExtension, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 61, 33);
			BindingExtension bindingExtension4 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 61, 33);
			BindingExtension bindingExtension5 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 62, 33);
			StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension();
			VisualDiagnostics.RegisterSourceInfo(staticResourceExtension3, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 64, 33);
			BindingExtension bindingExtension6 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 64, 33);
			string dG066_Project_Site = DigiDAppResources.DG066_Project_Site;
			VisualDiagnostics.RegisterSourceInfo(dG066_Project_Site, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 65, 33);
			LinkLabel linkLabel = new LinkLabel();
			VisualDiagnostics.RegisterSourceInfo(linkLabel, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 57, 30);
			ReferenceExtension referenceExtension2 = new ReferenceExtension();
			VisualDiagnostics.RegisterSourceInfo(referenceExtension2, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 71, 33);
			BindingExtension bindingExtension7 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension7, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 71, 33);
			BindingExtension bindingExtension8 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension8, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 72, 33);
			StaticResourceExtension staticResourceExtension4 = new StaticResourceExtension();
			VisualDiagnostics.RegisterSourceInfo(staticResourceExtension4, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 74, 33);
			BindingExtension bindingExtension9 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension9, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 74, 33);
			string dG066_Licentie_Site = DigiDAppResources.DG066_Licentie_Site;
			VisualDiagnostics.RegisterSourceInfo(dG066_Licentie_Site, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 75, 33);
			LinkLabel linkLabel2 = new LinkLabel();
			VisualDiagnostics.RegisterSourceInfo(linkLabel2, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 67, 30);
			Grid grid = new Grid();
			VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 26);
			INameScope nameScope = new NameScope();
			NameScope.SetNameScope(grid, nameScope);
			label3.transientNamescope = nameScope;
			nameScope.RegisterName("title", label3);
			Label label5 = label3;
			if (label5.StyleId == null)
			{
				string text3 = (label5.StyleId = "title");
			}
			label4.transientNamescope = nameScope;
			nameScope.RegisterName("description", label4);
			label5 = label4;
			if (label5.StyleId == null)
			{
				string text3 = (label5.StyleId = "description");
			}
			linkLabel.transientNamescope = nameScope;
			nameScope.RegisterName("linkProjectSite", linkLabel);
			LinkLabel linkLabel3 = linkLabel;
			if (linkLabel3.StyleId == null)
			{
				string text3 = (linkLabel3.StyleId = "linkProjectSite");
			}
			linkLabel2.transientNamescope = nameScope;
			nameScope.RegisterName("linkLicenseSite", linkLabel2);
			linkLabel3 = linkLabel2;
			if (linkLabel3.StyleId == null)
			{
				string text3 = (linkLabel3.StyleId = "linkLicenseSite");
			}
			grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
			grid.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Star)));
			grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto)));
			label3.SetValue(Grid.RowProperty, 0);
			label3.SetValue(Grid.ColumnSpanProperty, 2);
			label3.Focused += OnLabelFocused;
			label3.HandlerChanged += LabelOnHandlerChanged;
			staticResourceExtension2.Key = "LabelBold";
			XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
			SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[7] { label3, grid, dataTemplate, verticalStackLayout, verticalStackLayout2, contentView, __root }, VisualElement.StyleProperty, new INameScope[2] { nameScope, iNameScope }, this);
			xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
			xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
			xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(43, 33)));
			object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
			if (VisualDiagnostics.GetSourceInfo(obj2) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 33);
			}
			label3.SetValue(VisualElement.StyleProperty, obj2);
			bindingExtension2.Path = "Title";
			BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
			if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 44, 33);
			}
			label3.SetBinding(Label.TextProperty, bindingBase4);
			label3.Unfocused += OnLabelFocused;
			grid.Children.Add(label3);
			label4.SetValue(Grid.RowProperty, 1);
			label4.SetValue(Grid.ColumnSpanProperty, 2);
			label4.SetValue(VisualElement.BackgroundColorProperty, Colors.Transparent);
			label4.Focused += OnLabelFocused;
			label4.HandlerChanged += LabelOnHandlerChanged;
			bindingExtension3.Path = "Description";
			BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
			if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 54, 33);
			}
			label4.SetBinding(Label.TextProperty, bindingBase5);
			label4.Unfocused += OnLabelFocused;
			grid.Children.Add(label4);
			linkLabel.SetValue(Grid.RowProperty, 2);
			linkLabel.SetValue(Grid.ColumnProperty, 0);
			referenceExtension.Name = "Page";
			DG066 dG2 = __root;
			if (VisualDiagnostics.GetSourceInfo(dG2) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(dG2, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 61, 33);
			}
			bindingExtension4.Source = dG2;
			bindingExtension4.Path = "BindingContext.OpenWebsiteCommand";
			Binding binding = new Binding(bindingExtension4.Path, bindingExtension4.Mode, bindingExtension4.Converter, bindingExtension4.ConverterParameter, bindingExtension4.StringFormat, bindingExtension4.Source)
			{
				UpdateSourceEventName = bindingExtension4.UpdateSourceEventName,
				FallbackValue = bindingExtension4.FallbackValue,
				TargetNullValue = bindingExtension4.TargetNullValue
			};
			if (VisualDiagnostics.GetSourceInfo(binding) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(binding, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 61, 33);
			}
			linkLabel.SetBinding(LinkLabel.CommandProperty, binding);
			bindingExtension5.Path = "ProjectUrl";
			BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension4(bindingExtension5);
			if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 62, 33);
			}
			linkLabel.SetBinding(LinkLabel.CommandArgumentsProperty, bindingBase6);
			linkLabel.SetValue(LinkLabel.IsExternalLinkProperty, true);
			staticResourceExtension3.Key = "IsNotNullConverter";
			XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
			SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[8] { bindingExtension6, linkLabel, grid, dataTemplate, verticalStackLayout, verticalStackLayout2, contentView, __root }, typeof(BindingExtension).GetProperty("Converter"), new INameScope[2] { nameScope, iNameScope }, this);
			xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
			xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
			xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(64, 33)));
			object obj3 = ((IMarkupExtension)staticResourceExtension3).ProvideValue((IServiceProvider)xamlServiceProvider3);
			if (VisualDiagnostics.GetSourceInfo(obj3) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 64, 33);
			}
			bindingExtension6.Converter = (IValueConverter)obj3;
			bindingExtension6.Path = "ProjectUrl";
			BindingBase bindingBase7 = CreateTypedBindingFrom_bindingExtension5(bindingExtension6);
			if (VisualDiagnostics.GetSourceInfo(bindingBase7) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase7, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 64, 33);
			}
			linkLabel.SetBinding(VisualElement.IsVisibleProperty, bindingBase7);
			linkLabel.SetValue(LinkLabel.TextProperty, dG066_Project_Site);
			grid.Children.Add(linkLabel);
			linkLabel2.SetValue(Grid.RowProperty, 2);
			linkLabel2.SetValue(Grid.ColumnProperty, 1);
			referenceExtension2.Name = "Page";
			DG066 dG3 = __root;
			if (VisualDiagnostics.GetSourceInfo(dG3) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(dG3, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 71, 33);
			}
			bindingExtension7.Source = dG3;
			bindingExtension7.Path = "BindingContext.OpenWebsiteCommand";
			Binding binding2 = new Binding(bindingExtension7.Path, bindingExtension7.Mode, bindingExtension7.Converter, bindingExtension7.ConverterParameter, bindingExtension7.StringFormat, bindingExtension7.Source)
			{
				UpdateSourceEventName = bindingExtension7.UpdateSourceEventName,
				FallbackValue = bindingExtension7.FallbackValue,
				TargetNullValue = bindingExtension7.TargetNullValue
			};
			if (VisualDiagnostics.GetSourceInfo(binding2) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(binding2, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 71, 33);
			}
			linkLabel2.SetBinding(LinkLabel.CommandProperty, binding2);
			bindingExtension8.Path = "LicenseUrl";
			BindingBase bindingBase8 = CreateTypedBindingFrom_bindingExtension7(bindingExtension8);
			if (VisualDiagnostics.GetSourceInfo(bindingBase8) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase8, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 72, 33);
			}
			linkLabel2.SetBinding(LinkLabel.CommandArgumentsProperty, bindingBase8);
			linkLabel2.SetValue(LinkLabel.IsExternalLinkProperty, true);
			staticResourceExtension4.Key = "IsNotNullConverter";
			XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider(this);
			SimpleValueTargetProvider service4 = new SimpleValueTargetProvider(new object[8] { bindingExtension9, linkLabel2, grid, dataTemplate, verticalStackLayout, verticalStackLayout2, contentView, __root }, typeof(BindingExtension).GetProperty("Converter"), new INameScope[2] { nameScope, iNameScope }, this);
			xamlServiceProvider4.Add(typeof(IReferenceProvider), service4);
			xamlServiceProvider4.Add(typeof(IProvideValueTarget), service4);
			xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(74, 33)));
			object obj4 = ((IMarkupExtension)staticResourceExtension4).ProvideValue((IServiceProvider)xamlServiceProvider4);
			if (VisualDiagnostics.GetSourceInfo(obj4) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(obj4, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 74, 33);
			}
			bindingExtension9.Converter = (IValueConverter)obj4;
			bindingExtension9.Path = "LicenseUrl";
			BindingBase bindingBase9 = CreateTypedBindingFrom_bindingExtension8(bindingExtension9);
			if (VisualDiagnostics.GetSourceInfo(bindingBase9) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase9, new Uri("Pages\\DG066.xaml;assembly=DigiD.Mobile", UriKind.Relative), 74, 33);
			}
			linkLabel2.SetBinding(VisualElement.IsVisibleProperty, bindingBase9);
			linkLabel2.SetValue(LinkLabel.TextProperty, dG066_Licentie_Site);
			grid.Children.Add(linkLabel2);
			return grid;
		};
		verticalStackLayout.SetValue(BindableLayout.ItemTemplateProperty, dataTemplate);
		verticalStackLayout2.Children.Add(verticalStackLayout);
		contentView.SetValue(ContentView.ContentProperty, verticalStackLayout2);
		__root.SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG066ViewModel, List<OpenSourceLibraryModel>> setter = delegate(DG066ViewModel source, List<OpenSourceLibraryModel>? value)
			{
				source.Items = value;
			};
			return new TypedBinding<DG066ViewModel, List<OpenSourceLibraryModel>>((DG066ViewModel source) => (value: source.Items, success: true), setter, new Tuple<Func<DG066ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG066ViewModel, object>, string>((DG066ViewModel source) => source, "Items")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<OpenSourceLibraryModel, string> setter = delegate(OpenSourceLibraryModel source, string value)
			{
				source.Title = value;
			};
			return new TypedBinding<OpenSourceLibraryModel, string>((OpenSourceLibraryModel source) => (value: source.Title, success: true), setter, new Tuple<Func<OpenSourceLibraryModel, object>, string>[1]
			{
				new Tuple<Func<OpenSourceLibraryModel, object>, string>((OpenSourceLibraryModel source) => source, "Title")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<OpenSourceLibraryModel, string> setter = delegate(OpenSourceLibraryModel source, string value)
			{
				source.Description = value;
			};
			return new TypedBinding<OpenSourceLibraryModel, string>((OpenSourceLibraryModel source) => (value: source.Description, success: true), setter, new Tuple<Func<OpenSourceLibraryModel, object>, string>[1]
			{
				new Tuple<Func<OpenSourceLibraryModel, object>, string>((OpenSourceLibraryModel source) => source, "Description")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<OpenSourceLibraryModel, Uri> setter = delegate(OpenSourceLibraryModel source, Uri? value)
			{
				source.ProjectUrl = value;
			};
			return new TypedBinding<OpenSourceLibraryModel, Uri>((OpenSourceLibraryModel source) => (value: source.ProjectUrl, success: true), setter, new Tuple<Func<OpenSourceLibraryModel, object>, string>[1]
			{
				new Tuple<Func<OpenSourceLibraryModel, object>, string>((OpenSourceLibraryModel source) => source, "ProjectUrl")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<OpenSourceLibraryModel, Uri> setter = delegate(OpenSourceLibraryModel source, Uri? value)
			{
				source.ProjectUrl = value;
			};
			return new TypedBinding<OpenSourceLibraryModel, Uri>((OpenSourceLibraryModel source) => (value: source.ProjectUrl, success: true), setter, new Tuple<Func<OpenSourceLibraryModel, object>, string>[1]
			{
				new Tuple<Func<OpenSourceLibraryModel, object>, string>((OpenSourceLibraryModel source) => source, "ProjectUrl")
			})
			{
				Converter = extension.Converter
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension7(BindingExtension extension)
		{
			Action<OpenSourceLibraryModel, Uri> setter = delegate(OpenSourceLibraryModel source, Uri? value)
			{
				source.LicenseUrl = value;
			};
			return new TypedBinding<OpenSourceLibraryModel, Uri>((OpenSourceLibraryModel source) => (value: source.LicenseUrl, success: true), setter, new Tuple<Func<OpenSourceLibraryModel, object>, string>[1]
			{
				new Tuple<Func<OpenSourceLibraryModel, object>, string>((OpenSourceLibraryModel source) => source, "LicenseUrl")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension8(BindingExtension extension)
		{
			Action<OpenSourceLibraryModel, Uri> setter = delegate(OpenSourceLibraryModel source, Uri? value)
			{
				source.LicenseUrl = value;
			};
			return new TypedBinding<OpenSourceLibraryModel, Uri>((OpenSourceLibraryModel source) => (value: source.LicenseUrl, success: true), setter, new Tuple<Func<OpenSourceLibraryModel, object>, string>[1]
			{
				new Tuple<Func<OpenSourceLibraryModel, object>, string>((OpenSourceLibraryModel source) => source, "LicenseUrl")
			})
			{
				Converter = extension.Converter
			};
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
	[MemberNotNull("Page")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(DG066));
		Page = this.FindByName<BasePage<DG066ViewModel>>("Page");
	}
}
