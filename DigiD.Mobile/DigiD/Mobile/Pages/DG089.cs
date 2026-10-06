using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Windows.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Mobile.ViewModels;
using LocalizationResourceManager.Maui;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;

namespace DigiD.Mobile.Pages;

[XamlFilePath("Pages\\DG089.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
public class DG089 : BasePage<DG089ViewModel>
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private MenuItemSelectView BiometricsOn;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private MenuItemSelectView BiometricsOff;

	public DG089(DG089ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("BiometricsOn")]
	[MemberNotNull("BiometricsOff")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG089).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG089)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 17);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 14, 14);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 40);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 14);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 17);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 17);
		TranslateExtension translateExtension = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 17);
		bool flag = true;
		VisualDiagnostics.RegisterSourceInfo(flag, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 22);
		MenuItemSelectView menuItemSelectView = new MenuItemSelectView();
		VisualDiagnostics.RegisterSourceInfo(menuItemSelectView, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 14);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 17);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 17);
		BindingExtension bindingExtension6 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 17);
		TranslateExtension translateExtension2 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension2, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 38, 17);
		bool flag2 = false;
		VisualDiagnostics.RegisterSourceInfo(flag2, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 22);
		MenuItemSelectView menuItemSelectView2 = new MenuItemSelectView();
		VisualDiagnostics.RegisterSourceInfo(menuItemSelectView2, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 14);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		menuItemSelectView.transientNamescope = nameScope;
		nameScope.RegisterName("BiometricsOn", menuItemSelectView);
		MenuItemSelectView menuItemSelectView3 = menuItemSelectView;
		if (menuItemSelectView3.StyleId == null)
		{
			string text = (menuItemSelectView3.StyleId = "BiometricsOn");
		}
		menuItemSelectView2.transientNamescope = nameScope;
		nameScope.RegisterName("BiometricsOff", menuItemSelectView2);
		menuItemSelectView3 = menuItemSelectView2;
		if (menuItemSelectView3.StyleId == null)
		{
			string text = (menuItemSelectView3.StyleId = "BiometricsOff");
		}
		BiometricsOn = menuItemSelectView;
		BiometricsOff = menuItemSelectView2;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		verticalStackLayout.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 1.0);
		label.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 10.0));
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, verticalStackLayout, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(16, 17)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		bindingExtension.Path = "HeaderText";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 17);
		}
		label.SetBinding(Label.TextProperty, bindingBase);
		verticalStackLayout.Children.Add(label);
		label2.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 10.0));
		bindingExtension2.Path = "MessageText";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 40);
		}
		label2.SetBinding(Label.TextProperty, bindingBase2);
		verticalStackLayout.Children.Add(label2);
		menuItemSelectView.AutomationTestId = "BiometricsOn";
		bindingExtension3.Path = "SwitchSettingCommand";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 17);
		}
		menuItemSelectView.SetBinding(MenuItemSelectView.CommandProperty, bindingBase3);
		bindingExtension4.Path = "IsEnabled";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 17);
		}
		menuItemSelectView.SetBinding(MenuItemSelectView.IsSelectedProperty, bindingBase4);
		translateExtension.Text = "Alg_On";
		BindingBase bindingBase5 = ((IMarkupExtension<BindingBase>)translateExtension).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 17);
		}
		menuItemSelectView.SetBinding(MenuItemSelectView.TextProperty, bindingBase5);
		menuItemSelectView.SetValue(MenuItemSelectView.CommandParameterProperty, flag);
		verticalStackLayout.Children.Add(menuItemSelectView);
		menuItemSelectView2.AutomationTestId = "BiometricsOff";
		bindingExtension5.Path = "SwitchSettingCommand";
		BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension5(bindingExtension5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 17);
		}
		menuItemSelectView2.SetBinding(MenuItemSelectView.CommandProperty, bindingBase6);
		staticResourceExtension2.Key = "BooleanInvertConverter";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[5] { bindingExtension6, menuItemSelectView2, verticalStackLayout, contentView, this }, typeof(BindingExtension).GetProperty("Converter"), new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(37, 17)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 17);
		}
		bindingExtension6.Converter = (IValueConverter)obj2;
		bindingExtension6.Path = "IsEnabled";
		BindingBase bindingBase7 = CreateTypedBindingFrom_bindingExtension6(bindingExtension6);
		if (VisualDiagnostics.GetSourceInfo(bindingBase7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase7, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 17);
		}
		menuItemSelectView2.SetBinding(MenuItemSelectView.IsSelectedProperty, bindingBase7);
		translateExtension2.Text = "Alg_Off";
		BindingBase bindingBase8 = ((IMarkupExtension<BindingBase>)translateExtension2).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase8, new Uri("Pages\\DG089.xaml;assembly=DigiD.Mobile", UriKind.Relative), 38, 17);
		}
		menuItemSelectView2.SetBinding(MenuItemSelectView.TextProperty, bindingBase8);
		menuItemSelectView2.SetValue(MenuItemSelectView.CommandParameterProperty, flag2);
		verticalStackLayout.Children.Add(menuItemSelectView2);
		contentView.SetValue(ContentView.ContentProperty, verticalStackLayout);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG089ViewModel, string> setter = delegate(DG089ViewModel source, string? value)
			{
				source.HeaderText = value;
			};
			return new TypedBinding<DG089ViewModel, string>((DG089ViewModel source) => (value: source.HeaderText, success: true), setter, new Tuple<Func<DG089ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG089ViewModel, object>, string>((DG089ViewModel source) => source, "HeaderText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG089ViewModel, string> setter = delegate(DG089ViewModel source, string? value)
			{
				source.MessageText = value;
			};
			return new TypedBinding<DG089ViewModel, string>((DG089ViewModel source) => (value: source.MessageText, success: true), setter, new Tuple<Func<DG089ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG089ViewModel, object>, string>((DG089ViewModel source) => source, "MessageText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG089ViewModel, ICommand> setter = null;
			return new TypedBinding<DG089ViewModel, ICommand>((DG089ViewModel source) => ((ICommand value, bool success))(value: source.SwitchSettingCommand, success: true), setter, new Tuple<Func<DG089ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG089ViewModel, object>, string>((DG089ViewModel source) => source, "SwitchSettingCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DG089ViewModel, bool> setter = delegate(DG089ViewModel source, bool value)
			{
				source.IsEnabled = value;
			};
			return new TypedBinding<DG089ViewModel, bool>((DG089ViewModel source) => (value: source.IsEnabled, success: true), setter, new Tuple<Func<DG089ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG089ViewModel, object>, string>((DG089ViewModel source) => source, "IsEnabled")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<DG089ViewModel, ICommand> setter = null;
			return new TypedBinding<DG089ViewModel, ICommand>((DG089ViewModel source) => ((ICommand value, bool success))(value: source.SwitchSettingCommand, success: true), setter, new Tuple<Func<DG089ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG089ViewModel, object>, string>((DG089ViewModel source) => source, "SwitchSettingCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension6(BindingExtension extension)
		{
			Action<DG089ViewModel, bool> setter = delegate(DG089ViewModel source, bool value)
			{
				source.IsEnabled = value;
			};
			return new TypedBinding<DG089ViewModel, bool>((DG089ViewModel source) => (value: source.IsEnabled, success: true), setter, new Tuple<Func<DG089ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG089ViewModel, object>, string>((DG089ViewModel source) => source, "IsEnabled")
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
	[MemberNotNull("BiometricsOn")]
	[MemberNotNull("BiometricsOff")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(DG089));
		BiometricsOn = this.FindByName<MenuItemSelectView>("BiometricsOn");
		BiometricsOff = this.FindByName<MenuItemSelectView>("BiometricsOff");
	}
}
