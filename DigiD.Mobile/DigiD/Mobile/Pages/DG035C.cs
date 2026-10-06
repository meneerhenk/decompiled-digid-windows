using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Windows.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Resources;
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

[XamlFilePath("Pages\\DG035C.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG035C : BasePage<DG035CViewModel>
{
	public DG035C()
		: base((DG035CViewModel?)null)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG035C).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG035C)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG035C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 14, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG035C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 17);
		string dG035C_Titel = DigiDAppResources.DG035C_Titel;
		VisualDiagnostics.RegisterSourceInfo(dG035C_Titel, new Uri("Pages\\DG035C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG035C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 14);
		string dG035_Info2Stappen = DigiDAppResources.DG035_Info2Stappen;
		VisualDiagnostics.RegisterSourceInfo(dG035_Info2Stappen, new Uri("Pages\\DG035C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 17);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG035C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG035C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 17);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG035C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 17);
		TranslateExtension translateExtension = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension, new Uri("Pages\\DG035C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 17);
		bool flag = true;
		VisualDiagnostics.RegisterSourceInfo(flag, new Uri("Pages\\DG035C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 22);
		MenuItemSelectView menuItemSelectView = new MenuItemSelectView();
		VisualDiagnostics.RegisterSourceInfo(menuItemSelectView, new Uri("Pages\\DG035C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 14);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG035C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 44, 17);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\DG035C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 17);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG035C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 17);
		TranslateExtension translateExtension2 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension2, new Uri("Pages\\DG035C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 46, 17);
		bool flag2 = false;
		VisualDiagnostics.RegisterSourceInfo(flag2, new Uri("Pages\\DG035C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 48, 22);
		MenuItemSelectView menuItemSelectView2 = new MenuItemSelectView();
		VisualDiagnostics.RegisterSourceInfo(menuItemSelectView2, new Uri("Pages\\DG035C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 41, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG035C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 15, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG035C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 14, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG035C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		menuItemSelectView.transientNamescope = nameScope;
		menuItemSelectView2.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star)));
		grid.SetValue(Grid.RowSpacingProperty, 1.0);
		label.SetValue(Grid.RowProperty, 0);
		label.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 10.0));
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, grid, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(22, 17)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG035C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, dG035C_Titel);
		grid.Children.Add(label);
		label2.SetValue(Grid.RowProperty, 1);
		label2.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 10.0));
		label2.SetValue(Label.TextProperty, dG035_Info2Stappen);
		grid.Children.Add(label2);
		menuItemSelectView.SetValue(Grid.RowProperty, 2);
		menuItemSelectView.AutomationTestId = "2faOn";
		bindingExtension.Path = "TwoFactorChangedCommand";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG035C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 17);
		}
		menuItemSelectView.SetBinding(MenuItemSelectView.CommandProperty, bindingBase);
		bindingExtension2.Path = "TwoFactorEnabled";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG035C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 17);
		}
		menuItemSelectView.SetBinding(MenuItemSelectView.IsSelectedProperty, bindingBase2);
		translateExtension.Text = "Alg_On";
		BindingBase bindingBase3 = ((IMarkupExtension<BindingBase>)translateExtension).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG035C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 17);
		}
		menuItemSelectView.SetBinding(MenuItemSelectView.TextProperty, bindingBase3);
		menuItemSelectView.SetValue(MenuItemSelectView.CommandParameterProperty, flag);
		grid.Children.Add(menuItemSelectView);
		menuItemSelectView2.SetValue(Grid.RowProperty, 3);
		menuItemSelectView2.AutomationTestId = "2faOff";
		bindingExtension3.Path = "TwoFactorChangedCommand";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG035C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 44, 17);
		}
		menuItemSelectView2.SetBinding(MenuItemSelectView.CommandProperty, bindingBase4);
		staticResourceExtension2.Key = "BooleanInvertConverter";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[5] { bindingExtension4, menuItemSelectView2, grid, contentView, this }, typeof(BindingExtension).GetProperty("Converter"), new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(45, 17)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\DG035C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 17);
		}
		bindingExtension4.Converter = (IValueConverter)obj2;
		bindingExtension4.Path = "TwoFactorEnabled";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG035C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 17);
		}
		menuItemSelectView2.SetBinding(MenuItemSelectView.IsSelectedProperty, bindingBase5);
		translateExtension2.Text = "Alg_Off";
		BindingBase bindingBase6 = ((IMarkupExtension<BindingBase>)translateExtension2).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DG035C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 46, 17);
		}
		menuItemSelectView2.SetBinding(MenuItemSelectView.TextProperty, bindingBase6);
		menuItemSelectView2.SetValue(MenuItemSelectView.CommandParameterProperty, flag2);
		grid.Children.Add(menuItemSelectView2);
		contentView.SetValue(ContentView.ContentProperty, grid);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG035CViewModel, ICommand> setter = null;
			return new TypedBinding<DG035CViewModel, ICommand>((DG035CViewModel source) => ((ICommand value, bool success))(value: source.TwoFactorChangedCommand, success: true), setter, new Tuple<Func<DG035CViewModel, object>, string>[1]
			{
				new Tuple<Func<DG035CViewModel, object>, string>((DG035CViewModel source) => source, "TwoFactorChangedCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG035CViewModel, bool> setter = delegate(DG035CViewModel source, bool value)
			{
				source.TwoFactorEnabled = value;
			};
			return new TypedBinding<DG035CViewModel, bool>((DG035CViewModel source) => (value: source.TwoFactorEnabled, success: true), setter, new Tuple<Func<DG035CViewModel, object>, string>[1]
			{
				new Tuple<Func<DG035CViewModel, object>, string>((DG035CViewModel source) => source, "TwoFactorEnabled")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG035CViewModel, ICommand> setter = null;
			return new TypedBinding<DG035CViewModel, ICommand>((DG035CViewModel source) => ((ICommand value, bool success))(value: source.TwoFactorChangedCommand, success: true), setter, new Tuple<Func<DG035CViewModel, object>, string>[1]
			{
				new Tuple<Func<DG035CViewModel, object>, string>((DG035CViewModel source) => source, "TwoFactorChangedCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DG035CViewModel, bool> setter = delegate(DG035CViewModel source, bool value)
			{
				source.TwoFactorEnabled = value;
			};
			return new TypedBinding<DG035CViewModel, bool>((DG035CViewModel source) => (value: source.TwoFactorEnabled, success: true), setter, new Tuple<Func<DG035CViewModel, object>, string>[1]
			{
				new Tuple<Func<DG035CViewModel, object>, string>((DG035CViewModel source) => source, "TwoFactorEnabled")
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
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(DG035C));
	}
}
