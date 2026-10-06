using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Models;
using DigiD.Mobile.ViewModels;
using LocalizationResourceManager.Maui;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.Pages;

[XamlFilePath("Pages\\DG046.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG046 : BasePage<DG046ViewModel>
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label header;

	public DG046(DG046ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("header")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG046).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG046)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG046.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG046.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 17);
		TranslateExtension translateExtension = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension, new Uri("Pages\\DG046.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG046.xaml;assembly=DigiD.Mobile", UriKind.Relative), 15, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG046.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 17);
		DataTemplate dataTemplate = new DataTemplate();
		VisualDiagnostics.RegisterSourceInfo(dataTemplate, new Uri("Pages\\DG046.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 22);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\DG046.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 14);
		VerticalStackLayout verticalStackLayout2 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout2, new Uri("Pages\\DG046.xaml;assembly=DigiD.Mobile", UriKind.Relative), 14, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG046.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG046.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		verticalStackLayout2.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		nameScope.RegisterName("header", label);
		Label label2 = label;
		if (label2.StyleId == null)
		{
			string text = (label2.StyleId = "header");
		}
		verticalStackLayout.transientNamescope = nameScope;
		header = label;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		verticalStackLayout2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		label.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		label.SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, verticalStackLayout2, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(19, 17)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG046.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		translateExtension.Text = "DG046_Titel";
		BindingBase bindingBase = ((IMarkupExtension<BindingBase>)translateExtension).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG046.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 17);
		}
		label.SetBinding(Label.TextProperty, bindingBase);
		verticalStackLayout2.Children.Add(label);
		verticalStackLayout.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		bindingExtension.Path = "MenuItems";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG046.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 17);
		}
		verticalStackLayout.SetBinding(BindableLayout.ItemsSourceProperty, bindingBase2);
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 1.0);
		dataTemplate.LoadTemplate = delegate
		{
			BindingExtension bindingExtension2 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG046.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 48);
			MenuItemView menuItemView = new MenuItemView();
			VisualDiagnostics.RegisterSourceInfo(menuItemView, new Uri("Pages\\DG046.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 26);
			INameScope value = new NameScope();
			NameScope.SetNameScope(menuItemView, value);
			bindingExtension2.Path = "AutomationId";
			BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
			if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG046.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 48);
			}
			menuItemView.SetBinding(Element.AutomationIdProperty, bindingBase3);
			return menuItemView;
		};
		verticalStackLayout.SetValue(BindableLayout.ItemTemplateProperty, dataTemplate);
		verticalStackLayout2.Children.Add(verticalStackLayout);
		contentView.SetValue(ContentView.ContentProperty, verticalStackLayout2);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG046ViewModel, List<DigiD.Common.Controls.Models.MenuItem>> setter = delegate(DG046ViewModel source, List<DigiD.Common.Controls.Models.MenuItem> value)
			{
				source.MenuItems = value;
			};
			return new TypedBinding<DG046ViewModel, List<DigiD.Common.Controls.Models.MenuItem>>((DG046ViewModel source) => (value: source.MenuItems, success: true), setter, new Tuple<Func<DG046ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG046ViewModel, object>, string>((DG046ViewModel source) => source, "MenuItems")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DigiD.Common.Controls.Models.MenuItem, string> setter = null;
			return new TypedBinding<DigiD.Common.Controls.Models.MenuItem, string>((DigiD.Common.Controls.Models.MenuItem source) => (value: source.AutomationId, success: true), setter, new Tuple<Func<DigiD.Common.Controls.Models.MenuItem, object>, string>[1]
			{
				new Tuple<Func<DigiD.Common.Controls.Models.MenuItem, object>, string>((DigiD.Common.Controls.Models.MenuItem source) => source, "AutomationId")
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
	[MemberNotNull("header")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(DG046));
		header = this.FindByName<Label>("header");
	}
}
