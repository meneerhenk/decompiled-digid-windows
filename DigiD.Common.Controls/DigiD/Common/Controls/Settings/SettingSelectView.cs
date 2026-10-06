using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Input;
using DigiD.Common.Controls.Models;
using DigiD.Common.Interfaces;
using DigiD.Common.SessionModels;
using LocalizationResourceManager.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;

namespace DigiD.Common.Controls.Settings;

[XamlFilePath("Settings\\SettingSelectView.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
public class SettingSelectView : VerticalStackLayout
{
	protected readonly ILocalizationResourceManager LocalizationManager;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private VerticalStackLayout @this;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label lblTitle;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label lblIntro;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private VerticalStackLayout vsSettings;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label lblExplanation;

	protected List<AppSettingsModel> SupportedSettings { get; init; } = new List<AppSettingsModel>();

	protected ICommand? Command { get; init; }

	public ICommand SettingsChangeCommand { get; init; }

	protected virtual Task SetSetting(object setting)
	{
		foreach (AppSettingsModel supportedSetting in SupportedSettings)
		{
			supportedSetting.IsSelected = supportedSetting.Code == setting;
		}
		return Task.CompletedTask;
	}

	protected void SetTitle(string title)
	{
		lblTitle.Text = LocalizationManager[title];
	}

	public SettingSelectView(string title, string? explanation = null, string? intro = null)
	{
		LocalizationManager = AppSession.ServiceProvider.GetRequiredService<ILocalizationResourceManager>();
		InitializeComponent();
		lblTitle.Text = LocalizationManager[title];
		if (explanation != null)
		{
			lblExplanation.Text = LocalizationManager[explanation];
			lblExplanation.IsVisible = true;
		}
		if (intro != null)
		{
			lblIntro.Text = LocalizationManager[intro];
			lblIntro.IsVisible = true;
		}
		SettingsChangeCommand = new Command<object>(delegate(object? code)
		{
			if (code != null)
			{
				SetSetting(code);
				Command?.Execute(code);
			}
		});
	}

	protected override void OnHandlerChanged()
	{
		base.OnHandlerChanged();
		if (base.Handler != null)
		{
			SetItems();
		}
	}

	protected void SetItems()
	{
		BindableLayout.SetItemsSource(vsSettings, null);
		BindableLayout.SetItemsSource(vsSettings, SupportedSettings);
		foreach (MenuItemSelectView item in vsSettings.Children.Cast<MenuItemSelectView>())
		{
			if (item.BindingContext is AppSettingsModel appSettingsModel)
			{
				item.AutomationTestId = appSettingsModel.AutomationId;
				item.Command = SettingsChangeCommand;
				if (item.IsSelected && ((IApp)Application.Current).A11YService.IsInVoiceOverMode)
				{
					item.SetSemanticFocus();
				}
			}
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("this")]
	[MemberNotNull("lblTitle")]
	[MemberNotNull("lblIntro")]
	[MemberNotNull("vsSettings")]
	[MemberNotNull("lblExplanation")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(SettingSelectView).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(SettingSelectView)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Settings\\SettingSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 8, 51);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Settings\\SettingSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 8, 6);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Settings\\SettingSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 10, 6);
		DataTemplate dataTemplate = new DataTemplate();
		VisualDiagnostics.RegisterSourceInfo(dataTemplate, new Uri("Settings\\SettingSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 14, 14);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Settings\\SettingSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 12, 6);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Settings\\SettingSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 24, 74);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Settings\\SettingSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 24, 6);
		SettingSelectView __root = this;
		VisualDiagnostics.RegisterSourceInfo(__root, new Uri("Settings\\SettingSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 1, 2);
		INameScope nameScope = NameScope.GetNameScope(__root) ?? new NameScope();
		NameScope.SetNameScope(__root, nameScope);
		nameScope.RegisterName("this", __root);
		SettingSelectView settingSelectView = __root;
		if (settingSelectView.StyleId == null)
		{
			string text = (settingSelectView.StyleId = "this");
		}
		label.transientNamescope = nameScope;
		nameScope.RegisterName("lblTitle", label);
		Label label4 = label;
		if (label4.StyleId == null)
		{
			string text = (label4.StyleId = "lblTitle");
		}
		label2.transientNamescope = nameScope;
		nameScope.RegisterName("lblIntro", label2);
		label4 = label2;
		if (label4.StyleId == null)
		{
			string text = (label4.StyleId = "lblIntro");
		}
		verticalStackLayout.transientNamescope = nameScope;
		nameScope.RegisterName("vsSettings", verticalStackLayout);
		VerticalStackLayout verticalStackLayout2 = verticalStackLayout;
		if (verticalStackLayout2.StyleId == null)
		{
			string text = (verticalStackLayout2.StyleId = "vsSettings");
		}
		label3.transientNamescope = nameScope;
		nameScope.RegisterName("lblExplanation", label3);
		label4 = label3;
		if (label4.StyleId == null)
		{
			string text = (label4.StyleId = "lblExplanation");
		}
		this.@this = __root;
		lblTitle = label;
		lblIntro = label2;
		vsSettings = verticalStackLayout;
		lblExplanation = label3;
		label.SetValue(Label.PaddingProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(__root);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[2] { label, __root }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, __root);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(8, 51)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Settings\\SettingSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 8, 51);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		__root.Children.Add(label);
		label2.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 10.0));
		label2.SetValue(VisualElement.IsVisibleProperty, (bool)new VisibilityConverter().ConvertFromInvariantString("False"));
		__root.Children.Add(label2);
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 1.0);
		dataTemplate.LoadTemplate = delegate
		{
			ReferenceExtension referenceExtension = new ReferenceExtension();
			VisualDiagnostics.RegisterSourceInfo(referenceExtension, new Uri("Settings\\SettingSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 16, 21);
			BindingExtension bindingExtension = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Settings\\SettingSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 16, 21);
			BindingExtension bindingExtension2 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Settings\\SettingSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 17, 21);
			BindingExtension bindingExtension3 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Settings\\SettingSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 18, 21);
			BindingExtension bindingExtension4 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Settings\\SettingSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 19, 21);
			MenuItemSelectView menuItemSelectView = new MenuItemSelectView();
			VisualDiagnostics.RegisterSourceInfo(menuItemSelectView, new Uri("Settings\\SettingSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 15, 18);
			INameScope value = new NameScope();
			NameScope.SetNameScope(menuItemSelectView, value);
			referenceExtension.Name = "this";
			SettingSelectView settingSelectView2 = __root;
			if (VisualDiagnostics.GetSourceInfo(settingSelectView2) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(settingSelectView2, new Uri("Settings\\SettingSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 16, 21);
			}
			bindingExtension.Source = settingSelectView2;
			bindingExtension.Path = "SettingsChangeCommand";
			Binding binding = new Binding(bindingExtension.Path, bindingExtension.Mode, bindingExtension.Converter, bindingExtension.ConverterParameter, bindingExtension.StringFormat, bindingExtension.Source)
			{
				UpdateSourceEventName = bindingExtension.UpdateSourceEventName,
				FallbackValue = bindingExtension.FallbackValue,
				TargetNullValue = bindingExtension.TargetNullValue
			};
			if (VisualDiagnostics.GetSourceInfo(binding) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(binding, new Uri("Settings\\SettingSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 16, 21);
			}
			menuItemSelectView.SetBinding(MenuItemSelectView.CommandProperty, binding);
			bindingExtension2.Path = "Code";
			BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension2);
			if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Settings\\SettingSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 17, 21);
			}
			menuItemSelectView.SetBinding(MenuItemSelectView.CommandParameterProperty, bindingBase);
			bindingExtension3.Path = "IsSelected";
			BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension3);
			if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Settings\\SettingSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 18, 21);
			}
			menuItemSelectView.SetBinding(MenuItemSelectView.IsSelectedProperty, bindingBase2);
			bindingExtension4.Path = "Text.Localized";
			BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension4);
			if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Settings\\SettingSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 19, 21);
			}
			menuItemSelectView.SetBinding(MenuItemSelectView.TextProperty, bindingBase3);
			return menuItemSelectView;
		};
		verticalStackLayout.SetValue(BindableLayout.ItemTemplateProperty, dataTemplate);
		__root.Children.Add(verticalStackLayout);
		label3.SetValue(View.MarginProperty, new Thickness(20.0, 20.0, 20.0, 0.0));
		label3.SetValue(VisualElement.IsVisibleProperty, (bool)new VisibilityConverter().ConvertFromInvariantString("False"));
		staticResourceExtension2.Key = "CaptionLabelStyle";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(__root);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[2] { label3, __root }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, __root);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(24, 74)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Settings\\SettingSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 24, 74);
		}
		label3.SetValue(VisualElement.StyleProperty, obj2);
		__root.Children.Add(label3);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<AppSettingsModel, object> setter = null;
			return new TypedBinding<AppSettingsModel, object>((AppSettingsModel source) => (value: source.Code, success: true), setter, new Tuple<Func<AppSettingsModel, object>, string>[1]
			{
				new Tuple<Func<AppSettingsModel, object>, string>((AppSettingsModel source) => source, "Code")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<AppSettingsModel, bool> setter = delegate(AppSettingsModel source, bool value)
			{
				source.IsSelected = value;
			};
			return new TypedBinding<AppSettingsModel, bool>((AppSettingsModel source) => (value: source.IsSelected, success: true), setter, new Tuple<Func<AppSettingsModel, object>, string>[1]
			{
				new Tuple<Func<AppSettingsModel, object>, string>((AppSettingsModel source) => source, "IsSelected")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<AppSettingsModel, string> setter = null;
			return new TypedBinding<AppSettingsModel, string>((AppSettingsModel source) => (value: source.Text.Localized, success: true), setter, new Tuple<Func<AppSettingsModel, object>, string>[2]
			{
				new Tuple<Func<AppSettingsModel, object>, string>((AppSettingsModel source) => source, "Text"),
				new Tuple<Func<AppSettingsModel, object>, string>((AppSettingsModel source) => source.Text, "Localized")
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
	[MemberNotNull("this")]
	[MemberNotNull("lblTitle")]
	[MemberNotNull("lblIntro")]
	[MemberNotNull("vsSettings")]
	[MemberNotNull("lblExplanation")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(SettingSelectView));
		this.@this = this.FindByName<VerticalStackLayout>("this");
		lblTitle = this.FindByName<Label>("lblTitle");
		lblIntro = this.FindByName<Label>("lblIntro");
		vsSettings = this.FindByName<VerticalStackLayout>("vsSettings");
		lblExplanation = this.FindByName<Label>("lblExplanation");
	}
}
