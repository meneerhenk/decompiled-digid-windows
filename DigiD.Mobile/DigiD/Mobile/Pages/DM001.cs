using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Enums;
using DigiD.Mobile.Models;
using DigiD.Mobile.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.Pages;

[XamlFilePath("Pages\\DM001.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DM001 : BasePage<DM001ViewModel>
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private BasePage<DM001ViewModel> Page;

	public DM001()
		: base((DM001ViewModel?)null)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("Page")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DM001).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DM001)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DM001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DM001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 20);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DM001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DM001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 34);
		DataTemplate dataTemplate = new DataTemplate();
		VisualDiagnostics.RegisterSourceInfo(dataTemplate, new Uri("Pages\\DM001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 22);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\DM001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 14);
		VerticalStackLayout verticalStackLayout2 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout2, new Uri("Pages\\DM001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 14, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DM001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 6);
		DM001 __root = this;
		VisualDiagnostics.RegisterSourceInfo(__root, new Uri("Pages\\DM001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(__root) ?? new NameScope();
		NameScope.SetNameScope(__root, nameScope);
		nameScope.RegisterName("Page", __root);
		DM001 dM = __root;
		if (dM.StyleId == null)
		{
			string text = (dM.StyleId = "Page");
		}
		contentView.transientNamescope = nameScope;
		verticalStackLayout2.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		Page = __root;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		verticalStackLayout2.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		verticalStackLayout2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		verticalStackLayout2.SetValue(StackBase.SpacingProperty, 20.0);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(__root);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, verticalStackLayout2, contentView, __root }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, __root);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(18, 20)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DM001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 20);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, "Kies actie");
		verticalStackLayout2.Children.Add(label);
		bindingExtension.Path = "Actions";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DM001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 34);
		}
		verticalStackLayout.SetBinding(BindableLayout.ItemsSourceProperty, bindingBase);
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 20.0);
		dataTemplate.LoadTemplate = delegate
		{
			ReferenceExtension referenceExtension = new ReferenceExtension();
			VisualDiagnostics.RegisterSourceInfo(referenceExtension, new Uri("Pages\\DM001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 29);
			BindingExtension bindingExtension2 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DM001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 29);
			BindingExtension bindingExtension3 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DM001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 29);
			BindingExtension bindingExtension4 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DM001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 29);
			BorderedButton borderedButton = new BorderedButton();
			VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DM001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 26);
			INameScope value = new NameScope();
			NameScope.SetNameScope(borderedButton, value);
			borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
			referenceExtension.Name = "Page";
			DM001 dM2 = __root;
			if (VisualDiagnostics.GetSourceInfo(dM2) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(dM2, new Uri("Pages\\DM001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 29);
			}
			bindingExtension2.Source = dM2;
			bindingExtension2.Path = "BindingContext.ConfirmCommand";
			Binding binding = new Binding(bindingExtension2.Path, bindingExtension2.Mode, bindingExtension2.Converter, bindingExtension2.ConverterParameter, bindingExtension2.StringFormat, bindingExtension2.Source)
			{
				UpdateSourceEventName = bindingExtension2.UpdateSourceEventName,
				FallbackValue = bindingExtension2.FallbackValue,
				TargetNullValue = bindingExtension2.TargetNullValue
			};
			if (VisualDiagnostics.GetSourceInfo(binding) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(binding, new Uri("Pages\\DM001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 29);
			}
			borderedButton.SetBinding(Button.CommandProperty, binding);
			bindingExtension3.Path = "Action";
			BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension3);
			if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DM001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 29);
			}
			borderedButton.SetBinding(Button.CommandParameterProperty, bindingBase2);
			bindingExtension4.Path = "Title";
			BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension4);
			if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DM001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 29);
			}
			borderedButton.SetBinding(Button.TextProperty, bindingBase3);
			return borderedButton;
		};
		verticalStackLayout.SetValue(BindableLayout.ItemTemplateProperty, dataTemplate);
		verticalStackLayout2.Children.Add(verticalStackLayout);
		contentView.SetValue(ContentView.ContentProperty, verticalStackLayout2);
		__root.SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DM001ViewModel, List<DemoActionModel>> setter = delegate(DM001ViewModel source, List<DemoActionModel>? value)
			{
				source.Actions = value;
			};
			return new TypedBinding<DM001ViewModel, List<DemoActionModel>>((DM001ViewModel source) => (value: source.Actions, success: true), setter, new Tuple<Func<DM001ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM001ViewModel, object>, string>((DM001ViewModel source) => source, "Actions")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DemoActionModel, string> setter = delegate(DemoActionModel source, string? value)
			{
				source.Action = value;
			};
			return new TypedBinding<DemoActionModel, string>((DemoActionModel source) => (value: source.Action, success: true), setter, new Tuple<Func<DemoActionModel, object>, string>[1]
			{
				new Tuple<Func<DemoActionModel, object>, string>((DemoActionModel source) => source, "Action")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DemoActionModel, string> setter = delegate(DemoActionModel source, string? value)
			{
				source.Title = value;
			};
			return new TypedBinding<DemoActionModel, string>((DemoActionModel source) => (value: source.Title, success: true), setter, new Tuple<Func<DemoActionModel, object>, string>[1]
			{
				new Tuple<Func<DemoActionModel, object>, string>((DemoActionModel source) => source, "Title")
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
	[MemberNotNull("Page")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(DM001));
		Page = this.FindByName<BasePage<DM001ViewModel>>("Page");
	}
}
