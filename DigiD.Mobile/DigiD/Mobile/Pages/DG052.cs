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
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.Pages;

[XamlFilePath("Pages\\DG052.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG052 : BasePage<DG052ViewModel>
{
	public DG052(DG052ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG052).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG052)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 17);
		TranslateExtension translateExtension = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 15, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 34);
		DataTemplate dataTemplate = new DataTemplate();
		VisualDiagnostics.RegisterSourceInfo(dataTemplate, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 22);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 14);
		OnPlatformExtension onPlatformExtension = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 34);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 21);
		TranslateExtension translateExtension2 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension2, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 21);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 18);
		TranslateExtension translateExtension3 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension3, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 45);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 18);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 21);
		MenuItemView menuItemView = new MenuItemView();
		VisualDiagnostics.RegisterSourceInfo(menuItemView, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 18);
		VerticalStackLayout verticalStackLayout2 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout2, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 14);
		VerticalStackLayout verticalStackLayout3 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout3, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 14, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		verticalStackLayout3.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		verticalStackLayout2.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		menuItemView.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		label.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, verticalStackLayout3, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(17, 17)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		translateExtension.Text = "DG052_Titel";
		BindingBase bindingBase = ((IMarkupExtension<BindingBase>)translateExtension).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 17);
		}
		label.SetBinding(Label.TextProperty, bindingBase);
		verticalStackLayout3.Children.Add(label);
		bindingExtension.Path = "MenuItems";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 34);
		}
		verticalStackLayout.SetBinding(BindableLayout.ItemsSourceProperty, bindingBase2);
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 1.0);
		dataTemplate.LoadTemplate = delegate
		{
			BindingExtension bindingExtension3 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 48);
			MenuItemView menuItemView2 = new MenuItemView();
			VisualDiagnostics.RegisterSourceInfo(menuItemView2, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 26);
			INameScope value = new NameScope();
			NameScope.SetNameScope(menuItemView2, value);
			bindingExtension3.Path = "AutomationId";
			BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension2(bindingExtension3);
			if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 48);
			}
			menuItemView2.SetBinding(Element.AutomationIdProperty, bindingBase6);
			return menuItemView2;
		};
		verticalStackLayout.SetValue(BindableLayout.ItemTemplateProperty, dataTemplate);
		verticalStackLayout3.Children.Add(verticalStackLayout);
		onPlatformExtension.Android = "false";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[4] { verticalStackLayout2, verticalStackLayout3, contentView, this }, AutomationProperties.IsInAccessibleTreeProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(28, 34)));
		object obj2 = ((IMarkupExtension)onPlatformExtension).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 34);
		}
		verticalStackLayout2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, obj2);
		verticalStackLayout2.SetValue(StackBase.SpacingProperty, 20.0);
		label2.SetValue(View.MarginProperty, new Thickness(20.0, 50.0, 20.0, 0.0));
		label2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
		staticResourceExtension2.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[5] { label2, verticalStackLayout2, verticalStackLayout3, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(32, 21)));
		object obj3 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 21);
		}
		label2.SetValue(VisualElement.StyleProperty, obj3);
		translateExtension2.Text = "DG052_Subtitel";
		BindingBase bindingBase3 = ((IMarkupExtension<BindingBase>)translateExtension2).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 21);
		}
		label2.SetBinding(Label.TextProperty, bindingBase3);
		verticalStackLayout2.Children.Add(label2);
		label3.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, -10.0));
		translateExtension3.Text = "DG052_Info";
		BindingBase bindingBase4 = ((IMarkupExtension<BindingBase>)translateExtension3).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 45);
		}
		label3.SetBinding(Label.TextProperty, bindingBase4);
		verticalStackLayout2.Children.Add(label3);
		menuItemView.SetValue(Element.AutomationIdProperty, "MyDigiD");
		bindingExtension2.Path = "MyDigiDMenuItem";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension3(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG052.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 21);
		}
		menuItemView.SetBinding(BindableObject.BindingContextProperty, bindingBase5);
		verticalStackLayout2.Children.Add(menuItemView);
		verticalStackLayout3.Children.Add(verticalStackLayout2);
		contentView.SetValue(ContentView.ContentProperty, verticalStackLayout3);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG052ViewModel, List<DigiD.Common.Controls.Models.MenuItem>> setter = delegate(DG052ViewModel source, List<DigiD.Common.Controls.Models.MenuItem> value)
			{
				source.MenuItems = value;
			};
			return new TypedBinding<DG052ViewModel, List<DigiD.Common.Controls.Models.MenuItem>>((DG052ViewModel source) => (value: source.MenuItems, success: true), setter, new Tuple<Func<DG052ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG052ViewModel, object>, string>((DG052ViewModel source) => source, "MenuItems")
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
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG052ViewModel, DigiD.Common.Controls.Models.MenuItem> setter = null;
			return new TypedBinding<DG052ViewModel, DigiD.Common.Controls.Models.MenuItem>((DG052ViewModel source) => (value: source.MyDigiDMenuItem, success: true), setter, new Tuple<Func<DG052ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG052ViewModel, object>, string>((DG052ViewModel source) => source, "MyDigiDMenuItem")
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
		this.LoadFromXaml(typeof(DG052));
	}
}
