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

[XamlFilePath("Pages\\DG059.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG059 : BasePage<DG059ViewModel>
{
	public DG059(DG059ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG059).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG059)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG059.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG059.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 17);
		TranslateExtension translateExtension = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension, new Uri("Pages\\DG059.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG059.xaml;assembly=DigiD.Mobile", UriKind.Relative), 15, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG059.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 34);
		DataTemplate dataTemplate = new DataTemplate();
		VisualDiagnostics.RegisterSourceInfo(dataTemplate, new Uri("Pages\\DG059.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 22);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\DG059.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 14);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\DG059.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 17);
		TranslateExtension translateExtension2 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension2, new Uri("Pages\\DG059.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 17);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG059.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 14);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG059.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 34);
		DataTemplate dataTemplate2 = new DataTemplate();
		VisualDiagnostics.RegisterSourceInfo(dataTemplate2, new Uri("Pages\\DG059.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 22);
		VerticalStackLayout verticalStackLayout2 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout2, new Uri("Pages\\DG059.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 14);
		VerticalStackLayout verticalStackLayout3 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout3, new Uri("Pages\\DG059.xaml;assembly=DigiD.Mobile", UriKind.Relative), 14, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG059.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG059.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		verticalStackLayout3.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		verticalStackLayout2.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		verticalStackLayout3.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
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
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG059.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		translateExtension.Text = "DG059_Titel";
		BindingBase bindingBase = ((IMarkupExtension<BindingBase>)translateExtension).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG059.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 17);
		}
		label.SetBinding(Label.TextProperty, bindingBase);
		verticalStackLayout3.Children.Add(label);
		bindingExtension.Path = "PrimaryMenuItems";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG059.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 34);
		}
		verticalStackLayout.SetBinding(BindableLayout.ItemsSourceProperty, bindingBase2);
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 1.0);
		dataTemplate.LoadTemplate = delegate
		{
			BindingExtension bindingExtension3 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG059.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 48);
			MenuItemView menuItemView = new MenuItemView();
			VisualDiagnostics.RegisterSourceInfo(menuItemView, new Uri("Pages\\DG059.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 26);
			INameScope value = new NameScope();
			NameScope.SetNameScope(menuItemView, value);
			bindingExtension3.Path = "AutomationId";
			BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension2(bindingExtension3);
			if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG059.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 48);
			}
			menuItemView.SetBinding(Element.AutomationIdProperty, bindingBase5);
			return menuItemView;
		};
		verticalStackLayout.SetValue(BindableLayout.ItemTemplateProperty, dataTemplate);
		verticalStackLayout3.Children.Add(verticalStackLayout);
		label2.SetValue(View.MarginProperty, new Thickness(20.0));
		label2.SetValue(Element.AutomationIdProperty, "OtherHeader");
		staticResourceExtension2.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[4] { label2, verticalStackLayout3, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(31, 17)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\DG059.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 17);
		}
		label2.SetValue(VisualElement.StyleProperty, obj2);
		translateExtension2.Text = "DG059_Subtitel";
		BindingBase bindingBase3 = ((IMarkupExtension<BindingBase>)translateExtension2).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG059.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 17);
		}
		label2.SetBinding(Label.TextProperty, bindingBase3);
		verticalStackLayout3.Children.Add(label2);
		bindingExtension2.Path = "SecondaryMenuItems";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension3(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG059.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 34);
		}
		verticalStackLayout2.SetBinding(BindableLayout.ItemsSourceProperty, bindingBase4);
		verticalStackLayout2.SetValue(StackBase.SpacingProperty, 1.0);
		dataTemplate2.LoadTemplate = delegate
		{
			BindingExtension bindingExtension3 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG059.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 48);
			MenuItemView menuItemView = new MenuItemView();
			VisualDiagnostics.RegisterSourceInfo(menuItemView, new Uri("Pages\\DG059.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 26);
			INameScope value = new NameScope();
			NameScope.SetNameScope(menuItemView, value);
			bindingExtension3.Path = "AutomationId";
			BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension4(bindingExtension3);
			if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG059.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 48);
			}
			menuItemView.SetBinding(Element.AutomationIdProperty, bindingBase5);
			return menuItemView;
		};
		verticalStackLayout2.SetValue(BindableLayout.ItemTemplateProperty, dataTemplate2);
		verticalStackLayout3.Children.Add(verticalStackLayout2);
		contentView.SetValue(ContentView.ContentProperty, verticalStackLayout3);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG059ViewModel, List<DigiD.Common.Controls.Models.MenuItem>> setter = null;
			return new TypedBinding<DG059ViewModel, List<DigiD.Common.Controls.Models.MenuItem>>((DG059ViewModel source) => (value: source.PrimaryMenuItems, success: true), setter, new Tuple<Func<DG059ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG059ViewModel, object>, string>((DG059ViewModel source) => source, "PrimaryMenuItems")
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
			Action<DG059ViewModel, List<DigiD.Common.Controls.Models.MenuItem>> setter = null;
			return new TypedBinding<DG059ViewModel, List<DigiD.Common.Controls.Models.MenuItem>>((DG059ViewModel source) => (value: source.SecondaryMenuItems, success: true), setter, new Tuple<Func<DG059ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG059ViewModel, object>, string>((DG059ViewModel source) => source, "SecondaryMenuItems")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
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
		this.LoadFromXaml(typeof(DG059));
	}
}
