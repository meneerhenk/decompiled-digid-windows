using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Windows.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Interfaces;
using DigiD.Mobile.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;

namespace DigiD.Mobile.Pages;

[XamlFilePath("Pages\\DG001.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
public class DG001 : BasePage<DG001ViewModel>
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private BasePage<DG001ViewModel> page;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private BorderedButton NextButton;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private ToastView ToastView;

	public DG001(DG001ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		ToastView.OnAppearing();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("page")]
	[MemberNotNull("NextButton")]
	[MemberNotNull("ToastView")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG001).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG001)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 21);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 21);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 18);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 44);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 18);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 21);
		ReferenceExtension referenceExtension = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 21);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 21);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 21);
		StepsControl stepsControl = new StepsControl();
		VisualDiagnostics.RegisterSourceInfo(stepsControl, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 18);
		StackLayout stackLayout = new StackLayout();
		VisualDiagnostics.RegisterSourceInfo(stackLayout, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 14);
		BindingExtension bindingExtension6 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 17);
		BindingExtension bindingExtension7 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension7, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 17);
		BindingExtension bindingExtension8 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension8, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 41, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 14);
		ToastView toastView = new ToastView();
		VisualDiagnostics.RegisterSourceInfo(toastView, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 44, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		nameScope.RegisterName("page", this);
		if (StyleId == null)
		{
			string text = (StyleId = "page");
		}
		contentView.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		stackLayout.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		stepsControl.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		nameScope.RegisterName("NextButton", borderedButton);
		BorderedButton borderedButton2 = borderedButton;
		if (borderedButton2.StyleId == null)
		{
			string text = (borderedButton2.StyleId = "NextButton");
		}
		toastView.transientNamescope = nameScope;
		nameScope.RegisterName("ToastView", toastView);
		ToastView toastView2 = toastView;
		if (toastView2.StyleId == null)
		{
			string text = (toastView2.StyleId = "ToastView");
		}
		page = this;
		NextButton = borderedButton;
		ToastView = toastView;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid.SetValue(AutomationProperties.ExcludedWithChildrenProperty, false);
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Auto)));
		grid.SetValue(Grid.RowSpacingProperty, 0.0);
		stackLayout.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		stackLayout.SetValue(StackBase.SpacingProperty, 0.0);
		label.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 0.0, 20.0));
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[5] { label, stackLayout, grid, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(23, 21)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 21);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		bindingExtension.Path = "HeaderText.Localized";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 21);
		}
		label.SetBinding(Label.TextProperty, bindingBase);
		stackLayout.Children.Add(label);
		label2.SetValue(View.MarginProperty, new Thickness(0.0, -12.0, 0.0, 10.0));
		bindingExtension2.Path = "MessageText.Localized";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 44);
		}
		label2.SetBinding(Label.TextProperty, bindingBase2);
		stackLayout.Children.Add(label2);
		bindingExtension3.Path = "ButtonCommand";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 21);
		}
		stepsControl.SetBinding(StepsControl.CommandProperty, bindingBase3);
		referenceExtension.Name = "NextButton";
		BorderedButton borderedButton3 = borderedButton;
		if (VisualDiagnostics.GetSourceInfo(borderedButton3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(borderedButton3, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 21);
		}
		bindingExtension4.Source = borderedButton3;
		Binding binding = new Binding(bindingExtension4.Path, bindingExtension4.Mode, bindingExtension4.Converter, bindingExtension4.ConverterParameter, bindingExtension4.StringFormat, bindingExtension4.Source)
		{
			UpdateSourceEventName = bindingExtension4.UpdateSourceEventName,
			FallbackValue = bindingExtension4.FallbackValue,
			TargetNullValue = bindingExtension4.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 21);
		}
		stepsControl.SetBinding(StepsControl.CommandParameterProperty, binding);
		bindingExtension5.Path = "Steps";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 21);
		}
		stepsControl.SetBinding(StepsControl.ItemsProperty, bindingBase4);
		stackLayout.Children.Add(stepsControl);
		grid.Children.Add(stackLayout);
		borderedButton.SetValue(Grid.RowProperty, 1);
		borderedButton.SetValue(View.MarginProperty, new Thickness(0.0, 10.0, 0.0, 0.0));
		borderedButton.SetValue(Element.AutomationIdProperty, "NextButton");
		bindingExtension6.Path = "ButtonType";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension5(bindingExtension6);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 17);
		}
		borderedButton.SetBinding(BorderedButton.ButtonTypeProperty, bindingBase5);
		bindingExtension7.Path = "ButtonCommand";
		BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension6(bindingExtension7);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase6);
		bindingExtension8.Path = "ButtonText.Localized";
		BindingBase bindingBase7 = CreateTypedBindingFrom_bindingExtension7(bindingExtension8);
		if (VisualDiagnostics.GetSourceInfo(bindingBase7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase7, new Uri("Pages\\DG001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 41, 17);
		}
		borderedButton.SetBinding(Button.TextProperty, bindingBase7);
		borderedButton.SetValue(View.VerticalOptionsProperty, LayoutOptions.End);
		grid.Children.Add(borderedButton);
		toastView.SetValue(Grid.RowSpanProperty, 2);
		toastView.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
		grid.Children.Add(toastView);
		contentView.SetValue(ContentView.ContentProperty, grid);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG001ViewModel, string> setter = null;
			return new TypedBinding<DG001ViewModel, string>((DG001ViewModel source) => (value: source.HeaderText?.Localized, success: true), setter, new Tuple<Func<DG001ViewModel, object>, string>[2]
			{
				new Tuple<Func<DG001ViewModel, object>, string>((DG001ViewModel source) => source, "HeaderText"),
				new Tuple<Func<DG001ViewModel, object>, string>((DG001ViewModel source) => source.HeaderText, "Localized")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG001ViewModel, string> setter = null;
			return new TypedBinding<DG001ViewModel, string>((DG001ViewModel source) => (value: source.MessageText?.Localized, success: true), setter, new Tuple<Func<DG001ViewModel, object>, string>[2]
			{
				new Tuple<Func<DG001ViewModel, object>, string>((DG001ViewModel source) => source, "MessageText"),
				new Tuple<Func<DG001ViewModel, object>, string>((DG001ViewModel source) => source.MessageText, "Localized")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG001ViewModel, ICommand> setter = delegate(DG001ViewModel source, ICommand? value)
			{
				source.ButtonCommand = value;
			};
			return new TypedBinding<DG001ViewModel, ICommand>((DG001ViewModel source) => (value: source.ButtonCommand, success: true), setter, new Tuple<Func<DG001ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG001ViewModel, object>, string>((DG001ViewModel source) => source, "ButtonCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DG001ViewModel, List<IStepModel>> setter = delegate(DG001ViewModel source, List<IStepModel> value)
			{
				source.Steps = value;
			};
			return new TypedBinding<DG001ViewModel, List<IStepModel>>((DG001ViewModel source) => (value: source.Steps, success: true), setter, new Tuple<Func<DG001ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG001ViewModel, object>, string>((DG001ViewModel source) => source, "Steps")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<DG001ViewModel, ButtonType> setter = delegate(DG001ViewModel source, ButtonType value)
			{
				source.ButtonType = value;
			};
			return new TypedBinding<DG001ViewModel, ButtonType>((DG001ViewModel source) => (value: source.ButtonType, success: true), setter, new Tuple<Func<DG001ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG001ViewModel, object>, string>((DG001ViewModel source) => source, "ButtonType")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension6(BindingExtension extension)
		{
			Action<DG001ViewModel, ICommand> setter = delegate(DG001ViewModel source, ICommand? value)
			{
				source.ButtonCommand = value;
			};
			return new TypedBinding<DG001ViewModel, ICommand>((DG001ViewModel source) => (value: source.ButtonCommand, success: true), setter, new Tuple<Func<DG001ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG001ViewModel, object>, string>((DG001ViewModel source) => source, "ButtonCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension7(BindingExtension extension)
		{
			Action<DG001ViewModel, string> setter = null;
			return new TypedBinding<DG001ViewModel, string>((DG001ViewModel source) => (value: source.ButtonText?.Localized, success: true), setter, new Tuple<Func<DG001ViewModel, object>, string>[2]
			{
				new Tuple<Func<DG001ViewModel, object>, string>((DG001ViewModel source) => source, "ButtonText"),
				new Tuple<Func<DG001ViewModel, object>, string>((DG001ViewModel source) => source.ButtonText, "Localized")
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
	[MemberNotNull("page")]
	[MemberNotNull("NextButton")]
	[MemberNotNull("ToastView")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(DG001));
		page = this.FindByName<BasePage<DG001ViewModel>>("page");
		NextButton = this.FindByName<BorderedButton>("NextButton");
		ToastView = this.FindByName<ToastView>("ToastView");
	}
}
