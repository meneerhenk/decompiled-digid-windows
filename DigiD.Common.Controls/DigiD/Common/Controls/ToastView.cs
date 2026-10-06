using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Windows.Input;
using CommunityToolkit.Maui.Markup;
using CommunityToolkit.Mvvm.Messaging;
using DigiD.Common.Controls.Behaviors;
using DigiD.Common.Controls.Converters;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.Messages;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Graphics;
using WinRT;
using WinRT.DigiD_Common_ControlsVtableClasses;

namespace DigiD.Common.Controls;

[XamlFilePath("ToastView.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Common_Controls_HyperlinkLabelWinRTTypeDetails))]
public class ToastView : ContentView
{
	private readonly IToastService _service;

	private const short SecondsToLive = 10;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private ContentView toastContentView;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private StackLayout toast;

	public ICommand CloseToastCommand { get; init; }

	public ToastView()
	{
		InitializeComponent();
		_service = AppSession.ServiceProvider.GetRequiredService<IToastService>();
		CloseToastCommand = new Command(delegate(object p)
		{
			ToastClicked(p as ToastModel);
		});
		if (!WeakReferenceMessenger.Default.IsRegistered<ComingFromBackgroundMessage>(this))
		{
			WeakReferenceMessenger.Default.Register<ComingFromBackgroundMessage>(this, delegate
			{
				OnAppearing();
			});
		}
	}

	public void OnAppearing()
	{
		if (ShowToastsIfNecessary())
		{
			toast.TranslationY = -100.0;
			toast.TranslateToAsync(0.0, 0.0, 1000u, Easing.Linear);
			if (toast.Handler != null)
			{
				toast.SetSemanticFocus();
			}
		}
	}

	private void ChangePriorityForHighPriorityToasts()
	{
		foreach (ToastModel item in _service.Toasts.Where((ToastModel tm) => tm.Priority == ToastPriority.High))
		{
			item.Priority = ToastPriority.Normal;
		}
	}

	private bool ShowToastsIfNecessary()
	{
		DateTime utcNow = DateTime.UtcNow;
		foreach (ToastModel item in _service.Toasts.Reverse())
		{
			double totalSeconds = (utcNow - item.CreationTime).TotalSeconds;
			if (totalSeconds > 10.0 && item.Priority != ToastPriority.High)
			{
				_service.Toasts.Remove(item);
			}
		}
		BindableLayoutExtensions.ItemsSource(toast, _service.Toasts);
		return _service.Toasts.Count > 0;
	}

	protected void Toast_ChildRemoved(object? sender, ElementEventArgs e)
	{
		if (!(e.Element is Grid grid))
		{
			return;
		}
		foreach (IView child in grid.Children)
		{
			if (child is BindableObject bindable)
			{
				AutomationProperties.SetIsInAccessibleTree(bindable, false);
			}
		}
	}

	private void Image_Clicked(object? sender, EventArgs e)
	{
		if (sender is ImageButton { CommandParameter: ToastModel commandParameter })
		{
			ToastClicked(commandParameter);
		}
	}

	private void ToastClicked(ToastModel? toastModel)
	{
		if (toastModel != null)
		{
			_service.Remove(toastModel);
		}
	}

	private void Toast_OnUnloaded(object? sender, EventArgs e)
	{
		ChangePriorityForHighPriorityToasts();
	}

	private void Toast_OnLoaded(object? sender, EventArgs e)
	{
		ToastModel toastModel = _service.Toasts.FirstOrDefault();
		if (toastModel != null)
		{
			string text = toastModel.TitleForAccessibility + ", " + toastModel.Message;
			AppSession.ServiceProvider.GetRequiredService<IA11YService>().Speak(text, 1000);
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("toastContentView")]
	[MemberNotNull("toast")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(ToastView).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(ToastView)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ToastBackgroundColorConverter toastBackgroundColorConverter = new ToastBackgroundColorConverter();
		VisualDiagnostics.RegisterSourceInfo(toastBackgroundColorConverter, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 13, 14);
		ToastImageConverter toastImageConverter = new ToastImageConverter();
		VisualDiagnostics.RegisterSourceInfo(toastImageConverter, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 14, 14);
		ResourceDictionary resourceDictionary = new ResourceDictionary();
		VisualDiagnostics.RegisterSourceInfo(resourceDictionary, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 12, 10);
		DataTemplate dataTemplate = new DataTemplate();
		VisualDiagnostics.RegisterSourceInfo(dataTemplate, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 29, 14);
		StackLayout stackLayout = new StackLayout();
		VisualDiagnostics.RegisterSourceInfo(stackLayout, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 18, 6);
		ToastView __root = this;
		VisualDiagnostics.RegisterSourceInfo(__root, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 2, 2);
		INameScope iNameScope = NameScope.GetNameScope(__root) ?? new NameScope();
		NameScope.SetNameScope(__root, iNameScope);
		iNameScope.RegisterName("toastContentView", __root);
		ToastView toastView = __root;
		if (toastView.StyleId == null)
		{
			string text = (toastView.StyleId = "toastContentView");
		}
		stackLayout.transientNamescope = iNameScope;
		iNameScope.RegisterName("toast", stackLayout);
		StackLayout stackLayout2 = stackLayout;
		if (stackLayout2.StyleId == null)
		{
			string text = (stackLayout2.StyleId = "toast");
		}
		toastContentView = __root;
		toast = stackLayout;
		__root.Resources = resourceDictionary;
		resourceDictionary["ToastBackgroundColorConverter"] = toastBackgroundColorConverter;
		resourceDictionary["ToastImageConverter"] = toastImageConverter;
		__root.Resources = resourceDictionary;
		stackLayout.SetValue(View.MarginProperty, new Thickness(0.0));
		stackLayout.SetValue(Microsoft.Maui.Controls.Layout.PaddingProperty, new Thickness(0.0));
		stackLayout.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		stackLayout.ChildRemoved += Toast_ChildRemoved;
		stackLayout.Loaded += Toast_OnLoaded;
		stackLayout.SetValue(StackBase.SpacingProperty, 1.0);
		stackLayout.Unloaded += Toast_OnUnloaded;
		stackLayout.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
		dataTemplate.LoadTemplate = delegate
		{
			StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
			VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 32, 21);
			BindingExtension bindingExtension = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 32, 21);
			ReferenceExtension referenceExtension = new ReferenceExtension();
			VisualDiagnostics.RegisterSourceInfo(referenceExtension, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 75, 29);
			BindingExtension bindingExtension2 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 75, 29);
			BindingExtension bindingExtension3 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 76, 29);
			BindingExtension bindingExtension4 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 80, 38);
			BindingExtension bindingExtension5 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 81, 38);
			string alg_CloseToast = CommonResources.Alg_CloseToast;
			VisualDiagnostics.RegisterSourceInfo(alg_CloseToast, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 82, 46);
			BindingExtension bindingExtension6 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 82, 38);
			MultiBinding multiBinding = new MultiBinding();
			VisualDiagnostics.RegisterSourceInfo(multiBinding, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 79, 34);
			A11YBehavior a11YBehavior = new A11YBehavior();
			VisualDiagnostics.RegisterSourceInfo(a11YBehavior, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 73, 26);
			StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
			VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 39, 25);
			BindingExtension bindingExtension7 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension7, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 39, 25);
			Image image = new Image();
			VisualDiagnostics.RegisterSourceInfo(image, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 36, 22);
			StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension();
			VisualDiagnostics.RegisterSourceInfo(staticResourceExtension3, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 49, 29);
			StaticResourceExtension staticResourceExtension4 = new StaticResourceExtension();
			VisualDiagnostics.RegisterSourceInfo(staticResourceExtension4, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 50, 29);
			BindingExtension bindingExtension8 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension8, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 50, 29);
			BindingExtension bindingExtension9 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension9, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 51, 29);
			Label label = new Label();
			VisualDiagnostics.RegisterSourceInfo(label, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 46, 26);
			BindingExtension bindingExtension10 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension10, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 58, 29);
			Label label2 = new Label();
			VisualDiagnostics.RegisterSourceInfo(label2, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 55, 26);
			VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
			VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 42, 22);
			OnPlatformExtension onPlatformExtension = new OnPlatformExtension();
			VisualDiagnostics.RegisterSourceInfo(onPlatformExtension, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 66, 25);
			BindingExtension bindingExtension11 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension11, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 69, 25);
			ImageButton imageButton = new ImageButton();
			VisualDiagnostics.RegisterSourceInfo(imageButton, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 62, 22);
			Grid grid = new Grid();
			VisualDiagnostics.RegisterSourceInfo(grid, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 30, 18);
			INameScope nameScope = new NameScope();
			NameScope.SetNameScope(grid, nameScope);
			nameScope.RegisterName("ToastA11YBehavior", a11YBehavior);
			image.transientNamescope = nameScope;
			verticalStackLayout.transientNamescope = nameScope;
			label.transientNamescope = nameScope;
			label2.transientNamescope = nameScope;
			imageButton.transientNamescope = nameScope;
			grid.SetValue(Microsoft.Maui.Controls.Layout.PaddingProperty, new Thickness(16.0));
			staticResourceExtension.Key = "ToastBackgroundColorConverter";
			XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
			SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[5] { bindingExtension, grid, dataTemplate, stackLayout, __root }, typeof(BindingExtension).GetProperty("Converter"), new INameScope[2] { nameScope, iNameScope }, this);
			xamlServiceProvider.Add(typeof(IReferenceProvider), service);
			xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
			xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(32, 21)));
			object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
			if (VisualDiagnostics.GetSourceInfo(obj) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(obj, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 32, 21);
			}
			bindingExtension.Converter = (IValueConverter)obj;
			bindingExtension.Path = "Type";
			BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
			if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 32, 21);
			}
			grid.SetBinding(VisualElement.BackgroundColorProperty, bindingBase);
			grid.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(new GridLength(16.0, GridUnitType.Absolute)), new ColumnDefinition(GridLength.Star), new ColumnDefinition(new GridLength(18.0, GridUnitType.Absolute))));
			grid.SetValue(Grid.ColumnSpacingProperty, 8.0);
			grid.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
			referenceExtension.Name = "toastContentView";
			ToastView toastView2 = __root;
			if (VisualDiagnostics.GetSourceInfo(toastView2) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(toastView2, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 75, 29);
			}
			bindingExtension2.Source = toastView2;
			bindingExtension2.Path = "CloseToastCommand";
			Binding binding = new Binding(bindingExtension2.Path, bindingExtension2.Mode, bindingExtension2.Converter, bindingExtension2.ConverterParameter, bindingExtension2.StringFormat, bindingExtension2.Source)
			{
				UpdateSourceEventName = bindingExtension2.UpdateSourceEventName,
				FallbackValue = bindingExtension2.FallbackValue,
				TargetNullValue = bindingExtension2.TargetNullValue
			};
			if (VisualDiagnostics.GetSourceInfo(binding) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(binding, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 75, 29);
			}
			a11YBehavior.SetBinding(A11YBehavior.CommandProperty, binding);
			bindingExtension3.Path = ".";
			BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension3);
			if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 76, 29);
			}
			a11YBehavior.SetBinding(A11YBehavior.CommandParameterProperty, bindingBase2);
			a11YBehavior.SetValue(A11YBehavior.RoleProperty, A11YRole.Button);
			multiBinding.StringFormat = "{0} {1} {2}";
			bindingExtension4.Path = "TitleForAccessibility";
			BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension4);
			if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 80, 38);
			}
			multiBinding.Bindings.Add(bindingBase3);
			bindingExtension5.Path = "Message";
			BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension5);
			if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 81, 38);
			}
			multiBinding.Bindings.Add(bindingBase4);
			bindingExtension6.Source = alg_CloseToast;
			BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension5(bindingExtension6);
			if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 82, 38);
			}
			multiBinding.Bindings.Add(bindingBase5);
			a11YBehavior.SetBinding(A11YBehavior.DescriptionProperty, multiBinding);
			((IList<Behavior>)grid.GetValue(VisualElement.BehaviorsProperty)).Add(a11YBehavior);
			image.SetValue(Grid.ColumnProperty, 0);
			image.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
			staticResourceExtension2.Key = "ToastImageConverter";
			XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
			SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[6] { bindingExtension7, image, grid, dataTemplate, stackLayout, __root }, typeof(BindingExtension).GetProperty("Converter"), new INameScope[2] { nameScope, iNameScope }, this);
			xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
			xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
			xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(39, 25)));
			object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
			if (VisualDiagnostics.GetSourceInfo(obj2) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 39, 25);
			}
			bindingExtension7.Converter = (IValueConverter)obj2;
			bindingExtension7.Path = "Type";
			BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension6(bindingExtension7);
			if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 39, 25);
			}
			image.SetBinding(Image.SourceProperty, bindingBase6);
			image.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
			grid.Children.Add(image);
			verticalStackLayout.SetValue(Grid.ColumnProperty, 1);
			verticalStackLayout.SetValue(StackBase.SpacingProperty, 0.0);
			verticalStackLayout.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
			label.SetValue(View.MarginProperty, new Thickness(0.0, -4.0, 0.0, 0.0));
			label.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
			staticResourceExtension3.Key = "FontBold";
			XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
			SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[6] { label, verticalStackLayout, grid, dataTemplate, stackLayout, __root }, Label.FontFamilyProperty, new INameScope[2] { nameScope, iNameScope }, this);
			xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
			xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
			xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(49, 29)));
			object obj3 = ((IMarkupExtension)staticResourceExtension3).ProvideValue((IServiceProvider)xamlServiceProvider3);
			if (VisualDiagnostics.GetSourceInfo(obj3) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 49, 29);
			}
			label.SetValue(Label.FontFamilyProperty, obj3);
			staticResourceExtension4.Key = "IsStringNotNullOrWhiteSpaceConverter";
			XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider(this);
			SimpleValueTargetProvider service4 = new SimpleValueTargetProvider(new object[7] { bindingExtension8, label, verticalStackLayout, grid, dataTemplate, stackLayout, __root }, typeof(BindingExtension).GetProperty("Converter"), new INameScope[2] { nameScope, iNameScope }, this);
			xamlServiceProvider4.Add(typeof(IReferenceProvider), service4);
			xamlServiceProvider4.Add(typeof(IProvideValueTarget), service4);
			xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(50, 29)));
			object obj4 = ((IMarkupExtension)staticResourceExtension4).ProvideValue((IServiceProvider)xamlServiceProvider4);
			if (VisualDiagnostics.GetSourceInfo(obj4) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(obj4, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 50, 29);
			}
			bindingExtension8.Converter = (IValueConverter)obj4;
			bindingExtension8.Path = "Title";
			BindingBase bindingBase7 = CreateTypedBindingFrom_bindingExtension7(bindingExtension8);
			if (VisualDiagnostics.GetSourceInfo(bindingBase7) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase7, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 50, 29);
			}
			label.SetBinding(VisualElement.IsVisibleProperty, bindingBase7);
			bindingExtension9.Path = "Title";
			BindingBase bindingBase8 = CreateTypedBindingFrom_bindingExtension8(bindingExtension9);
			if (VisualDiagnostics.GetSourceInfo(bindingBase8) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase8, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 51, 29);
			}
			label.SetBinding(Label.TextProperty, bindingBase8);
			label.SetValue(Label.TextColorProperty, Colors.Black);
			label.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Start);
			verticalStackLayout.Children.Add(label);
			label2.SetValue(View.MarginProperty, new Thickness(0.0, -4.0, 0.0, -8.0));
			label2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
			bindingExtension10.Path = "Message";
			BindingBase bindingBase9 = CreateTypedBindingFrom_bindingExtension9(bindingExtension10);
			if (VisualDiagnostics.GetSourceInfo(bindingBase9) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase9, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 58, 29);
			}
			label2.SetBinding(Label.TextProperty, bindingBase9);
			label2.SetValue(Label.TextColorProperty, Colors.Black);
			verticalStackLayout.Children.Add(label2);
			grid.Children.Add(verticalStackLayout);
			imageButton.SetValue(Grid.ColumnProperty, 2);
			imageButton.SetValue(View.MarginProperty, new Thickness(-12.0));
			imageButton.SetValue(ImageButton.PaddingProperty, new Thickness(12.0));
			onPlatformExtension.Android = "False";
			XamlServiceProvider xamlServiceProvider5 = new XamlServiceProvider(this);
			SimpleValueTargetProvider service5 = new SimpleValueTargetProvider(new object[5] { imageButton, grid, dataTemplate, stackLayout, __root }, AutomationProperties.IsInAccessibleTreeProperty, new INameScope[2] { nameScope, iNameScope }, this);
			xamlServiceProvider5.Add(typeof(IReferenceProvider), service5);
			xamlServiceProvider5.Add(typeof(IProvideValueTarget), service5);
			xamlServiceProvider5.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(66, 25)));
			object obj5 = ((IMarkupExtension)onPlatformExtension).ProvideValue((IServiceProvider)xamlServiceProvider5);
			if (VisualDiagnostics.GetSourceInfo(obj5) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(obj5, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 66, 25);
			}
			imageButton.SetValue(AutomationProperties.IsInAccessibleTreeProperty, obj5);
			imageButton.SetValue(ImageButton.BorderWidthProperty, 2.0);
			imageButton.Clicked += Image_Clicked;
			bindingExtension11.Path = ".";
			BindingBase bindingBase10 = CreateTypedBindingFrom_bindingExtension10(bindingExtension11);
			if (VisualDiagnostics.GetSourceInfo(bindingBase10) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase10, new Uri("ToastView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 69, 25);
			}
			imageButton.SetBinding(ImageButton.CommandParameterProperty, bindingBase10);
			imageButton.SetValue(ImageButton.SourceProperty, ImageSource.FromFile("digid_icon_toast_sluiten.png"));
			grid.Children.Add(imageButton);
			return grid;
		};
		stackLayout.SetValue(BindableLayout.ItemTemplateProperty, dataTemplate);
		__root.SetValue(ContentView.ContentProperty, stackLayout);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<ToastModel, ToastType> setter = null;
			return new TypedBinding<ToastModel, ToastType>((ToastModel source) => (value: source.Type, success: true), setter, new Tuple<Func<ToastModel, object>, string>[1]
			{
				new Tuple<Func<ToastModel, object>, string>((ToastModel source) => source, "Type")
			})
			{
				Converter = extension.Converter
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension10(BindingExtension extension)
		{
			Action<ToastModel, ToastModel> setter = null;
			return new TypedBinding<ToastModel, ToastModel>((ToastModel source) => (value: source, success: true), setter, new Tuple<Func<ToastModel, object>, string>[0]);
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<ToastModel, ToastModel> setter = null;
			return new TypedBinding<ToastModel, ToastModel>((ToastModel source) => (value: source, success: true), setter, new Tuple<Func<ToastModel, object>, string>[0]);
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<ToastModel, string> setter = null;
			return new TypedBinding<ToastModel, string>((ToastModel source) => (value: source.TitleForAccessibility, success: true), setter, new Tuple<Func<ToastModel, object>, string>[1]
			{
				new Tuple<Func<ToastModel, object>, string>((ToastModel source) => source, "TitleForAccessibility")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<ToastModel, string> setter = null;
			return new TypedBinding<ToastModel, string>((ToastModel source) => (value: source.Message, success: true), setter, new Tuple<Func<ToastModel, object>, string>[1]
			{
				new Tuple<Func<ToastModel, object>, string>((ToastModel source) => source, "Message")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<ToastModel, ToastModel> setter = null;
			return new TypedBinding<ToastModel, ToastModel>((ToastModel source) => (value: source, success: true), setter, new Tuple<Func<ToastModel, object>, string>[0])
			{
				Source = extension.Source
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension6(BindingExtension extension)
		{
			Action<ToastModel, ToastType> setter = null;
			return new TypedBinding<ToastModel, ToastType>((ToastModel source) => (value: source.Type, success: true), setter, new Tuple<Func<ToastModel, object>, string>[1]
			{
				new Tuple<Func<ToastModel, object>, string>((ToastModel source) => source, "Type")
			})
			{
				Converter = extension.Converter
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension7(BindingExtension extension)
		{
			Action<ToastModel, string> setter = null;
			return new TypedBinding<ToastModel, string>((ToastModel source) => (value: source.Title, success: true), setter, new Tuple<Func<ToastModel, object>, string>[1]
			{
				new Tuple<Func<ToastModel, object>, string>((ToastModel source) => source, "Title")
			})
			{
				Converter = extension.Converter
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension8(BindingExtension extension)
		{
			Action<ToastModel, string> setter = null;
			return new TypedBinding<ToastModel, string>((ToastModel source) => (value: source.Title, success: true), setter, new Tuple<Func<ToastModel, object>, string>[1]
			{
				new Tuple<Func<ToastModel, object>, string>((ToastModel source) => source, "Title")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension9(BindingExtension extension)
		{
			Action<ToastModel, string> setter = null;
			return new TypedBinding<ToastModel, string>((ToastModel source) => (value: source.Message, success: true), setter, new Tuple<Func<ToastModel, object>, string>[1]
			{
				new Tuple<Func<ToastModel, object>, string>((ToastModel source) => source, "Message")
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
	[MemberNotNull("toastContentView")]
	[MemberNotNull("toast")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(ToastView));
		toastContentView = this.FindByName<ContentView>("toastContentView");
		toast = this.FindByName<StackLayout>("toast");
	}
}
