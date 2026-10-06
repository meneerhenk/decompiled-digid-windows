using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DigiD.Common.Controls.Models;
using DigiD.Common.Resources;
using LocalizationResourceManager.Maui;
using Microsoft.Maui;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;

namespace DigiD.Common.Controls.Settings;

[XamlFilePath("Settings\\A11YHelpAndInfoView.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
public class A11YHelpAndInfoView : BaseSettingsView
{
	public List<ActionMenuItem> MenuItems { get; set; }

	public A11YHelpAndInfoView()
	{
		int num = 1;
		List<ActionMenuItem> list = new List<ActionMenuItem>(num);
		CollectionsMarshal.SetCount(list, num);
		CollectionsMarshal.AsSpan(list)[0] = new ActionMenuItem("MoreInfo", "Alg_A11yLinkMoreInfo", "iconMenuExternalLink", OpenMoreInfoLink, chevronVisible: false);
		MenuItems = list;
		base._002Ector();
		InitializeComponent();
		base.BindingContext = this;
	}

	private static Task<bool> OpenMoreInfoLink()
	{
		return Browser.OpenAsync(CommonResources.Alg_A11y_MoreInfo_Link);
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(A11YHelpAndInfoView).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(A11YHelpAndInfoView)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Settings\\A11YHelpAndInfoView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 15, 13);
		TranslateExtension translateExtension = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension, new Uri("Settings\\A11YHelpAndInfoView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 16, 13);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Settings\\A11YHelpAndInfoView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 13, 10);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Settings\\A11YHelpAndInfoView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 18, 36);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Settings\\A11YHelpAndInfoView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 18, 10);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Settings\\A11YHelpAndInfoView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 20, 30);
		DataTemplate dataTemplate = new DataTemplate();
		VisualDiagnostics.RegisterSourceInfo(dataTemplate, new Uri("Settings\\A11YHelpAndInfoView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 22, 18);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Settings\\A11YHelpAndInfoView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 20, 10);
		VerticalStackLayout verticalStackLayout2 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout2, new Uri("Settings\\A11YHelpAndInfoView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 11, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Settings\\A11YHelpAndInfoView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 3, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		verticalStackLayout2.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		verticalStackLayout2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		label.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[3] { label, verticalStackLayout2, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(15, 13)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Settings\\A11YHelpAndInfoView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 15, 13);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		translateExtension.Text = "Alg_A11y_Title";
		BindingBase bindingBase = ((IMarkupExtension<BindingBase>)translateExtension).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Settings\\A11YHelpAndInfoView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 16, 13);
		}
		label.SetBinding(Label.TextProperty, bindingBase);
		verticalStackLayout2.Children.Add(label);
		label2.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		bindingExtension.Path = "Intro";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Settings\\A11YHelpAndInfoView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 18, 36);
		}
		label2.SetBinding(Label.TextProperty, bindingBase2);
		verticalStackLayout2.Children.Add(label2);
		bindingExtension2.Path = "MenuItems";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Settings\\A11YHelpAndInfoView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 20, 30);
		}
		verticalStackLayout.SetBinding(BindableLayout.ItemsSourceProperty, bindingBase3);
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 1.0);
		dataTemplate.LoadTemplate = delegate
		{
			BindingExtension bindingExtension3 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Settings\\A11YHelpAndInfoView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 23, 44);
			MenuItemView menuItemView = new MenuItemView();
			VisualDiagnostics.RegisterSourceInfo(menuItemView, new Uri("Settings\\A11YHelpAndInfoView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 23, 22);
			INameScope value = new NameScope();
			NameScope.SetNameScope(menuItemView, value);
			bindingExtension3.Path = "AutomationId";
			BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
			if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Settings\\A11YHelpAndInfoView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 23, 44);
			}
			menuItemView.SetBinding(Element.AutomationIdProperty, bindingBase4);
			return menuItemView;
		};
		verticalStackLayout.SetValue(BindableLayout.ItemTemplateProperty, dataTemplate);
		verticalStackLayout2.Children.Add(verticalStackLayout);
		SetValue(ContentView.ContentProperty, verticalStackLayout2);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<A11YHelpAndInfoView, string> setter = delegate(A11YHelpAndInfoView source, string value)
			{
				source.Intro = value;
			};
			return new TypedBinding<A11YHelpAndInfoView, string>((A11YHelpAndInfoView source) => (value: source.Intro, success: true), setter, new Tuple<Func<A11YHelpAndInfoView, object>, string>[1]
			{
				new Tuple<Func<A11YHelpAndInfoView, object>, string>((A11YHelpAndInfoView source) => source, "Intro")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<A11YHelpAndInfoView, List<ActionMenuItem>> setter = delegate(A11YHelpAndInfoView source, List<ActionMenuItem> value)
			{
				source.MenuItems = value;
			};
			return new TypedBinding<A11YHelpAndInfoView, List<ActionMenuItem>>((A11YHelpAndInfoView source) => (value: source.MenuItems, success: true), setter, new Tuple<Func<A11YHelpAndInfoView, object>, string>[1]
			{
				new Tuple<Func<A11YHelpAndInfoView, object>, string>((A11YHelpAndInfoView source) => source, "MenuItems")
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
		this.LoadFromXaml(typeof(A11YHelpAndInfoView));
	}
}
