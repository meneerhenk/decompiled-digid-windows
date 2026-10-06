using System;
using System.CodeDom.Compiler;
using System.Reflection;
using DigiD.Common.Models;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;

namespace DigiD.Mobile.Controls;

[XamlFilePath("Controls\\UsageHistoryListItem.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
public class UsageHistoryListItem : ContentView
{
	public UsageHistoryListItem()
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(UsageHistoryListItem).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(UsageHistoryListItem)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Controls\\UsageHistoryListItem.xaml;assembly=DigiD.Mobile", UriKind.Relative), 14, 13);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Controls\\UsageHistoryListItem.xaml;assembly=DigiD.Mobile", UriKind.Relative), 15, 13);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Controls\\UsageHistoryListItem.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 10);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Controls\\UsageHistoryListItem.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 63);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Controls\\UsageHistoryListItem.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 10);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Controls\\UsageHistoryListItem.xaml;assembly=DigiD.Mobile", UriKind.Relative), 8, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Controls\\UsageHistoryListItem.xaml;assembly=DigiD.Mobile", UriKind.Relative), 1, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		verticalStackLayout.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		verticalStackLayout.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 0.0, 10.0));
		verticalStackLayout.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 2.0);
		label.SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
		staticResourceExtension.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[3] { label, verticalStackLayout, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(14, 13)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Controls\\UsageHistoryListItem.xaml;assembly=DigiD.Mobile", UriKind.Relative), 14, 13);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		bindingExtension.StringFormat = "{0:ddd dd-MM-yyyy, HH:mm:ss}";
		bindingExtension.Path = "DateTime";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Controls\\UsageHistoryListItem.xaml;assembly=DigiD.Mobile", UriKind.Relative), 15, 13);
		}
		label.SetBinding(Label.TextProperty, bindingBase);
		verticalStackLayout.Children.Add(label);
		label2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
		bindingExtension2.Path = "Message";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Controls\\UsageHistoryListItem.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 63);
		}
		label2.SetBinding(Label.TextProperty, bindingBase2);
		verticalStackLayout.Children.Add(label2);
		SetValue(ContentView.ContentProperty, verticalStackLayout);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<UsageHistoryModel, DateTime> setter = delegate(UsageHistoryModel source, DateTime value)
			{
				source.DateTime = value;
			};
			return new TypedBinding<UsageHistoryModel, DateTime>((UsageHistoryModel source) => (value: source.DateTime, success: true), setter, new Tuple<Func<UsageHistoryModel, object>, string>[1]
			{
				new Tuple<Func<UsageHistoryModel, object>, string>((UsageHistoryModel source) => source, "DateTime")
			})
			{
				StringFormat = extension.StringFormat
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<UsageHistoryModel, string> setter = delegate(UsageHistoryModel source, string value)
			{
				source.Message = value;
			};
			return new TypedBinding<UsageHistoryModel, string>((UsageHistoryModel source) => (value: source.Message, success: true), setter, new Tuple<Func<UsageHistoryModel, object>, string>[1]
			{
				new Tuple<Func<UsageHistoryModel, object>, string>((UsageHistoryModel source) => source, "Message")
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
		this.LoadFromXaml(typeof(UsageHistoryListItem));
	}
}
