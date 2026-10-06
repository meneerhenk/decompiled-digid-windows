using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
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

namespace DigiD.Mobile.Pages;

[XamlFilePath("Pages\\DG044.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
public class DG044 : BasePage<DG044ViewModel>
{
	public DG044()
		: base((DG044ViewModel?)null)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG044).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG044)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 17);
		TranslateExtension translateExtension = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 15, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 34);
		DataTemplate dataTemplate = new DataTemplate();
		VisualDiagnostics.RegisterSourceInfo(dataTemplate, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 22);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 14);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 82);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 21);
		TranslateExtension translateExtension2 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension2, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 21);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 18);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 38);
		DataTemplate dataTemplate2 = new DataTemplate();
		VisualDiagnostics.RegisterSourceInfo(dataTemplate2, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 26);
		VerticalStackLayout verticalStackLayout2 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout2, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 18);
		VerticalStackLayout verticalStackLayout3 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout3, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 14);
		VerticalStackLayout verticalStackLayout4 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout4, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 14, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		verticalStackLayout4.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		verticalStackLayout3.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		verticalStackLayout2.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		verticalStackLayout4.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		label.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, verticalStackLayout4, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(17, 17)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		translateExtension.Text = "DG044_Titel";
		BindingBase bindingBase = ((IMarkupExtension<BindingBase>)translateExtension).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 17);
		}
		label.SetBinding(Label.TextProperty, bindingBase);
		verticalStackLayout4.Children.Add(label);
		bindingExtension.Path = "PrimaryMenuItems";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 34);
		}
		verticalStackLayout.SetBinding(BindableLayout.ItemsSourceProperty, bindingBase2);
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 1.0);
		dataTemplate.LoadTemplate = delegate
		{
			BindingExtension bindingExtension4 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 48);
			MenuItemView menuItemView = new MenuItemView();
			VisualDiagnostics.RegisterSourceInfo(menuItemView, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 26);
			INameScope value = new NameScope();
			NameScope.SetNameScope(menuItemView, value);
			bindingExtension4.Path = "AutomationId";
			BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension3(bindingExtension4);
			if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 48);
			}
			menuItemView.SetBinding(Element.AutomationIdProperty, bindingBase6);
			return menuItemView;
		};
		verticalStackLayout.SetValue(BindableLayout.ItemTemplateProperty, dataTemplate);
		verticalStackLayout4.Children.Add(verticalStackLayout);
		verticalStackLayout3.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		bindingExtension2.Path = "SecondMenuVisible";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension4(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 82);
		}
		verticalStackLayout3.SetBinding(VisualElement.IsVisibleProperty, bindingBase3);
		label2.SetValue(View.MarginProperty, new Thickness(20.0, 20.0, 20.0, 20.0));
		staticResourceExtension2.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[5] { label2, verticalStackLayout3, verticalStackLayout4, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(31, 21)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 21);
		}
		label2.SetValue(VisualElement.StyleProperty, obj2);
		translateExtension2.Text = "DG044_Subtitel";
		BindingBase bindingBase4 = ((IMarkupExtension<BindingBase>)translateExtension2).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 21);
		}
		label2.SetBinding(Label.TextProperty, bindingBase4);
		verticalStackLayout3.Children.Add(label2);
		bindingExtension3.Path = "SecondMenuItems";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension5(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 38);
		}
		verticalStackLayout2.SetBinding(BindableLayout.ItemsSourceProperty, bindingBase5);
		verticalStackLayout2.SetValue(StackBase.SpacingProperty, 1.0);
		dataTemplate2.LoadTemplate = delegate
		{
			BindingExtension bindingExtension4 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 52);
			MenuItemView menuItemView = new MenuItemView();
			VisualDiagnostics.RegisterSourceInfo(menuItemView, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 30);
			INameScope value = new NameScope();
			NameScope.SetNameScope(menuItemView, value);
			bindingExtension4.Path = "AutomationId";
			BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension6(bindingExtension4);
			if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DG044.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 52);
			}
			menuItemView.SetBinding(Element.AutomationIdProperty, bindingBase6);
			return menuItemView;
		};
		verticalStackLayout2.SetValue(BindableLayout.ItemTemplateProperty, dataTemplate2);
		verticalStackLayout3.Children.Add(verticalStackLayout2);
		verticalStackLayout4.Children.Add(verticalStackLayout3);
		contentView.SetValue(ContentView.ContentProperty, verticalStackLayout4);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG044ViewModel, List<DigiD.Common.Controls.Models.MenuItem>> setter = delegate(DG044ViewModel source, List<DigiD.Common.Controls.Models.MenuItem> value)
			{
				source.PrimaryMenuItems = value;
			};
			return new TypedBinding<DG044ViewModel, List<DigiD.Common.Controls.Models.MenuItem>>((DG044ViewModel source) => (value: source.PrimaryMenuItems, success: true), setter, new Tuple<Func<DG044ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG044ViewModel, object>, string>((DG044ViewModel source) => source, "PrimaryMenuItems")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DigiD.Common.Controls.Models.MenuItem, string> setter = null;
			return new TypedBinding<DigiD.Common.Controls.Models.MenuItem, string>((DigiD.Common.Controls.Models.MenuItem source) => (value: source.AutomationId, success: true), setter, new Tuple<Func<DigiD.Common.Controls.Models.MenuItem, object>, string>[1]
			{
				new Tuple<Func<DigiD.Common.Controls.Models.MenuItem, object>, string>((DigiD.Common.Controls.Models.MenuItem source) => source, "AutomationId")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DG044ViewModel, bool> setter = delegate(DG044ViewModel source, bool value)
			{
				source.SecondMenuVisible = value;
			};
			return new TypedBinding<DG044ViewModel, bool>((DG044ViewModel source) => (value: source.SecondMenuVisible, success: true), setter, new Tuple<Func<DG044ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG044ViewModel, object>, string>((DG044ViewModel source) => source, "SecondMenuVisible")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<DG044ViewModel, List<DigiD.Common.Controls.Models.MenuItem>> setter = delegate(DG044ViewModel source, List<DigiD.Common.Controls.Models.MenuItem> value)
			{
				source.SecondMenuItems = value;
			};
			return new TypedBinding<DG044ViewModel, List<DigiD.Common.Controls.Models.MenuItem>>((DG044ViewModel source) => (value: source.SecondMenuItems, success: true), setter, new Tuple<Func<DG044ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG044ViewModel, object>, string>((DG044ViewModel source) => source, "SecondMenuItems")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension6(BindingExtension extension)
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
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(DG044));
	}
}
