using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using CommunityToolkit.Mvvm.Messaging;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Models.Messages;
using DigiD.Mobile.Controls;
using DigiD.Mobile.Models;
using DigiD.Mobile.ViewModels;
using LocalizationResourceManager.Maui;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Devices;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.Pages;

[XamlFilePath("Pages\\DG060.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG060 : BasePage<DG060ViewModel>
{
	public DG060(DG060ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		DeviceDisplay.Current.MainDisplayInfoChanged += OrientationChanged;
	}

	protected override void OnDisappearing()
	{
		base.OnDisappearing();
		DeviceDisplay.Current.MainDisplayInfoChanged -= OrientationChanged;
	}

	private void OrientationChanged(object? sender, DisplayInfoChangedEventArgs e)
	{
		SendSizeChangedMessage();
	}

	private static void SendSizeChangedMessage()
	{
		if (DeviceInfo.Platform == DevicePlatform.iOS || DeviceInfo.Platform == DevicePlatform.MacCatalyst)
		{
			WeakReferenceMessenger.Default.Send(new ScrollViewSizeChangedMessage());
		}
	}

	private void VerticalStackLayout_SizeChanged(object? sender, EventArgs? e)
	{
		SendSizeChangedMessage();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG060).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG060)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 15, 18);
		OnPlatformExtension onPlatformExtension = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 34);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 21);
		TranslateExtension translateExtension = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 21);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 18);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 21);
		TranslateExtension translateExtension2 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension2, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 21);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 18);
		OnPlatformExtension onPlatformExtension2 = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension2, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 21);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 21);
		DataTemplate dataTemplate = new DataTemplate();
		VisualDiagnostics.RegisterSourceInfo(dataTemplate, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 26);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 18);
		VerticalStackLayout verticalStackLayout2 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout2, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 14);
		StackLayout stackLayout = new StackLayout();
		VisualDiagnostics.RegisterSourceInfo(stackLayout, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 15, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		stackLayout.transientNamescope = nameScope;
		verticalStackLayout2.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		onPlatformExtension.Android = "False";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { verticalStackLayout2, stackLayout, contentView, this }, AutomationProperties.IsInAccessibleTreeProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(17, 34)));
		object obj = ((IMarkupExtension)onPlatformExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 34);
		}
		verticalStackLayout2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, obj);
		verticalStackLayout2.SetValue(StackBase.SpacingProperty, 20.0);
		label.SetValue(View.MarginProperty, new Thickness(20.0, 0.0));
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[5] { label, verticalStackLayout2, stackLayout, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(20, 21)));
		object obj2 = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 21);
		}
		label.SetValue(VisualElement.StyleProperty, obj2);
		translateExtension.Text = "DG060_Titel";
		BindingBase bindingBase = ((IMarkupExtension<BindingBase>)translateExtension).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 21);
		}
		label.SetBinding(Label.TextProperty, bindingBase);
		verticalStackLayout2.Children.Add(label);
		label2.SetValue(View.MarginProperty, new Thickness(20.0, 0.0));
		bindingExtension.Path = "ShowIntro";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 21);
		}
		label2.SetBinding(VisualElement.IsVisibleProperty, bindingBase2);
		translateExtension2.Text = "DG060_Intro";
		BindingBase bindingBase3 = ((IMarkupExtension<BindingBase>)translateExtension2).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 21);
		}
		label2.SetBinding(Label.TextProperty, bindingBase3);
		verticalStackLayout2.Children.Add(label2);
		onPlatformExtension2.Android = "False";
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[5] { verticalStackLayout, verticalStackLayout2, stackLayout, contentView, this }, AutomationProperties.IsInAccessibleTreeProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(29, 21)));
		object obj3 = ((IMarkupExtension)onPlatformExtension2).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 21);
		}
		verticalStackLayout.SetValue(AutomationProperties.IsInAccessibleTreeProperty, obj3);
		bindingExtension2.Path = "Items";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 21);
		}
		verticalStackLayout.SetBinding(BindableLayout.ItemsSourceProperty, bindingBase4);
		verticalStackLayout.SizeChanged += VerticalStackLayout_SizeChanged;
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 1.0);
		dataTemplate.LoadTemplate = delegate
		{
			BindingExtension bindingExtension3 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 50);
			DynamicResource dynamicResource = new DynamicResource("MenuItemBackgroundColor");
			VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 84);
			VisualState visualState = new VisualState();
			VisualDiagnostics.RegisterSourceInfo(visualState, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 54);
			DynamicResource dynamicResource2 = new DynamicResource("FontTextColor");
			VisualDiagnostics.RegisterSourceInfo(dynamicResource2, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 54, 87);
			Setter setter = new Setter();
			VisualDiagnostics.RegisterSourceInfo(setter, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 54, 62);
			VisualState visualState2 = new VisualState();
			VisualDiagnostics.RegisterSourceInfo(visualState2, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 52, 54);
			VisualStateGroup visualStateGroup = new VisualStateGroup();
			VisualDiagnostics.RegisterSourceInfo(visualStateGroup, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 46, 50);
			VisualStateGroupList visualStateGroupList = new VisualStateGroupList();
			VisualDiagnostics.RegisterSourceInfo(visualStateGroupList, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 46);
			BindingExtension bindingExtension4 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 72);
			HyperlinkLabel hyperlinkLabel = new HyperlinkLabel();
			VisualDiagnostics.RegisterSourceInfo(hyperlinkLabel, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 42);
			Border border = new Border();
			VisualDiagnostics.RegisterSourceInfo(border, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 38);
			Accordion accordion = new Accordion();
			VisualDiagnostics.RegisterSourceInfo(accordion, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 30);
			INameScope nameScope2 = new NameScope();
			NameScope.SetNameScope(accordion, nameScope2);
			border.transientNamescope = nameScope2;
			nameScope2.RegisterName("border", border);
			Border border2 = border;
			if (border2.StyleId == null)
			{
				string text = (border2.StyleId = "border");
			}
			INameScope nameScope3 = new NameScope();
			hyperlinkLabel.transientNamescope = nameScope2;
			bindingExtension3.Path = "Title.Localized";
			BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
			if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 50);
			}
			accordion.SetBinding(Accordion.TitleProperty, bindingBase5);
			((IDynamicResourceHandler)accordion).SetDynamicResource(Accordion.HeaderBackgroundColorProperty, dynamicResource.Key);
			border.SetValue(View.MarginProperty, new Thickness(10.0, 0.0));
			border.SetValue(Border.StrokeProperty, new BrushTypeConverter().ConvertFromInvariantString("Transparent") as Brush);
			border.SetValue(Border.StrokeThicknessProperty, 2.0);
			border.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
			visualStateGroup.Name = "CommonStates";
			visualState.Name = "Normal";
			Setter setter2 = new Setter
			{
				Property = Border.StrokeProperty,
				Value = (new BrushTypeConverter().ConvertFromInvariantString("Transparent") as Brush)
			};
			if (VisualDiagnostics.GetSourceInfo(setter2) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(setter2, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 49, 62);
			}
			visualState.Setters.Add(setter2);
			visualStateGroup.States.Add(visualState);
			visualState2.Name = "Focused";
			setter.Property = Border.StrokeProperty;
			setter.Value = dynamicResource2;
			Setter setter3 = new Setter
			{
				Property = Border.StrokeProperty,
				Value = dynamicResource2
			};
			if (VisualDiagnostics.GetSourceInfo(setter3) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(setter3, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 54, 62);
			}
			visualState2.Setters.Add(setter3);
			visualStateGroup.States.Add(visualState2);
			visualStateGroupList.Add(visualStateGroup);
			border.SetValue(VisualStateManager.VisualStateGroupsProperty, visualStateGroupList);
			bindingExtension4.Path = "FaqText.Localized";
			BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
			if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DG060.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 72);
			}
			hyperlinkLabel.SetBinding(Label.TextProperty, bindingBase6);
			border.SetValue(Border.ContentProperty, hyperlinkLabel);
			accordion.AccordionContentView = border;
			return accordion;
		};
		verticalStackLayout.SetValue(BindableLayout.ItemTemplateProperty, dataTemplate);
		verticalStackLayout2.Children.Add(verticalStackLayout);
		stackLayout.Children.Add(verticalStackLayout2);
		contentView.SetValue(ContentView.ContentProperty, stackLayout);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG060ViewModel, bool> setter = null;
			return new TypedBinding<DG060ViewModel, bool>((DG060ViewModel source) => (value: source.ShowIntro, success: true), setter, new Tuple<Func<DG060ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG060ViewModel, object>, string>((DG060ViewModel source) => source, "ShowIntro")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG060ViewModel, List<AccordionItem>> setter = delegate(DG060ViewModel source, List<AccordionItem> value)
			{
				source.Items = value;
			};
			return new TypedBinding<DG060ViewModel, List<AccordionItem>>((DG060ViewModel source) => (value: source.Items, success: true), setter, new Tuple<Func<DG060ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG060ViewModel, object>, string>((DG060ViewModel source) => source, "Items")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<AccordionItem, string> setter = null;
			return new TypedBinding<AccordionItem, string>((AccordionItem source) => (value: source.Title.Localized, success: true), setter, new Tuple<Func<AccordionItem, object>, string>[2]
			{
				new Tuple<Func<AccordionItem, object>, string>((AccordionItem source) => source, "Title"),
				new Tuple<Func<AccordionItem, object>, string>((AccordionItem source) => source.Title, "Localized")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<AccordionItem, string> setter = null;
			return new TypedBinding<AccordionItem, string>((AccordionItem source) => (value: source.FaqText.Localized, success: true), setter, new Tuple<Func<AccordionItem, object>, string>[2]
			{
				new Tuple<Func<AccordionItem, object>, string>((AccordionItem source) => source, "FaqText"),
				new Tuple<Func<AccordionItem, object>, string>((AccordionItem source) => source.FaqText, "Localized")
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
		this.LoadFromXaml(typeof(DG060));
	}
}
